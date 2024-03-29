namespace Maple2.Trigger._02000311_bf {
    public static class _ai {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9999993, key: "Buff_01", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Phase_02") == 1) {
                    return new StatePhase_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_02 : TriggerState {
            internal StatePhase_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_2001");
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_2002");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StatePhase_02_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_02_b : TriggerState {
            internal StatePhase_02_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 201, script: "$02000311_BF__AI__0$", arg4: 2, arg5: 2);
                context.SetConversation(type: 1, spawnId: 202, script: "$02000311_BF__AI__1$", arg4: 2, arg5: 0);
                context.SetSkill(triggerIds: new []{6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePhase_02_c(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_02_c : TriggerState {
            internal StatePhase_02_c(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003111, textId: 20003111, duration: 5000);
                context.SetEffect(triggerIds: new []{7001, 7002}, visible: true);
                context.SetUserValue(triggerId: 9999994, key: "Buff_01", value: 1);
                context.SetUserValue(triggerId: 9999995, key: "Buff_02", value: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
