using Examen2F.Modelos.DAO;
using Examen2F.Modelos.Entidades;
using Examen2F.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2F.Controladores
{
   public class LoginController
    {
        LoginView vista;
        public LoginController(LoginView view)
        {
            vista = view;
            vista.Iniciarbutton.Click += new EventHandler(ValidarUsuario);
        }
        private void ValidarUsuario(object serder, EventArgs e)
        {
            bool esValido = false;
            UsuarioDAO userDAO = new UsuarioDAO();

            Usuario user = new Usuario();

            user.Correo = vista.CorreotextBox.Text;
            user.Clave = vista.ClavetextBox.Text;

            esValido = userDAO.ValidarUsuario(user);

            if (esValido)
            {
                MenuView menu = new MenuView();
                vista.Hide();
                menu.Show();
               
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto");
            }
        }
    }
}

