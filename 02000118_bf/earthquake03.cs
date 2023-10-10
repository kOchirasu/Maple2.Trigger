namespace Maple2.Trigger._02000118_bf {
    public static class _earthquake03 {
        public class StateLeverPull : TriggerState {
            internal StateLeverPull(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000292}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000292}, arg2: 0)) {
                    return new StateSkill동작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill동작 : TriggerState {
            internal StateSkill동작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{2009, 2010, 2011, 2012}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 10);
                context.SetSkill(triggerIds: new []{2009, 2010, 2011, 2012}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new StateLeverPull(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
