using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ev_Final_4toBi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            byte Num1 = Byte.Parse(TextVar1.Text);
            byte Num2 = Byte.Parse(TextVar2.Text);
            int Producto = Num1 * Num2;
            MessageBox.Show("el resultado es este " + Producto); 
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            byte num1 = byte.Parse(TextVar1.Text);
            byte num2 = byte.Parse(TextVar2.Text);
           int Suma = num1 + num2;
            MessageBox.Show("este es el resultado de nuestra suma " + Suma);
        }

        private void BtnPotencia_Click(object sender, EventArgs e)
        {
           int Num1 = int.Parse(TextVar1.Text);
           int Num2 = int.Parse(TextVar2.Text);
            int Potencia = 1;
            int J = 0;
            while (J != Num2)
            {
                Potencia = Potencia * Num1;
                J++;
            }
            MessageBox.Show("Este es el resultado de nuestra potencia" + Potencia);
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            byte Num1 = byte.Parse(TextVar1.Text);
            byte Num2 = byte.Parse(TextVar2.Text);

            if (Num2 > 0)
            {
                float Division = Num1 / Num2;
                MessageBox.Show("el resultado es este " + Division); 
            }
            else
            {
                MessageBox.Show("esta definicion es indefinida");
            }
        }
    }
}
