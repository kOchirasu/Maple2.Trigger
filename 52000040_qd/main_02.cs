namespace Maple2.Trigger._52000040_qd {
    public static class _main_02 {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 4, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 3, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003053}, questStates: new byte[]{1})) {
                    return new StateEnd(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003053}, questStates: new byte[]{2})) {
                    return new StateEnd(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003053}, questStates: new byte[]{3})) {
                    return new StateEnd(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003052}, questStates: new byte[]{3})) {
                    return new StateStart_05(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003052}, questStates: new byte[]{2})) {
                    return new StateStart_05(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003052}, questStates: new byte[]{1})) {
                    context.SetEffect(triggerIds: new []{6002}, visible: true);
                    context.CreateMonster(spawnIds: new []{401}, arg2: false);
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStart_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02 : TriggerState {
            internal StateStart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 401, script: "$52000040_QD__MAIN_02__0$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStart_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_03 : TriggerState {
            internal StateStart_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 401, script: "$52000040_QD__MAIN_02__1$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 401, script: "$52000040_QD__MAIN_02__2$", arg4: 2, arg5: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.MoveNpc(spawnId: 401, patrolName: "MS2PatrolData_4001");
                    context.SetCinematicUI(type: 0);
                    context.SetCinematicUI(type: 2);
                    return new StateStart_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_04 : TriggerState {
            internal StateStart_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 702, spawnIds: new []{401})) {
                    return new StateNpc_exit_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpc_exit_01 : TriggerState {
            internal StateNpc_exit_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6001}, visible: true);
                context.DestroyMonster(spawnIds: new []{401});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateStart_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_05 : TriggerState {
            internal StateStart_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 701, type: "trigger", code: "FollowingLaoz");
                context.CreateMonster(spawnIds: new []{501}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003053}, questStates: new byte[]{1})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{501});
                context.SetPortal(portalId: 3, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 4, visible: true, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
