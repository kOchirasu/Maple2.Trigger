namespace Maple2.Trigger._52020010_qd {
    public static class _main_c {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2007}, questIds: new []{60200055}, questStates: new byte[]{2})) {
                    return new StateActor_On(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2007}, questIds: new []{60200055}, questStates: new byte[]{3})) {
                    return new StateActor_On(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2007}, questIds: new []{60200060}, questStates: new byte[]{1})) {
                    return new StateActor_On(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2007}, questIds: new []{60200060}, questStates: new byte[]{2})) {
                    return new StateActor_Off(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2007}, questIds: new []{60200060}, questStates: new byte[]{3})) {
                    return new StateActor_Off(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActor_On : TriggerState {
            internal StateActor_On(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 8001, visible: true, initialSequence: "Event_01_A");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2007}, questIds: new []{60200060}, questStates: new byte[]{2})) {
                    return new StateActor_Off(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2007}, questIds: new []{60200060}, questStates: new byte[]{3})) {
                    return new StateActor_Off(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActor_Off : TriggerState {
            internal StateActor_Off(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 8001, visible: true, initialSequence: "Event_01_A");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2007}, questIds: new []{60200060}, questStates: new byte[]{2})) {
                    return new StateActor_Off(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2007}, questIds: new []{60200060}, questStates: new byte[]{2})) {
                    return new StateActor_Off(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
