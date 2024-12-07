namespace TradeHistory.Models
{
    public class Position: BaseEntity
    {
        public string Comment { get; set; }

        public long AccountId { get; set; }
        public Account Account { get; set; }

        public long StrategyId { get; set; }
        public Strategy Strategy { get; set; }

        public long InstrumentId { get; set; }
        public Instrument Instrument { get; set; }

        public List<Deal> Deals { get; set; }
    }
}
