using System;

namespace Maple2.Trigger._02000139_bf {
    public static class _01_trigger01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {401, 402, 403, 404}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000131}, arg2: 1);
                context.SetMesh(arg1: new int[] {201, 202, 203}, arg2: false);
                context.SetLadder(arg1: 301, arg2: false, arg3: false);
                context.SetLadder(arg1: 302, arg2: false, arg3: false);
                context.SetLadder(arg1: 303, arg2: false, arg3: false);
                context.SetLadder(arg1: 304, arg2: false, arg3: false);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000131}, arg2: 0)) {
                    context.State = new State발판등장1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판등장1 : TriggerState {
            internal State발판등장1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {201}, arg2: true);
                context.SetTimer(arg1: "2", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State발판등장2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판등장2 : TriggerState {
            internal State발판등장2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {202}, arg2: true);
                context.SetTimer(arg1: "3", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State발판등장3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판등장3 : TriggerState {
            internal State발판등장3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {203}, arg2: true);
                context.SetTimer(arg1: "4", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new State사다리등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State사다리등장 : TriggerState {
            internal State사다리등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 301, arg2: true, arg3: true);
                context.SetEffect(arg1: new int[] {401}, arg2: true);
                context.SetLadder(arg1: 302, arg2: true, arg3: true);
                context.SetEffect(arg1: new int[] {402}, arg2: true);
                context.SetLadder(arg1: 303, arg2: true, arg3: true);
                context.SetEffect(arg1: new int[] {403}, arg2: true);
                context.SetLadder(arg1: 304, arg2: true, arg3: true);
                context.SetEffect(arg1: new int[] {404}, arg2: true);
                context.SetTimer(arg1: "4", arg2: 20);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}