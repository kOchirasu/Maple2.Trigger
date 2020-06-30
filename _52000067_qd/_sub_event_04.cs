using System;

namespace Maple2.Trigger._52000067_qd {
    public static class _sub_event_04 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {759}, arg2: true);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 706, arg2: 1)) {
                    context.State = new Stateready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 759, arg2: "Talk_A");
                context.SetConversation(arg1: 1, arg2: 759, arg3: "$52000067_QD__SUB_EVENT_04__0$", arg4: 3, arg5: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}