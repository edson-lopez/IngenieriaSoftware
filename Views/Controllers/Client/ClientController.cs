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
                                 Nombre = d.name,
                                 Apellido = d.lastname,
                                 Telefono = d.phone,
                                 Email = d.email
                             }).ToList();
            }
            return lstClient;

        }

        public void saveClient(string _name, string _lastname, string _phone, string _email)
        {
            using (Models.EF.homesteadEntities db = new Models.EF.homesteadEntities())
            {
                db.client.Add(new Models.EF.client
                {
                    name = _name,
                    lastname = _lastname,
                    phone = _phone,
                    email = _email
                });

                db.SaveChanges();
            }
        }
    }
}
