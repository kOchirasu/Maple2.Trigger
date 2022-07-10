namespace Maple2.Trigger._51000001_dg {
    public static class _endgame {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{144})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, script: "0,0");
                context.CameraSelect(triggerId: 344, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.PlaySystemSoundInBox(sound: "System_Ending_Popup_01");
                    context.ArcadeSpringFarmEndGame();
                    return new State진짜끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진짜끝 : TriggerState {
            internal State진짜끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "10", seconds: 10, clearAtZero: false, display: true, arg5: -30, arg6: "TR");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "10")) {
                    return new State퇴장(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퇴장 : TriggerState {
            internal State퇴장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 0, portalId: 0);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
