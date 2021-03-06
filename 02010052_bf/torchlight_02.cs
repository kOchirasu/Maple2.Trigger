namespace Maple2.Trigger._02010052_bf {
    public static class _torchlight_02 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7010}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {110})) {
                    return new StateBurn_state(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBurn_state : TriggerState {
            internal StateBurn_state(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7502}, arg2: true);
                context.SetMesh(arg1: new[] {5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012, 5013, 5014, 5015, 5016, 5017, 5018, 5019, 5020, 5021, 5022, 5023, 5024, 5025, 5026}, arg2: false, arg3: 800, arg4: 100, arg5: 0f);
                context.SetEventUI(arg1: 1, script: "$02010052_BF__TORCHLIGHT_02__0$", arg3: 3000);
                context.SetEffect(arg1: new[] {7010}, arg2: true);
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
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}