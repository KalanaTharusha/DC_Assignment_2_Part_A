using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Data_DLL
{
    public class Transaction
    {
        public int Id { get; set; }
        public TransactionType Type { get; set; }
        public double Amount { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }

        public enum TransactionType
        {
            Deposit,
            Withdrawal
        }
    }
}
