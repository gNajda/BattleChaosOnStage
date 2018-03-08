namespace BattleChaosOnStage.Core.Match
{
    public class MatchStage
    {
        public int Round { get; private set; }
        public MatchFaze Faze { get; private set; }

        public void ProgressStage()
        {
            if(Faze == MatchFaze.Support)
            {
                Faze = MatchFaze.Front;
                Round++;
                return;
            }

            Faze++;
        }
    }


}
