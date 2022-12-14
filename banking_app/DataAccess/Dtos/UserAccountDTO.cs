using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_app.DataAccess.Dtos
{
    [Table("userAccount")]
    public class UserAccountDTO
    {
        [Key]
        public int Id { get; set; }

        [required]
        public int UserId { get; set; }

        [required]
        public int AccountNumber { get; set; }

        [ForeignKey("AccountNumber")]
        public AccountDTO Account { get; set; } = null!;

        [ForeignKey("UserID")]
        public UserDTO User { get; set; } = null!;

        public UserAccountDTO(int userID, int accountNumber)
        {
            this.UserId = userID;
            this.AccountNumber = accountNumber;
        }

    }
}
