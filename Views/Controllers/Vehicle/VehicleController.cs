using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Controllers
{
    public class VehicleController
    {
        public List<ModelViewModel> GetModels() {
            List<Models.ModelViewModel> lstModels = new List<Models.ModelViewModel>();
            using (Models.EF.homesteadEntities db = new Models.EF.homesteadEntities())
            {
                lstModels = (from a in db.vehicle_model 
                             join b in db.color on a.id_color equals b.id
                             join c in db.vehicle_type on a.id_vehicle_type equals c.id
                             join d in db.vehicle_motor on a.id_motor equals d.id 
                             join e in db.brand on a.id_brand  equals e.id
                             select new Models.ModelViewModel
                             {
                                 id = a.id,
                                 brand = e.name,
                                 name = a.name,
                                 tipo = c.name,
                                 color = b.name,
                                 motor = d.name,
                                 fecha_creo = a.created_at
                             }).ToList();
            }
            return lstModels;
        }

        public List<VehicleTypeViewModel> GetVehicleTypes()
        {
            List<Models.VehicleTypeViewModel> lstVehicleType = new List<Models.VehicleTypeViewModel>();

            using (Models.EF.homesteadEntities db = new Models.EF.homesteadEntities())
            {
                lstVehicleType = (from d in db.vehicle_type
                            select new Models.VehicleTypeViewModel
                            {
                                id = d.id,
                                Nombre = d.name
                            }).ToList();
            }
            return lstVehicleType;
        }

        public List<ColorViewModel> GetColorList()
        {
            List<Models.ColorViewModel> lstColor = new List<Models.ColorViewModel>();

            using (Models.EF.homesteadEntities db = new Models.EF.homesteadEntities())
            {
                lstColor = (from d in db.color
                                  select new Models.ColorViewModel
                                  {
                                      id = d.id,
                                      Nombre = d.name
                                  }).ToList();
            }
            return lstColor;
        }
        
        public List<MotorViewModel> GetMotorList()
        {
            List<Models.MotorViewModel> lstMotor = new List<Models.MotorViewModel>();

            using (Models.EF.homesteadEntities db = new Models.EF.homesteadEntities())
            {
                lstMotor = (from d in db.vehicle_motor
                            select new Models.MotorViewModel
                            {
                                id = d.id,
                                Nombre = d.name
                            }).ToList();
            }
            return lstMotor;
        }

        public List<Vehicle.ModelBuilder> getBuilderList()
        {
            List < Vehicle.ModelBuilder >  _list;

            _list = new List<Vehicle.ModelBuilder>();
            _list.Add(new Vehicle.Builders.bmwBuilder());
            _list.Add(new Vehicle.Builders.ferrariBuilder());
            _list.Add(new Vehicle.Builders.teslaBuilder());
            _list.Add(new Vehicle.Builders.toyotaBuilder());
            return _list;
        }
    }
}
