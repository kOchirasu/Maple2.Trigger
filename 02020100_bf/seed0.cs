namespace Maple2.Trigger._02020100_bf {
    public static class _seed0 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990001, key: "Seed0interact", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Seed0start") == 1) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1301}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(arg1: new[] {10002115}, arg2: 1, arg3: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Seed0start") == 2) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002115}, arg2: 0)) {
                    return new State씨앗0_대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State씨앗0_대기 : TriggerState {
            internal State씨앗0_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1301}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10002115}, arg2: 0, arg3: true);
                context.SetUserValue(triggerId: 99990001, key: "Seed0interact", value: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Seed0start") == 2) {
                    return new StateEnd(context);
                }

                if (!context.CheckAnyUserAdditionalEffect(triggerBoxId: 0, additionalEffectId: 70002109, level: true)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002115}, arg2: 0);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}