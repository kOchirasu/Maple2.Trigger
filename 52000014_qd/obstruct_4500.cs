namespace Maple2.Trigger._52000014_qd {
    public static class _obstruct_4500 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{4500}, arg2: false);
                context.SetEffect(triggerIds: new []{450}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new State발동Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State발동Prepare : TriggerState {
            internal State발동Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State발동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State발동 : TriggerState {
            internal State발동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 1);
                context.SetSkill(triggerIds: new []{4500}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State발동Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
