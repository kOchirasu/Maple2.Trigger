namespace Maple2.Trigger._02020100_bf {
    public static class _seed3 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990001, key: "EliteClear", value: 0);
                context.SetUserValue(triggerId: 99990001, key: "Seed3interact", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Seed3start") == 1) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {229});
                context.SetMesh(arg1: new[] {1304}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(arg1: new[] {10002111}, arg2: 1, arg3: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Seed3start") == 2) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002111}, arg2: 0)) {
                    return new StateSeed3_Planting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeed3_Planting : TriggerState {
            internal StateSeed3_Planting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990001, key: "Seed3interact", value: 1);
                context.SetMesh(arg1: new[] {1304}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10002122}, arg2: 1, arg3: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Seed3start") == 2) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002122}, arg2: 0)) {
                    return new StateSeed3_중보(context);
                }

                if (!context.CheckAnyUserAdditionalEffect(triggerBoxId: 0, additionalEffectId: 70002109, level: 1)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeed3_중보 : TriggerState {
            internal StateSeed3_중보(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 1404, arg2: true, arg3: "Interaction_lapentatree_A01_On");
                context.DestroyMonster(arg1: new[] {121, 122, 123, 124});
                context.CreateMonster(arg1: new[] {229}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {229})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990001, key: "EliteClear", value: 1);
                context.SetInteractObject(arg1: new[] {10002111}, arg2: 0);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}