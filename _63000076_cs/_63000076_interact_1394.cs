namespace Maple2.Trigger._63000076_cs {
    public static class _63000076_interact_1394 {
        public class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: true);
                context.CreateMonster(arg1: new[] {102}, arg2: true);
                context.CreateMonster(arg1: new[] {103}, arg2: true);
                context.CreateMonster(arg1: new[] {104}, arg2: true);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001394}, arg2: 0)) {
                    context.State = new State1394화난요정_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1394화난요정_01 : TriggerState {
            internal State1394화난요정_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101});
                context.DestroyMonster(arg1: new[] {102});
                context.DestroyMonster(arg1: new[] {103});
                context.DestroyMonster(arg1: new[] {104});
                context.CreateMonster(arg1: new[] {201}, arg2: true);
                context.CreateMonster(arg1: new[] {202}, arg2: true);
                context.CreateMonster(arg1: new[] {203}, arg2: true);
                context.CreateMonster(arg1: new[] {204}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {201, 202, 203, 204})) {
                    context.State = new State1394화난요정_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1394화난요정_02 : TriggerState {
            internal State1394화난요정_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State1394화난요정_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1394화난요정_03 : TriggerState {
            internal State1394화난요정_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: true);
                context.CreateMonster(arg1: new[] {102}, arg2: true);
                context.CreateMonster(arg1: new[] {103}, arg2: true);
                context.CreateMonster(arg1: new[] {104}, arg2: true);
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