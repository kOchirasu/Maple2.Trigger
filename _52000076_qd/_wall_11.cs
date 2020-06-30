using System;

namespace Maple2.Trigger._52000076_qd {
    public static class _wall_11 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State벽재생(context);

        private class State벽재생 : TriggerState {
            internal State벽재생(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {
                        31101, 31102, 31103, 31104, 31105, 31106, 31107, 31108, 31109, 31110, 31111, 31112, 31113,
                        31114, 31115, 31116, 31117, 31118, 31119, 31120, 31121, 31122
                    }, arg2: true, arg3: 0, arg4: 10, arg5: 3f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "111")) {
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
                        31101, 31102, 31103, 31104, 31105, 31106, 31107, 31108, 31109, 31110, 31111, 31112, 31113,
                        31114, 31115, 31116, 31117, 31118, 31119, 31120, 31121, 31122
                    }, arg2: false, arg3: 0, arg4: 10, arg5: 3f);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: "111")) {
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