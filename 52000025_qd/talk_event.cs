namespace Maple2.Trigger._52000025_qd {
    public static class _talk_event {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{702})) {
                    return new StateTalk_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_01 : TriggerState {
            internal StateTalk_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 201, script: "$52000025_QD__TALK_EVENT__0$", arg4: 3, arg5: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateTalk_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_02 : TriggerState {
            internal StateTalk_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 201, script: "$52000025_QD__TALK_EVENT__1$", arg4: 2, arg5: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
