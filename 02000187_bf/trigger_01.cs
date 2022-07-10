namespace Maple2.Trigger._02000187_bf {
    public static class _trigger_01 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{101}, questIds: new []{20001281}, questStates: new byte[]{2})) {
                    return new StateMobCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobCreation : TriggerState {
            internal StateMobCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{201, 202, 203, 204, 205, 206});
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{201, 202, 203, 204, 205, 206})) {
                    return new StateCoolTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCoolTime : TriggerState {
            internal StateCoolTime(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 20);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
