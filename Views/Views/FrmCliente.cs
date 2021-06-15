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
    public partial class FrmCliente : Form
    {
        Controllers.ClientController clientController = new Controllers.ClientController();
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            clientController.saveClient(txtCname.Text, txtClastname.Text, txtCphone.Text, txtCemail.Text);
            MessageBox.Show("Cliente Ingresado Exitosamente");
            dgClients.DataSource = clientController.GetClientList();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            dgClients.DataSource = clientController.GetClientList();
        }
    }
}
