using System;

namespace Maple2.Trigger._64000001_gd {
    public static class _ringout {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 12, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "105")) {
                    context.State = new State링아웃(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State링아웃 : TriggerState {
            internal State링아웃(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.MoveUser(arg1: 64000001, arg2: 2, arg3: 105);
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}