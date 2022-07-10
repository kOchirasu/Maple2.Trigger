namespace Maple2.Trigger._02000242_bf {
    public static class _trigger_01_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{701, 702}, visible: false);
                context.DestroyMonster(spawnIds: new []{631, 632, 633, 634, 635, 636, 637, 638, 639});
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{201})) {
                    return new StateMobCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobCreation : TriggerState {
            internal StateMobCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{631, 632, 633, 634, 635, 636, 637, 638, 639}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{631, 632, 633, 634, 635, 636, 637, 638, 639})) {
                    return new State통과(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State통과 : TriggerState {
            internal State통과(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateItem(spawnIds: new []{501, 502, 503, 504, 505, 506, 507, 508, 509, 510, 511, 512, 513, 514, 515, 516, 517, 518, 519, 520});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
