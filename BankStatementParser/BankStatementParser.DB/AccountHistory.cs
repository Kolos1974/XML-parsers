using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankStatementParser.DB
{
    public partial class AccountHistory
    {
        // public int Id { get; set; }

        public string? AccNumValue { get; set; }

        public string? AccNumName { get; set; }

        public string? AccAccountDate { get; set; }

        public string? AccTransType { get; set; }

        public string? AccCurrencyCode { get; set; }

        public string? AccTransId { get; set; }

        public string? AccCustName { get; set; }

        public string? AccCustBankAccount { get; set; }

        public string? AccCustBankAccountName { get; set; }

        public string? AccNotice1 { get; set; }

        public string? AccNotice2 { get; set; }

        public string? AccNotice3 { get; set; }

        public string? NtryAmount { get; set; }

        public string? AccValueDate { get; set; }

        public string? AccOriginCurrencyCode { get; set; }

        public string? AccOriginAmount { get; set; }



    }
}
