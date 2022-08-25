using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Bileti_Satis_Programi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int seans = 0;
        int seansUcret = 0;

        private void btnArtis_Click(object sender, EventArgs e)
        {
            seans++;
            seansUcret += 8;

            txtKisiSayisi.Text = seans.ToString();
            txtBiletFiyat.Text = seansUcret.ToString();

            if (seans == 10)
            {
                btnArtis.Enabled = false;
            }
            if (seans >= 1)
            {
                btnAzalis.Enabled = true;
            }
        }

        private void btnAzalis_Click(object sender, EventArgs e)
        {
            seans--;
            seansUcret -= 8;
            txtKisiSayisi.Text = seans.ToString();
            txtBiletFiyat.Text = seansUcret.ToString();

            if (seans == 0)
            {
                btnAzalis.Enabled = false;
            }
            if (seans <= 10)
            {
                btnArtis.Enabled = true;
            }
        }

        int seans2 = 0;
        int seansUcret2 = 0;
        private void btnArtis2_Click(object sender, EventArgs e)
        {
            seans2++;
            seansUcret2 += 20;

            txtKisiSayisi2.Text = seans2.ToString();
            txtBiletFiyat2.Text = seansUcret2.ToString();

            if (seans2 == 15)
            {
                btnArtis2.Enabled = false;
            }
            if (seans2 <= 0)
            {
                btnAzalis2.Enabled = true;
            }
        }

        private void btnAzalis2_Click(object sender, EventArgs e)
        {
            seans2--;
            seansUcret2 -= 20;

            txtKisiSayisi2.Text = seans2.ToString();
            txtBiletFiyat2.Text = seansUcret2.ToString();

            if (seans2 == 0)
            {
                btnAzalis2.Enabled = false;
            }
            if (seansUcret2 <= 15)
            {
                btnArtis2.Enabled = true;
            }
        }

        int seans3 = 0;
        int seansUcret3 = 0;
        private void btnArtis3_Click(object sender, EventArgs e)
        {
            seans3++;
            seansUcret3 += 30;

            txtKisiSayisi3.Text = seans3.ToString();
            txtBiletFiyat3.Text = seansUcret3.ToString();

            if (seans3 == 20)
            {
                btnArtis3.Enabled = false;
            }
            if (seans3 <= 0)
            {
                btnAzalis3.Enabled = true;
            }
        }

        private void btnAzalis3_Click(object sender, EventArgs e)
        {
            seans3--;
            seansUcret3-= 30;

            txtKisiSayisi3.Text = seans3.ToString();
            txtBiletFiyat3.Text = seansUcret3.ToString();

            if (seans3 == 0)
            {
                btnAzalis3.Enabled = false;
            }
            if (seansUcret3 <= 15)
            {
                btnArtis3.Enabled = true;
            }
        }

        int seans4 = 0;
        int seansUcret4 = 0;
        private void btnArtis4_Click(object sender, EventArgs e)
        {
            seans4++;
            seansUcret4 += 40;

            txtKisiSayisi4.Text = seans4.ToString();
            txtBiletFiyat4.Text = seansUcret4.ToString();

            if (seans4 == 30)
            {
                btnArtis4.Enabled = false;
            }
            if (seans4 <= 0)
            {
                btnAzalis4.Enabled = true;
            }
        }

        private void btnAzalis4_Click(object sender, EventArgs e)
        {
            seans4--;
            seansUcret4 -= 40;

            txtKisiSayisi4.Text = seans4.ToString();
            txtBiletFiyat4.Text = seansUcret4.ToString();

            if (seans4 == 0)
            {
                btnAzalis4.Enabled = false;
            }
            if (seansUcret4 <= 30)
            {
                btnArtis4.Enabled = true;
            }
        }

        int misir = 0;
        int fiyatMisir = 0;
        private void btnMisirArtis_Click(object sender, EventArgs e)
        {
            misir++;
            txtMisirMiktar.Text = misir.ToString();

            fiyatMisir += 45;
            txtMisirFiyat.Text = fiyatMisir.ToString();
        }

        private void btnMisirAzalt_Click(object sender, EventArgs e)
        {
            misir--;
            fiyatMisir -= 45;

            txtMisirMiktar.Text = misir.ToString();
            txtMisirFiyat.Text = fiyatMisir.ToString();

            if (misir == 0)
            {
                btnMisirAzalt.Enabled = false;
            }
            if (fiyatMisir <= 0)
            {
                btnMisirArtis.Enabled = true;
            }
        }
        int kola = 0;
        int kolaFiyat = 0;
        private void btnKolaArtis_Click(object sender, EventArgs e)
        {
            kola++;
            txtKolaMiktar.Text = kola.ToString();

            kolaFiyat += 30;
            txtKolaFiyat.Text = kolaFiyat.ToString();
        }

        private void btnKolaAzalt_Click(object sender, EventArgs e)
        {
            kola--;
            kolaFiyat -= 30;

            txtKolaMiktar.Text = kola.ToString();
            txtKolaFiyat.Text = kolaFiyat.ToString();

            if (kola == 0)
            {
                btnKolaAzalt.Enabled = false;
            }
            if (kolaFiyat <= 0)
            {
                btnKolaArtis.Enabled = true;
            }
        }

        int su = 0;
        int suFiyat = 0;
        private void btnSuArtir_Click(object sender, EventArgs e)
        {
            su++;
            txtSuMiktar.Text = su.ToString();

            suFiyat += 25;
            txtSuFiyat.Text = suFiyat.ToString();
        }

        private void btnSuAzalt_Click(object sender, EventArgs e)
        {
            su--;
            txtSuMiktar.Text = su.ToString();

            suFiyat -= 25;
            txtSuFiyat.Text = suFiyat.ToString();

            if (su == 0)
            {
                btnSuAzalt.Enabled = false;
            }
            if (suFiyat <= 0)
            {
                btnSuArtir.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\TULPAR\\OneDrive\\Masaüstü\\c_sharp_form\\csharp_ornekler\\Sinema_Bileti_Satis_Programi\\fragman.mp4";
        }
    }
}
