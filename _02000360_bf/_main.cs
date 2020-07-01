namespace Maple2.Trigger._02000360_bf {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001009}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001009}, arg2: 0)) {
                    return new State1번아이템(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1번아이템 : TriggerState {
            internal State1번아이템(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateItem(arg1: new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14});
                context.CreateItem(arg1: new[] {15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41});
                context.CreateItem(arg1: new[] {42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70});
                context.CreateItem(arg1: new[] {71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87});
                context.SetTimer(arg1: "181", arg2: 19);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "181")) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}