namespace Maple2.Trigger._61000004_me {
    public static class _trigger_01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.SetMesh(arg1: new[] {301, 302, 303}, arg2: true, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {3101, 3102, 3201, 3202, 3301, 3302, 3401, 3402, 3403, 3404}, arg2: false, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new[] {71011, 71012, 71021, 71022, 72011, 72021, 73011, 73021, 73022, 73023}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    context.State = new State랜덤블록01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State랜덤블록01 : TriggerState {
            internal State랜덤블록01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.SetMesh(arg1: new[] {3101}, arg2: true, arg3: 0, arg4: 0);
                    context.SetEffect(arg1: new[] {71011, 71012}, arg2: true);
                    context.State = new State랜덤블록02(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.SetMesh(arg1: new[] {3102}, arg2: true, arg3: 0, arg4: 0);
                    context.SetEffect(arg1: new[] {71021, 71022}, arg2: true);
                    context.State = new State랜덤블록02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State랜덤블록02 : TriggerState {
            internal State랜덤블록02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.SetMesh(arg1: new[] {3201}, arg2: true, arg3: 0, arg4: 0);
                    context.SetEffect(arg1: new[] {72011}, arg2: true);
                    context.State = new State랜덤블록03(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.SetMesh(arg1: new[] {3202}, arg2: true, arg3: 0, arg4: 0);
                    context.SetEffect(arg1: new[] {72021}, arg2: true);
                    context.State = new State랜덤블록03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State랜덤블록03 : TriggerState {
            internal State랜덤블록03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.SetMesh(arg1: new[] {3301}, arg2: true, arg3: 0, arg4: 0);
                    context.SetEffect(arg1: new[] {73011}, arg2: true);
                    context.State = new State랜덤블록04(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.SetMesh(arg1: new[] {3302}, arg2: true, arg3: 0, arg4: 0);
                    context.SetEffect(arg1: new[] {73021, 73022, 73023}, arg2: true);
                    context.State = new State랜덤블록04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State랜덤블록04 : TriggerState {
            internal State랜덤블록04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.SetMesh(arg1: new[] {3401, 3402}, arg2: true, arg3: 0, arg4: 0);
                    context.State = new State시작조건체크(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.SetMesh(arg1: new[] {3403, 3404}, arg2: true, arg3: 0, arg4: 0);
                    context.State = new State시작조건체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작조건체크 : TriggerState {
            internal State시작조건체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 60000)) {
                    context.State = new State어나운스0(context);
                    return;
                }

                if (context.GetUserCount(boxId: 101) == 20) {
                    context.State = new State어나운스0(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어나운스0 : TriggerState {
            internal State어나운스0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "ME_Trigger_01_00");
                context.SetEventUI(arg1: 1, arg2: "$61000004_ME__TRIGGER_01__0$", arg3: 7000, arg4: "0");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State어나운스1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어나운스1 : TriggerState {
            internal State어나운스1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCountUI(text: "$61000004_ME__TRIGGER_01__1$", stage: 0, count: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5500)) {
                    context.SetMesh(arg1: new[] {301, 302, 303}, arg2: false, arg3: 12, arg4: 0);
                    context.SetAchievement(arg1: 101, arg2: "trigger", arg3: "dailyquest_start");
                    context.GiveGuildExp(boxId: false, type: 2);
                    context.StartMiniGame(boxId: 105, round: 1, gameName: "escape");
                    context.StartMiniGameRound(boxId: 105, round: 1);
                    context.MoveUserToBox(boxId: 101, portalId: true);
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 999111, key: "gameStart", value: 1);
                context.SetTimer(arg1: "180", arg2: 180, arg3: false, arg4: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "180")) {
                    context.State = new State경기종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State경기종료 : TriggerState {
            internal State경기종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 102, arg2: "trigger", arg3: "escape_win");
                context.SetEventUI(arg1: 3, arg2: "$61000004_ME__TRIGGER_01__2$", arg3: 5000, arg4: "102");
                context.SetEventUI(arg1: 6, arg2: "$61000004_ME__TRIGGER_01__3$", arg3: 5000, arg4: "!102");
                context.AddBuff(arg1: new[] {102}, arg2: 70000019, arg3: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.EndMiniGameRound(winnerBoxId: 102, expRate: 0.25f, isGainLoserBonus: true);
                    context.MiniGameGiveReward(winnerBoxId: 102, contentType: "miniGame");
                    context.EndMiniGame(winnerBoxId: 102, gameName: "escape");
                    context.State = new State강제이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State강제이동 : TriggerState {
            internal State강제이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    context.MoveUser(arg1: 0, arg2: 0);
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