using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Premier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bouton_Btn_Click(object sender, EventArgs e)
        {
            //Process.Start("https://www.google.com/search?q=" + ZoneText_Txt.Text);

            Process.Start("https://www.tiktok.com/search/user?q=" + ZoneText_Txt.Text);
        }
    }
}
