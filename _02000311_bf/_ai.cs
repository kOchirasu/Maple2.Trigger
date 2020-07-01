namespace Maple2.Trigger._02000311_bf {
    public static class _ai {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9999993, key: "Buff_01", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Phase_02") == 1) {
                    context.State = new StatePhase_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePhase_02 : TriggerState {
            internal StatePhase_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2001");
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_2002");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StatePhase_02_b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePhase_02_b : TriggerState {
            internal StatePhase_02_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 201, arg3: "$02000311_BF__AI__0$", arg4: 2, arg5: 2);
                context.SetConversation(arg1: 1, arg2: 202, arg3: "$02000311_BF__AI__1$", arg4: 2, arg5: 0);
                context.SetSkill(arg1: new[] {6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StatePhase_02_c(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePhase_02_c : TriggerState {
            internal StatePhase_02_c(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003111, textId: 20003111, duration: 5000);
                context.SetEffect(arg1: new[] {7001, 7002}, arg2: true);
                context.SetUserValue(triggerId: 9999994, key: "Buff_01", value: 1);
                context.SetUserValue(triggerId: 9999995, key: "Buff_02", value: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}