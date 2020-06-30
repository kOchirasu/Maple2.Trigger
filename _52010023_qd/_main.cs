using System;

namespace Maple2.Trigger._52010023_qd {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetEffect(arg1: new int[] {7001}, arg2: false);
                context.CreateMonster(arg1: new int[] {101});
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {701}, arg2: new int[] {40002500},
                    arg3: new byte[] {2})) {
                    context.State = new StateEvent_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_01 : TriggerState {
            internal StateEvent_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52010023_QD__MAIN__0$", arg4: 5);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2001");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 702, arg2: new int[] {101})) {
                    context.State = new StateNpc_out(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpc_out : TriggerState {
            internal StateNpc_out(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7001}, arg2: true);
                context.DestroyMonster(arg1: new int[] {101});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}