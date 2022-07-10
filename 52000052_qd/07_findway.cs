namespace Maple2.Trigger._52000052_qd {
    public static class _07_findway {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 22, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(triggerIds: new []{4027, 3007}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3107}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(triggerIds: new []{3007}, visible: true, arg3: 0, arg4: 0);
                context.SetMeshAnimation(triggerIds: new []{3107}, visible: false, arg3: 0, arg4: 0);
                context.SetEffect(triggerIds: new []{5207}, visible: false);
                context.SetUserValue(key: "FindWay", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "FindWay") == 1) {
                    return new StateReadyToWalkIn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn01 : TriggerState {
            internal StateReadyToWalkIn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{4027}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_107");
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_207");
                context.SetConversation(type: 1, spawnId: 202, script: "$52000052_QD__04_FINDWAY__0$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateReadyToWalkIn02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn02 : TriggerState {
            internal StateReadyToWalkIn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1307, key: "RouteSelected", value: 1);
                context.SetUserValue(triggerId: 2307, key: "RouteSelected", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateReadyToWalkIn03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn03 : TriggerState {
            internal StateReadyToWalkIn03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 102, script: "$52000052_QD__04_FINDWAY__1$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateRound07_Start(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{102, 202});
            }
        }

        private class StateRound07_Start : TriggerState {
            internal StateRound07_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1007, 2007}, arg2: false);
                context.SetConversation(type: 1, spawnId: 1007, script: "$52000052_QD__04_FINDWAY__2$", arg4: 3, arg5: 2);
                context.SetUserValue(triggerId: 907, key: "MobWaveStart", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "07RoundSuccess") == 1) {
                    return new StateRound07_Sucess02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound07_Sucess02 : TriggerState {
            internal StateRound07_Sucess02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 2007, patrolName: "MS2PatrolData_2007");
                context.DestroyMonster(spawnIds: new []{1007});
                context.CreateMonster(spawnIds: new []{107}, arg2: false);
                context.SetMesh(triggerIds: new []{3007}, visible: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(triggerIds: new []{3007}, visible: false, arg3: 0, arg4: 0);
                context.SetEffect(triggerIds: new []{5207}, visible: true);
                context.SetPortal(portalId: 22, visible: true, enabled: true, minimapVisible: false);
                context.SetConversation(type: 1, spawnId: 107, script: "$52000052_QD__04_FINDWAY__3$", arg4: 2, arg5: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateRound07_RouteSelect(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound07_RouteSelect : TriggerState {
            internal StateRound07_RouteSelect(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{2007});
                context.CreateMonster(spawnIds: new []{207}, arg2: false);
                context.MoveNpc(spawnId: 107, patrolName: "MS2PatrolData_107New");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateGoToRound12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGoToRound12 : TriggerState {
            internal StateGoToRound12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{107});
                context.MoveNpc(spawnId: 207, patrolName: "MS2PatrolData_207New");
                context.SetUserValue(triggerId: 12, key: "FindWay", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit02 : TriggerState {
            internal StateQuit02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{207});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound07_PickRoute_Left : TriggerState {
            internal StateRound07_PickRoute_Left(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1307, key: "MakeTrue", value: 1);
                context.SetUserValue(triggerId: 2307, key: "MakeFalse", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateGoToRound09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGoToRound09 : TriggerState {
            internal StateGoToRound09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9, key: "FindWay", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound07_PickRoute_Right : TriggerState {
            internal StateRound07_PickRoute_Right(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1307, key: "MakeFalse", value: 1);
                context.SetUserValue(triggerId: 2307, key: "MakeTrue", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateGoToRound10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGoToRound10 : TriggerState {
            internal StateGoToRound10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 10, key: "FindWayLeft", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
