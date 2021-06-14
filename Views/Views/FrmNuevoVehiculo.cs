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
    public partial class FrmNuevoVehiculo : Form
    {
        Controllers.VehicleController vehicleController = new Controllers.VehicleController();
        Controllers.ClientController clientController = new Controllers.ClientController();
        
        public FrmNuevoVehiculo()
        {
            InitializeComponent();
        }

        private void FrmNuevaOrden_Load(object sender, EventArgs e)
        {
            dgModels.DataSource = vehicleController.GetModels();

            cbxBrands.DataSource = vehicleController.getBuilderList();

            cbxTipoVehiculo.DataSource = vehicleController.GetVehicleTypes();
            cbxTipoVehiculo.ValueMember = "Id";
            cbxTipoVehiculo.DisplayMember = "Nombre";

            cbxColor.DataSource = vehicleController.GetColorList();
            cbxColor.ValueMember = "Id";
            cbxColor.DisplayMember = "Nombre";

            cbxMotor.DataSource = vehicleController.GetMotorList();
            cbxMotor.ValueMember = "Id";
            cbxMotor.DisplayMember = "Nombre";           
        }

        private void cbxBrands_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cbxTipoVehiculo_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevoDetalle_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmaOrden_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoModelo_Click(object sender, EventArgs e)
        {
            Controllers.Vehicle.ModelBuilder builder = (Controllers.Vehicle.ModelBuilder)cbxBrands.SelectedItem;
            Controllers.Vehicle.Model model = builder.BuildModel(Convert.ToInt32(cbxTipoVehiculo.SelectedValue), Convert.ToInt32(cbxMotor.SelectedValue), Convert.ToInt32(cbxColor.SelectedValue), txtModelName.Text);
            MessageBox.Show("Agregado Exitosamente: Marca:"+ cbxBrands.SelectedItem +"  "+model.getDescription());
            dgModels.DataSource = vehicleController.GetModels();
        }
    }
}
