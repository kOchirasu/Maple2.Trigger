using System;

namespace Maple2.Trigger._64000001_gd {
    public static class _wait {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시간표확인(context);

        private class State시간표확인 : TriggerState {
            internal State시간표확인(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 10, arg3: false);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 104, arg2: 6)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.TimeExpired(arg1: "10")) {
                    context.State = new State시간표확인(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "88", arg2: 1200, arg3: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "88")) {
                    context.State = new State시간표확인(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}