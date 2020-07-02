namespace Maple2.Trigger._02000253_bf {
    public static class _vehicle_02 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8052}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetDungeonMaxUserCount() == 2) {
                    return new StateVehicle_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateVehicle_01 : TriggerState {
            internal StateVehicle_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {8052}, arg2: true);
                context.CreateMonster(arg1: new[] {3004}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {3004})) {
                    return new StateVehicle_spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateVehicle_spawn : TriggerState {
            internal StateVehicle_spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8052}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001053}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001053}, arg2: 0)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001053}, arg2: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}