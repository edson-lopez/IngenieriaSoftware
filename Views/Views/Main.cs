using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = vehicleController.GetList();
        }

        private void btnNuevaOrden_Click(object sender, EventArgs e)
        {
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            FrmCliente frm = new FrmCliente();
            frm.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmNotificaciones frm = new FrmNotificaciones();
            frm.ShowDialog();
        }

        private void btnEstadoFabrica_Click(object sender, EventArgs e)
        {
            FrmNuevoVehiculo frm = new FrmNuevoVehiculo();
            frm.ShowDialog();
        }

        private void btnDepartamentos_Click(object sender, EventArgs e)
        {

        }
    }
}
