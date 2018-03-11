using System;
using System.Collections.Generic;

namespace BattleChaosOnStage.MatchEngine.Pipeline
{
    public class ActionPipelineBuilder : IActionPipelineBuilder
    {
        private List<Func<ActionContextDelegate, ActionContextDelegate>> _middlewares;

        public ActionPipelineBuilder()
        {
            _middlewares = new List<Func<ActionContextDelegate, ActionContextDelegate>>();
        }

        public void Use(Func<ActionContextDelegate, ActionContextDelegate> middleware)
        {
            _middlewares.Add(middleware);
        }

        public ActionContextDelegate Build()
        {
            ActionContextDelegate current = x => { };

            for (var i = _middlewares.Count - 1; i >= 0; i--)
            {
                current = AddNextDelegate(_middlewares[i], current);
            }

            return current;
        }

        private static ActionContextDelegate AddNextDelegate(Func<ActionContextDelegate, ActionContextDelegate> current, ActionContextDelegate next)
        {
            return current(next);
        }
    }
}
