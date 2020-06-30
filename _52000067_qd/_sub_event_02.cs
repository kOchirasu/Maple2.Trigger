using System;

namespace Maple2.Trigger._52000067_qd {
    public static class _sub_event_02 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7200}, arg2: false);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 704, arg2: 1)) {
                    context.State = new Stateidle_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateidle_02 : TriggerState {
            internal Stateidle_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {756, 755}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$52000067_QD__SUB_EVENT_02__0$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52000067_QD__SUB_EVENT_02__1$", arg4: 3, arg5: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Stateready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}