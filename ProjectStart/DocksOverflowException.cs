using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStart
{
    class DocksOverflowException : Exception
    {
        public DocksOverflowException() : base("На парковке нет свободных мест")
        { }
    }
}
