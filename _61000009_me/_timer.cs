namespace Maple2.Trigger._61000009_me {
    public static class _timer {
        public class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 100, textId: 40012);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new Stateready(context);
                }

                if (context.GetUserValue(key: "timer") == 1) {
                    return new StateReady_Idle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady_Idle : TriggerState {
            internal StateReady_Idle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 100);
                context.SetTimer(arg1: "1200", arg2: 1200, arg3: false, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1200")) {
                    return new StateendGame(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateendGame : TriggerState {
            internal StateendGame(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 5, arg2: "$61000004_ME__TRIGGER_01__2$", arg3: 3000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.MoveUser(arg1: 0, arg2: 0);
                    return new Stateend(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateend : TriggerState {
            internal Stateend(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}