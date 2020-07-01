namespace Maple2.Trigger._02100000_bf {
    public static class _timer {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 19, arg2: false, arg3: false, arg4: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {106})) {
                    context.State = new State타이머시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State타이머시작 : TriggerState {
            internal State타이머시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10000", arg2: 360, arg3: true, arg4: true, arg5: 0);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State유저감지_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저감지_2 : TriggerState {
            internal State유저감지_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {104})) {
                    context.State = new State몬스터등장_보스(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터등장_보스 : TriggerState {
            internal State몬스터등장_보스(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {82001}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State종료선택(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료선택 : TriggerState {
            internal State종료선택(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {82001})) {
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

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {-1});
                context.SetAchievement(arg1: 9900, arg2: "trigger", arg3: "Find02100000");
                context.SetEventUI(arg1: 7, arg2: "$02100000_BF__TIMER__1$", arg3: 2000, arg4: "0");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
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
                context.SetEventUI(arg1: 5, arg2: "$02100000_BF__TIMER__0$", arg3: 2000, arg4: "0");
                context.DestroyMonster(arg1: new[] {-1});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.DungeonFail();
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 19, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 5, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}