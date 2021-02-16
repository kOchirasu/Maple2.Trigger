namespace Maple2.Trigger._02000064_tw_triatown02 {
    public static class _massive_door_2 {
        public class StateWaitClosing : TriggerState {
            internal StateWaitClosing(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State5SecondsBeforeClose : TriggerState {
            internal State5SecondsBeforeClose(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "115", arg2: 115);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "115")) {
                    return new StateClosed1(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "115");
            }
        }

        private class StateClosed1 : TriggerState {
            internal StateClosed1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateClosed2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "5");
            }
        }

        private class StateClosed2 : TriggerState {
            internal StateClosed2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "6", arg2: 60);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    return new StateWaitClosing(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "6");
            }
        }
    }
}