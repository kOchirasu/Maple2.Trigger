using System;

namespace Maple2.Trigger._80000007_bonus {
    public static class _trigger_02 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {
                        501, 502, 503, 504, 505, 506, 507, 508, 509, 510, 511, 512, 513, 514, 515, 516, 517, 518, 519,
                        520, 521, 522, 523, 524, 525, 526, 527, 528, 529, 530, 531, 532, 533, 534, 535, 536, 537, 538,
                        539, 540, 541, 542, 543, 544, 545, 546, 547, 548, 549
                    }, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {151})) {
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
                        501, 502, 503, 504, 505, 506, 507, 508, 509, 510, 511, 512, 513, 514, 515, 516, 517, 518, 519,
                        520, 521, 522, 523, 524, 525, 526, 527, 528, 529, 530, 531, 532, 533, 534, 535, 536, 537, 538,
                        539, 540, 541, 542, 543, 544, 545, 546, 547, 548, 549
                    }, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State벽재생(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벽재생 : TriggerState {
            internal State벽재생(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.UserDetected(arg1: new int[] {151})) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}