namespace Maple2.Trigger._02000074_in {
    public static class _main {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{4000}, visible: false);
                context.DestroyMonster(spawnIds: new []{101, 102});
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001592}, questStates: new byte[]{3})) {
                    return new StateEnd(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001592}, questStates: new byte[]{2})) {
                    return new StateSpawnMessage(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001592}, questStates: new byte[]{1})) {
                    return new StateSpawnMessage(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001591}, questStates: new byte[]{3})) {
                    return new StateSpawnMessage(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001591}, questStates: new byte[]{2})) {
                    return new StateSpawnMessage(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001589}, questStates: new byte[]{2})) {
                    return new State케이틀린Spawn(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001589}, questStates: new byte[]{1})) {
                    return new State케이틀린Spawn(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001588}, questStates: new byte[]{3})) {
                    return new State케이틀린Spawn(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001588}, questStates: new byte[]{2})) {
                    return new State케이틀린Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린Spawn : TriggerState {
            internal State케이틀린Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{9000})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSpawnMessage : TriggerState {
            internal StateSpawnMessage(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
                context.SetMesh(triggerIds: new []{4000}, visible: true);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{9000})) {
                    return new StateStart(context);
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
