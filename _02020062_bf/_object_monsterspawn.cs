namespace Maple2.Trigger._02020062_bf {
    public static class _object_monsterspawn {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

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
                    return new StateWait(context);
                }

                if (context.GetUserValue(key: "EliteSpawn") == 2) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

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