using banking_app.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_app.DataAccess.Dtos
{
    public class TransactionDTO: IDto
    {
        public int TransactionID { get; set; }
      
        public DateTime dateTime { get; set; }

        public List<TransactionDTO> TransactionStatement { get; set; }
    }
}
