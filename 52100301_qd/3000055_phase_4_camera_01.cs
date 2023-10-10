namespace Maple2.Trigger._52100301_qd {
    public static class _3000055_phase_4_camera_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 690000, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Phase_4_Camera_01") == 1) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 690000, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State리셋(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리셋 : TriggerState {
            internal State리셋(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Phase_4_Camera_01") == 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
