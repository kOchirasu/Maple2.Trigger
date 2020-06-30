using System;

namespace Maple2.Trigger._81000003_item {
    public static class _trigger_02 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State레버(context);

        private class State레버 : TriggerState {
            internal State레버(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000225}, arg2: 1);
                context.SetMesh(
                    arg1: new int[] {
                        530, 531, 532, 533, 534, 535, 536, 537, 538, 539, 540, 541, 542, 543, 544, 545, 546, 547, 548,
                        549, 550
                    }, arg2: true);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000225}, arg2: 0)) {
                    context.State = new State바닥열기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State바닥열기 : TriggerState {
            internal State바닥열기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "8", arg2: 200);
                context.SetMesh(
                    arg1: new int[] {
                        530, 531, 532, 533, 534, 535, 536, 537, 538, 539, 540, 541, 542, 543, 544, 545, 546, 547, 548,
                        549, 550
                    }, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "8")) {
                    context.State = new State레버(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}