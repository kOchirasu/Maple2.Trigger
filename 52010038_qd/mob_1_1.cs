namespace Maple2.Trigger._52010038_qd {
    public static class _mob_1_1 {
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
                context.SpawnNpcRange(spawnIds: new []{2001, 2002, 2003, 2004}, isAutoTargeting: true);
                context.SpawnNpcRange(spawnIds: new []{2001, 2002, 2003, 2004}, isAutoTargeting: true);
                context.SpawnNpcRange(spawnIds: new []{2001, 2002, 2003, 2004}, isAutoTargeting: true);
                context.CreateMonster(spawnIds: new []{2011}, arg2: true);
            }
        }

        private class StateCreation : TriggerState {
            internal StateCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2011}, arg2: true);
                context.SpawnNpcRange(spawnIds: new []{2001, 2002, 2003, 2004}, isAutoTargeting: true, randomPickCount: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateCreation(context);
                }

                if (context.GetUserValue(key: "WaveSlowDown") == 1) {
                    return new StateCreation2(context);
                }

                if (context.GetUserValue(key: "WaveEnd") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation2 : TriggerState {
            internal StateCreation2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2011}, arg2: true);
                context.SpawnNpcRange(spawnIds: new []{2001, 2002, 2003, 2004}, isAutoTargeting: true, randomPickCount: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 14000)) {
                    return new StateCreation2(context);
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
