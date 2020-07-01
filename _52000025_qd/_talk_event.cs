namespace Maple2.Trigger._52000025_qd {
    public static class _talk_event {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {702})) {
                    context.State = new Statetalk_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statetalk_01 : TriggerState {
            internal Statetalk_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 201, arg3: "$52000025_QD__TALK_EVENT__0$", arg4: 3, arg5: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statetalk_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statetalk_02 : TriggerState {
            internal Statetalk_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 201, arg3: "$52000025_QD__TALK_EVENT__1$", arg4: 2, arg5: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}