namespace Maple2.Trigger._02020100_bf {
    public static class _seed2 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990001, key: "Seed2interact", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Seed2start") == 1) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{221, 222, 223, 224});
                context.SetMesh(triggerIds: new []{1303}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(interactIds: new []{10002110}, state: 1, arg3: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Seed2start") == 2) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002110}, arg2: 0)) {
                    return new StateSeed2_Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeed2_Wait : TriggerState {
            internal StateSeed2_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{221, 222, 223, 224}, arg2: false);
                context.SetMesh(triggerIds: new []{1303}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10002110}, state: 0, arg3: true);
                context.SetUserValue(triggerId: 99990001, key: "Seed2interact", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Seed2start") == 2) {
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
                context.SetInteractObject(interactIds: new []{10002110}, state: 0);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
