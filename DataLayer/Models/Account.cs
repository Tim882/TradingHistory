using DataLayer.Models;

namespace TradeHistory.Models
{
    public class Account: BaseEntity
    {
        public string Name { get; set; }
        public List<Operation> Operations { get; set; }
        public List<Position> Positions { get; set; }
    }
}
