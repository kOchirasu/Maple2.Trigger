namespace Maple2.Trigger._80000019_bonus {
    public static class _01_bonusobjectspawn {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new []{10000549, 10000550, 10000551, 10000552, 10000553, 10000554, 10000555, 10000556, 10000557, 10000558, 10000559, 10000560, 10000561, 10000562, 10000563}, isStart: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateSpawnOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSpawnOn : TriggerState {
            internal StateSpawnOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new []{10000549, 10000550, 10000551, 10000552, 10000553, 10000554, 10000555, 10000556, 10000557, 10000558, 10000559, 10000560, 10000561, 10000562, 10000563}, isStart: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount() == 0) {
                    return new StateSpawnOff(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSpawnOff : TriggerState {
            internal StateSpawnOff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new []{10000549, 10000550, 10000551, 10000552, 10000553, 10000554, 10000555, 10000556, 10000557, 10000558, 10000559, 10000560, 10000561, 10000562, 10000563}, isStart: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
