using System;

namespace BattleChaosOnStage.MatchEngine.Pipeline
{
    public interface IActionPipelineBuilder
    {
        ActionContextDelegate Build();
        void Use(Func<ActionContextDelegate, ActionContextDelegate> middleware);
    }
}
