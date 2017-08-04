using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace _20170412_giyotin
{
    public partial class FormGiyotin : Form
    {
        public FormGiyotin()
        {
            InitializeComponent();
        }
        int x, y, z, t, u;
        string[] kisiler = new string[] { "Melek", "Seda", "Uğur", "Muhammed", "Kübra", "Özdecan", "Simon", "Yücel", "Ceren", "Eray", "Onur", "Esra", "Ahmet", "Dilan", "Ebubekir" };

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            tmrYaz.Enabled = true;
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\CASPER\Documents\Visual Studio 2012\Projects\20170412_giyotin\20170412_giyotin\psycho_theme (online-audio-converter.com).wav";
            
            player.Play();
        }


        private void tmrSure_Tick(object sender, EventArgs e)
        {
            x = rdm.Next(0, 400);
            y = rdm.Next(0, 400);
            z = rdm.Next(0, 255);
            t = rdm.Next(0, 255);
            u = rdm.Next(0, 255);

            label[i] = new Label();
            label[i].Text = kisiler[rdm.Next(0, 14)].ToString();
            label[i].ForeColor = Color.FromArgb(z, t, u);
            label[i].Location = new Point(x, y);
            label[i].Name = "lbl" + i;
            label[i].AutoSize = true;
            labelisimler.Add(label[i].Name);
            this.Controls.Add(label[i]);
            if (i >= 29)
            {
                tmrYaz.Enabled = false;
                tmrSil.Enabled = true;
            }
            else
            {
                i++;
            }
        }
        Label[] label = new Label[30];
        int i = 0;
        Random rdm = new Random();
        List<string> labelisimler = new List<string>();
        private void FormGiyotin_Load(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\CASPER\Documents\Visual Studio 2012\Projects\20170412_giyotin\20170412_giyotin\psycho_theme (online-audio-converter.com).wav";
            
        }

        private void tmrSil_Tick(object sender, EventArgs e)
        {
            if (labelisimler.Count > 1)
            {
                int sayi = rdm.Next(0, labelisimler.Count);
                Label lbl = (Label)this.Controls.Find(labelisimler[sayi], false)[0];
                this.Controls.Remove(lbl);
                labelisimler.RemoveAt(sayi);
            }
            else
            {
                tmrSil.Enabled = false;
                Label lbl = (Label)this.Controls.Find(labelisimler[0], false)[0];
                lbl.Font = new Font(lbl.Font.FontFamily, 20);
                lbl.Location = new Point(178, 164);
                //sonuncusu kaldığında yapılacak işlemon


            }
        }
    }
}
