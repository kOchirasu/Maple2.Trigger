namespace Maple2.Trigger._02020130_bf {
    public static class _phasepatterntrigger {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PhaseSumTotal", value: 0);
                context.SetUserValue(key: "PhasePatternTrigger", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 601) == 1) {
                    return new State보스3마리_페이즈전환계산(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보스3마리_페이즈전환계산 : TriggerState {
            internal State보스3마리_페이즈전환계산(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "PhaseSumTotal") >= 3) {
                    return new State보스3마리_페이즈전환실행_2페이즈(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보스3마리_페이즈전환실행_2페이즈 : TriggerState {
            internal State보스3마리_페이즈전환실행_2페이즈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "PhasePatternTrigger", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "PhaseSumTotal") >= 9) {
                    return new State보스3마리_페이즈전환실행_3페이즈(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보스3마리_페이즈전환실행_3페이즈 : TriggerState {
            internal State보스3마리_페이즈전환실행_3페이즈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "PhasePatternTrigger", value: 3);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "PhaseSumTotal") >= 15) {
                    return new State보스3마리_페이즈전환실행_4페이즈(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보스3마리_페이즈전환실행_4페이즈 : TriggerState {
            internal State보스3마리_페이즈전환실행_4페이즈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "PhasePatternTrigger", value: 4);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "PhaseSumTotal") >= 18) {
                    return new State보스3마리_페이즈전환실행_5페이즈(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보스3마리_페이즈전환실행_5페이즈 : TriggerState {
            internal State보스3마리_페이즈전환실행_5페이즈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "PhasePatternTrigger", value: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1200)) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}