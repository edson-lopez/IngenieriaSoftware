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
        public IEnumerable<Models.VehicleModel> GetList() {
            using (Models.EF.homesteadEntities db = new Models.EF.homesteadEntities())
            {
                IEnumerable<Models.VehicleModel> lst = (from d in db.brand
                                                       select new Models.VehicleModel {
                                                        id =d.id,
                                                        name = d.name
                                                       }).ToList();
                return lst;
            }
        }
    }
}
