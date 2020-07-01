namespace Maple2.Trigger._02010055_bf {
    public static class _bossspawn {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1001}, arg2: false);
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 8, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 9, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    context.State = new State룸체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State룸체크 : TriggerState {
            internal State룸체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.IsDungeonRoom()) {
                    context.State = new State난이도체크(context);
                    return;
                }

                if (!context.IsDungeonRoom()) {
                    context.State = new State퀘스트던전(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State난이도체크 : TriggerState {
            internal State난이도체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.GetDungeonLevel() == 2) {
                    context.State = new State레이드(context);
                    return;
                }

                if (context.GetDungeonLevel() == 3) {
                    context.State = new State카오스레이드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트던전 : TriggerState {
            internal State퀘스트던전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {101}, arg2: 70000118, arg3: 1, arg4: false, arg5: false);
                context.CreateMonster(arg1: new[] {2299}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2299})) {
                    context.State = new State종료딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레이드 : TriggerState {
            internal State레이드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2099}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2099})) {
                    context.State = new State종료딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카오스레이드 : TriggerState {
            internal State카오스레이드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2199}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2199})) {
                    context.State = new State종료딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료딜레이 : TriggerState {
            internal State종료딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                    context.SetPortal(arg1: 8, arg2: true, arg3: true, arg4: true);
                    context.SetPortal(arg1: 9, arg2: true, arg3: true, arg4: true);
                    context.DungeonClear();
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