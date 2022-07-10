namespace Maple2.Trigger._02010052_bf {
    public static class _torchlight_02 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7010}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{110})) {
                    return new StateBurn_state(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBurn_state : TriggerState {
            internal StateBurn_state(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7502}, visible: true);
                context.SetMesh(triggerIds: new []{5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012, 5013, 5014, 5015, 5016, 5017, 5018, 5019, 5020, 5021, 5022, 5023, 5024, 5025, 5026}, visible: false, arg3: 800, arg4: 100, arg5: 0f);
                context.SetEventUI(arg1: 1, script: "$02010052_BF__TORCHLIGHT_02__0$", duration: 3000);
                context.SetEffect(triggerIds: new []{7010}, visible: true);
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
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
