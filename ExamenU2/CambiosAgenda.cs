using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenU2
{
    public partial class CambiosAgenda : Form
    {
        public CambiosAgenda(string Id, string APaterno, string AMaterno, string Nombre,
            string Telefono, string Correo)
        {
            InitializeComponent();
            txtId.Text = Id;
            txtAPaterno.Text = APaterno;
            txtAMaterno.Text = AMaterno;
            txtNombre.Text = Nombre;
            maskedTextBox1.Text = Telefono;
            txtCorreo.Text = Correo;

        }

        private void CambiosAgenda_Load(object sender, EventArgs e)
        {

        }

        private void butactualizar_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            bool f = datos.comando("update usuarios set " +
                "APaterno='" + txtAPaterno.Text + "', " +
                "AMaterno='" + txtAMaterno.Text + "', " +
                "Nombre='" + txtNombre.Text + "', " +
                "Telefono='" + maskedTextBox1.Text.Replace("-","") + "', " +
                "Correo='" + txtCorreo.Text + "' " +
                "WHERE ID='" + txtId.Text + "'");
            if (f == true)
            {
                MessageBox.Show("Datos Actualizados", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Error al actualizar", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void butcancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro de eliminar el registro?",
                     "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                Datos datos = new Datos();
                bool f = datos.comando("delete from Usuarios where ID='" + txtId.Text + "'");
                if (f == true)
                {
                    MessageBox.Show("Datos Eliminados", "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al eliminar", "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
