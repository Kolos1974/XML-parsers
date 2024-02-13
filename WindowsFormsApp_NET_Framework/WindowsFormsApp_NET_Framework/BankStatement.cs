using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_NET_Framework
{
    internal class BankStatement
    {
        public List<Row> BankStatementList { get; set; }

        public BankStatement()
        {
            BankStatementList = new List<Row>();
        }

    }
}
