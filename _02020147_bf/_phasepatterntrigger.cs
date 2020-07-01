namespace Maple2.Trigger._02020147_bf {
    public static class _phasepatterntrigger {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PhaseSumTotal", value: 0);
                context.SetUserValue(key: "PhasePatternTrigger", value: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 601) == 1) {
                    context.State = new State보스3마리_페이즈전환계산(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스3마리_페이즈전환계산 : TriggerState {
            internal State보스3마리_페이즈전환계산(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "PhaseSumTotal") >= 3) {
                    context.State = new State보스3마리_페이즈전환실행_2페이즈(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스3마리_페이즈전환실행_2페이즈 : TriggerState {
            internal State보스3마리_페이즈전환실행_2페이즈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "PhasePatternTrigger", value: 2);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "PhaseSumTotal") >= 6) {
                    context.State = new State보스3마리_페이즈전환실행_3페이즈(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스3마리_페이즈전환실행_3페이즈 : TriggerState {
            internal State보스3마리_페이즈전환실행_3페이즈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "PhasePatternTrigger", value: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1200)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}