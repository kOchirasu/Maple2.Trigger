using System;

namespace Maple2.Trigger._61000010_me {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State입장(context);

        private class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3000, 3001, 3002, 3003}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "101")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 60000)) {
                    context.State = new State어나운스0(context);
                    return;
                }

                if (context.UserValue(key: "GameStart", value: 1)) {
                    context.State = new State어나운스0(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어나운스0 : TriggerState {
            internal State어나운스0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$61000010_ME__main__0$", arg3: new int[] {3000}, arg4: "0");
                context.SetAchievement(arg1: 101, arg2: "trigger", arg3: "ShanghaiRunnersStart");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
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
                context.SetTimer(arg1: "99", arg2: 190, arg3: false, arg4: true);
                context.SetMesh(arg1: new int[] {3000, 3001, 3002, 3003}, arg2: false);
                context.SetUserValue(triggerID: 999111, key: "gameStart", value: 1);
                context.StartMiniGame(boxId: 199, round: 1, gameName: "shanghairunner");
                context.StartMiniGameRound(boxId: 199, round: 1);
                context.MoveUserToBox(boxId: 101, portalId: true);
                context.SetAchievement(arg1: 101, arg2: "trigger", arg3: "dailyquest_start");
                context.GiveGuildExp(boxID: false, type: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "99")) {
                    context.State = new State경기종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State경기종료 : TriggerState {
            internal State경기종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 3, arg2: "$61000006_ME__TRIGGER_03__2$", arg3: new int[] {5000}, arg4: "401");
                context.SetEventUI(arg1: 6, arg2: "$61000006_ME__TRIGGER_03__3$", arg3: new int[] {5000}, arg4: "!401");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.EndMiniGameRound(winnerBoxId: 102, expRate: 0.25f, isGainLoserBonus: "true");
                    context.MiniGameGiveReward(winnerBoxId: 102, contentType: "MiniGameType2");
                    context.EndMiniGame(winnerBoxId: 102, gameName: "shanghairunner");
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
                if (context.WaitTick(waitTick: 3000)) {
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