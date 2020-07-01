namespace Maple2.Trigger._80000018_bonus {
    public static class _01_bonusobjectspawn {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(
                    groupId: new[] {
                        10000534, 10000535, 10000536, 10000537, 10000538, 10000539, 10000540, 10000541, 10000542,
                        10000543, 10000544, 10000545, 10000546, 10000547, 10000548
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
                        10000534, 10000535, 10000536, 10000537, 10000538, 10000539, 10000540, 10000541, 10000542,
                        10000543, 10000544, 10000545, 10000546, 10000547, 10000548
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
                        10000534, 10000535, 10000536, 10000537, 10000538, 10000539, 10000540, 10000541, 10000542,
                        10000543, 10000544, 10000545, 10000546, 10000547, 10000548
                    }, isStart: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}