namespace Maple2.Trigger._63000076_cs {
    public static class _63000076_interact_1392 {
        public class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {108, 115}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001392}, arg2: 0)) {
                    return new State1392화난요정_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1392화난요정_01 : TriggerState {
            internal State1392화난요정_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {108, 115});
                context.CreateMonster(arg1: new[] {208, 215}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {208, 215})) {
                    return new State1392화난요정_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1392화난요정_02 : TriggerState {
            internal State1392화난요정_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State1392화난요정_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1392화난요정_03 : TriggerState {
            internal State1392화난요정_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {108, 115}, arg2: false);
            }

            public override TriggerState Execute() {
                return new State종료(context);
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}