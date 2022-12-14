using banking_app.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_app.DataAccess.Dtos
{

    [Table("Accounts")]
    public class AccountDTO: IDto
    {
        [Key]
        public int AccountNumber { get; set; }

        [Required]
        [StringLength(10)]
        public string AccountType { get; set; }

        [Required]
        public int UserID { get; set; }

        [required]
        public double Balance { get; set; }

        [ForeignKey("UserID")]
        public UserDTO User { get; set; } = null!;

       // public List<TransactionDTO> Transactions { get; set; }

        public AccountDTO(string AccountType, int UserID)
        {
            this.AccountType = AccountType;
            this.UserID = UserID;
        }

        public AccountDTO(int AccountNumber, string AccountType, int UserID, float Balance) 
        {
            this.AccountNumber = AccountNumber;
            this.AccountType = AccountType;
            this.UserID = UserID;
            this.Balance = Balance;
        }

       /* public AccountDTO(int accountNumber, string accountType, UserDTO user, float balance, List<TransactionDTO> Transactions)
        {
            this.AccountNumber = accountNumber;
            this.AccountType = accountType;
            this.UserID = user.getId();
            this.Balance = balance;
            this.Transactions = Transactions;
        }*/

       
    }
}
