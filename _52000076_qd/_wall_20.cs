using System;

namespace Maple2.Trigger._52000076_qd {
    public static class _wall_20 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State벽재생(context);

        private class State벽재생 : TriggerState {
            internal State벽재생(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {
                        3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216,
                        3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225
                    }, arg2: true, arg3: 0, arg4: 10, arg5: 3f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "120")) {
                    context.State = new State벽삭제(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벽삭제 : TriggerState {
            internal State벽삭제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {
                        3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216,
                        3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225
                    }, arg2: false, arg3: 0, arg4: 10, arg5: 3f);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: "120")) {
                    context.State = new State딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State딜레이 : TriggerState {
            internal State딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State벽재생(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}