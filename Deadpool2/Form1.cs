using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deadpool2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtreal1_KeyUp(object sender, KeyEventArgs e)
        {

            Regex regex = new Regex("^-?[0-9]+([.])?([0-9]+)?$");
            if (regex.IsMatch(txtreal1.Text))
            {
                errorProvider1.SetError(txtreal1, String.Empty);
            }
            else
            {
                errorProvider1.SetError(txtreal1,
                      "Ingresar solo números");
            }
        }
        private void txtimaginario1_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^-?[0-9]+([.])?([0-9]+)?$");
            if (regex.IsMatch(txtimaginario1.Text))
            {
                errorProvider1.SetError(txtimaginario1, String.Empty);
            }
            else
            {
                errorProvider1.SetError(txtimaginario1,
                      "Ingresar solo números");
            }
        }

        private void txtreal2_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^-?[0-9]+([.])?([0-9]+)?$");
            if (regex.IsMatch(txtreal2.Text))
            {
                errorProvider1.SetError(txtreal2, String.Empty);
            }
            else
            {
                errorProvider1.SetError(txtreal2,
                      "Ingresar solo números");
            }
        }

        private void txtimaginario2_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^-?[0-9]+([.])?([0-9]+)?$");
            if (regex.IsMatch(txtimaginario2.Text))
            {
                errorProvider1.SetError(txtimaginario2, String.Empty);
            }
            else
            {
                errorProvider1.SetError(txtimaginario2,
                      "Ingresar solo números");
            }
        }

        //Estructura para multiplicar 
        public struct Multiply
        {

            public double real;
            public double imag;

            // Operador sobrecargado
            public static Multiply operator *(Multiply m1, Multiply m2)
            {
                Multiply nc = new Multiply();
                //              (ac-bd)*
                nc.real = ((m1.real * m2.real) + (-1 * (m1.imag * m2.imag)));
                //              ( ad + bc)
                nc.imag = ((m1.real * m2.imag) + (m1.imag * m2.real));

                return nc;
            }
        }
        // Botón multiplicar

        private void btnMultiply_Click(object sender, EventArgs e)
        {

            Multiply s1 = new Multiply();

            Multiply s2 = new Multiply();

            Multiply multi = new Multiply();

            s1.real = double.Parse(txtreal1.Text);
            s1.imag = double.Parse(txtimaginario1.Text);
            s2.real = double.Parse(txtreal2.Text);
            s2.imag = double.Parse(txtimaginario2.Text);

            multi = s1 * s2;

            resReal.Text = multi.real.ToString();
            resImaginario.Text = multi.imag.ToString();
        }


    }
}
