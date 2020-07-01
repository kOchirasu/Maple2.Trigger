namespace Maple2.Trigger._61000006_me {
    public static class _trigger_03 {
        public class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {402})) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 999, arg2: true, arg3: true, arg4: true);
                context.SetMesh(arg1: new[] {501, 502, 503, 504, 505, 506, 507, 508, 509}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 60000)) {
                    context.State = new State어나운스0(context);
                    return;
                }

                if (context.GetUserCount(boxId: 402) == 20) {
                    context.State = new State어나운스0(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어나운스0 : TriggerState {
            internal State어나운스0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "ME_Trigger_03_00");
                context.SetEventUI(arg1: 1, arg2: "$61000006_ME__TRIGGER_03__0$", arg3: 7000, arg4: "0");
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
                context.ShowCountUI(text: "$61000006_ME__TRIGGER_03__1$", stage: 0, count: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
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
                context.SetTimer(arg1: "160", arg2: 160, arg3: false, arg4: true);
                context.SetMesh(arg1: new[] {501, 502, 503, 504, 505, 506, 507, 508, 509}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000224}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000214}, arg2: 1);
                context.SetAchievement(arg1: 402, arg2: "trigger", arg3: "dailyquest_start");
                context.GiveGuildExp(boxId: false, type: 2);
                context.StartMiniGame(boxId: 499, round: 1, gameName: "crazyrunner");
                context.StartMiniGameRound(boxId: 499, round: 1);
                context.MoveUserToBox(boxId: 400, portalId: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "160")) {
                    context.State = new State경기종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State경기종료 : TriggerState {
            internal State경기종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 401, arg2: "trigger", arg3: "crazyrunner_win");
                context.SetEventUI(arg1: 3, arg2: "$61000006_ME__TRIGGER_03__2$", arg3: 5000, arg4: "401");
                context.SetEventUI(arg1: 6, arg2: "$61000006_ME__TRIGGER_03__3$", arg3: 5000, arg4: "!401");
                context.AddBuff(arg1: new[] {401}, arg2: 70000019, arg3: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.EndMiniGameRound(winnerBoxId: 401, expRate: 0.25f, isGainLoserBonus: true);
                    context.MiniGameGiveReward(winnerBoxId: 401, contentType: "miniGame");
                    context.EndMiniGame(winnerBoxId: 401, gameName: "crazyrunner");
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