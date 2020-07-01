namespace Maple2.Trigger._63000076_cs {
    public static class _63000076_interact_1393 {
        public class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {109}, arg2: true);
                context.CreateMonster(arg1: new[] {110}, arg2: true);
                context.CreateMonster(arg1: new[] {111}, arg2: true);
                context.CreateMonster(arg1: new[] {112}, arg2: true);
                context.CreateMonster(arg1: new[] {113}, arg2: true);
                context.CreateMonster(arg1: new[] {114}, arg2: true);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001393}, arg2: 0)) {
                    context.State = new State1393화난요정_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1393화난요정_01 : TriggerState {
            internal State1393화난요정_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {109});
                context.DestroyMonster(arg1: new[] {110});
                context.DestroyMonster(arg1: new[] {111});
                context.DestroyMonster(arg1: new[] {112});
                context.DestroyMonster(arg1: new[] {113});
                context.DestroyMonster(arg1: new[] {114});
                context.CreateMonster(arg1: new[] {209}, arg2: true);
                context.CreateMonster(arg1: new[] {210}, arg2: true);
                context.CreateMonster(arg1: new[] {211}, arg2: true);
                context.CreateMonster(arg1: new[] {212}, arg2: true);
                context.CreateMonster(arg1: new[] {213}, arg2: true);
                context.CreateMonster(arg1: new[] {214}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {209, 210, 211, 212, 213, 214})) {
                    context.State = new State1393화난요정_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1393화난요정_02 : TriggerState {
            internal State1393화난요정_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State1393화난요정_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1393화난요정_03 : TriggerState {
            internal State1393화난요정_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {109}, arg2: false);
                context.CreateMonster(arg1: new[] {110}, arg2: false);
                context.CreateMonster(arg1: new[] {111}, arg2: false);
                context.CreateMonster(arg1: new[] {112}, arg2: false);
                context.CreateMonster(arg1: new[] {113}, arg2: false);
                context.CreateMonster(arg1: new[] {114}, arg2: false);
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