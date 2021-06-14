using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Vehicle
{

    public class Model
    {
        Type _type;
        Motor _motor;
        Color _color;

        public Model(Type type, Motor motor, Color color)
        {
            _type = type;
            _motor = motor;
            _color = color;
        }

        public string getDescription()
        {
            return "Tipo: "+_type.description+"  Motor: "+_motor.description+"  Color: "+_color.description;
        }
    }
}
