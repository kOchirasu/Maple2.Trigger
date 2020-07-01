namespace Maple2.Trigger._80000017_bonus {
    public static class _01_bonusobjectspawn {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(
                    groupId: new[] {
                        10000519, 10000520, 10000521, 10000522, 10000523, 10000524, 10000525, 10000526, 10000527,
                        10000528, 10000529, 10000530, 10000531, 10000532, 10000533
                    }, isStart: false);
            }

            public override void Execute() {
                if (context.GetUserCount() > 0) {
                    context.State = new StateSpawnOn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSpawnOn : TriggerState {
            internal StateSpawnOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(
                    groupId: new[] {
                        10000519, 10000520, 10000521, 10000522, 10000523, 10000524, 10000525, 10000526, 10000527,
                        10000528, 10000529, 10000530, 10000531, 10000532, 10000533
                    }, isStart: true);
            }

            public override void Execute() {
                if (context.GetUserCount() == 0) {
                    context.State = new StateSpawnOff(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSpawnOff : TriggerState {
            internal StateSpawnOff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(
                    groupId: new[] {
                        10000519, 10000520, 10000521, 10000522, 10000523, 10000524, 10000525, 10000526, 10000527,
                        10000528, 10000529, 10000530, 10000531, 10000532, 10000533
                    }, isStart: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}