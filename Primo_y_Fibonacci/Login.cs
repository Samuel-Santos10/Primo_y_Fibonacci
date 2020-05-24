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
    public partial class Login : Form
    {

        string usuario = "programador";
        string contra = "1234";

        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if ((txtusuario.Text != "") && (txtcontra.Text != ""))
            {

                if (txtusuario.Text != usuario || txtcontra.Text != contra)
                {
                    if (txtusuario.Text != usuario)
                    {
                        MessageBox.Show("Usuario Incorrecto");
                        txtusuario.Clear();
                        txtcontra.Clear();
                        return;
                    }

                    if (txtcontra.Text != contra)
                    {
                        MessageBox.Show("Contraseña Incorrecta");
                        txtcontra.Clear();
                        txtcontra.Focus();
                        return;
                    }
                }

                else
                {
                    txtusuario.Clear();
                    txtcontra.Clear();
                    Menu form = new Menu();
                    form.Show();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
