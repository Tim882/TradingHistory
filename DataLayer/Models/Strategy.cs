using TradeHistory.Enums;

namespace TradeHistory.Models
{
    public class Strategy: BaseEntity
    {
        public string Description { get; set; }
        public StrategyType Type { get; set; }

        public List<Position> Positions { get; set; }
    }
}
