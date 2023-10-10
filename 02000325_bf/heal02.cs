namespace Maple2.Trigger._02000325_bf {
    public static class _heal02 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{702}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000740}, arg2: 0)) {
                    return new StateSkill작동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill작동 : TriggerState {
            internal StateSkill작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{702}, enabled: true);
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetEffect(triggerIds: new []{612}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    context.SetSkill(triggerIds: new []{702}, enabled: false);
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    context.SetInteractObject(interactIds: new []{10000740}, state: 2);
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
