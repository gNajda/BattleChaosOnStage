using BattleChaosOnStage.EventBus.Events;
using System.Threading.Tasks;

namespace BattleChaosOnStage.EventBus.EventHandlers
{
    public interface IEventHandler<T> where T : IEvent
    {
        Task HandleAsync(T @event);
    }
}
