namespace Maple2.Trigger._80000012_bonus {
    public static class _camera_restore {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 8001, arg2: true);
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new Statecamera_restore(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statecamera_restore : TriggerState {
            internal Statecamera_restore(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 8001, arg2: true);
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new Stateidle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}