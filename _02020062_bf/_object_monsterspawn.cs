namespace Maple2.Trigger._02020062_bf {
    public static class _object_monsterspawn {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new[] {494}, isStart: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "EliteSpawn") == 1) {
                    return new State스폰(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰 : TriggerState {
            internal State스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new[] {494}, isStart: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "EliteSpawn") == 0) {
                    return new State대기(context);
                }

                if (context.GetUserValue(key: "EliteSpawn") == 2) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new[] {494}, isStart: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}