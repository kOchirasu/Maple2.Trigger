using Maple2.Trigger.Enum;

namespace Maple2.Trigger._61000010_me {
    public static class _main {
        public class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3000, 3001, 3002, 3003}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 60000)) {
                    return new State어나운스0(context);
                }

                if (context.GetUserValue(key: "GameStart") == 1) {
                    return new State어나운스0(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어나운스0 : TriggerState {
            internal State어나운스0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000010_ME__main__0$", duration: 3000, boxId: 0);
                context.SetAchievement(triggerId: 101, type: "trigger", code: "ShanghaiRunnersStart");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State어나운스1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어나운스1 : TriggerState {
            internal State어나운스1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCountUI(text: "$61000006_ME__TRIGGER_03__1$", stage: 0, count: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 190, autoRemove: false, display: true);
                context.SetMesh(triggerIds: new []{3000, 3001, 3002, 3003}, visible: false);
                context.SetUserValue(triggerId: 999111, key: "gameStart", value: 1);
                context.StartMiniGame(boxId: 199, round: 1, type: MiniGame.ShanghaiRunners);
                context.StartMiniGameRound(boxId: 199, round: 1);
                context.MoveUserToBox(boxId: 101, portalId: 1);
                context.SetAchievement(triggerId: 101, type: "trigger", code: "dailyquest_start");
                context.GiveGuildExp(boxId: 0, type: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State경기종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State경기종료 : TriggerState {
            internal State경기종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 3, script: "$61000006_ME__TRIGGER_03__2$", duration: 5000, boxId: 401);
                context.SetEventUI(arg1: 6, script: "$61000006_ME__TRIGGER_03__3$", duration: 5000, notBoxId: 401);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.EndMiniGameRound(winnerBoxId: 102, expRate: 0.25f, isGainLoserBonus: true);
                    context.MiniGameGiveReward(winnerBoxId: 102, contentType: "MiniGameType2");
                    context.EndMiniGame(winnerBoxId: 102, type: MiniGame.ShanghaiRunners);
                    return new State강제이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State강제이동 : TriggerState {
            internal State강제이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.MoveUser(mapId: 0, portalId: 0);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
