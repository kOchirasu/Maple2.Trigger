namespace Maple2.Trigger._52000067_qd {
    public static class _sub_event_04 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {759}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 706) == 1) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 759, arg2: "Talk_A");
                context.SetConversation(arg1: 1, arg2: 759, script: "$52000067_QD__SUB_EVENT_04__0$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}