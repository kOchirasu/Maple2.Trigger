namespace Maple2.Trigger._63000076_cs {
    public static class _63000076_interact_1395 {
        public class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {116, 117}, arg2: false);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001395}, arg2: 0)) {
                    context.State = new State1395화난요정_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1395화난요정_01 : TriggerState {
            internal State1395화난요정_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {116, 117});
                context.CreateMonster(arg1: new[] {216, 217}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {216, 217})) {
                    context.State = new State1395화난요정_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1395화난요정_02 : TriggerState {
            internal State1395화난요정_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State1395화난요정_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1395화난요정_03 : TriggerState {
            internal State1395화난요정_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {116, 117}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}