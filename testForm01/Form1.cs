using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testForm01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tx01.Text = "";
            if (text01.Text.Length <= 2)
            {
                tx01.Text = "Hola Buenos Dias Humannoide!!";
            }
            else
            {
                tx01.Text = "Hola Buenos Dias " + text01.Text + "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

            if(OPERADR.Text.Equals("+"))
            {
                int uno = int.Parse(txOP01.Text);
                int dos = int.Parse(txOP2.Text);
                int res = uno + dos;
                string respta = Convert.ToString(res);
                RESPTA.Text = respta;
            }
            if (OPERADR.Text.Equals("-"))
            {
                int uno = int.Parse(txOP01.Text);
                int dos = int.Parse(txOP2.Text);
                int res = uno - dos;
                string respta = Convert.ToString(res);
                RESPTA.Text = respta;
            }
            if (OPERADR.Text.Equals("*"))
            {
                int uno = int.Parse(txOP01.Text);
                int dos = int.Parse(txOP2.Text);
                int res = uno * dos;
                string respta = Convert.ToString(res);
                RESPTA.Text = respta;
            }
            if (OPERADR.Text.Equals("/"))
            {
                int uno = int.Parse(txOP01.Text);
                int dos = int.Parse(txOP2.Text);
                int res = uno / dos;
                string respta = Convert.ToString(res);
                RESPTA.Text = respta;
            }
        }
        /**
         * para validar texto y numeros en cuadros de texto
         **/
        private void text01_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);//valida solo letras lo malo esq no permite espacios
            //e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);//valida solo numeros lo malo esq  no permite operadores(+-*/.)
        }

        private void txOP01_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);//valida solo numeros
        }
    }
}
