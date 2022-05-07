using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace dependencyInjection
{
    public class SimpleClass
    {
        public int RandomNumber() {
            return new Random().Next(1, 10);
        }
    }
}
