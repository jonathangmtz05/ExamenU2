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
    public partial class AltasAgenda : Form
    {
        public AltasAgenda()
        {
            InitializeComponent();
        }

        private void butcancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butinsertar_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            bool f = datos.comando("INSERT INTO Usuarios (APaterno, AMaterno, Nombre, Telefono, Correo) VALUES ('" +
               txtAPaterno.Text + "','" + txtAMaterno.Text + "','" + txtNombre.Text + "','" +
               mtbTel.Text.Replace("-","") + "','" + txtCorreo.Text + "')");
            if (f == true)
            {
                MessageBox.Show("Datos insertados", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al insertar", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
