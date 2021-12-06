using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace IPSGUI
{
    public partial class Login : Form
    {
        UsuarioServiceOracle service = new UsuarioServiceOracle();

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string usuario = TxtUsuario.Text.Trim();
            string pass = TxtPass.Text.Trim();
            UsuarioServiceOracle usuarioService = new UsuarioServiceOracle();
            
            if (usuario != "" && pass != "")
            {
                
                usuario usuario1 = usuarioService.BuscarID(usuario,pass);
                
                if (usuario1 != null)
                {
                    FrmMenuPrincipal menu =  new FrmMenuPrincipal();
                    this.Dispose();
                    MessageBox.Show($" BIENVENIDO AL SISTEMA ");
                    menu.Show();



                }
                else
                {
                    MessageBox.Show($" USUARIO O CONTRASEÑA INCORRECTA ");
                    
                }


            }
            else
            {
                MessageBox.Show(" CAMPOS VACIOS ");
            }
        }
    }
}
