using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStart
{
    class DocksNotFoundException : Exception
    {
        public DocksNotFoundException(int i) : base("Не найден автомобиль по месту "+ i)
        { }
    }
}
