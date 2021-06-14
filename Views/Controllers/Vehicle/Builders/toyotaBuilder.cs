using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Vehicle.Builders
{
    class toyotaBuilder : ModelBuilder
    {
        public toyotaBuilder()
        {
            using (Models.EF.homesteadEntities db = new Models.EF.homesteadEntities())
            {
                _description = (from d in db.brand
                                where d.id == 4
                                select d.name).SingleOrDefault();
            }
        }

        public override Color BuildColor(int id)
        {
            return new ColorOption(id);
        }

        public override Motor BuildMotor(int id)
        {
            return new MotorOption(id);
        }

        public override Type BuildType(int id)
        {
            return new TypeOption(id);
        }
    }
}
