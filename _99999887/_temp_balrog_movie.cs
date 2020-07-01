namespace Maple2.Trigger._99999887 {
    public static class _temp_balrog_movie {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 200, arg2: false, arg3: "Idle_A");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {100})) {
                    return new State연출시작(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CameraSelectPath(arg1: new[] {101, 102}, arg2: false);
            }
        }

        private class State연출시작 : TriggerState {
            internal State연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 10);
                context.SetActor(arg1: 200, arg2: true, arg3: "Down_A");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State시작대기중(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }
    }
}