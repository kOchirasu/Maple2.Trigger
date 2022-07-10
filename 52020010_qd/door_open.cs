namespace Maple2.Trigger._52020010_qd {
    public static class _door_open {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5016, 5017}, visible: false);
                context.SetBreakable(triggerIds: new []{10001, 10002}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2005}, questIds: new []{60200050}, questStates: new byte[]{2})) {
                    return new StateCheck(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2005}, questIds: new []{60200050}, questStates: new byte[]{3})) {
                    return new StateCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheck : TriggerState {
            internal StateCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001275}, arg2: 0)) {
                    return new StateDoorOpen(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDoorOpen : TriggerState {
            internal StateDoorOpen(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5016, 5017}, visible: true);
                context.SetBreakable(triggerIds: new []{10001, 10002}, enabled: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
