using Maple2.Trigger.Enum;

namespace Maple2.Trigger._81000003_item {
    public static class _trigger_03 {
        public class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                // wait.xml 시작 타이머 설정 UI
                context.SetTimer(timerId: "59", seconds: 180, autoRemove: true, display: true, vOffset: -90);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{402})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 999, visible: true, enabled: true, minimapVisible: true);
                context.SetMesh(triggerIds: new []{501, 502, 503, 504, 505, 506, 507, 508, 509}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 180000)) {
                    return new State어나운스0(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어나운스0 : TriggerState {
            internal State어나운스0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "ME_Trigger_03_00");
                context.SetEventUI(arg1: 1, script: "$61000006_ME__TRIGGER_03__0$", duration: 4000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
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
                context.SetUserValue(triggerId: 999111, key: "gameStart", value: 1);
                context.SetTimer(timerId: "160", seconds: 160, autoRemove: false, display: true); // trigger_03.xml 시작 타이머 설정
                context.SetMesh(triggerIds: new []{501, 502, 503, 504, 505, 506, 507, 508, 509}, visible: false);
                context.SetInteractObject(interactIds: new []{10000224, 10000214}, state: 1);
                context.StartMiniGame(isShowResultUI: false, boxId: 499, round: 1, type: MiniGame.UserCrazyRunners);
                context.StartMiniGameRound(boxId: 499, round: 1);
                context.MoveUserToBox(boxId: 400, portalId: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "160")) {
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
                context.SetEventUI(arg1: 4, script: "$61000006_ME__TRIGGER_03__3$", duration: 5000, notBoxId: 401);
                context.AddBuff(boxIds: new []{401}, skillId: 70000132, level: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.EndMiniGameRound(winnerBoxId: 401, expRate: 0.133333333f, isGainLoserBonus: true, type: MiniGame.UserCrazyRunners);
                    context.EndMiniGame(winnerBoxId: 401, type: MiniGame.UserCrazyRunners);
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
                if (context.WaitTick(waitTick: 15000)) {
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
