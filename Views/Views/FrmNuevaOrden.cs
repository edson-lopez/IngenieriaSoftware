using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;

namespace Views
{
    public partial class FrmNuevaOrden : Form
    {
        Controllers.VehicleController vehicleController = new Controllers.VehicleController();
        Controllers.ClientController clientController = new Controllers.ClientController();
        public FrmNuevaOrden()
        {
            InitializeComponent();
        }

        private void FrmNuevaOrden_Load(object sender, EventArgs e)
        {
            cbxBrands.DataSource = vehicleController.GetBrands();
            cbxBrands.ValueMember = "Id";
            cbxBrands.DisplayMember = "Nombre";

            cbxTipoVehiculo.DataSource = vehicleController.GetVehicleTypes();
            cbxTipoVehiculo.ValueMember = "Id";
            cbxTipoVehiculo.DisplayMember = "Nombre";

            cbxClient.DataSource = clientController.GetClientList();
            cbxClient.ValueMember = "Id";
            cbxClient.DisplayMember = "Nombre";


            cbxModel.DataSource = vehicleController.GetModels(Convert.ToInt32(cbxTipoVehiculo.SelectedValue),Convert.ToInt32(cbxBrands.SelectedValue));
            cbxModel.ValueMember = "Id";
            cbxModel.DisplayMember = "Nombre";
             
        }

        private void cbxBrands_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                cbxModel.DataSource = vehicleController.GetModels(Convert.ToInt32(cbxTipoVehiculo.SelectedValue), Convert.ToInt32(cbxBrands.SelectedValue));
                cbxModel.ValueMember = "Id";
                cbxModel.DisplayMember = "Nombre";
            }
            catch (Exception)
            {
            }
        }

        private void cbxTipoVehiculo_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                cbxModel.DataSource = vehicleController.GetModels(Convert.ToInt32(cbxTipoVehiculo.SelectedValue), Convert.ToInt32(cbxBrands.SelectedValue));
                cbxModel.ValueMember = "Id";
                cbxModel.DisplayMember = "Nombre";
            }
            catch (Exception)
            {
            }
        }

        private void btnNuevoDetalle_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmaOrden_Click(object sender, EventArgs e)
        {

        }
    }
}
