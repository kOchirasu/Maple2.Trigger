using System;

namespace Maple2.Trigger._99999931 {
    public static class _endlever {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State게임종료(context);

        private class State게임종료 : TriggerState {
            internal State게임종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {211, 212}, arg2: true);
                context.SetMesh(arg1: new int[] {551, 552}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000216}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000216}, arg2: 0)) {
                    context.State = new State종료안내(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료안내 : TriggerState {
            internal State종료안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 3);
                context.SetEventUI(arg1: 5, arg3: new int[] {3000});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State문열기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문열기 : TriggerState {
            internal State문열기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 7);
                context.SetMesh(arg1: new int[] {211, 212}, arg2: false);
                context.SetMesh(arg1: new int[] {551, 552}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State문닫기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문닫기 : TriggerState {
            internal State문닫기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetMesh(arg1: new int[] {211, 212}, arg2: true);
                context.SetMesh(arg1: new int[] {551, 552}, arg2: false);
                context.SetMesh(arg1: new int[] {201, 202, 203, 204, 205, 206, 207, 208}, arg2: true);
                context.SetPortal(arg1: 101, arg2: false, arg3: true);
                context.SetPortal(arg1: 102, arg2: false, arg3: true);
                context.SetPortal(arg1: 103, arg2: false, arg3: true);
                context.SetPortal(arg1: 104, arg2: false, arg3: true);
                context.SetPortal(arg1: 115, arg2: false, arg3: true);
                context.SetPortal(arg1: 116, arg2: false, arg3: true);
                context.SetPortal(arg1: 117, arg2: false, arg3: true);
                context.SetPortal(arg1: 118, arg2: false, arg3: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State게임종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}