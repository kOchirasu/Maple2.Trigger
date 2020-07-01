using System;

namespace Maple2.Trigger._81000003_item {
    public static class _trigger_03 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State입장(context);

        private class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "59", arg2: 180, arg3: true, arg4: true, arg5: -90,
                    desc: "wait.xml 시작 타이머 설정 UI");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {402})) {
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
                context.SetMesh(arg1: new int[] {501, 502, 503, 504, 505, 506, 507, 508, 509}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 180000)) {
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
                context.SetEventUI(arg1: 1, arg2: "$61000006_ME__TRIGGER_03__0$", arg3: new int[] {4000}, arg4: "0");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
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
                context.SetUserValue(triggerID: 999111, key: "gameStart", value: 1);
                context.SetTimer(arg1: "160", arg2: 160, arg3: false, arg4: true, desc: "trigger_03.xml 시작 타이머 설정");
                context.SetMesh(arg1: new int[] {501, 502, 503, 504, 505, 506, 507, 508, 509}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000224}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {10000214}, arg2: 1);
                context.StartMiniGame(isShowResultUI: "false", boxId: 499, round: 1,
                    gameName: "UserMassive_Crazyrunner");
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
                context.SetEventUI(arg1: 3, arg2: "$61000006_ME__TRIGGER_03__2$", arg3: new int[] {5000}, arg4: "401");
                context.SetEventUI(arg1: 4, arg2: "$61000006_ME__TRIGGER_03__3$", arg3: new int[] {5000}, arg4: "!401");
                context.AddBuff(arg1: new int[] {401}, arg2: 70000132, arg3: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.EndMiniGameRound(winnerBoxId: 401, expRate: 0.133333333f, isGainLoserBonus: "true",
                        gameName: "UserMassive_Crazyrunner");
                    context.EndMiniGame(winnerBoxId: 401, gameName: "UserMassive_Crazyrunner");
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