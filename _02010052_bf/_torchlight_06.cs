namespace Maple2.Trigger._02010052_bf {
    public static class _torchlight_06 {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new[] {6100, 6101, 6102, 6103, 6104, 6105, 6106, 6107, 6108, 6109, 6110, 6111, 6112, 6113, 6114, 6115, 6116, 6117, 6118, 6119, 6120, 6121, 6122}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {7006}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 709) == 1) {
                    context.State = new StateEvent_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_05 : TriggerState {
            internal StateEvent_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7543}, arg2: true);
                context.SetMesh(arg1: new[] {6100, 6101, 6102, 6103, 6104, 6105, 6106, 6107, 6108, 6109, 6110, 6111, 6112, 6113, 6114, 6115, 6116, 6117, 6118, 6119, 6120, 6121, 6122}, arg2: true, arg3: 80, arg4: 70, arg5: 8f);
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new StateEvent_05_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_05_01 : TriggerState {
            internal StateEvent_05_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {994});
                context.CreateMonster(arg1: new[] {106}, arg2: false);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 200, textId: 20105201);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {106})) {
                    context.State = new Stateburn_state(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateburn_state : TriggerState {
            internal Stateburn_state(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 200);
                context.SetEffect(arg1: new[] {7506}, arg2: true);
                context.SetMesh(arg1: new[] {6100, 6101, 6102, 6103, 6104, 6105, 6106, 6107, 6108, 6109, 6110, 6111, 6112, 6113, 6114, 6115, 6116, 6117, 6118, 6119, 6120, 6121, 6122}, arg2: false, arg3: 800, arg4: 100, arg5: 0f);
                context.SetMesh(arg1: new[] {600002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEventUI(arg1: 1, arg2: "$02010052_BF__TORCHLIGHT_06__0$", arg3: 3000);
                context.SetEffect(arg1: new[] {7006}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1, arg4: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new Statespawn_state(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statespawn_state : TriggerState {
            internal Statespawn_state(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}