using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Premier
{
    public partial class Form1 : Form
    {
        readonly string FileCreate = Application.StartupPath + @"\sauvegarde.txt";

        public Form1()
        {
            InitializeComponent();

            Chk_Google.Click += new EventHandler(Chk_Google_Click);
            Chk_Wiki.Click += new EventHandler(Chk_Wiki_Click);
        }

        private void Bouton_Btn_Click(object sender, EventArgs e)
        {
            if (Chk_Google.Checked == true & ZoneText_Txt.Text != "")
            {
                Process.Start("https://www.google.com/search?q=" + ZoneText_Txt.Text);
            }
            else if (Chk_Wiki.Checked == true & ZoneText_Txt.Text != "")
            {
                Process.Start("https://fr.wikipedia.org/wiki/" + ZoneText_Txt.Text);
            }

            if (ZoneText_Txt.Text != "")
                using (StreamWriter file_create = File.AppendText(FileCreate))
                {
                    file_create.WriteLine(ZoneText_Txt.Text);
                }
            else
                ZoneText_Txt.BackColor = Color.Red;
                MessageBox.Show("Veuillez saisir un terme de recherche dans la zone de texte avant de cliquer sur le bouton !");
                ZoneText_Txt.BackColor = Color.White;
        }

        private void Chk_Google_Click(object sender, EventArgs e)
        {
            if (Chk_Google.Checked == true)
            {
                Chk_Wiki.Checked = false;
            }
            else
            {
                Chk_Wiki.Checked = true;
            }
        }

        private void Chk_Wiki_Click(object sender, EventArgs e)
        {
            if (Chk_Wiki.Checked == true)
            {
                Chk_Google.Checked = false;
            }
            else
            {
                Chk_Google.Checked = true;
            }
        }
    }
}
