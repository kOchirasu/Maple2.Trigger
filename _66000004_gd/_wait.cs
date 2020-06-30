using System;

namespace Maple2.Trigger._66000004_gd {
    public static class _wait {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "60", arg2: 30, arg3: true, arg4: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "104")) {
                    context.State = new State어나운스01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어나운스01 : TriggerState {
            internal State어나운스01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26500301, textID: 26500301, duration: 4500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State어나운스01(context);
                    return;
                }

                if (context.CountUsers(arg1: 104, arg2: 2)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "60")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 26500301);
            }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}