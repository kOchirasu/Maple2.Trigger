namespace Maple2.Trigger._02000403_bf {
    public static class _event_05 {
        public class StateNone : TriggerState {
            internal StateNone(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{706})) {
                    return new StateIdle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{121, 154, 122, 156, 110})) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 706, type: "trigger", code: "Hauntedmansion");
                context.CreateMonster(spawnIds: new []{1110, 1111, 1112, 1113}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 1110, script: "$02000403_BF__EVENT_05__0$", arg4: 3, arg5: 4);
                context.SetConversation(type: 1, spawnId: 1111, script: "$02000403_BF__EVENT_05__1$", arg4: 3, arg5: 5);
                context.SetConversation(type: 1, spawnId: 1112, script: "$02000403_BF__EVENT_05__2$", arg4: 3, arg5: 1);
                context.SetConversation(type: 1, spawnId: 1113, script: "$02000403_BF__EVENT_05__3$", arg4: 3, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new StateExit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateExit : TriggerState {
            internal StateExit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1110, 1111, 1112, 1113});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
