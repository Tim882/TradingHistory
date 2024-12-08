namespace Messages
{
    public class OpenedPosition : IEvent
    {
        public string Id = new Guid().ToString();
        public string Ticker { get; set; }
    }
}
