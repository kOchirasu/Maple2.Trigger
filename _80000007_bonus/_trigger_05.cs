namespace Maple2.Trigger._80000007_bonus {
    public static class _trigger_05 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new[] {
                        652, 653, 654, 655, 656, 657, 658, 659, 660, 661, 662, 663, 664, 665, 666, 667, 668, 669, 670,
                        671, 672, 673, 674, 675, 676, 677, 678, 679, 680, 681, 682, 683, 684, 685, 686, 687, 688, 689,
                        690, 691, 692, 693, 694, 695, 696, 697, 698, 699, 700
                    }, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {154})) {
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
                    arg1: new[] {
                        652, 653, 654, 655, 656, 657, 658, 659, 660, 661, 662, 663, 664, 665, 666, 667, 668, 669, 670,
                        671, 672, 673, 674, 675, 676, 677, 678, 679, 680, 681, 682, 683, 684, 685, 686, 687, 688, 689,
                        690, 691, 692, 693, 694, 695, 696, 697, 698, 699, 700
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
                if (!context.UserDetected(arg1: new[] {154})) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}