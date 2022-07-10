namespace Maple2.Trigger._02010052_bf {
    public static class _torchlight_01 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{81001, 81002, 81003, 81004, 81005}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateBurn_state(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBurn_state : TriggerState {
            internal StateBurn_state(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010, 6011, 6012}, visible: false, arg3: 800, arg4: 100, arg5: 0f);
                context.SetEventUI(arg1: 1, script: "$02010052_BF__TORCHLIGHT_01__0$", duration: 3000);
                context.SetEffect(triggerIds: new []{7001}, visible: true);
                context.SetTimer(timerId: "1", seconds: 1, display: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
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
                context.SetEffect(triggerIds: new []{7501, 81001, 81002, 81003, 81004, 81005}, visible: true);
                context.SetActor(triggerId: 8101, visible: false, initialSequence: "Dmg_A");
                context.SetActor(triggerId: 8102, visible: false, initialSequence: "Dmg_A");
                context.SetActor(triggerId: 8103, visible: false, initialSequence: "Dmg_A");
                context.SetActor(triggerId: 8104, visible: false, initialSequence: "Dmg_A");
                context.SetActor(triggerId: 8105, visible: false, initialSequence: "Dmg_A");
                context.CreateMonster(spawnIds: new []{311, 312, 313, 314, 315}, arg2: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
