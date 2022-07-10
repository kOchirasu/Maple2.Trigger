namespace Maple2.Trigger._02000378_bf {
    public static class _04_findway {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 21, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(triggerIds: new []{4024, 3004}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3104}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(triggerIds: new []{3004}, visible: true, arg3: 0, arg4: 0);
                context.SetMeshAnimation(triggerIds: new []{3104}, visible: false, arg3: 0, arg4: 0);
                context.SetEffect(triggerIds: new []{5204}, visible: false);
                context.SetUserValue(key: "FindWay", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "FindWay") == 1) {
                    return new StateReadyToWalkIn_FromPortal(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn_FromPortal : TriggerState {
            internal StateReadyToWalkIn_FromPortal(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{4024}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerId: 1304, key: "RouteSelected", value: 1);
                context.SetUserValue(triggerId: 2304, key: "RouteSelected", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateReadyToWalkIn_FromPortal02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CreateMonster(spawnIds: new []{2004, 104}, arg2: false);
            }
        }

        private class StateReadyToWalkIn_FromPortal02 : TriggerState {
            internal StateReadyToWalkIn_FromPortal02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 104, script: "$02000378_BF__04_FINDWAY__1$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateRound04_Start(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{104});
            }
        }

        private class StateRound04_Start : TriggerState {
            internal StateRound04_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1004}, arg2: false);
                context.SetConversation(type: 1, spawnId: 1004, script: "$02000378_BF__04_FINDWAY__4$", arg4: 3, arg5: 2);
                context.SetUserValue(triggerId: 904, key: "MobWaveStart", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "04RoundSuccess") == 1) {
                    return new StateRound04_Sucess02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound04_Sucess02 : TriggerState {
            internal StateRound04_Sucess02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 2004, patrolName: "MS2PatrolData_2004");
                context.DestroyMonster(spawnIds: new []{1004});
                context.CreateMonster(spawnIds: new []{104}, arg2: false);
                context.SetMesh(triggerIds: new []{3004}, visible: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(triggerIds: new []{3004}, visible: false, arg3: 0, arg4: 0);
                context.SetEffect(triggerIds: new []{5204}, visible: true);
                context.SetPortal(portalId: 21, visible: true, enabled: true, minimapVisible: false);
                context.SetConversation(type: 1, spawnId: 104, script: "$02000378_BF__04_FINDWAY__5$", arg4: 2, arg5: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateRound04_RouteSelect(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound04_RouteSelect : TriggerState {
            internal StateRound04_RouteSelect(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{2004});
                context.CreateMonster(spawnIds: new []{204}, arg2: false);
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_104New");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateGoToRound12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGoToRound12 : TriggerState {
            internal StateGoToRound12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{104});
                context.MoveNpc(spawnId: 204, patrolName: "MS2PatrolData_204New");
                context.SetUserValue(triggerId: 12, key: "FindWay", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateQuit02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit02 : TriggerState {
            internal StateQuit02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{204});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
