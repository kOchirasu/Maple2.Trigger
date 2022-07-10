namespace Maple2.Trigger._02010052_bf {
    public static class _torchlight_04 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{6051, 6052, 6053, 6054, 6055, 6056, 6057, 6058, 6059, 6060, 6061, 6062, 6063, 6064, 6065, 6066}, visible: false, arg3: 800, arg4: 100, arg5: 8f);
                context.SetEffect(triggerIds: new []{7004}, visible: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{104}, arg2: true);
                context.ShowGuideSummary(entityId: 200, textId: 20105204);
                context.SetEffect(triggerIds: new []{7541}, visible: true);
                context.SetMesh(triggerIds: new []{6051, 6052, 6053, 6054, 6055, 6056, 6057, 6058, 6059, 6060, 6061, 6062, 6063, 6064, 6065, 6066}, visible: true, arg3: 80, arg4: 100, arg5: 8f);
                context.MoveNpc(spawnId: 994, patrolName: "MS2PatrolData_1006");
                context.SetConversation(type: 1, spawnId: 994, script: "$02010052_BF__MAIN__6$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{104})) {
                    return new StateBurn_state(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBurn_state : TriggerState {
            internal StateBurn_state(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7504}, visible: true);
                context.SetMesh(triggerIds: new []{6051, 6052, 6053, 6054, 6055, 6056, 6057, 6058, 6059, 6060, 6061, 6062, 6063, 6064, 6065, 6066}, visible: false, arg3: 800, arg4: 100, arg5: 8f);
                context.SetEventUI(arg1: 1, script: "$02010052_BF__TORCHLIGHT_04__0$", duration: 3000);
                context.SetEffect(triggerIds: new []{7004}, visible: true);
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 80003, enable: true);
                context.SetConversation(type: 2, spawnId: 21800073, script: "$02010052_BF__TORCHLIGHT_04__1$", arg4: 2);
                context.SetTimer(timerId: "2", seconds: 2);
                context.SetSkip(state: new StateRun(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new StateRun(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 7);
                context.CameraSelect(triggerId: 80003, enable: false);
            }
        }

        private class StateRun : TriggerState {
            internal StateRun(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 994, script: "$02010052_BF__TORCHLIGHT_04__2$", arg4: 3);
                context.MoveNpc(spawnId: 994, patrolName: "MS2PatrolData_1005");
                context.CreateMonster(spawnIds: new []{501, 502, 503, 504, 505, 506}, arg2: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
