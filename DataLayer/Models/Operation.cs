using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeHistory.Enums;
using TradeHistory.Models;

namespace DataLayer.Models
{
    public class Operation: BaseEntity
    {
        public decimal Sum { get; set; }
        public DateTime Date { get; set; }
        public OperationType OperationType { get; set; }

        public long AccountId { get; set; }
        public Account Account { get; set; }
    }
}
