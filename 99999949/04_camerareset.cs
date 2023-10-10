namespace Maple2.Trigger._99999949 {
    public static class _04_camerareset {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9031})) {
                    return new StateGuide(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuide : TriggerState {
            internal StateGuide(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(message: "4번 영역에 들어가면 CameraReset 트리거가 발동됩니다.");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9030})) {
                    return new StateCameraReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraReady : TriggerState {
            internal StateCameraReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(message: "SetOnetimeEffect 1초 후에 시작됩니다.");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraWalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk01 : TriggerState {
            internal StateCameraWalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(message: "600번 카메라 선택");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 603, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCameraWalk03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk03 : TriggerState {
            internal StateCameraWalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(message: "602번 카메라 선택");
                context.CameraSelect(triggerId: 604, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCameraReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraReset : TriggerState {
            internal StateCameraReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(message: "모든 카메라 리셋");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 604, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(message: "5초 후에 트리거가 리셋됩니다. 4번 영역 밖으로 나가세요.");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
