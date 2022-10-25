using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JintPocConsoleApp
{
    internal enum SecurityType
    {
        House,
        Flat
    }

    internal class SourceModel
    {
        public Decimal LoanAmount { get; set; }
        public string securityPostcode { get; set; }
        public SecurityType SecurityType { get; set; }
    }
}
