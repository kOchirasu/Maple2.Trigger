namespace Maple2.Trigger._02010052_bf {
    public static class _torchlight_06 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(triggerIds: new []{6100, 6101, 6102, 6103, 6104, 6105, 6106, 6107, 6108, 6109, 6110, 6111, 6112, 6113, 6114, 6115, 6116, 6117, 6118, 6119, 6120, 6121, 6122}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{7006}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 709) == 1) {
                    return new StateEvent_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_05 : TriggerState {
            internal StateEvent_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7543}, visible: true);
                context.SetMesh(triggerIds: new []{6100, 6101, 6102, 6103, 6104, 6105, 6106, 6107, 6108, 6109, 6110, 6111, 6112, 6113, 6114, 6115, 6116, 6117, 6118, 6119, 6120, 6121, 6122}, visible: true, arg3: 80, arg4: 70, arg5: 8f);
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new StateEvent_05_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_05_01 : TriggerState {
            internal StateEvent_05_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{994});
                context.CreateMonster(spawnIds: new []{106}, arg2: false);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 200, textId: 20105201);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{106})) {
                    return new StateBurn_state(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBurn_state : TriggerState {
            internal StateBurn_state(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 200);
                context.SetEffect(triggerIds: new []{7506}, visible: true);
                context.SetMesh(triggerIds: new []{6100, 6101, 6102, 6103, 6104, 6105, 6106, 6107, 6108, 6109, 6110, 6111, 6112, 6113, 6114, 6115, 6116, 6117, 6118, 6119, 6120, 6121, 6122}, visible: false, arg3: 800, arg4: 100, arg5: 0f);
                context.SetMesh(triggerIds: new []{600002}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEventUI(arg1: 1, script: "$02010052_BF__TORCHLIGHT_06__0$", duration: 3000);
                context.SetEffect(triggerIds: new []{7006}, visible: true);
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
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
