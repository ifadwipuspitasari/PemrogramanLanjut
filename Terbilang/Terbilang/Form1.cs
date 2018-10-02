using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Terbilang;

namespace Terbilang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTerbilang_Click(object sender, EventArgs e)
        {
            int nominal = Convert.ToInt32(nilainominal.Text);
            Terbilang terbilang = new Terbilang();

            hasilTerbilang.Items.Add(terbilang.TerbilangIndonesia(nominal));
        }
    }
}
