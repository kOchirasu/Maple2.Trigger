namespace Maple2.Trigger._65000003_bd {
    public static class _cannon {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {104})) {
                    return new State대포등장(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대포등장 : TriggerState {
            internal State대포등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1001, 1002, 1003, 1004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {104})) {
                    return new State소환해제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소환해제 : TriggerState {
            internal State소환해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1001, 1002, 1003, 1004}, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}