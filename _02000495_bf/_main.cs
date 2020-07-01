namespace Maple2.Trigger._02000495_bf {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    context.State = new State레이드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레이드 : TriggerState {
            internal State레이드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2001}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State2초대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2초대기 : TriggerState {
            internal State2초대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State던전클리어(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전클리어 : TriggerState {
            internal State던전클리어(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State포털개방(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포털개방 : TriggerState {
            internal State포털개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
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