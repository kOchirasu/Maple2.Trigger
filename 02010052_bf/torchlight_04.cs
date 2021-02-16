namespace Maple2.Trigger._02010052_bf {
    public static class _torchlight_04 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {6051, 6052, 6053, 6054, 6055, 6056, 6057, 6058, 6059, 6060, 6061, 6062, 6063, 6064, 6065, 6066}, arg2: false, arg3: 800, arg4: 100, arg5: 8f);
                context.SetEffect(arg1: new[] {7004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 707) == 1) {
                    return new StateEvent_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_04 : TriggerState {
            internal StateEvent_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {104}, arg2: true);
                context.ShowGuideSummary(entityId: 200, textId: 20105204);
                context.SetEffect(arg1: new[] {7541}, arg2: true);
                context.SetMesh(arg1: new[] {6051, 6052, 6053, 6054, 6055, 6056, 6057, 6058, 6059, 6060, 6061, 6062, 6063, 6064, 6065, 6066}, arg2: true, arg3: 80, arg4: 100, arg5: 8f);
                context.MoveNpc(arg1: 994, arg2: "MS2PatrolData_1006");
                context.SetConversation(arg1: 1, arg2: 994, script: "$02010052_BF__MAIN__6$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {104})) {
                    return new StateBurn_state(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBurn_state : TriggerState {
            internal StateBurn_state(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7504}, arg2: true);
                context.SetMesh(arg1: new[] {6051, 6052, 6053, 6054, 6055, 6056, 6057, 6058, 6059, 6060, 6061, 6062, 6063, 6064, 6065, 6066}, arg2: false, arg3: 800, arg4: 100, arg5: 8f);
                context.SetEventUI(arg1: 1, script: "$02010052_BF__TORCHLIGHT_04__0$", arg3: 3000);
                context.SetEffect(arg1: new[] {7004}, arg2: true);
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(arg1: 80003, arg2: true);
                context.SetConversation(arg1: 2, arg2: 21800073, script: "$02010052_BF__TORCHLIGHT_04__1$", arg4: 2);
                context.SetTimer(id: "2", arg2: 2);
                context.SetSkip(state: new StateRun(context));
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new StateRun(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 7);
                context.CameraSelect(arg1: 80003, arg2: false);
            }
        }

        private class StateRun : TriggerState {
            internal StateRun(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 707) == 1) {
                    return new StateRun_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRun_01 : TriggerState {
            internal StateRun_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 200, textId: 20105202);
                context.SetConversation(arg1: 1, arg2: 994, script: "$02010052_BF__TORCHLIGHT_04__2$", arg4: 3);
                context.MoveNpc(arg1: 994, arg2: "MS2PatrolData_1005");
                context.CreateMonster(arg1: new[] {501, 502, 503, 504, 505, 506}, arg2: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}