using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wavelet
{
    public partial class Form1 : Form
    {
        Wavelet item;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            item = new Wavelet();
            item.setCoeff(Helper.GetVector(openFileDialog1));
            Helper.FillListView(listView1, item.getCoeff());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Helper.FillListView(listView2, item.getSums());
        }
    }
}
