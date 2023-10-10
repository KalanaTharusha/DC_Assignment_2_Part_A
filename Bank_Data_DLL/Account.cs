using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bank_Data_DLL
{
    public class Account
    {
        public int Id { get; set; }
        public int AccountNo { get; set; }
        public double Balance { get; set; }
        public int HolderId { get; set; }
        public User Holder { get; set; }
        [JsonIgnore]
        public ICollection<Transaction> Transactions { get; set; }
    }
}
