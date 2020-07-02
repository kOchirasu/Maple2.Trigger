namespace Maple2.Trigger._52000067_qd {
    public static class _sub_event_02 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7200}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {756, 755}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$52000067_QD__SUB_EVENT_02__0$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52000067_QD__SUB_EVENT_02__1$", arg4: 3, arg5: 2);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}