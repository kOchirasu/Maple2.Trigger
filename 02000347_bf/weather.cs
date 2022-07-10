namespace Maple2.Trigger._02000347_bf {
    public static class _weather {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{600}, visible: false);
                context.SetInteractObject(interactIds: new []{10000804}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{60002})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000804}, state: 1);
                context.SetEffect(triggerIds: new []{600}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new State비내림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비내림 : TriggerState {
            internal State비내림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{600}, visible: true);
                context.SetTimer(timerId: "30", seconds: 30);
                context.SetEventUI(arg1: 1, script: "$02000347_BF__MAIN1__4$", duration: 2000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "30")) {
                    context.SetEventUI(arg1: 1, script: "$02000347_BF__MAIN1__3$", duration: 2000, boxId: 0);
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    context.SetEffect(triggerIds: new []{600}, visible: false);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
