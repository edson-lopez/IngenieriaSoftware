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
        public List<VehicleViewModel> GetModels(int id_type, int id_brand) {
            List<Models.VehicleViewModel> lstModels = new List<Models.VehicleViewModel>();
            using (Models.EF.homesteadEntities db = new Models.EF.homesteadEntities())
            {
                lstModels = (from d in db.vehicle_model
                             where d.id_vehicle_type == id_type
                             where d.id_brand == id_brand
                             select new Models.VehicleViewModel
                             {
                                 id = d.id,
                                 Nombre = d.name
                             }).ToList();
            }
            return lstModels;

        }

        public List<BrandViewModel> GetBrands()
        {
            List<Models.BrandViewModel> lstBrand = new List<Models.BrandViewModel>();

            using (Models.EF.homesteadEntities db = new Models.EF.homesteadEntities())
            {
                lstBrand = (from d in db.brand
                            select new Models.BrandViewModel
                            {
                                id = d.id,
                                Nombre = d.name
                            }).ToList();
            }
            return lstBrand;
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
    }
}
