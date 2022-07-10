namespace Maple2.Trigger._02000253_bf {
    public static class _vehicle_03 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8053}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonMaxUserCount() == 3) {
                    return new StateVehicle_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateVehicle_01 : TriggerState {
            internal StateVehicle_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 906) == 1) {
                    return new StateMonster_spawn_ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster_spawn_ready : TriggerState {
            internal StateMonster_spawn_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateMonster_spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster_spawn : TriggerState {
            internal StateMonster_spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8053}, visible: true);
                context.CreateMonster(spawnIds: new []{3001}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3001})) {
                    return new StateVehicle_spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateVehicle_spawn : TriggerState {
            internal StateVehicle_spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8053}, visible: true);
                context.SetInteractObject(interactIds: new []{10001052}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001052}, arg2: 0)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001052}, state: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
