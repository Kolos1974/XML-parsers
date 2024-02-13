namespace WindowsFormsApp_NET_Framework
{
    public class Row
    {

        public string BankAccount { get; set; }

        public string BankName { get; set; }


        public override string ToString()
        {
            return $"BankAccount: {BankAccount} --- BankName: {BankName} ";
        }


    }
}