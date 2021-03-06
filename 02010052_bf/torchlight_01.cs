namespace Maple2.Trigger._02010052_bf {
    public static class _torchlight_01 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {81001, 81002, 81003, 81004, 81005}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateBurn_state(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBurn_state : TriggerState {
            internal StateBurn_state(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010, 6011, 6012}, arg2: false, arg3: 800, arg4: 100, arg5: 0f);
                context.SetEventUI(arg1: 1, script: "$02010052_BF__TORCHLIGHT_01__0$", arg3: 3000);
                context.SetEffect(arg1: new[] {7001}, arg2: true);
                context.SetTimer(id: "1", arg2: 1, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSpawn_state(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSpawn_state : TriggerState {
            internal StateSpawn_state(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 200);
                context.SetEffect(arg1: new[] {7501, 81001, 81002, 81003, 81004, 81005}, arg2: true);
                context.SetActor(arg1: 8101, arg2: false, arg3: "Dmg_A");
                context.SetActor(arg1: 8102, arg2: false, arg3: "Dmg_A");
                context.SetActor(arg1: 8103, arg2: false, arg3: "Dmg_A");
                context.SetActor(arg1: 8104, arg2: false, arg3: "Dmg_A");
                context.SetActor(arg1: 8105, arg2: false, arg3: "Dmg_A");
                context.CreateMonster(arg1: new[] {311, 312, 313, 314, 315}, arg2: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}