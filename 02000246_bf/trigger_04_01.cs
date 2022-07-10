namespace Maple2.Trigger._02000246_bf {
    public static class _trigger_04_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{631, 632, 633, 634, 635, 636, 637, 638, 639});
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{204})) {
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
                context.SetTimer(timerId: "1", seconds: 120);
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
                context.SetTimer(timerId: "2", seconds: 180);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
