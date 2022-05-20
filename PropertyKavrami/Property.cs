using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyKavrami
{
    class Property
    {
        private int kilo;

        public int KILO
        {
            get
            {
                return kilo;
            }

            set
            {
                kilo = value;
            }
        }
    }
}
