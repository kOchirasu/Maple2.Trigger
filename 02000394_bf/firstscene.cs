namespace Maple2.Trigger._02000394_bf {
    public static class _firstscene {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {100})) {
                    return new StateCameraCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraCinematic01 : TriggerState {
            internal StateCameraCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelect(arg1: 3000, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraCinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraCinematic02 : TriggerState {
            internal StateCameraCinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {3000, 3001, 3002, 3003}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.6f);
            }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}