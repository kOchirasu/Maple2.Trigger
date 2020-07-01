namespace Maple2.Trigger._80000020_bonus {
    public static class _01_bonusobjectspawn {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(
                    groupId: new[] {
                        10000564, 10000565, 10000566, 10000567, 10000568, 10000569, 10000570, 10000571, 10000572,
                        10000573, 10000574, 10000575, 10000576, 10000577, 10000578
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
                        10000564, 10000565, 10000566, 10000567, 10000568, 10000569, 10000570, 10000571, 10000572,
                        10000573, 10000574, 10000575, 10000576, 10000577, 10000578
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
                        10000564, 10000565, 10000566, 10000567, 10000568, 10000569, 10000570, 10000571, 10000572,
                        10000573, 10000574, 10000575, 10000576, 10000577, 10000578
                    }, isStart: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}