namespace Maple2.Trigger._63000076_cs {
    public static class _63000076_interact_1393 {
        public class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {109, 110, 111, 112, 113, 114}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001393}, arg2: 0)) {
                    return new State1393화난요정_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1393화난요정_01 : TriggerState {
            internal State1393화난요정_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {109, 110, 111, 112, 113, 114});
                context.CreateMonster(arg1: new[] {209, 210, 211, 212, 213, 214}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {209, 210, 211, 212, 213, 214})) {
                    return new State1393화난요정_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1393화난요정_02 : TriggerState {
            internal State1393화난요정_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State1393화난요정_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1393화난요정_03 : TriggerState {
            internal State1393화난요정_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {109, 110, 111, 112, 113, 114}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}