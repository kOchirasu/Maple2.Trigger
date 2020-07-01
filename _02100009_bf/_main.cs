namespace Maple2.Trigger._02100009_bf {
    public static class _main {
        public class State유저감지 : TriggerState {
            internal State유저감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    context.State = new State타이머설정(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State타이머설정 : TriggerState {
            internal State타이머설정(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 3, arg2: false, arg3: false, arg4: true);
                context.SetPortal(arg1: 4, arg2: true, arg3: true, arg4: true);
                context.SetTimer(arg1: "10000", arg2: 300, arg3: true, arg4: true, arg5: 0);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State끝 : TriggerState {
            internal State끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {100000001}) && context.MonsterDead(arg1: new[] {100000002})) {
                    context.State = new State성공(context);
                    return;
                }

                if (context.TimeExpired(arg1: "10000")) {
                    context.State = new State실패(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "10000");
            }
        }

        private class State성공 : TriggerState {
            internal State성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State성공_2(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEventUI(arg1: 1, arg2: "$02100009_BF__text__0$", arg3: 4000);
            }
        }

        private class State성공_2 : TriggerState {
            internal State성공_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5500)) {
                    context.DungeonClear();
                    context.State = new State성공_3(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetPortal(arg1: 3, arg2: true, arg3: true, arg4: true);
            }
        }

        private class State성공_3 : TriggerState {
            internal State성공_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {101}, arg2: 50000230, arg3: 1, arg4: false, arg5: false);
                context.DestroyMonster(arg1: new[] {-1});
                context.SetAchievement(arg1: 9900, arg2: "trigger", arg3: "Find02100009");
                context.SetEventUI(arg1: 7, arg2: "$02100009_BF__MAIN__1$", arg3: 2000, arg4: "0");
                context.SetAchievement(arg1: 9900, arg2: "trigger", arg3: "02100009_2");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.DungeonClear();
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State실패 : TriggerState {
            internal State실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {101}, arg2: 50000230, arg3: 1, arg4: false, arg5: false);
                context.SetEventUI(arg1: 5, arg2: "$02100009_BF__MAIN__0$", arg3: 2000, arg4: "0");
                context.DestroyMonster(arg1: new[] {-1});
                context.SetPortal(arg1: 3, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.DungeonFail();
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