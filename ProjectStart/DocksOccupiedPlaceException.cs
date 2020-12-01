using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStart
{
    class DocksOccupiedPlaceException: Exception
    {
        public DocksOccupiedPlaceException() : base("Данное место занято")
        { }
    }
}
