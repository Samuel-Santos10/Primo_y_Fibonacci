using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primo_y_Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fibonacci();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {

            int numero = byte.Parse(txtnum.Text);

            int cont = 0;

            for (int i = 1; i <= numero; i++)

            {
            
           if (numero % i == 0)

                {
                    cont++;
                }
            }

            if (cont == 2)
            {
                lblrespuesta.Text =  numero + (" Es PRIMO");

            }

            else

            {
                lblrespuesta.Text = numero + (" NO es primo");
            }
           
        }

        private void fibonacci ()

        {

            int pnumero = 0;
            int snumero = 1;
            int x;
            int nlimite = 1000;

            lstnumeros.Items.Add(pnumero);
            lstnumeros.Items.Add(snumero);

            while (snumero + pnumero <= nlimite)
            {
                x = pnumero;
                pnumero = snumero;
                snumero = x + pnumero;

                lstnumeros.Items.Add(snumero);
            }

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            lblrespuesta.Text = "";
            txtnum.Text = "";
        }
    }
}
