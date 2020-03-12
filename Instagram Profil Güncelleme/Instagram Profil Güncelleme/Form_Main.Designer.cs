namespace Instagram_Profil_Güncelleme
{
    partial class Form_Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.tab_Sekmeler = new System.Windows.Forms.TabControl();
            this.tab_InstagramGiris = new System.Windows.Forms.TabPage();
            this.group_Insta_KodDogrulama = new System.Windows.Forms.GroupBox();
            this.button_Insta_TekrarKodIste = new System.Windows.Forms.Button();
            this.button_Insta_Dogrula = new System.Windows.Forms.Button();
            this.label90 = new System.Windows.Forms.Label();
            this.textBox_Insta_KodDogrulama = new System.Windows.Forms.TextBox();
            this.label_Insta_SMSveEPOSTA = new System.Windows.Forms.Label();
            this.group_IkiFaktorluDogrulama = new System.Windows.Forms.GroupBox();
            this.button_Insta_IkiFaktorKodGir = new System.Windows.Forms.Button();
            this.textBox_Insta_IkiFaktorKodGir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_InstaGiris = new System.Windows.Forms.Panel();
            this.textBox_InstaGiris_kadi = new System.Windows.Forms.TextBox();
            this.label_Insta_GirisDurum = new System.Windows.Forms.Label();
            this.textBox_InstaGiris_sifre = new System.Windows.Forms.TextBox();
            this.button_InstaGiris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.group_Insta_TelefonGirme = new System.Windows.Forms.GroupBox();
            this.button_Insta_TelefonGir = new System.Windows.Forms.Button();
            this.textBox_Insta_TelefonGir = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.group_Insta_HesapDogrulama = new System.Windows.Forms.GroupBox();
            this.button_Insta_KodIste = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.radio_Insta_EpostaDogrulama = new System.Windows.Forms.RadioButton();
            this.radio_Insta_TelefonDogrulama = new System.Windows.Forms.RadioButton();
            this.tab_Sayfa = new System.Windows.Forms.TabPage();
            this.button_ProfilGuncelleme = new System.Windows.Forms.Button();
            this.groupBox_GonderiPaylas = new System.Windows.Forms.GroupBox();
            this.listView_Insta_GonderiListesi = new System.Windows.Forms.ListView();
            this.col_GonderiAciklama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_GonderiResimYol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menu_GonderiListesi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seciliGönderiSil_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox_Insta_GonderiAciklamasi = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button_Insta_GonderiResimSec = new System.Windows.Forms.Button();
            this.combo_Insta_Cinsiyet = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Insta_InternetSitesi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox_Insta_ProfilResmi = new System.Windows.Forms.PictureBox();
            this.textBox_Insta_SeciliProfilResmiYolu = new System.Windows.Forms.TextBox();
            this.button_Insta_ProfilResmiSec = new System.Windows.Forms.Button();
            this.richTextBox_Insta_Biyografi = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tab_Logs = new System.Windows.Forms.TabPage();
            this.listBox_Logs = new System.Windows.Forms.ListBox();
            this.Footer_Durum = new System.Windows.Forms.StatusStrip();
            this.Footer_Durum_Baslik = new System.Windows.Forms.ToolStripStatusLabel();
            this.Footer_Durum_Mesaj = new System.Windows.Forms.ToolStripStatusLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.button_TestButonu = new System.Windows.Forms.Button();
            this.tab_Sekmeler.SuspendLayout();
            this.tab_InstagramGiris.SuspendLayout();
            this.group_Insta_KodDogrulama.SuspendLayout();
            this.group_IkiFaktorluDogrulama.SuspendLayout();
            this.panel_InstaGiris.SuspendLayout();
            this.group_Insta_TelefonGirme.SuspendLayout();
            this.group_Insta_HesapDogrulama.SuspendLayout();
            this.tab_Sayfa.SuspendLayout();
            this.groupBox_GonderiPaylas.SuspendLayout();
            this.menu_GonderiListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Insta_ProfilResmi)).BeginInit();
            this.tab_Logs.SuspendLayout();
            this.Footer_Durum.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_Sekmeler
            // 
            this.tab_Sekmeler.Controls.Add(this.tab_InstagramGiris);
            this.tab_Sekmeler.Controls.Add(this.tab_Sayfa);
            this.tab_Sekmeler.Controls.Add(this.tab_Logs);
            this.tab_Sekmeler.Location = new System.Drawing.Point(12, 12);
            this.tab_Sekmeler.Name = "tab_Sekmeler";
            this.tab_Sekmeler.SelectedIndex = 0;
            this.tab_Sekmeler.Size = new System.Drawing.Size(499, 527);
            this.tab_Sekmeler.TabIndex = 0;
            // 
            // tab_InstagramGiris
            // 
            this.tab_InstagramGiris.Controls.Add(this.group_Insta_KodDogrulama);
            this.tab_InstagramGiris.Controls.Add(this.group_IkiFaktorluDogrulama);
            this.tab_InstagramGiris.Controls.Add(this.panel_InstaGiris);
            this.tab_InstagramGiris.Controls.Add(this.group_Insta_TelefonGirme);
            this.tab_InstagramGiris.Controls.Add(this.group_Insta_HesapDogrulama);
            this.tab_InstagramGiris.Location = new System.Drawing.Point(4, 25);
            this.tab_InstagramGiris.Name = "tab_InstagramGiris";
            this.tab_InstagramGiris.Padding = new System.Windows.Forms.Padding(3);
            this.tab_InstagramGiris.Size = new System.Drawing.Size(491, 498);
            this.tab_InstagramGiris.TabIndex = 0;
            this.tab_InstagramGiris.Text = "Instagram Giriş";
            this.tab_InstagramGiris.UseVisualStyleBackColor = true;
            // 
            // group_Insta_KodDogrulama
            // 
            this.group_Insta_KodDogrulama.Controls.Add(this.button_Insta_TekrarKodIste);
            this.group_Insta_KodDogrulama.Controls.Add(this.button_Insta_Dogrula);
            this.group_Insta_KodDogrulama.Controls.Add(this.label90);
            this.group_Insta_KodDogrulama.Controls.Add(this.textBox_Insta_KodDogrulama);
            this.group_Insta_KodDogrulama.Controls.Add(this.label_Insta_SMSveEPOSTA);
            this.group_Insta_KodDogrulama.Location = new System.Drawing.Point(61, 424);
            this.group_Insta_KodDogrulama.Name = "group_Insta_KodDogrulama";
            this.group_Insta_KodDogrulama.Size = new System.Drawing.Size(339, 186);
            this.group_Insta_KodDogrulama.TabIndex = 29;
            this.group_Insta_KodDogrulama.TabStop = false;
            this.group_Insta_KodDogrulama.Text = "Kodu Doğrula";
            this.group_Insta_KodDogrulama.Visible = false;
            // 
            // button_Insta_TekrarKodIste
            // 
            this.button_Insta_TekrarKodIste.AutoSize = true;
            this.button_Insta_TekrarKodIste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Insta_TekrarKodIste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Insta_TekrarKodIste.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button_Insta_TekrarKodIste.FlatAppearance.BorderSize = 2;
            this.button_Insta_TekrarKodIste.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Insta_TekrarKodIste.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button_Insta_TekrarKodIste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Insta_TekrarKodIste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Insta_TekrarKodIste.ForeColor = System.Drawing.Color.White;
            this.button_Insta_TekrarKodIste.Location = new System.Drawing.Point(31, 137);
            this.button_Insta_TekrarKodIste.Name = "button_Insta_TekrarKodIste";
            this.button_Insta_TekrarKodIste.Size = new System.Drawing.Size(134, 32);
            this.button_Insta_TekrarKodIste.TabIndex = 12;
            this.button_Insta_TekrarKodIste.Text = "Tekrar Kod İste";
            this.button_Insta_TekrarKodIste.UseVisualStyleBackColor = false;
            this.button_Insta_TekrarKodIste.Click += new System.EventHandler(this.Button_Insta_TekrarKodIste_Click);
            // 
            // button_Insta_Dogrula
            // 
            this.button_Insta_Dogrula.AutoSize = true;
            this.button_Insta_Dogrula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Insta_Dogrula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Insta_Dogrula.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button_Insta_Dogrula.FlatAppearance.BorderSize = 2;
            this.button_Insta_Dogrula.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Insta_Dogrula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button_Insta_Dogrula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Insta_Dogrula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Insta_Dogrula.ForeColor = System.Drawing.Color.White;
            this.button_Insta_Dogrula.Location = new System.Drawing.Point(225, 137);
            this.button_Insta_Dogrula.Name = "button_Insta_Dogrula";
            this.button_Insta_Dogrula.Size = new System.Drawing.Size(87, 32);
            this.button_Insta_Dogrula.TabIndex = 11;
            this.button_Insta_Dogrula.Text = "Doğrula";
            this.button_Insta_Dogrula.UseVisualStyleBackColor = false;
            this.button_Insta_Dogrula.Click += new System.EventHandler(this.Button_Insta_Dogrula_Click);
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(36, 95);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(72, 16);
            this.label90.TabIndex = 7;
            this.label90.Text = "Kodu Girin:";
            // 
            // textBox_Insta_KodDogrulama
            // 
            this.textBox_Insta_KodDogrulama.Location = new System.Drawing.Point(116, 92);
            this.textBox_Insta_KodDogrulama.Name = "textBox_Insta_KodDogrulama";
            this.textBox_Insta_KodDogrulama.Size = new System.Drawing.Size(196, 22);
            this.textBox_Insta_KodDogrulama.TabIndex = 6;
            // 
            // label_Insta_SMSveEPOSTA
            // 
            this.label_Insta_SMSveEPOSTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Insta_SMSveEPOSTA.Location = new System.Drawing.Point(17, 37);
            this.label_Insta_SMSveEPOSTA.Name = "label_Insta_SMSveEPOSTA";
            this.label_Insta_SMSveEPOSTA.Size = new System.Drawing.Size(307, 52);
            this.label_Insta_SMSveEPOSTA.TabIndex = 1;
            this.label_Insta_SMSveEPOSTA.Text = "Sms veya eposta adresinize kod gönderildi";
            this.label_Insta_SMSveEPOSTA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // group_IkiFaktorluDogrulama
            // 
            this.group_IkiFaktorluDogrulama.Controls.Add(this.button_Insta_IkiFaktorKodGir);
            this.group_IkiFaktorluDogrulama.Controls.Add(this.textBox_Insta_IkiFaktorKodGir);
            this.group_IkiFaktorluDogrulama.Controls.Add(this.label5);
            this.group_IkiFaktorluDogrulama.Location = new System.Drawing.Point(465, 349);
            this.group_IkiFaktorluDogrulama.Name = "group_IkiFaktorluDogrulama";
            this.group_IkiFaktorluDogrulama.Size = new System.Drawing.Size(227, 137);
            this.group_IkiFaktorluDogrulama.TabIndex = 28;
            this.group_IkiFaktorluDogrulama.TabStop = false;
            this.group_IkiFaktorluDogrulama.Text = "İki faktörlü doğrulama";
            this.group_IkiFaktorluDogrulama.Visible = false;
            // 
            // button_Insta_IkiFaktorKodGir
            // 
            this.button_Insta_IkiFaktorKodGir.AutoSize = true;
            this.button_Insta_IkiFaktorKodGir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Insta_IkiFaktorKodGir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Insta_IkiFaktorKodGir.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button_Insta_IkiFaktorKodGir.FlatAppearance.BorderSize = 2;
            this.button_Insta_IkiFaktorKodGir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Insta_IkiFaktorKodGir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button_Insta_IkiFaktorKodGir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Insta_IkiFaktorKodGir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Insta_IkiFaktorKodGir.ForeColor = System.Drawing.Color.White;
            this.button_Insta_IkiFaktorKodGir.Location = new System.Drawing.Point(29, 87);
            this.button_Insta_IkiFaktorKodGir.Name = "button_Insta_IkiFaktorKodGir";
            this.button_Insta_IkiFaktorKodGir.Size = new System.Drawing.Size(177, 32);
            this.button_Insta_IkiFaktorKodGir.TabIndex = 5;
            this.button_Insta_IkiFaktorKodGir.Text = "Kodu Doğrula";
            this.button_Insta_IkiFaktorKodGir.UseVisualStyleBackColor = false;
            this.button_Insta_IkiFaktorKodGir.Click += new System.EventHandler(this.Button_Insta_IkiFaktorKodGir_Click);
            // 
            // textBox_Insta_IkiFaktorKodGir
            // 
            this.textBox_Insta_IkiFaktorKodGir.Location = new System.Drawing.Point(29, 56);
            this.textBox_Insta_IkiFaktorKodGir.Name = "textBox_Insta_IkiFaktorKodGir";
            this.textBox_Insta_IkiFaktorKodGir.Size = new System.Drawing.Size(177, 22);
            this.textBox_Insta_IkiFaktorKodGir.TabIndex = 4;
            this.textBox_Insta_IkiFaktorKodGir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Kodu Girin";
            // 
            // panel_InstaGiris
            // 
            this.panel_InstaGiris.Controls.Add(this.textBox_InstaGiris_kadi);
            this.panel_InstaGiris.Controls.Add(this.label_Insta_GirisDurum);
            this.panel_InstaGiris.Controls.Add(this.textBox_InstaGiris_sifre);
            this.panel_InstaGiris.Controls.Add(this.button_InstaGiris);
            this.panel_InstaGiris.Controls.Add(this.label2);
            this.panel_InstaGiris.Controls.Add(this.label1);
            this.panel_InstaGiris.Location = new System.Drawing.Point(118, 82);
            this.panel_InstaGiris.Name = "panel_InstaGiris";
            this.panel_InstaGiris.Size = new System.Drawing.Size(261, 259);
            this.panel_InstaGiris.TabIndex = 21;
            // 
            // textBox_InstaGiris_kadi
            // 
            this.textBox_InstaGiris_kadi.Location = new System.Drawing.Point(16, 40);
            this.textBox_InstaGiris_kadi.Name = "textBox_InstaGiris_kadi";
            this.textBox_InstaGiris_kadi.Size = new System.Drawing.Size(221, 22);
            this.textBox_InstaGiris_kadi.TabIndex = 2;
            this.textBox_InstaGiris_kadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_Insta_GirisDurum
            // 
            this.label_Insta_GirisDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Insta_GirisDurum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_Insta_GirisDurum.Location = new System.Drawing.Point(16, 166);
            this.label_Insta_GirisDurum.Name = "label_Insta_GirisDurum";
            this.label_Insta_GirisDurum.Size = new System.Drawing.Size(221, 74);
            this.label_Insta_GirisDurum.TabIndex = 19;
            this.label_Insta_GirisDurum.Text = "Bekleniyor..";
            this.label_Insta_GirisDurum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_InstaGiris_sifre
            // 
            this.textBox_InstaGiris_sifre.Location = new System.Drawing.Point(16, 94);
            this.textBox_InstaGiris_sifre.Name = "textBox_InstaGiris_sifre";
            this.textBox_InstaGiris_sifre.Size = new System.Drawing.Size(221, 22);
            this.textBox_InstaGiris_sifre.TabIndex = 3;
            this.textBox_InstaGiris_sifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_InstaGiris
            // 
            this.button_InstaGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_InstaGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_InstaGiris.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button_InstaGiris.FlatAppearance.BorderSize = 2;
            this.button_InstaGiris.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_InstaGiris.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button_InstaGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_InstaGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_InstaGiris.ForeColor = System.Drawing.Color.White;
            this.button_InstaGiris.Location = new System.Drawing.Point(16, 130);
            this.button_InstaGiris.Name = "button_InstaGiris";
            this.button_InstaGiris.Size = new System.Drawing.Size(221, 33);
            this.button_InstaGiris.TabIndex = 4;
            this.button_InstaGiris.Text = "Giriş Yap";
            this.button_InstaGiris.UseVisualStyleBackColor = false;
            this.button_InstaGiris.Click += new System.EventHandler(this.Button_InstaGiris_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // group_Insta_TelefonGirme
            // 
            this.group_Insta_TelefonGirme.Controls.Add(this.button_Insta_TelefonGir);
            this.group_Insta_TelefonGirme.Controls.Add(this.textBox_Insta_TelefonGir);
            this.group_Insta_TelefonGirme.Controls.Add(this.label6);
            this.group_Insta_TelefonGirme.Location = new System.Drawing.Point(465, 16);
            this.group_Insta_TelefonGirme.Name = "group_Insta_TelefonGirme";
            this.group_Insta_TelefonGirme.Size = new System.Drawing.Size(357, 134);
            this.group_Insta_TelefonGirme.TabIndex = 26;
            this.group_Insta_TelefonGirme.TabStop = false;
            this.group_Insta_TelefonGirme.Text = "Hesap İçin Telefon Girin";
            this.group_Insta_TelefonGirme.Visible = false;
            // 
            // button_Insta_TelefonGir
            // 
            this.button_Insta_TelefonGir.AutoSize = true;
            this.button_Insta_TelefonGir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Insta_TelefonGir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Insta_TelefonGir.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button_Insta_TelefonGir.FlatAppearance.BorderSize = 2;
            this.button_Insta_TelefonGir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Insta_TelefonGir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button_Insta_TelefonGir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Insta_TelefonGir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Insta_TelefonGir.ForeColor = System.Drawing.Color.White;
            this.button_Insta_TelefonGir.Location = new System.Drawing.Point(149, 74);
            this.button_Insta_TelefonGir.Name = "button_Insta_TelefonGir";
            this.button_Insta_TelefonGir.Size = new System.Drawing.Size(177, 32);
            this.button_Insta_TelefonGir.TabIndex = 5;
            this.button_Insta_TelefonGir.Text = "Kod Gönder";
            this.button_Insta_TelefonGir.UseVisualStyleBackColor = false;
            this.button_Insta_TelefonGir.Click += new System.EventHandler(this.Button_Insta_TelefonGir_Click);
            // 
            // textBox_Insta_TelefonGir
            // 
            this.textBox_Insta_TelefonGir.Location = new System.Drawing.Point(149, 43);
            this.textBox_Insta_TelefonGir.Name = "textBox_Insta_TelefonGir";
            this.textBox_Insta_TelefonGir.Size = new System.Drawing.Size(177, 22);
            this.textBox_Insta_TelefonGir.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Telefon Numarası:";
            // 
            // group_Insta_HesapDogrulama
            // 
            this.group_Insta_HesapDogrulama.Controls.Add(this.button_Insta_KodIste);
            this.group_Insta_HesapDogrulama.Controls.Add(this.label3);
            this.group_Insta_HesapDogrulama.Controls.Add(this.radio_Insta_EpostaDogrulama);
            this.group_Insta_HesapDogrulama.Controls.Add(this.radio_Insta_TelefonDogrulama);
            this.group_Insta_HesapDogrulama.Location = new System.Drawing.Point(465, 156);
            this.group_Insta_HesapDogrulama.Name = "group_Insta_HesapDogrulama";
            this.group_Insta_HesapDogrulama.Size = new System.Drawing.Size(357, 187);
            this.group_Insta_HesapDogrulama.TabIndex = 27;
            this.group_Insta_HesapDogrulama.TabStop = false;
            this.group_Insta_HesapDogrulama.Text = "Doğrulama Yöntemi Seçin";
            this.group_Insta_HesapDogrulama.Visible = false;
            // 
            // button_Insta_KodIste
            // 
            this.button_Insta_KodIste.AutoSize = true;
            this.button_Insta_KodIste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Insta_KodIste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Insta_KodIste.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button_Insta_KodIste.FlatAppearance.BorderSize = 2;
            this.button_Insta_KodIste.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Insta_KodIste.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button_Insta_KodIste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Insta_KodIste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Insta_KodIste.ForeColor = System.Drawing.Color.White;
            this.button_Insta_KodIste.Location = new System.Drawing.Point(29, 137);
            this.button_Insta_KodIste.Name = "button_Insta_KodIste";
            this.button_Insta_KodIste.Size = new System.Drawing.Size(136, 32);
            this.button_Insta_KodIste.TabIndex = 10;
            this.button_Insta_KodIste.Text = "Kod İste";
            this.button_Insta_KodIste.UseVisualStyleBackColor = false;
            this.button_Insta_KodIste.Click += new System.EventHandler(this.Button_Insta_KodIste_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 49);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lütfen hesabınızı doğrulamak için bir yöntem seçin:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radio_Insta_EpostaDogrulama
            // 
            this.radio_Insta_EpostaDogrulama.AutoSize = true;
            this.radio_Insta_EpostaDogrulama.Location = new System.Drawing.Point(29, 106);
            this.radio_Insta_EpostaDogrulama.Name = "radio_Insta_EpostaDogrulama";
            this.radio_Insta_EpostaDogrulama.Size = new System.Drawing.Size(69, 20);
            this.radio_Insta_EpostaDogrulama.TabIndex = 9;
            this.radio_Insta_EpostaDogrulama.TabStop = true;
            this.radio_Insta_EpostaDogrulama.Text = "Eposta";
            this.radio_Insta_EpostaDogrulama.UseVisualStyleBackColor = true;
            this.radio_Insta_EpostaDogrulama.Visible = false;
            // 
            // radio_Insta_TelefonDogrulama
            // 
            this.radio_Insta_TelefonDogrulama.AutoSize = true;
            this.radio_Insta_TelefonDogrulama.Location = new System.Drawing.Point(29, 80);
            this.radio_Insta_TelefonDogrulama.Name = "radio_Insta_TelefonDogrulama";
            this.radio_Insta_TelefonDogrulama.Size = new System.Drawing.Size(72, 20);
            this.radio_Insta_TelefonDogrulama.TabIndex = 8;
            this.radio_Insta_TelefonDogrulama.TabStop = true;
            this.radio_Insta_TelefonDogrulama.Text = "Telefon";
            this.radio_Insta_TelefonDogrulama.UseVisualStyleBackColor = true;
            this.radio_Insta_TelefonDogrulama.Visible = false;
            // 
            // tab_Sayfa
            // 
            this.tab_Sayfa.Controls.Add(this.button_ProfilGuncelleme);
            this.tab_Sayfa.Controls.Add(this.groupBox_GonderiPaylas);
            this.tab_Sayfa.Controls.Add(this.combo_Insta_Cinsiyet);
            this.tab_Sayfa.Controls.Add(this.label4);
            this.tab_Sayfa.Controls.Add(this.textBox_Insta_InternetSitesi);
            this.tab_Sayfa.Controls.Add(this.label9);
            this.tab_Sayfa.Controls.Add(this.pictureBox_Insta_ProfilResmi);
            this.tab_Sayfa.Controls.Add(this.textBox_Insta_SeciliProfilResmiYolu);
            this.tab_Sayfa.Controls.Add(this.button_Insta_ProfilResmiSec);
            this.tab_Sayfa.Controls.Add(this.richTextBox_Insta_Biyografi);
            this.tab_Sayfa.Controls.Add(this.label7);
            this.tab_Sayfa.Location = new System.Drawing.Point(4, 25);
            this.tab_Sayfa.Name = "tab_Sayfa";
            this.tab_Sayfa.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Sayfa.Size = new System.Drawing.Size(491, 498);
            this.tab_Sayfa.TabIndex = 1;
            this.tab_Sayfa.Text = "Profil Düzenleme";
            this.tab_Sayfa.UseVisualStyleBackColor = true;
            // 
            // button_ProfilGuncelleme
            // 
            this.button_ProfilGuncelleme.AutoSize = true;
            this.button_ProfilGuncelleme.BackColor = System.Drawing.Color.DarkGreen;
            this.button_ProfilGuncelleme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ProfilGuncelleme.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.button_ProfilGuncelleme.FlatAppearance.BorderSize = 2;
            this.button_ProfilGuncelleme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button_ProfilGuncelleme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.button_ProfilGuncelleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ProfilGuncelleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ProfilGuncelleme.ForeColor = System.Drawing.Color.White;
            this.button_ProfilGuncelleme.Location = new System.Drawing.Point(19, 446);
            this.button_ProfilGuncelleme.Name = "button_ProfilGuncelleme";
            this.button_ProfilGuncelleme.Size = new System.Drawing.Size(180, 36);
            this.button_ProfilGuncelleme.TabIndex = 26;
            this.button_ProfilGuncelleme.Text = "Profili Güncelle";
            this.button_ProfilGuncelleme.UseVisualStyleBackColor = false;
            this.button_ProfilGuncelleme.Click += new System.EventHandler(this.Button_ProfilGuncelleme_Click);
            // 
            // groupBox_GonderiPaylas
            // 
            this.groupBox_GonderiPaylas.Controls.Add(this.listView_Insta_GonderiListesi);
            this.groupBox_GonderiPaylas.Controls.Add(this.richTextBox_Insta_GonderiAciklamasi);
            this.groupBox_GonderiPaylas.Controls.Add(this.label10);
            this.groupBox_GonderiPaylas.Controls.Add(this.button_Insta_GonderiResimSec);
            this.groupBox_GonderiPaylas.Location = new System.Drawing.Point(19, 220);
            this.groupBox_GonderiPaylas.Name = "groupBox_GonderiPaylas";
            this.groupBox_GonderiPaylas.Size = new System.Drawing.Size(455, 220);
            this.groupBox_GonderiPaylas.TabIndex = 25;
            this.groupBox_GonderiPaylas.TabStop = false;
            this.groupBox_GonderiPaylas.Text = "Gönderi Paylaş";
            // 
            // listView_Insta_GonderiListesi
            // 
            this.listView_Insta_GonderiListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_GonderiAciklama,
            this.col_GonderiResimYol});
            this.listView_Insta_GonderiListesi.ContextMenuStrip = this.menu_GonderiListesi;
            this.listView_Insta_GonderiListesi.FullRowSelect = true;
            this.listView_Insta_GonderiListesi.HideSelection = false;
            this.listView_Insta_GonderiListesi.LabelEdit = true;
            this.listView_Insta_GonderiListesi.Location = new System.Drawing.Point(11, 129);
            this.listView_Insta_GonderiListesi.Name = "listView_Insta_GonderiListesi";
            this.listView_Insta_GonderiListesi.Size = new System.Drawing.Size(435, 81);
            this.listView_Insta_GonderiListesi.TabIndex = 16;
            this.listView_Insta_GonderiListesi.UseCompatibleStateImageBehavior = false;
            this.listView_Insta_GonderiListesi.View = System.Windows.Forms.View.Details;
            // 
            // col_GonderiAciklama
            // 
            this.col_GonderiAciklama.Text = "Açıklama";
            this.col_GonderiAciklama.Width = 300;
            // 
            // col_GonderiResimYol
            // 
            this.col_GonderiResimYol.Text = "Resim Yolu";
            this.col_GonderiResimYol.Width = 200;
            // 
            // menu_GonderiListesi
            // 
            this.menu_GonderiListesi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seciliGönderiSil_MenuItem});
            this.menu_GonderiListesi.Name = "menu_GonderiListesi";
            this.menu_GonderiListesi.Size = new System.Drawing.Size(162, 26);
            // 
            // seciliGönderiSil_MenuItem
            // 
            this.seciliGönderiSil_MenuItem.Name = "seciliGönderiSil_MenuItem";
            this.seciliGönderiSil_MenuItem.Size = new System.Drawing.Size(161, 22);
            this.seciliGönderiSil_MenuItem.Text = "Seçili Gönderi Sil";
            this.seciliGönderiSil_MenuItem.Click += new System.EventHandler(this.SeciliGönderiSil_MenuItem_Click);
            // 
            // richTextBox_Insta_GonderiAciklamasi
            // 
            this.richTextBox_Insta_GonderiAciklamasi.Location = new System.Drawing.Point(11, 41);
            this.richTextBox_Insta_GonderiAciklamasi.Name = "richTextBox_Insta_GonderiAciklamasi";
            this.richTextBox_Insta_GonderiAciklamasi.Size = new System.Drawing.Size(308, 82);
            this.richTextBox_Insta_GonderiAciklamasi.TabIndex = 14;
            this.richTextBox_Insta_GonderiAciklamasi.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Gönderi Açıklaması";
            // 
            // button_Insta_GonderiResimSec
            // 
            this.button_Insta_GonderiResimSec.AutoSize = true;
            this.button_Insta_GonderiResimSec.Location = new System.Drawing.Point(325, 41);
            this.button_Insta_GonderiResimSec.Name = "button_Insta_GonderiResimSec";
            this.button_Insta_GonderiResimSec.Size = new System.Drawing.Size(132, 82);
            this.button_Insta_GonderiResimSec.TabIndex = 14;
            this.button_Insta_GonderiResimSec.Text = "Resim Seç ve Ekle";
            this.button_Insta_GonderiResimSec.UseVisualStyleBackColor = true;
            this.button_Insta_GonderiResimSec.Click += new System.EventHandler(this.Button_Insta_GonderiResimSec_Click);
            // 
            // combo_Insta_Cinsiyet
            // 
            this.combo_Insta_Cinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Insta_Cinsiyet.FormattingEnabled = true;
            this.combo_Insta_Cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın",
            "Söylememeyi Tercih Ediyorum"});
            this.combo_Insta_Cinsiyet.Location = new System.Drawing.Point(362, 188);
            this.combo_Insta_Cinsiyet.Name = "combo_Insta_Cinsiyet";
            this.combo_Insta_Cinsiyet.Size = new System.Drawing.Size(112, 24);
            this.combo_Insta_Cinsiyet.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(362, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Cinsiyet";
            // 
            // textBox_Insta_InternetSitesi
            // 
            this.textBox_Insta_InternetSitesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Insta_InternetSitesi.Location = new System.Drawing.Point(19, 188);
            this.textBox_Insta_InternetSitesi.Name = "textBox_Insta_InternetSitesi";
            this.textBox_Insta_InternetSitesi.Size = new System.Drawing.Size(337, 22);
            this.textBox_Insta_InternetSitesi.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(16, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "İnternet Sitesi";
            // 
            // pictureBox_Insta_ProfilResmi
            // 
            this.pictureBox_Insta_ProfilResmi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Insta_ProfilResmi.Location = new System.Drawing.Point(362, 96);
            this.pictureBox_Insta_ProfilResmi.Name = "pictureBox_Insta_ProfilResmi";
            this.pictureBox_Insta_ProfilResmi.Size = new System.Drawing.Size(112, 71);
            this.pictureBox_Insta_ProfilResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Insta_ProfilResmi.TabIndex = 20;
            this.pictureBox_Insta_ProfilResmi.TabStop = false;
            // 
            // textBox_Insta_SeciliProfilResmiYolu
            // 
            this.textBox_Insta_SeciliProfilResmiYolu.Location = new System.Drawing.Point(362, 65);
            this.textBox_Insta_SeciliProfilResmiYolu.Name = "textBox_Insta_SeciliProfilResmiYolu";
            this.textBox_Insta_SeciliProfilResmiYolu.ReadOnly = true;
            this.textBox_Insta_SeciliProfilResmiYolu.Size = new System.Drawing.Size(112, 22);
            this.textBox_Insta_SeciliProfilResmiYolu.TabIndex = 19;
            // 
            // button_Insta_ProfilResmiSec
            // 
            this.button_Insta_ProfilResmiSec.AutoSize = true;
            this.button_Insta_ProfilResmiSec.Location = new System.Drawing.Point(362, 31);
            this.button_Insta_ProfilResmiSec.Name = "button_Insta_ProfilResmiSec";
            this.button_Insta_ProfilResmiSec.Size = new System.Drawing.Size(117, 28);
            this.button_Insta_ProfilResmiSec.TabIndex = 18;
            this.button_Insta_ProfilResmiSec.Text = "Profil Resmi Seç";
            this.button_Insta_ProfilResmiSec.UseVisualStyleBackColor = true;
            this.button_Insta_ProfilResmiSec.Click += new System.EventHandler(this.Button_Insta_ProfilResmiSec_Click);
            // 
            // richTextBox_Insta_Biyografi
            // 
            this.richTextBox_Insta_Biyografi.Location = new System.Drawing.Point(19, 33);
            this.richTextBox_Insta_Biyografi.Name = "richTextBox_Insta_Biyografi";
            this.richTextBox_Insta_Biyografi.Size = new System.Drawing.Size(337, 134);
            this.richTextBox_Insta_Biyografi.TabIndex = 16;
            this.richTextBox_Insta_Biyografi.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(16, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Biyografi";
            // 
            // tab_Logs
            // 
            this.tab_Logs.Controls.Add(this.listBox_Logs);
            this.tab_Logs.Location = new System.Drawing.Point(4, 25);
            this.tab_Logs.Name = "tab_Logs";
            this.tab_Logs.Size = new System.Drawing.Size(491, 498);
            this.tab_Logs.TabIndex = 2;
            this.tab_Logs.Text = "İşlem Kayıtları";
            this.tab_Logs.UseVisualStyleBackColor = true;
            // 
            // listBox_Logs
            // 
            this.listBox_Logs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Logs.FormattingEnabled = true;
            this.listBox_Logs.ItemHeight = 16;
            this.listBox_Logs.Location = new System.Drawing.Point(0, 0);
            this.listBox_Logs.Name = "listBox_Logs";
            this.listBox_Logs.Size = new System.Drawing.Size(491, 498);
            this.listBox_Logs.TabIndex = 0;
            // 
            // Footer_Durum
            // 
            this.Footer_Durum.BackColor = System.Drawing.Color.LightGray;
            this.Footer_Durum.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Footer_Durum_Baslik,
            this.Footer_Durum_Mesaj});
            this.Footer_Durum.Location = new System.Drawing.Point(0, 554);
            this.Footer_Durum.Name = "Footer_Durum";
            this.Footer_Durum.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.Footer_Durum.Size = new System.Drawing.Size(524, 22);
            this.Footer_Durum.SizingGrip = false;
            this.Footer_Durum.TabIndex = 25;
            // 
            // Footer_Durum_Baslik
            // 
            this.Footer_Durum_Baslik.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Footer_Durum_Baslik.Name = "Footer_Durum_Baslik";
            this.Footer_Durum_Baslik.Size = new System.Drawing.Size(48, 17);
            this.Footer_Durum_Baslik.Text = "Durum:";
            // 
            // Footer_Durum_Mesaj
            // 
            this.Footer_Durum_Mesaj.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Footer_Durum_Mesaj.Name = "Footer_Durum_Mesaj";
            this.Footer_Durum_Mesaj.Size = new System.Drawing.Size(67, 17);
            this.Footer_Durum_Mesaj.Text = "Bekleniyor..";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.DarkGray;
            this.label8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(0, 576);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(524, 30);
            this.label8.TabIndex = 24;
            this.label8.Text = "adamlaryazilim.com";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_TestButonu
            // 
            this.button_TestButonu.AutoSize = true;
            this.button_TestButonu.Location = new System.Drawing.Point(615, 39);
            this.button_TestButonu.Name = "button_TestButonu";
            this.button_TestButonu.Size = new System.Drawing.Size(114, 28);
            this.button_TestButonu.TabIndex = 26;
            this.button_TestButonu.Text = "Test Butonu";
            this.button_TestButonu.UseVisualStyleBackColor = true;
            this.button_TestButonu.Click += new System.EventHandler(this.Button_TestButonu_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(524, 606);
            this.Controls.Add(this.button_TestButonu);
            this.Controls.Add(this.Footer_Durum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tab_Sekmeler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instagram Profil Düzenleme";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.tab_Sekmeler.ResumeLayout(false);
            this.tab_InstagramGiris.ResumeLayout(false);
            this.group_Insta_KodDogrulama.ResumeLayout(false);
            this.group_Insta_KodDogrulama.PerformLayout();
            this.group_IkiFaktorluDogrulama.ResumeLayout(false);
            this.group_IkiFaktorluDogrulama.PerformLayout();
            this.panel_InstaGiris.ResumeLayout(false);
            this.panel_InstaGiris.PerformLayout();
            this.group_Insta_TelefonGirme.ResumeLayout(false);
            this.group_Insta_TelefonGirme.PerformLayout();
            this.group_Insta_HesapDogrulama.ResumeLayout(false);
            this.group_Insta_HesapDogrulama.PerformLayout();
            this.tab_Sayfa.ResumeLayout(false);
            this.tab_Sayfa.PerformLayout();
            this.groupBox_GonderiPaylas.ResumeLayout(false);
            this.groupBox_GonderiPaylas.PerformLayout();
            this.menu_GonderiListesi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Insta_ProfilResmi)).EndInit();
            this.tab_Logs.ResumeLayout(false);
            this.Footer_Durum.ResumeLayout(false);
            this.Footer_Durum.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Sekmeler;
        private System.Windows.Forms.TabPage tab_InstagramGiris;
        private System.Windows.Forms.TabPage tab_Sayfa;
        private System.Windows.Forms.StatusStrip Footer_Durum;
        private System.Windows.Forms.ToolStripStatusLabel Footer_Durum_Baslik;
        private System.Windows.Forms.ToolStripStatusLabel Footer_Durum_Mesaj;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel_InstaGiris;
        private System.Windows.Forms.TextBox textBox_InstaGiris_kadi;
        private System.Windows.Forms.Label label_Insta_GirisDurum;
        private System.Windows.Forms.TextBox textBox_InstaGiris_sifre;
        private System.Windows.Forms.Button button_InstaGiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tab_Logs;
        private System.Windows.Forms.ListBox listBox_Logs;
        private System.Windows.Forms.PictureBox pictureBox_Insta_ProfilResmi;
        private System.Windows.Forms.TextBox textBox_Insta_SeciliProfilResmiYolu;
        private System.Windows.Forms.Button button_Insta_ProfilResmiSec;
        private System.Windows.Forms.RichTextBox richTextBox_Insta_Biyografi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox group_Insta_TelefonGirme;
        private System.Windows.Forms.Button button_Insta_TelefonGir;
        private System.Windows.Forms.TextBox textBox_Insta_TelefonGir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox group_Insta_HesapDogrulama;
        private System.Windows.Forms.Button button_Insta_KodIste;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radio_Insta_EpostaDogrulama;
        private System.Windows.Forms.RadioButton radio_Insta_TelefonDogrulama;
        private System.Windows.Forms.GroupBox group_IkiFaktorluDogrulama;
        private System.Windows.Forms.Button button_Insta_IkiFaktorKodGir;
        private System.Windows.Forms.TextBox textBox_Insta_IkiFaktorKodGir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_TestButonu;
        private System.Windows.Forms.GroupBox group_Insta_KodDogrulama;
        private System.Windows.Forms.Button button_Insta_TekrarKodIste;
        private System.Windows.Forms.Button button_Insta_Dogrula;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.TextBox textBox_Insta_KodDogrulama;
        private System.Windows.Forms.Label label_Insta_SMSveEPOSTA;
        private System.Windows.Forms.ComboBox combo_Insta_Cinsiyet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Insta_InternetSitesi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox_GonderiPaylas;
        private System.Windows.Forms.ListView listView_Insta_GonderiListesi;
        private System.Windows.Forms.ColumnHeader col_GonderiAciklama;
        private System.Windows.Forms.ColumnHeader col_GonderiResimYol;
        private System.Windows.Forms.RichTextBox richTextBox_Insta_GonderiAciklamasi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_Insta_GonderiResimSec;
        private System.Windows.Forms.Button button_ProfilGuncelleme;
        private System.Windows.Forms.ContextMenuStrip menu_GonderiListesi;
        private System.Windows.Forms.ToolStripMenuItem seciliGönderiSil_MenuItem;
    }
}

