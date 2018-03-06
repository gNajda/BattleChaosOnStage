using BattleChaosOnStage.EventBus.EventHandlers;
using BattleChaosOnStage.EventBus.Events;
using System;

namespace BattleChaosOnStage.EventBus.Bus
{
    public interface IEventBus
    {
        void Start();
        void Stop();
        void SubscribeHandler(IEventHandler<IEvent> eventHandler);
        void UnSubscribeHandler(IEventHandler<IEvent> eventHandler);
        void UnSubscribeHandler(Guid eventGandlerId);
    }
}
