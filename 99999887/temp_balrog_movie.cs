namespace Maple2.Trigger._99999887 {
    public static class _temp_balrog_movie {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 200, visible: false, initialSequence: "Idle_A");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{100})) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CameraSelectPath(pathIds: new []{101, 102}, returnView: false);
            }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 10);
                context.SetActor(triggerId: 200, visible: true, initialSequence: "Down_A");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "1");
            }
        }
    }
}
