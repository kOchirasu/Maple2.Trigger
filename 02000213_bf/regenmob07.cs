namespace Maple2.Trigger._02000213_bf {
    public static class _regenmob07 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    return new State소환몹Appear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소환몹Appear : TriggerState {
            internal State소환몹Appear(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000259}, arg2: 1)) {
                    context.CreateMonster(arg1: new[] {1007}, arg2: false);
                    return new StateDeadCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeadCheck : TriggerState {
            internal StateDeadCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000259}, arg2: 0)) {
                    return new State소멸(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000259}, arg2: 2)) {
                    return new State소멸(context);
                }

                if (context.MonsterDead(arg1: new[] {1007})) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitTime : TriggerState {
            internal StateWaitTime(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 15);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State소환몹Appear(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State소멸 : TriggerState {
            internal State소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1007});
                context.SetTimer(arg1: "1", arg2: 1200);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }
    }
}