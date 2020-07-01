using System;

namespace Maple2.Trigger._52000014_qd {
    public static class _move_6000 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new int[] {6000}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9600})) {
                    context.State = new State침몰01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State침몰01 : TriggerState {
            internal State침몰01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 17);
                context.SetBreakable(arg1: new int[] {6000}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}