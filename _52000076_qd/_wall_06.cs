using System;

namespace Maple2.Trigger._52000076_qd {
    public static class _wall_06 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State벽재생(context);

        private class State벽재생 : TriggerState {
            internal State벽재생(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {
                        36001, 36002, 36003, 36004, 36005, 36006, 36007, 36008, 36009, 36010, 36011, 36012, 36013,
                        36014, 36015, 36016, 36017, 36018, 36019, 36020, 36021
                    }, arg2: true, arg3: 0, arg4: 10, arg5: 3f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {106})) {
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
                        36001, 36002, 36003, 36004, 36005, 36006, 36007, 36008, 36009, 36010, 36011, 36012, 36013,
                        36014, 36015, 36016, 36017, 36018, 36019, 36020, 36021
                    }, arg2: false, arg3: 0, arg4: 10, arg5: 3f);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: new int[] {106})) {
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