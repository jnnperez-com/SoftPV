using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftPV.Entities
{
    public static class Credencial
    {
        private static string _Token;

        public static string Token
        {
            get
            {
                return _Token;
            }

            set
            {
                _Token = value;
            }
        }
    }
}
