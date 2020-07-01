namespace Maple2.Trigger._99999949 {
    public static class _04_camerareset {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9031})) {
                    context.State = new StateGuide(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGuide : TriggerState {
            internal StateGuide(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(message: "4번 영역에 들어가면 CameraReset 트리거가 발동됩니다.");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9030})) {
                    context.State = new StateCameraReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraReady : TriggerState {
            internal StateCameraReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(message: "SetOnetimeEffect 1초 후에 시작됩니다.");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCameraWalk01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk01 : TriggerState {
            internal StateCameraWalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(message: "600번 카메라 선택");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 603, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateCameraWalk03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk03 : TriggerState {
            internal StateCameraWalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(message: "602번 카메라 선택");
                context.CameraSelect(arg1: 604, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateCameraReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraReset : TriggerState {
            internal StateCameraReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(message: "모든 카메라 리셋");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 604, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(message: "5초 후에 트리거가 리셋됩니다. 4번 영역 밖으로 나가세요.");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}