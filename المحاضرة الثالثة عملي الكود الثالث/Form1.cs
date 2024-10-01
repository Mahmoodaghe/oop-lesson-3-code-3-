using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace المحاضرة_الثالثة_عملي_الكود_الثالث
{
    public partial class Form1 : Form
    {
        double x, y, z;
        string[] p = {"+","-","*","/" };
        public Form1()
        {
            InitializeComponent();
            listop.Items.AddRange(p);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            result.ReadOnly = true;
            //listop.AllowDrop = ComboBoxStyle.DropDownList;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fristN.Text = secondN.Text = result.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToDouble(fristN.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("العدد الاول غير صالح تحذير");//,MessageBoxButtons.OK,MessageBoxIcon.Hand);
                fristN.Text = "";
                fristN.Focus();
                result.Text= "";
                return;
            }
            try
            {
                y = Convert.ToDouble(secondN.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("العدد الثاني غير صحيح");
                secondN.Text = "";
                secondN.Focus();
                result.Text = "";
                return;
            } bool f = true;
            switch (listop.SelectedIndex)
            {
                default: break;
                case 0: z = x + y; break;
                case 1: z = x - y; break;
                case 2: z = x * y; break;
                case 3:
                        if (y == 0)
                        {
                            MessageBox.Show("لايجوز القسمة  على صفر");
                            f = false;
                            secondN.Text = null;
                            break;
                        }
                        else
                        {
                            z = x / y;
                            break;
                        }
            }
            if (f)
                result.Text = z.ToString();
        }
        
        private void listop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listop_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void listop_MouseClick(object sender, MouseEventArgs e)
        {
            
                result.Text = (Convert.ToInt16( fristN )+Convert.ToInt16(secondN)).ToString();
        }
    }
}
