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
   public class ClientesController
    {
        ClientesView vista;
        ClienteDAO clienteDAO = new ClienteDAO();
        Cliente cliente = new Cliente();
        string operacion = string.Empty;
        public ClientesController(ClientesView view)
        {
            vista = view;
            vista.Nuevobutton.Click += new EventHandler(Nuevo);
            vista.Guardarbutton.Click += new EventHandler(Guardar);
            vista.Load += new EventHandler(Load);
        }
        private void Nuevo(object serder, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }
        private void Load(object serder, EventArgs e)
        {
            ListarClientes();
        }
        private void Guardar(object serder, EventArgs e)
        {
            if (vista.NombretextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.NombretextBox, "Ingrese un Nombre");
                vista.NombretextBox.Focus();
                return;
            }
            if (vista.EmailtextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.EmailtextBox, "Ingrese un Email");
                vista.EmailtextBox.Focus();
                return;
            }
            if (vista.IdentidadtextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.IdentidadtextBox, "Ingrese una Identidad");
                vista.IdentidadtextBox.Focus();
                return;
            }
            if (vista.DirecciontextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.DirecciontextBox, "Ingrese una Direccion");
                vista.DirecciontextBox.Focus();
                return;
            }

            cliente.Identidad = vista.IdentidadtextBox.Text;
            cliente.Nombre = vista.NombretextBox.Text;
            cliente.Email = vista.EmailtextBox.Text;
            cliente.Direccion = vista.DirecciontextBox.Text;

            if (operacion == "Nuevo")
            {
                bool inserto = clienteDAO.InsertarCliente(cliente);
                if (inserto)
                {
                    MessageBox.Show("Cliente Creado exitosamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cliente no se pudo crear", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }
        private void ListarClientes()
        {
            vista.ClientesDataGridView.DataSource = clienteDAO.GetClientes();
        }
        private void HabilitarControles()
        {
            vista.IdentidadtextBox.Enabled = true;
            vista.NombretextBox.Enabled = true;
            vista.DirecciontextBox.Enabled = true;
            vista.EmailtextBox.Enabled = true;
            vista.IdentidadtextBox.Enabled = true;

            vista.Guardarbutton.Enabled = true;
            vista.Cancelarbutton.Enabled = true;
            vista.Modificarbutton.Enabled = false;
            vista.Nuevobutton.Enabled = false;
        }
    }
}
