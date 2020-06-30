using System;

namespace Maple2.Trigger._99999905 {
    public static class _seagull_02 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2002}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "10502")) {
                    context.State = new State이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동 : TriggerState {
            internal State이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.MoveNpc(arg1: 2002, arg2: "MS2PatrolData_2002");                     // context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}