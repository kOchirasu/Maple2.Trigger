namespace Maple2.Trigger._02000041_bf {
    public static class _elite {
        public class StateCreation : TriggerState {
            internal StateCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1001, 1002}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1001, 1002})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "30", seconds: 30, clearAtZero: false, display: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "30")) {
                    return new StateCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
