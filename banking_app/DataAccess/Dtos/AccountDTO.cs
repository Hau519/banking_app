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

    [Table("account")]
    public class AccountDTO: IDto
    {
        [Key]
        public int AccountNumber { get; set; }

        [required]
        public float balance { get; set; }

        [Required]
        [StringLength(64)]
        public string accountType { get; set; }

        [ForeignKey("UserId")]
        public UserDTO User { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime createdTime { get; set; }
        //public List<TransactionDTO> Transactions { get; set; }

        public AccountDTO(int AccountNumber, float balance, string type)
        {
            this.AccountNumber = AccountNumber;
            this.balance = balance;
            this.accountType = type;
        }

        public AccountDTO() { }
    }
}
