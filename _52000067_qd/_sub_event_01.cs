using System;

namespace Maple2.Trigger._52000067_qd {
    public static class _sub_event_01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {751}, arg2: true);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 703, arg2: 1)) {
                    context.State = new Stateready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 751, arg3: "$52000067_QD__SUB_EVENT_01__0$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 751, arg3: "$52000067_QD__SUB_EVENT_01__1$", arg4: 3, arg5: 3);
                context.SetConversation(arg1: 1, arg2: 751, arg3: "$52000067_QD__SUB_EVENT_01__2$", arg4: 3, arg5: 6);
                context.SetConversation(arg1: 1, arg2: 751, arg3: "$52000067_QD__SUB_EVENT_01__3$", arg4: 3, arg5: 9);
                context.SetConversation(arg1: 1, arg2: 751, arg3: "$52000067_QD__SUB_EVENT_01__4$", arg4: 3, arg5: 12);
                context.SetConversation(arg1: 1, arg2: 751, arg3: "$52000067_QD__SUB_EVENT_01__5$", arg4: 3, arg5: 15);
                context.SetConversation(arg1: 1, arg2: 751, arg3: "$52000067_QD__SUB_EVENT_01__6$", arg4: 3, arg5: 18);
                context.SetConversation(arg1: 1, arg2: 752, arg3: "$52000067_QD__SUB_EVENT_01__7$", arg4: 3, arg5: 19);
                context.SetConversation(arg1: 1, arg2: 753, arg3: "$52000067_QD__SUB_EVENT_01__8$", arg4: 3, arg5: 19);
                context.SetConversation(arg1: 1, arg2: 754, arg3: "$52000067_QD__SUB_EVENT_01__9$", arg4: 3, arg5: 20);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statestart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {757, 758, 761, 762}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 757, arg3: "$52000067_QD__SUB_EVENT_01__10$", arg4: 3, arg5: 2);
                context.SetConversation(arg1: 1, arg2: 758, arg3: "$52000067_QD__SUB_EVENT_01__11$", arg4: 3, arg5: 3);
                context.SetConversation(arg1: 1, arg2: 762, arg3: "$52000067_QD__SUB_EVENT_01__12$", arg4: 3, arg5: 2);
                context.SetConversation(arg1: 1, arg2: 761, arg3: "$52000067_QD__SUB_EVENT_01__13$", arg4: 3, arg5: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}