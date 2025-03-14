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
    public partial class Agenda : Form
    {
        public Agenda()
        {
            InitializeComponent();
        }
        private void ActualizaGrid()
        {
            Datos obj = new Datos();
            DataSet ds = obj.consulta("SELECT Id, APaterno AS [Apellido Paterno], AMaterno AS [Apellido Materno], Nombre, Telefono, Correo FROM Usuarios");
            if (ds != null)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
        private void Agenda_Load(object sender, EventArgs e)
        {
            ActualizaGrid();
        }

        private void butinsertar_Click(object sender, EventArgs e)
        {
            AltasAgenda altas = new AltasAgenda();
            altas.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CambiosAgenda cambios = new CambiosAgenda(
                dataGridView1[0, e.RowIndex].Value.ToString(),
                dataGridView1[1, e.RowIndex].Value.ToString(),
                dataGridView1[2, e.RowIndex].Value.ToString(),
                dataGridView1[3, e.RowIndex].Value.ToString(),
                dataGridView1[4, e.RowIndex].Value.ToString(),
                dataGridView1[5, e.RowIndex].Value.ToString());
            cambios.ShowDialog();
        }

        private void Agenda_Activated(object sender, EventArgs e)
        {
            ActualizaGrid();
        }

        private void butSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
