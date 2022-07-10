namespace Maple2.Trigger._02000281_bf {
    public static class _heal08 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{708}, arg2: false);
                context.SetInteractObject(interactIds: new []{10000247}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000247}, arg2: 0)) {
                    return new StateSkill작동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill작동 : TriggerState {
            internal StateSkill작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{708}, arg2: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    context.SetSkill(triggerIds: new []{708}, arg2: false);
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "29", seconds: 29);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "29")) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
