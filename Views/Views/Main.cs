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
    public partial class Main : Form
    {
        Controllers.VehicleController vehicleController = new Controllers.VehicleController();
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = vehicleController.GetList();
        }
    }
}
