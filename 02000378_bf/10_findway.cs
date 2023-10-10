namespace Maple2.Trigger._02000378_bf {
    public static class _10_findway {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{4030, 3010}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3110}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(triggerIds: new []{3010}, visible: true, arg3: 0, arg4: 0);
                context.SetMeshAnimation(triggerIds: new []{3110}, visible: false, arg3: 0, arg4: 0);
                context.SetEffect(triggerIds: new []{5210}, visible: false);
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
                context.SetMesh(triggerIds: new []{4030}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerId: 1310, key: "RouteSelected", value: 1);
                context.SetUserValue(triggerId: 2310, key: "RouteSelected", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateReadyToWalkIn_FromPortal02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CreateMonster(spawnIds: new []{110, 2010}, arg2: false);
            }
        }

        private class StateReadyToWalkIn_FromPortal02 : TriggerState {
            internal StateReadyToWalkIn_FromPortal02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 110, script: "$02000378_BF__10_FINDWAY__3$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateRound10_Start(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{110});
            }
        }

        private class StateRound10_Start : TriggerState {
            internal StateRound10_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1010}, arg2: false);
                context.SetConversation(type: 1, spawnId: 1010, script: "$02000378_BF__10_FINDWAY__4$", arg4: 3, arg5: 2);
                context.SetUserValue(triggerId: 910, key: "MobWaveStart", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "10RoundSuccess") == 1) {
                    return new StateRound10_Sucess01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound10_Sucess01 : TriggerState {
            internal StateRound10_Sucess01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 2010, patrolName: "MS2PatrolData_2010");
                context.DestroyMonster(spawnIds: new []{1010});
                context.CreateMonster(spawnIds: new []{110}, arg2: false);
                context.SetMesh(triggerIds: new []{3010}, visible: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3110}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(triggerIds: new []{3010}, visible: false, arg3: 0, arg4: 0);
                context.SetMeshAnimation(triggerIds: new []{3110}, visible: true, arg3: 0, arg4: 0);
                context.SetEffect(triggerIds: new []{5210}, visible: true);
                context.SetConversation(type: 1, spawnId: 110, script: "$02000378_BF__10_FINDWAY__5$", arg4: 2, arg5: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateRound10_RouteSelect(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound10_RouteSelect : TriggerState {
            internal StateRound10_RouteSelect(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{2010});
                context.CreateMonster(spawnIds: new []{210}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 50)) {
                    return new StateRound10_PickRoute_Left(context);
                }

                if (context.RandomCondition(rate: 50)) {
                    return new StateRound10_PickRoute_Right(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound10_PickRoute_Left : TriggerState {
            internal StateRound10_PickRoute_Left(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1310, key: "MakeTrue", value: 1);
                context.SetUserValue(triggerId: 2310, key: "MakeFalse", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateGoToPortal17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGoToPortal17 : TriggerState {
            internal StateGoToPortal17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 110, patrolName: "MS2PatrolData_17");
                context.MoveNpc(spawnId: 210, patrolName: "MS2PatrolData_27");
                context.SetUserValue(triggerId: 12, key: "FindWay", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound10_PickRoute_Right : TriggerState {
            internal StateRound10_PickRoute_Right(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1310, key: "MakeFalse", value: 1);
                context.SetUserValue(triggerId: 2310, key: "MakeTrue", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateGoToPortal18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGoToPortal18 : TriggerState {
            internal StateGoToPortal18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 110, patrolName: "MS2PatrolData_18");
                context.MoveNpc(spawnId: 210, patrolName: "MS2PatrolData_28");
                context.SetUserValue(triggerId: 12, key: "FindWay", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{110, 210});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
