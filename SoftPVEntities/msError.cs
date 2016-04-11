using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftPV.Entities
{
    public static class msError
    {
        private static string _ErrorMessage;

        public static string ErrorMessage
        {
            get
            {
                return _ErrorMessage;
            }

            set
            {
                _ErrorMessage = value;
            }
        }
    }
}
