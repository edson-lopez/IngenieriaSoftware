using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Vehicle
{
    public abstract class ModelBuilder
    {
        protected string _description;
        public abstract Type BuildType(int id);

        public abstract Motor BuildMotor(int id);

        public abstract Color BuildColor(int id);

        public override string ToString()
        {
            return _description;
        }
        public Model BuildModel(int _type, int _motor, int _color, string _name)
        {
            Type type = BuildType(_type);
            Motor motor = BuildMotor(_motor);
            Color color = BuildColor(_color);

            saveModel(_type, _motor, _color, _name, _description);

            return new Model(type, motor, color);
        }

        public void saveModel(int _type, int _motor, int _color, string _name, string _brand)
        {
            int id_brand;

            var now = DateTime.Now;
            var date = new DateTime(now.Year, now.Month, now.Day,
                    now.Hour, now.Minute, now.Second);


            using (Models.EF.homesteadEntities db = new Models.EF.homesteadEntities())
            {

                id_brand = (from d in db.brand
                            where d.name == _brand
                            select d.id).SingleOrDefault();

                db.vehicle_model.Add(new Models.EF.vehicle_model { 
                    id_brand = id_brand,
                    id_vehicle_type = _type,
                    id_motor = _motor,
                    id_color = _color,
                    name = _name ,
                    created_at = date
                });

                db.SaveChanges();
            }
        }
    }
}
