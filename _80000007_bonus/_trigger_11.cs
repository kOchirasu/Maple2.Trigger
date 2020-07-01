namespace Maple2.Trigger._80000007_bonus {
    public static class _trigger_11 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new[] {
                        951, 952, 953, 954, 955, 956, 957, 958, 959, 960, 961, 962, 963, 964, 965, 966, 967, 968, 969,
                        970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988,
                        989, 990, 991, 992, 993, 994, 995, 996, 997, 998, 999
                    }, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {160})) {
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
                        951, 952, 953, 954, 955, 956, 957, 958, 959, 960, 961, 962, 963, 964, 965, 966, 967, 968, 969,
                        970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988,
                        989, 990, 991, 992, 993, 994, 995, 996, 997, 998, 999
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
                if (!context.UserDetected(arg1: new[] {160})) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}