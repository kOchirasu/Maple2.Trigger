namespace Maple2.Trigger._02000390_bf {
    public static class _error {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.IsDungeonRoom()) {
                    return new StateIdle(context);
                }

                if (!context.IsDungeonRoom()) {
                    return new StateQuest_idle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Error") == 1) {
                    return new StateEnd(context);
                }

                if (context.UserDetected(boxIds: new []{702})) {
                    return new StateError(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateError : TriggerState {
            internal StateError(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveRandomUser(mapId: 02000390, portalId: 2, triggerId: 702, count: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateIdle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest_idle : TriggerState {
            internal StateQuest_idle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Error") == 1) {
                    return new StateEnd(context);
                }

                if (context.UserDetected(boxIds: new []{702})) {
                    return new StateQuest_error(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{50001518}, questStates: new byte[]{1})) {
                    return new StateEnd(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{50001517}, questStates: new byte[]{2})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest_error : TriggerState {
            internal StateQuest_error(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveRandomUser(mapId: 02000390, portalId: 2, triggerId: 702, count: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateQuest_idle(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{50001518}, questStates: new byte[]{1})) {
                    return new StateEnd(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{50001517}, questStates: new byte[]{2})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{1001, 1002}, visible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
