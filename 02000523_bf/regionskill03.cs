namespace Maple2.Trigger._02000523_bf {
    public static class _regionskill03 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 203, spawnIds: new []{900})) {
                    return new StateSkill작동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill작동 : TriggerState {
            internal StateSkill작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{301, 302}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (!context.NpcDetected(boxId: 203, spawnIds: new []{900})) {
                    return new StateTriggerReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTriggerReset : TriggerState {
            internal StateTriggerReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{301, 302}, arg2: false);
                context.SetTimer(timerId: "1", seconds: 1);
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
