namespace Maple2.Trigger._52010038_qd {
    public static class _mob_1_3 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "bombStart") == 1) {
                    return new StateCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation : TriggerState {
            internal StateCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2097}, arg2: false);
                context.SpawnNpcRange(rangeId: new []{2008, 2009, 2010}, isAutoTargeting: true);
                context.SpawnNpcRange(rangeId: new []{2101, 2102, 2103, 2104, 2105, 2106, 2107}, isAutoTargeting: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2097})) {
                    context.SetUserValue(triggerId: 999001, key: "CoreIsDead", value: 1);
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
