using System;

namespace Maple2.Trigger._02020062_bf {
    public static class _movepanel4 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State발판초기화(context);

        private class State발판초기화 : TriggerState {
            internal State발판초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new int[] {2300, 2301, 2302, 2303, 2304, 2305, 2306, 2307, 2308},
                    arg2: false);
                context.SetVisibleBreakableObject(
                    arg1: new int[] {2300, 2301, 2302, 2303, 2304, 2305, 2306, 2307, 2308}, arg2: false);
                context.SetUserValue(triggerID: 99990027, key: "MovePanel04", value: 0);
                context.SetInteractObject(arg1: new int[] {12000118}, arg2: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "MovePanel04", value: 1)) {
                    context.State = new State레버생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레버생성 : TriggerState {
            internal State레버생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {12000118}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000118}, arg2: 0)) {
                    context.State = new State발판이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판이동 : TriggerState {
            internal State발판이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetVisibleBreakableObject(
                    arg1: new int[] {2300, 2301, 2302, 2303, 2304, 2305, 2306, 2307, 2308}, arg2: true);
                context.SetInteractObject(arg1: new int[] {12000118}, arg2: 2);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9203")) {
                    context.SetBreakable(arg1: new int[] {2300, 2301, 2302, 2303, 2304, 2305, 2306, 2307, 2308},
                        arg2: true);
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new int[] {2300, 2301, 2302, 2303, 2304, 2305, 2306, 2307, 2308},
                    arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State발판이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}