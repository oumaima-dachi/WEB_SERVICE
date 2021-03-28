using System;
using System.Windows.Forms;

namespace WindowsFormsAppTP
{
    public partial class Form1 : Form
    {
        ServiceReference1.Service1Client cal = new ServiceReference1.Service1Client();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            tb_resultat.Text = Convert.ToString(cal.WebAdd(int.Parse(tb_x.Text), int.Parse(tb_y.Text)));
        }

        private void btn_soustraction_Click(object sender, EventArgs e)
        {
            tb_resultat.Text = Convert.ToString(cal.WebSoustraction(int.Parse(tb_x.Text), int.Parse(tb_y.Text)));
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            tb_resultat.Text = Convert.ToString(cal.WebMultiply(int.Parse(tb_x.Text), int.Parse(tb_y.Text)));
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            tb_resultat.Text = Convert.ToString(cal.WebDivision(int.Parse(tb_x.Text), int.Parse(tb_y.Text)));
        }
    }
}
