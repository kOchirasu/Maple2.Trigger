namespace Maple2.Trigger._02000351_bf {
    public static class _teleport_01 {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {705}, arg2: 1)) {
                    return new Statestart_sound(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {9000005}, arg2: true);
            }
        }

        private class Statestart_sound : TriggerState {
            internal Statestart_sound(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new Stateidle(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {9000005}, arg2: false);
            }
        }
    }
}