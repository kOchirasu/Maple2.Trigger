namespace Maple2.Trigger._99999886 {
    public static class _temp_balrog_movie {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 200, arg2: false, arg3: "Idle_A");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {100})) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CameraSelectPath(arg1: new[] {101, 102}, arg2: false);
            }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 7);
                context.SetActor(arg1: 200, arg2: true, arg3: "Skill_Chain_Ready_A");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }
    }
}