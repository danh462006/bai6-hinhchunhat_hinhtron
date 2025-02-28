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

            lab1.Text = "-Diện tích: " + dientichchunhat(double.Parse(txtso1.Text), double.Parse(txtso2.Text)) + "\n - chu vi: " + chuvichunhat(double.Parse(txtso1.Text), double.Parse(txtso2.Text));

        }

        private void btnso2_Click(object sender, EventArgs e)
        {
            lab3.Text = "-Diện tích: " + dientichtron(double.Parse(txtso3.Text)) + "\n- chu vi: " + chuvitron(double.Parse( txtso3.Text));

        }
        double dientichchunhat(double dai, double rong) { return dai * rong; }
        double chuvichunhat(double dai, double rong) { return (dai + rong)*2; }
        double dientichtron(double bk) { return 3.14*( bk * bk); }
        double chuvitron(double bk) { return (bk * 2) * 3.14; }

        private void btn03_Click(object sender, EventArgs e)
        {
            if (rdbso1.Checked)
            {
                lab1.Text = "-Diện tích: " + dientichchunhat(double.Parse(txtso1.Text), double.Parse(txtso2.Text)) ;
            }
            if (rdbso2.Checked)
            {
                lab1.Text = "\n - chu vi: " + chuvichunhat(double.Parse(txtso1.Text), double.Parse(txtso2.Text));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chb01.Checked)
            {
                lab1.Text = "-Diện tích: " + dientichchunhat(double.Parse(txtso1.Text), double.Parse(txtso2.Text));
            }
            if (chb02.Checked)
            {
                lab1.Text += "\n - chu vi: " + chuvichunhat(double.Parse(txtso1.Text), double.Parse(txtso2.Text));
            }

        }
    }
    

}
