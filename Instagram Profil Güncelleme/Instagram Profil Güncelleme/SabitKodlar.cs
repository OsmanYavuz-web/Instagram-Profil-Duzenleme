using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instagram_Profil_Güncelleme
{
    public class SabitKodlar
    {
        /// <summary>
        /// İki değer arasındaki veriyi ayırma fonksiyonu
        /// VeriAyiklama(HtmlKod, "<title>", "</title>");
        /// </summary>
        /// <param name="kaynakKod">Metnin tümü</param>
        /// <param name="ilkVeri">İlk veri değeri</param>
        /// <param name="sonVeri">Son veri değeri</param>
        /// <returns></returns>
        #region Veri Ayıklama Fonksiyon - VeriAyiklama(kaynakKod, ilkVeri, sonVeri)
        public string VeriAyiklama(string kaynakKod, string ilkVeri, string sonVeri)
        {
            string ayiklananVeri;
            try
            {
                string gelen = kaynakKod;
                int titleIndexBaslangici = gelen.IndexOf(ilkVeri) + ilkVeri.Length;
                int titleIndexBitisi = gelen.Substring(titleIndexBaslangici).IndexOf(sonVeri);
                ayiklananVeri = gelen.Substring(titleIndexBaslangici, titleIndexBitisi);
                return ayiklananVeri;
            }
            catch
            {
                return "False";
            }
        }
        #endregion



        /// <summary>
        /// Klasör kontrolü yapan ve yoksa oluşturan fonksiyon
        /// </summary>
        /// <param name="Yol">Klasörün oluşturulacağı yol</param>
        /// <param name="gizliKlasor">True/False klasör yoksa yeniden oluştururken gizli klasör yapar</param>
        /// <returns></returns>
        #region Klasör var mı?
        public bool Klasor_Kontrol(string Yol, bool gizliKlasor = false)
        {
            // Log klasörü var mı?
            try
            {
                // var mı?
                string varmi = Yol;
                if (Directory.Exists(varmi) == false)
                {
                    // yoksa oluştur
                    string path = Yol;
                    if (!Directory.Exists(path))
                    {
                        DirectoryInfo di = Directory.CreateDirectory(path);

                        if (gizliKlasor)
                        {
                            // gizli klasör oluştur
                            di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
                        }
                        else
                        {
                            // normal klasör oluştur
                            di.Attributes = FileAttributes.Directory;
                        }

                    }
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        #endregion




    }
}
