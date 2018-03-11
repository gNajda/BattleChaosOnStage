using BattleChaosOnStage.MatchEngine.Model;
using BattleChaosOnStage.MatchEngine.Pipeline;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xunit;

namespace BattleChaosOnStage.MatchEngine.Tests.Pipeline
{
    public class ActionPipelineBuilderTest
    {
        [Fact]
        public void Test()
        {
            Debug.WriteLine("Starting");
            var builder = new ActionPipelineBuilder();

            builder.Use(Test1);

            builder.Use(Test2);

            var pipeline = builder.Build();

            pipeline(new ActionContext());
        }

        private static ActionContextDelegate Test1(ActionContextDelegate next)
        {
            return context =>
            {
                Debug.WriteLine("1 Midleware");
                next(context);
            };
        }

        private static ActionContextDelegate Test2(ActionContextDelegate next)
        {
            return context =>
            {
                Debug.WriteLine("2 Midleware");
                next(context);
            };
        }
    }
}
