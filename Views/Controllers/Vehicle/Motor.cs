using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Vehicle
{
    public abstract class Motor
    {
        protected string _description;
        public string description { get { return _description; } }

    }

    public class MotorOption : Motor
    {
        public MotorOption(int i)
        {
            using (Models.EF.homesteadEntities db = new Models.EF.homesteadEntities())
            {
                _description = (from d in db.vehicle_motor
                                where d.id == i
                                select d.name).SingleOrDefault();
            }
        }
    }
}
