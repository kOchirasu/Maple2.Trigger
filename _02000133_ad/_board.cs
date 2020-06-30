using System;

namespace Maple2.Trigger._02000133_ad {
    public static class _board {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000346}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000346}, arg2: 0)) {
                    context.State = new State어나운스(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어나운스 : TriggerState {
            internal State어나운스(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000133_AD__BOARD__0$", arg3: new int[] {4000}, arg4: "101");
                context.SetTimer(arg1: "5", arg2: 5, arg3: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}