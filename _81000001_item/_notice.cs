using System;

namespace Maple2.Trigger._81000001_item {
    public static class _notice {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {102})) {
                    context.State = new State어나운스0(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어나운스0 : TriggerState {
            internal State어나운스0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "4", arg2: 15, arg3: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}