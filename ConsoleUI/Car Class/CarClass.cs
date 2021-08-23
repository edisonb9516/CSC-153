using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Class
{
    public class CarClass
    {
        public string model;
        public string year;
        public int speed;

        public CarClass()
        {
            StandardMessage.Messages.Model();
            model = Console.ReadLine();

            StandardMessage.Messages.Year();
            year = Console.ReadLine();

            speed = 0;

       
        }
    }
}
