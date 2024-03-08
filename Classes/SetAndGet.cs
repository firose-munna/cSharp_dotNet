using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class SetAndGet
    {

        private int _number;

        public void setNumber(int number)
        {
            _number = number;
        }
        public int getNumber()
        {
            return _number;
        }
    }
}
