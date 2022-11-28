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
    [Table("Clients")]
    public class UserDTO: IDto
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(124)]
        public string FullName { get; set; }

        [Required]
        [StringLength(8)]
        public string SIN { get; set; }

        [Required]
        [StringLength(12)]
        public string PasswordHash { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime RegistrationDate { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(15)]
        public string PhoneNumber { get; set; }

        public List<AccountDTO> Accounts { get; set; }

        public UserDTO(string fullName, string passwordHash, string email, string phoneNumber, string sin)
        {
            FullName = fullName;
            PasswordHash = passwordHash;
            Email = email;
            PhoneNumber = phoneNumber;
            SIN = sin;
        }

        public UserDTO(string fullName, string passwordHash, string email, string phoneNumber, string sin, List<AccountDTO>? accounts = null)
        {
            this.FullName = fullName;
            this.PasswordHash = passwordHash;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.SIN =sin;
            this.Accounts = accounts ?? new List<AccountDTO>();
        }

        public int getId()
        {
            return this.ID;
        }
    }
}
