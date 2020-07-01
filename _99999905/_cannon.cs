using System;

namespace Maple2.Trigger._99999905 {
    public static class _cannon {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {104})) {
                    context.State = new State대포등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대포등장 : TriggerState {
            internal State대포등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1001, 1002, 1003, 1004}, arg2: false);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: new int[] {104})) {
                    context.State = new State소환해제(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소환해제 : TriggerState {
            internal State소환해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {1001, 1002, 1003, 1004}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}