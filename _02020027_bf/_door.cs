using System;

namespace Maple2.Trigger._02020027_bf {
    public static class _door {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {9001, 9002, 9003, 9004, 9005, 9006, 9007}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.CheckNpcHp(compare: "lower", value: 50, spawnPointId: 201, isRelative: "true")) {
                    context.State = new State문열림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문열림 : TriggerState {
            internal State문열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {9001, 9002, 9003, 9004, 9005, 9006, 9007}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 10f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "1002")) {
                    context.State = new State문닫힘(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문닫힘 : TriggerState {
            internal State문닫힘(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {9001, 9002, 9003, 9004, 9005, 9006}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 10f);
                context.SetMesh(arg1: new int[] {9007}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}