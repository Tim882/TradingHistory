using Messages;
using Microsoft.AspNetCore.Components;
using NServiceBus;

namespace TradeHistory
{
    public class OpenedPositionHandler : IHandleMessages<OpenedPosition>
    {
        public Task Handle(OpenedPosition message, IMessageHandlerContext context)
        {
            Console.WriteLine(message.Ticker);

            return Task.CompletedTask;
        }
    }
}
