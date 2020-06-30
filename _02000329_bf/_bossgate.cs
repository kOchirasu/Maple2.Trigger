using System;

namespace Maple2.Trigger._02000329_bf {
    public static class _bossgate {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "710")) {
                    context.State = new State사다리가이드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State사다리가이드 : TriggerState {
            internal State사다리가이드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 106, textID: 20000060);
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 106);
            }
        }
    }
}