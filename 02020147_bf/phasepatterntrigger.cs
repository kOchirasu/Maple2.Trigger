namespace Maple2.Trigger._02020147_bf {
    public static class _phasepatterntrigger {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PhaseSumTotal", value: 0);
                context.SetUserValue(key: "PhasePatternTrigger", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 601) == 1) {
                    return new StateBoss3마리_Phase전환계산(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss3마리_Phase전환계산 : TriggerState {
            internal StateBoss3마리_Phase전환계산(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "PhaseSumTotal") >= 3) {
                    return new StateBoss3마리_Phase전환실행_2페이즈(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss3마리_Phase전환실행_2페이즈 : TriggerState {
            internal StateBoss3마리_Phase전환실행_2페이즈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "PhasePatternTrigger", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "PhaseSumTotal") >= 6) {
                    return new StateBoss3마리_Phase전환실행_3페이즈(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss3마리_Phase전환실행_3페이즈 : TriggerState {
            internal StateBoss3마리_Phase전환실행_3페이즈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "PhasePatternTrigger", value: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1200)) {
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
