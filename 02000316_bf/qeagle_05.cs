namespace Maple2.Trigger._02000316_bf {
    public static class _qeagle_05 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000573}, state: 1);
                context.SetActor(triggerId: 909, visible: false, initialSequence: "Attack_Idle_A");
                context.SetEffect(triggerIds: new []{910}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000573}, arg2: 0)) {
                    return new StateInteractObject(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateInteractObject : TriggerState {
            internal StateInteractObject(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 909, visible: true, initialSequence: "Attack_Idle_A");
                context.SetEffect(triggerIds: new []{910}, visible: true);
                context.SetTimer(timerId: "1", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State그리폰Remove(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetActor(triggerId: 909, visible: false, initialSequence: "Attack_Idle_A");
                context.SetEffect(triggerIds: new []{910}, visible: false);
            }
        }

        private class State그리폰Remove : TriggerState {
            internal State그리폰Remove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 600);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
