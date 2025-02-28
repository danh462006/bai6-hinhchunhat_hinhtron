using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai6_hinhchunhat_hinhtron
{
    public partial class tbnso2 : Form
    {
        public tbnso2()
        {
            InitializeComponent();
        }

        private void btnso1_Click(object sender, EventArgs e)
        {
            int cdai= Convert.ToInt32(txtso1.Text);
            int crong= Convert.ToInt32(txtso2.Text);
            int dt, chuv;
            dt = cdai * crong;
            chuv = (crong + dt)*2;
            lab1.Text = ("diện tích: " + dt).ToString();
            lab2.Text = ("chu vi: " + chuv).ToString();

        }

        private void btnso2_Click(object sender, EventArgs e)
        {
            int bk= Convert.ToInt32(txtso3.Text);
            double dtht, chuvht;
            dtht = 3.14 * (bk * bk);
            chuvht = (bk * 2) * 3.14;
            lab3.Text = ("diện tích: " + dtht).ToString();
            lab4.Text = ("chu vi: " + chuvht).ToString();

        }
    }
}
