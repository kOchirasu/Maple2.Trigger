namespace Maple2.Trigger._52000067_qd {
    public static class _sub_event_02 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7200}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 704) == 1) {
                    return new StateIdle_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIdle_02 : TriggerState {
            internal StateIdle_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{756, 755}, arg2: true);
                context.SetConversation(type: 1, spawnId: 102, script: "$52000067_QD__SUB_EVENT_02__0$", arg4: 3, arg5: 0);
                context.SetConversation(type: 1, spawnId: 101, script: "$52000067_QD__SUB_EVENT_02__1$", arg4: 3, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
