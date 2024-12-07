using TradeHistory.Enums;

namespace TradeHistory.Models
{
    public class Deal: BaseEntity
    {
        public DateTime Date { get; set; }
        public decimal LotPrice { get; set; }
        public long NumOfLots { get; set; }
        public DealReason DealReason { get; set; }

        public long PositionId { get; set; }
        public Position Position { get; set; }
    }
}
