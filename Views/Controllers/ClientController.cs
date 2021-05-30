using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Controllers
{ 
    public class ClientController
    {
        public List<ClientViewModel> GetClientList()
        {
            List<Models.ClientViewModel> lstClient = new List<Models.ClientViewModel>();
            using (Models.EF.homesteadEntities db = new Models.EF.homesteadEntities())
            {
                lstClient = (from d in db.client
                             select new Models.ClientViewModel
                             {
                                 id = d.id,
                                 Nombre = d.name + " " + d.lastname
                             }).ToList();
            }
            return lstClient;

        }
    }
}
