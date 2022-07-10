namespace Maple2.Trigger._02020100_bf {
    public static class _seed0 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990001, key: "Seed0interact", value: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetMesh(triggerIds: new []{1301}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(interactIds: new []{10002115}, state: 1, arg3: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Seed0start") == 2) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002115}, arg2: 0)) {
                    return new StateSeed0_Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeed0_Wait : TriggerState {
            internal StateSeed0_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{1301}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10002115}, state: 0, arg3: true);
                context.SetUserValue(triggerId: 99990001, key: "Seed0interact", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Seed0start") == 2) {
                    return new StateEnd(context);
                }

                if (!context.CheckAnyUserAdditionalEffect(boxId: 0, additionalEffectId: 70002109, level: 1)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002115}, state: 0);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
