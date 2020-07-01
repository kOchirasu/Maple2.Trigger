using System;

namespace Maple2.Trigger._52000014_qd {
    public static class _cube_2304 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {2304}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {12304}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {92304})) {
                    context.State = new State무너짐01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State무너짐01 : TriggerState {
            internal State무너짐01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 5);
                context.SetEffect(arg1: new int[] {12304}, arg2: true);
                context.SetMesh(arg1: new int[] {2304}, arg2: false, arg3: 200, arg4: 0, arg5: 1f);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {12304}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}