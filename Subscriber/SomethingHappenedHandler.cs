using System.Threading.Tasks;
using Messages;
using NServiceBus;
using NServiceBus.Logging;

namespace Subscriber
{
    internal class SomethingHappenedHandler : IHandleMessages<ISomethingHappened>
    {
        private static readonly ILog Log = LogManager.GetLogger<SomethingHappenedHandler>();

        public Task Handle(ISomethingHappened message, IMessageHandlerContext context)
        {
            Log.Info($"Received SomethingHappenedMessage. Time: {message.Time}, Observation: {message.Observation}.");
            return Task.CompletedTask;
        }
    }
}
