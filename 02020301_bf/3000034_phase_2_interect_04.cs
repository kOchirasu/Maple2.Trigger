namespace Maple2.Trigger._02020301_bf {
    public static class _3000034_phase_2_interect_04 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Phase_2_Interect_04") == 1) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{703}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{703})) {
                    return new State재Creation(context);
                }

                if (context.GetUserValue(key: "Phase_2_Interect_04") == 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재Creation : TriggerState {
            internal State재Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new StateStart(context);
                }

                if (context.GetUserValue(key: "Phase_2_Interect_04") == 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
