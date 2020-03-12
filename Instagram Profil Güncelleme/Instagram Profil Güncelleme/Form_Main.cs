using InstagramApiSharp.API;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.SessionHandlers;
using InstagramApiSharp.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instagram_Profil_Güncelleme
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }



        // Değişkenler
        SabitKodlar c_SabitKodlar = new SabitKodlar();
        private static IInstaApi InstaApi;
        const string OturumDosyasi = "Oturum.bin";
        private string Yol_Kullanicilar = Application.StartupPath + @"\Kullanicilar\";
        Thread t_Guncelle;






        /// <summary>
        /// Bildirim Sistemi
        /// </summary>
        /// <param name="ifade"></param>
        /// <param name="mesaj"></param>
        /// <param name="baslik"></param>
        /// <param name="mesajKutusu"></param>
        /// <param name="logEkle"></param>
        #region Bilgi Mesajı Bildirim Sistemi > BilgiMesaji(ifade, mesaj, baslik) > hata, bilgi, soru
        void BilgiMesaji(string ifade, string mesaj, string baslik, bool mesajKutusu = false, bool logEkle = true)
        {
            try
            {
                string zaman = DateTime.Now.ToString("dd/MM/yyyy HH:mm").ToString();
                baslik = this.Text;
                switch (ifade)
                {
                    case "hata":
                        // mesaj kutusunda göster
                        if (mesajKutusu == true)
                        {
                            MessageBox.Show(mesaj, baslik, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        // işlem penceresine aktar
                        if (logEkle == true)
                        {
                            listBox_Logs.Items.Insert(0, "[" + zaman + "] " + mesaj);
                        }

                        // durum çubuğu
                        Footer_Durum_Mesaj.ForeColor = Color.DarkRed;
                        Footer_Durum_Mesaj.Text = "[" + zaman + "] " + mesaj;
                        break;

                    case "bilgi":
                        // mesaj kutusunda göster
                        if (mesajKutusu == true)
                        {
                            MessageBox.Show(mesaj, baslik, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        // işlem penceresine aktar
                        if (logEkle == true)
                        {
                            listBox_Logs.Items.Insert(0, "[" + zaman + "] " + mesaj);
                        }
                        // durum çubuğu
                        Footer_Durum_Mesaj.ForeColor = Color.DarkBlue;
                        Footer_Durum_Mesaj.Text = "[" + zaman + "] " + mesaj;
                        break;

                    case "soru":
                        // mesaj kutusunda göster
                        if (mesajKutusu == true)
                        {
                            MessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        }
                        // işlem penceresine aktar
                        if (logEkle == true)
                        {
                            listBox_Logs.Items.Insert(0, "[" + zaman + "] " + mesaj);
                        }
                        // durum çubuğu
                        Footer_Durum_Mesaj.ForeColor = Color.DarkBlue;
                        Footer_Durum_Mesaj.Text = "[" + zaman + "] " + mesaj;
                        break;

                    case "basarili":
                        // mesaj kutusunda göster
                        if (mesajKutusu == true)
                        {
                            MessageBox.Show(mesaj, baslik, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        // işlem penceresine aktar
                        if (logEkle == true)
                        {
                            listBox_Logs.Items.Insert(0, "[" + zaman + "] " + mesaj);
                        }
                        // durum çubuğu
                        Footer_Durum_Mesaj.ForeColor = Color.DarkGreen;
                        Footer_Durum_Mesaj.Text = "[" + zaman + "] " + mesaj;
                        break;

                    default:
                        MessageBox.Show(mesaj, baslik, MessageBoxButtons.OK);
                        break;
                }
            }
            catch //(Exception ex)
            {
                // log kaydet
                //c_AnaKodlar.LogKaydiOlustur("Hata", Program.Yol_Loglar, "Bilgi Mesajı sırasında hata oluştu." + " " + KullaniciAdi, ex.Message, ex.StackTrace);
            }
        }
        #endregion



        /// <summary>
        /// Oturum yükleme
        /// </summary>
        void OturumYukle()
        {
            InstaApi?.SessionHandler?.Load();
        }



        /// <summary>
        /// Oturum kaydetme
        /// </summary>
        void OturumKaydet()
        {
            if (InstaApi == null)
                return;
            if (!InstaApi.IsUserAuthenticated)
                return;
            InstaApi.SessionHandler.Save();
        }



        /// <summary>
        /// FORM LOAD
        /// </summary>
        private void Form_Main_Load(object sender, EventArgs e)
        {
            //Thread Aktifleştirme
            CheckForIllegalCrossThreadCalls = false;
            Control.CheckForIllegalCrossThreadCalls = false;

            c_SabitKodlar.Klasor_Kontrol(Yol_Kullanicilar);
        }




        #region 1- Instagram Giriş


        /// <summary>
        /// Giriş yapma aktifse
        /// </summary>
        void InstaGirisAktif()
        {
            button_InstaGiris.Enabled = false;
            textBox_InstaGiris_kadi.Enabled = false;
            textBox_InstaGiris_sifre.Enabled = false;
        }


        /// <summary>
        /// Giriş yapma pasifse
        /// </summary>
        void InstaGirisPasif()
        {
            button_InstaGiris.Enabled = true;
            textBox_InstaGiris_kadi.Enabled = true;
            textBox_InstaGiris_sifre.Enabled = true;
        }


        /// <summary>
        /// Instagram Giriş Yap Butonu
        /// </summary>
        private async void Button_InstaGiris_Click(object sender, EventArgs e)
        {
            // Kutucuklar boşsa durrr
            if (textBox_InstaGiris_kadi.Text == "" || textBox_InstaGiris_sifre.Text == "")
            {
                // Bilgi Mesajı
                BilgiMesaji("bilgi", "Bütün alanları doldurmalısınız.", this.Text, true);
            }
            else
            {
                // Bilgi Mesajı
                BilgiMesaji("bilgi", "Giriş yapılıyor, bekleyin.", this.Text, false);
                label_Insta_GirisDurum.Text = "Giriş yapılıyor, bekleyin.";
                InstaGirisAktif();

                // Dosya yolu
                string StateKlasor = Yol_Kullanicilar + textBox_InstaGiris_kadi.Text + @"\";
                c_SabitKodlar.Klasor_Kontrol(StateKlasor);
                string StateYol = StateKlasor + OturumDosyasi;
                if (File.Exists(StateYol))
                {
                    File.Delete(StateYol);
                }

                // Kullanıcı oturumları
                var userSession = new UserSessionData
                {
                    UserName = textBox_InstaGiris_kadi.Text,
                    Password = textBox_InstaGiris_sifre.Text
                };

                // Oturum oluşturma
                InstaApi = InstaApiBuilder.CreateBuilder()
                    .SetUser(userSession)
                    .SetRequestDelay(RequestDelay.FromSeconds(0, 1))
                    .SetSessionHandler(new FileSessionHandler() { FilePath = StateYol })
                    .Build();
                OturumYukle();

                //MessageBox.Show(InstaApi.IsUserAuthenticated.ToString());

                // Giriş Kontrolü
                if (InstaApi.IsUserAuthenticated)
                {
                    // Başarılı

                    // Bilgi Mesajı
                    BilgiMesaji("basarili", "Giriş yapıldı.", this.Text, false);
                    label_Insta_GirisDurum.Text = "Giriş yapıldı.";
                    InstaGirisAktif();
                }
                else
                {
                    // Başarısız

                    // Giriş çıktısı
                    var girisCiktisi = await InstaApi.LoginAsync();
                    string donenVeri = girisCiktisi.Value.ToString();

                    /*MessageBox.Show(girisCiktisi.Info.Message);
                    MessageBox.Show(donenVeri);*/

                    // Kullanıcı Bilgileri Hatalı
                    if (donenVeri == "BadPassword" || donenVeri == "InvalidUser")
                    {
                        // Bilgi Mesajı
                        BilgiMesaji("hata", "Kullanıcı bilgileriniz hatalı.", this.Text, true);
                        label_Insta_GirisDurum.Text = "Kullanıcı bilgileriniz hatalı.";
                        InstaGirisPasif();
                    }

                    // Hesap Banlı
                    else if (donenVeri == "InactiveUser")
                    {
                        // Bilgi Mesajı
                        BilgiMesaji("hata", "Hesap Instagram tarafından kapatılmış.", this.Text, true);
                        label_Insta_GirisDurum.Text = "Hesap Instagram tarafından kapatılmış.";
                        InstaGirisPasif();
                    }


                    // Hesap Askıda
                    else if (girisCiktisi.Info.Message == "Sorry, there was a problem with your request.")
                    {
                        // Bilgi Mesajı
                        BilgiMesaji("hata", "Lütfen tekrar denemeden önce birkaç dakika bekleyin.", this.Text, true);
                        label_Insta_GirisDurum.Text = "Lütfen tekrar denemeden önce birkaç dakika bekleyin.";
                        InstaGirisPasif();
                    }



                    // Giriş başarılı mı?
                    else if (girisCiktisi.Succeeded)
                    {
                        // Bilgi Mesajı
                        BilgiMesaji("basarili", "Giriş yapıldı.", this.Text, false);
                        label_Insta_GirisDurum.Text = "Giriş yapıldı.";
                        tab_Sekmeler.SelectedTab = tab_Sayfa;
                        InstaGirisAktif();
                        OturumKaydet();
                    }

                    // Diğer Giriş Yöntemleri
                    else
                    {

                        // 1- Doğrulama Gereken Hesap
                        if (girisCiktisi.Value == InstaLoginResult.ChallengeRequired)
                        {
                            // Doğrulama işlemi
                            var challenge = await InstaApi.GetChallengeRequireVerifyMethodAsync();

                            // Doğrulama Başarılı mı?
                            if (!challenge.Succeeded)
                            {
                                // Başarısız

                                // Bilgi Mesajı
                                BilgiMesaji("hata", "Hesap doğrulama başarısız.", this.Text, true);
                                label_Insta_GirisDurum.Text = "Hesap doğrulama başarısız.";
                                InstaGirisPasif();
                            }
                            else
                            {
                                // Başarılı

                                // Telefon numarası girme
                                if (challenge.Value.SubmitPhoneRequired)
                                {
                                    // Bilgi Mesajı
                                    BilgiMesaji("bilgi", "Hesaba telefon numarası girmelisiniz.", this.Text, true);
                                    label_Insta_GirisDurum.Text = "Hesaba telefon numarası girmelisiniz.";
                                    panel_InstaGiris.Visible = false;
                                    group_Insta_TelefonGirme.Dock = DockStyle.Fill;
                                    group_Insta_TelefonGirme.Visible = true;
                                }
                                else
                                {
                                    // Parametreler boş değilse
                                    if (challenge.Value.StepData != null)
                                    {
                                        // Telefon
                                        if (!string.IsNullOrEmpty(challenge.Value.StepData.PhoneNumber))
                                        {
                                            radio_Insta_TelefonDogrulama.Checked = false;
                                            radio_Insta_TelefonDogrulama.Visible = true;
                                            radio_Insta_TelefonDogrulama.Text = challenge.Value.StepData.PhoneNumber;
                                        }

                                        // Eposta
                                        if (!string.IsNullOrEmpty(challenge.Value.StepData.Email))
                                        {
                                            radio_Insta_EpostaDogrulama.Checked = false;
                                            radio_Insta_EpostaDogrulama.Visible = true;
                                            radio_Insta_EpostaDogrulama.Text = challenge.Value.StepData.Email;
                                        }

                                        panel_InstaGiris.Visible = false;
                                        group_Insta_HesapDogrulama.Dock = DockStyle.Fill;
                                        group_Insta_HesapDogrulama.Visible = true;
                                    }
                                }



                            } // end if: doğrulama

                        }

                        // 2- İki Faktörlü doğrulama
                        else if (girisCiktisi.Value == InstaLoginResult.TwoFactorRequired)
                        {
                            panel_InstaGiris.Visible = false;
                            group_IkiFaktorluDogrulama.Dock = DockStyle.Fill;
                            group_IkiFaktorluDogrulama.Visible = true;
                        }

                    }


                } // END IF: Giriş kontrolü


            } // END IF: Kutucuklar boşsa



        }



        /// <summary>
        /// Instagram Kod İsteme
        /// </summary>
        private async void Button_Insta_KodIste_Click(object sender, EventArgs e)
        {
            bool isEmail = false;
            if (radio_Insta_EpostaDogrulama.Checked)
                isEmail = true;

            try
            {
                // Yeni kod 60 saniyede bir geliyor                 
                if (isEmail)
                {
                    // Epostaya doğrulama kodu gönderme
                    var email = await InstaApi.RequestVerifyCodeToEmailForChallengeRequireAsync();
                    if (email.Succeeded)
                    {
                        label_Insta_SMSveEPOSTA.Text = $"Eposta adresine kod gönderildi:\n{email.Value.StepData.ContactPoint}";
                        BilgiMesaji("bilgi", $"Eposta adresine kod gönderildi:\n{email.Value.StepData.ContactPoint}", this.Text);

                        group_Insta_HesapDogrulama.Visible = false;
                        group_Insta_KodDogrulama.Dock = DockStyle.Fill;
                        group_Insta_KodDogrulama.Visible = true;
                    }
                    else
                    {
                        BilgiMesaji("hata", "Hata: " + email.Info.Message, this.Text, true);
                    }
                }
                else
                {
                    // Telefona doğrulama kodu gönderme
                    var phoneNumber = await InstaApi.RequestVerifyCodeToSMSForChallengeRequireAsync();
                    if (phoneNumber.Succeeded)
                    {
                        label_Insta_SMSveEPOSTA.Text = $"Telefona kod gönderildi:\n{phoneNumber.Value.StepData.ContactPoint}";
                        BilgiMesaji("bilgi", $"Telefona kod gönderildi:\n{phoneNumber.Value.StepData.ContactPoint}", this.Text);

                        group_Insta_HesapDogrulama.Visible = false;
                        group_Insta_KodDogrulama.Dock = DockStyle.Fill;
                        group_Insta_KodDogrulama.Visible = true;
                    }
                    else
                    {
                        BilgiMesaji("hata", "Hata: " + phoneNumber.Info.Message, this.Text, true);
                    }
                }
            }
            catch (Exception ex)
            {
                BilgiMesaji("hata", "Hata: " + ex.Message, this.Text, true);
            }

        }



        /// <summary>
        /// Hesap için telefon numarası girme
        /// </summary>
        private async void Button_Insta_TelefonGir_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox_Insta_TelefonGir.Text) ||
                     string.IsNullOrWhiteSpace(textBox_Insta_TelefonGir.Text))
                {
                    BilgiMesaji("hata", "Lütfen geçerli bir telefon numarası girin.\r\ni.e:+989123456789", this.Text, true);
                    return;
                }
                var phoneNumber = textBox_Insta_TelefonGir.Text;
                if (!phoneNumber.StartsWith("+"))
                    phoneNumber = $"+{phoneNumber}";

                var submitPhone = await InstaApi.SubmitPhoneNumberForChallengeRequireAsync(phoneNumber);
                if (submitPhone.Succeeded)
                {
                    group_Insta_TelefonGirme.Visible = false;
                    group_Insta_KodDogrulama.Dock = DockStyle.Fill;
                    group_Insta_KodDogrulama.Visible = true;
                }
                else
                {
                    if(submitPhone.Info.Message.IndexOf("like your phone number may be incorrect") != -1)
                    {
                        BilgiMesaji("hata", "Telefon numarası hatalı. Ülke kodu ile girin.", this.Text, true);
                    }
                    else
                    {
                        BilgiMesaji("hata", submitPhone.Info.Message, this.Text, true);
                    }
                }
            }
            catch (Exception ex)
            {
                BilgiMesaji("hata", "Hata: " + ex.Message, this.Text, true);
            }
        }


        /// <summary>
        /// Tekrar Kod İsteme
        /// </summary>
        private async void Button_Insta_TekrarKodIste_Click(object sender, EventArgs e)
        {
            bool isEmail = false;
            if (radio_Insta_EpostaDogrulama.Checked)
                isEmail = true;

            try
            {
                // Yeni kod 60 saniyede bir geliyor                
                if (isEmail)
                {
                    // Epostaya doğrulama kodu gönderme
                    var email = await InstaApi.RequestVerifyCodeToEmailForChallengeRequireAsync(replayChallenge: true);
                    if (email.Succeeded)
                    {
                        label_Insta_SMSveEPOSTA.Text = $"Eposta adresine kod tekrar gönderildi:\n{email.Value.StepData.ContactPoint}";
                        BilgiMesaji("bilgi", $"Eposta adresine kod tekrar gönderildi:\n{email.Value.StepData.ContactPoint}", this.Text);

                        group_Insta_HesapDogrulama.Visible = false;
                        group_Insta_KodDogrulama.Dock = DockStyle.Fill;
                        group_Insta_KodDogrulama.Visible = true;
                    }
                    else
                    {
                        BilgiMesaji("hata", "Hata: " + email.Info.Message, this.Text, true);
                    }
                }
                else
                {
                    // Telefona doğrulama kodu gönderme
                    var phoneNumber = await InstaApi.RequestVerifyCodeToSMSForChallengeRequireAsync(replayChallenge: true);
                    if (phoneNumber.Succeeded)
                    {
                        label_Insta_SMSveEPOSTA.Text = $"Telefona kod tekrar gönderildi:{phoneNumber.Value.StepData.ContactPoint}";
                        BilgiMesaji("bilgi", $"Telefona kod tekrar gönderildi:\n{phoneNumber.Value.StepData.ContactPoint}", this.Text);

                        group_Insta_HesapDogrulama.Visible = false;
                        group_Insta_KodDogrulama.Dock = DockStyle.Fill;
                        group_Insta_KodDogrulama.Visible = true;
                    }
                    else
                    {
                        BilgiMesaji("hata", "Hata: " + phoneNumber.Info.Message, this.Text, true);
                    }
                }
            }
            catch (Exception ex)
            {
                BilgiMesaji("hata", "Hata: " + ex.Message, this.Text, true);
            }
        }


        /// <summary>
        /// Gelen kodu doğrulama
        /// </summary>
        private async void Button_Insta_Dogrula_Click(object sender, EventArgs e)
        {
            textBox_Insta_KodDogrulama.Text = textBox_Insta_KodDogrulama.Text.Trim();
            textBox_Insta_KodDogrulama.Text = textBox_Insta_KodDogrulama.Text.Replace(" ", "");
            var regex = new Regex(@"^-*[0-9,\.]+$");
            if (!regex.IsMatch(textBox_Insta_KodDogrulama.Text))
            {
                BilgiMesaji("hata", "Kod sayısal olmalı!!", this.Text, true);
                return;
            }
            if (textBox_Insta_KodDogrulama.Text.Length != 6)
            {
                BilgiMesaji("hata", "Kod 6 haneli olmalı!!", this.Text, true);
                return;
            }

            try
            {
                // Gelen kod ile giriş
                var verifyLogin = await InstaApi.VerifyCodeForChallengeRequireAsync(textBox_Insta_KodDogrulama.Text);
                if (verifyLogin.Succeeded)
                {
                    // Giriş başarılı
                    group_Insta_KodDogrulama.Visible = group_Insta_HesapDogrulama.Visible = false;
                    panel_InstaGiris.Visible = true;
                    panel_InstaGiris.Enabled = false;

                    // Bilgi Mesajı
                    BilgiMesaji("basarili", "Giriş yapıldı.", this.Text, false);
                    label_Insta_GirisDurum.Text = "Giriş yapıldı.";
                    tab_Sekmeler.SelectedTab = tab_Sayfa;
                    InstaGirisAktif();
                    OturumKaydet();
                }
                else
                {
                    group_Insta_KodDogrulama.Visible = group_Insta_HesapDogrulama.Visible = false;
                    
                    // İki faktörlü doğrulama gerekiyor
                    if (verifyLogin.Value == InstaLoginResult.TwoFactorRequired)
                    {
                        group_Insta_KodDogrulama.Dock = DockStyle.Fill;
                        group_IkiFaktorluDogrulama.Visible = true;
                    }
                    else
                    {
                        BilgiMesaji("hata", "Hata: " + verifyLogin.Info.Message, this.Text, true);
                    }

                }

            }
            catch (Exception ex)
            {
                BilgiMesaji("hata", "Hata: " + ex.Message, this.Text, true);
            }
        }


        /// <summary>
        /// İki faktörlü kod doğrulama
        /// </summary>
        private async void Button_Insta_IkiFaktorKodGir_Click(object sender, EventArgs e)
        {
            if (InstaApi == null)
                return;
            if (string.IsNullOrEmpty(textBox_Insta_IkiFaktorKodGir.Text))
            {
                BilgiMesaji("bilgi", "Lütfen iki faktörlü kodunuzu girin ve Kodu Doğrula butonuna basın.", this.Text, true);
                return;
            }
            // Kodu gönder
            var twoFactorLogin = await InstaApi.TwoFactorLoginAsync(textBox_Insta_IkiFaktorKodGir.Text);
            
            if (twoFactorLogin.Succeeded)
            {
                // Başarılı

                // Giriş başarılı
                group_IkiFaktorluDogrulama.Visible = false;
                panel_InstaGiris.Visible = true;
                panel_InstaGiris.Enabled = false;

                // Bilgi Mesajı
                BilgiMesaji("basarili", "Giriş yapıldı.", this.Text, false);
                label_Insta_GirisDurum.Text = "Giriş yapıldı.";
                tab_Sekmeler.SelectedTab = tab_Sayfa;
                InstaGirisAktif();
                OturumKaydet();

            }
            else
            {
                BilgiMesaji("hata", "Hata: " + twoFactorLogin.Info.Message, this.Text, true);
            }
        }



        #endregion




        #region 2- Profil Güncelleme


        /// <summary>
        /// Profil resmi seçme
        /// </summary>
        private void Button_Insta_ProfilResmiSec_Click(object sender, EventArgs e)
        {
            try
            {
                // Resim seç ve picturebox aktar
                OpenFileDialog resimSec = new OpenFileDialog();
                resimSec.Title = "Instagram Profil Resmi Seç";
                resimSec.Filter = "Resim Dosyası (*.jpg, *.jpeg) | *.jpg; *.jpeg;";

                if (resimSec.ShowDialog() == DialogResult.OK)
                {
                    textBox_Insta_SeciliProfilResmiYolu.Text = resimSec.FileName;
                    pictureBox_Insta_ProfilResmi.ImageLocation = resimSec.FileName;
                }
            }
            catch (Exception ex)
            {
                // Bilgi Mesajı
                BilgiMesaji("hata", "Profil resmi seçilirken sorun oluştu;\n\n" + ex.Message, this.Text, true);
            }
        }



        /// <summary>
        /// Gönderi paylaşımı için ekleme yapma
        /// </summary>
        private void Button_Insta_GonderiResimSec_Click(object sender, EventArgs e)
        {
            try
            {
                // Resim seç ve picturebox aktar
                OpenFileDialog resimSec = new OpenFileDialog();
                resimSec.Title = "Instagram Gönderi Resmi Seç";
                resimSec.Filter = "Resim Dosyası (*.jpg, *.jpeg) | *.jpg; *.jpeg;";

                if (resimSec.ShowDialog() == DialogResult.OK)
                {
                    // listeye ekle
                    string[] ekle = { richTextBox_Insta_GonderiAciklamasi.Text, resimSec.FileName };
                    var satir = new ListViewItem(ekle);
                    listView_Insta_GonderiListesi.Items.Add(satir);
                }
            }
            catch (Exception ex)
            {
                // Bilgi Mesajı
                BilgiMesaji("hata", " Gönderi resmi seçilirken sorun oluştu;\n\n" + ex.Message, this.Text, true);
            }
        }


        /// <summary>
        /// Gönderi listesinden seçili gönderiyi sil
        /// </summary>
        private void SeciliGönderiSil_MenuItem_Click(object sender, EventArgs e)
        {
            if (listView_Insta_GonderiListesi.SelectedItems.Count == 1)
            {
                DialogResult soru = MessageBox.Show("Seçili gönderi silinsin mi?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (soru == DialogResult.Yes)
                {
                    // sil
                    try
                    {
                        // listeden silme
                        listView_Insta_GonderiListesi.SelectedItems[0].Remove();

                        // Bilgi Mesajı
                        BilgiMesaji("basarili", "Seçili gönderi başarıyla silindi.", this.Text, false);
                    }
                    catch (Exception ex)
                    {
                        // Bilgi Mesajı
                        BilgiMesaji("hata", "Seçili gönderi silinirken sorun oluştu;\n\n" + ex.Message, this.Text, true);
                    }
                }
            }
        }


        /// <summary>
        /// Profil Güncelleme
        /// </summary>
        private async void Button_ProfilGuncelleme_Click(object sender, EventArgs e)
        {

            try
            {
                BilgiMesaji("bilgi", "Profil güncelleme başladı, bekleyin.", this.Text);
                // Değişkenler
                string adSoyad = null;
                string eposta = null;
                string site_adresi = textBox_Insta_InternetSitesi.Text;
                string telefon = null;
                string biyografi = richTextBox_Insta_Biyografi.Text;
                string yeniKadi = null;
                InstaGenderType? cinsiyet;
                if (combo_Insta_Cinsiyet.Text == "Erkek")
                {
                    cinsiyet = InstaGenderType.Male;
                }
                else if (combo_Insta_Cinsiyet.Text == "Kadın")
                {
                    cinsiyet = InstaGenderType.Female;
                }
                else
                {
                    cinsiyet = InstaGenderType.Unknown;
                }


                // Profil düzenleme
                try
                {

                    var setBiography = await InstaApi.AccountProcessor
                    .EditProfileAsync(adSoyad, biyografi, site_adresi, eposta, telefon, cinsiyet, yeniKadi);

                    if (setBiography.Succeeded)
                    {
                        // Başarılı
                        BilgiMesaji("bilgi", textBox_InstaGiris_kadi.Text + " biyografi güncellendi.", this.Text);
                    }
                    else
                    {
                        // Başarısız
                        BilgiMesaji("hata", textBox_InstaGiris_kadi.Text + " biyografi güncellenemedi.", this.Text);
                    }

                }
                catch
                {
                    BilgiMesaji("hata", textBox_InstaGiris_kadi.Text + " profil güncellenemedi.", this.Text);
                }



                // Biyografi Düzenleme
                /*try
                {

                    var setBiography = await InstaApi.AccountProcessor
                    .SetBiographyAsync(biyografi);

                    if (setBiography.Succeeded)
                    {
                        // Başarılı
                        BilgiMesaji("bilgi", textBox_InstaGiris_kadi.Text + " biyografi güncellendi.", this.Text);
                    }
                    else
                    {
                        // Başarısız
                        BilgiMesaji("hata", textBox_InstaGiris_kadi.Text + " biyografi güncellenemedi.", this.Text);
                    }

                }
                catch
                {
                    BilgiMesaji("hata", textBox_InstaGiris_kadi.Text + " profil güncellenemedi.", this.Text);
                }*/



                // Profil Foto Güncelleme
                try
                {
                    if (textBox_Insta_SeciliProfilResmiYolu.Text != "")
                    {
                        var picturePath = textBox_Insta_SeciliProfilResmiYolu.Text;
                        var pictureBytes = File.ReadAllBytes(picturePath);
                        var changeProfilePicture = await InstaApi.AccountProcessor
                                        .ChangeProfilePictureAsync(pictureBytes);

                        MessageBox.Show(changeProfilePicture.Info.Message.ToString());

                        if (changeProfilePicture.Succeeded)
                        {
                            // Başarılı
                            BilgiMesaji("bilgi", textBox_InstaGiris_kadi.Text + " profil resmi güncellendi.", this.Text);
                        }
                        else
                        {
                            // Başarısız
                            BilgiMesaji("hata", textBox_InstaGiris_kadi.Text + " profil resmi güncellenemedi.", this.Text);
                        }
                    }
                }
                catch
                {
                    BilgiMesaji("hata", textBox_InstaGiris_kadi.Text + " profil resmi güncellenemedi.", this.Text);
                }



                // Gönderileri paylaşma
                foreach (ListViewItem gonderi in listView_Insta_GonderiListesi.Items)
                {
                    string mesaj = gonderi.SubItems[0].Text;
                    string yol = gonderi.SubItems[1].Text;
                    try
                    {
                        string instaUpload = instaResimUploadFonk(yol, mesaj);
                        if (instaUpload == "true")
                        {
                            // Başarılı
                            BilgiMesaji("bilgi", textBox_InstaGiris_kadi.Text + " gönderi paylaşıldı.", this.Text);
                        }
                        else
                        {
                            // Başarısız
                            BilgiMesaji("hata", textBox_InstaGiris_kadi.Text + " gönderi paylaşılamadı.", this.Text);
                        }
                    }
                    catch
                    {
                        // Başarısız
                        BilgiMesaji("hata", textBox_InstaGiris_kadi.Text + " gönderi paylaşılamadı.", this.Text);
                    }

                    // 2 sn bekle
                    Task.Delay(2000).Wait();
                }



            }
            catch
            {
                BilgiMesaji("hata", "Profil güncellemede hata oluştu.", this.Text, true);
                if (t_Guncelle.IsAlive)
                {
                    t_Guncelle.Abort();
                }
            }
            finally
            {
                BilgiMesaji("bilgi", "İşlem tamamlandı.", this.Text, true);
            }

        }




        /// <summary>
        /// Instagram Resim Upload
        /// </summary>
        /// <param name="yol"></param>
        /// <param name="mesaj"></param>
        /// <returns></returns>
        private string instaResimUploadFonk(string yol, string mesaj)
        {
            string cikti = null;

            var resimUpload = Task.Run(() =>
            {
                try
                {

                    var mediaImage = new InstaImageUpload
                    {
                        Height = 1080,
                        Width = 1080,
                        Uri = yol
                    };
                    var result = InstaApi.MediaProcessor.UploadPhotoAsync(mediaImage, mesaj);
                    if (result.Result.Succeeded)
                    {
                        cikti = "true";
                    }
                    else
                    {
                        cikti = "false";
                    }
                }
                catch
                {
                    cikti = "Exception";
                }
            });

            resimUpload.Wait();

            if (resimUpload.IsCompleted)
            {
                return cikti;
            }
            else
            {
                return cikti;
            }
        }





        #endregion








        private void Button_TestButonu_Click(object sender, EventArgs e)
        {


        }


        



    }
}
