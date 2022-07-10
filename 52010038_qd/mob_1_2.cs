namespace Maple2.Trigger._52010038_qd {
    public static class _mob_1_2 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "WaveStart") == 1) {
                    return new StateCreation(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SpawnNpcRange(rangeId: new []{2005, 2006, 2007}, isAutoTargeting: true);
            }
        }

        private class StateCreation : TriggerState {
            internal StateCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{4000}, arg2: false);
                context.SpawnNpcRange(rangeId: new []{2005, 2006, 2007}, isAutoTargeting: true, randomPickCount: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateCreation(context);
                }

                if (context.GetUserValue(key: "WaveEnd") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
