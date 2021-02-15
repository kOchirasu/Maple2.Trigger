namespace Maple2.Trigger._02020051_bf {
    public static class _103_potion {
        public class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Main") == 1) {
                    return new State포션사용_Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State포션사용_Prepare : TriggerState {
            internal State포션사용_Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002131}, arg2: 2);
                context.SetUserValue(triggerId: 101, key: "Potion", value: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 720000)) {
                    return new State포션사용(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State포션사용 : TriggerState {
            internal State포션사용(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002131}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10002131}, arg2: 0)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 101, key: "Potion", value: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Main") == 2) {
                    return new StateSetup(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}