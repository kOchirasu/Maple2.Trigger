namespace Maple2.Trigger._63000001_cs {
    public static class _trigger_hint {
        public class State힌트 : TriggerState {
            internal State힌트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(
                    arg1: new[]
                        {801, 802, 803, 804, 805, 806, 807, 808, 809, 810, 811, 812, 813, 814, 815, 816, 817, 818},
                    arg2: true, arg3: 2, arg4: 0, arg5: 1000);
                context.SetTimer(arg1: "99", arg2: 3, arg3: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "99")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new[]
                        {801, 802, 803, 804, 805, 806, 807, 808, 809, 810, 811, 812, 813, 814, 815, 816, 817, 818},
                    arg2: false);
                context.SetTimer(arg1: "41", arg2: 30, arg3: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "41")) {
                    context.State = new State힌트(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}