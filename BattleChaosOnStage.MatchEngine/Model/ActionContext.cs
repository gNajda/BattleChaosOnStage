using BattleChaosOnStage.MatchEngine.Action;
using BattleChaosOnStage.MatchEngine.Command;
using BattleChaosOnStage.MatchEngine.Pipeline;
using System.Collections.Generic;

namespace BattleChaosOnStage.MatchEngine.Model
{
    public class ActionContext
    {
        public string Message { get; set; }
        public ActionProcessStatus Status { get; set; }
        public ICommand Command { get; set; }
        public List<IGameAction> ActionList { get; set; }
    }
}