using System;

namespace Maple2.Trigger._02000298_bf {
    public static class _mob_08 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {109})) {
                    context.CreateMonster(arg1: new int[] {1008}, arg2: false);
                    context.State = new State종료(context);
                    return;
                }

                if (context.UserDetected(arg1: new int[] {110})) {
                    context.CreateMonster(arg1: new int[] {1008}, arg2: false);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1800000", arg2: 1800000);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1800000")) {
                    // context.State = new State종료2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}