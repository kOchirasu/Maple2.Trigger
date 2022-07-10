namespace Maple2.Trigger._52000052_qd {
    public static class _09_findway {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{4029, 3009}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3109}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(triggerIds: new []{3009}, visible: true, arg3: 0, arg4: 0);
                context.SetMeshAnimation(triggerIds: new []{3109}, visible: false, arg3: 0, arg4: 0);
                context.SetEffect(triggerIds: new []{5209}, visible: false);
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
                context.SetMesh(triggerIds: new []{4029}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveNpc(spawnId: 107, patrolName: "MS2PatrolData_109");
                context.MoveNpc(spawnId: 207, patrolName: "MS2PatrolData_209");
                context.SetConversation(type: 1, spawnId: 207, script: "$52000052_QD__04_FINDWAY__0$", arg4: 2, arg5: 0);
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
                context.SetUserValue(triggerId: 1309, key: "RouteSelected", value: 1);
                context.SetUserValue(triggerId: 2309, key: "RouteSelected", value: 1);
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
                context.SetConversation(type: 1, spawnId: 107, script: "$52000052_QD__04_FINDWAY__1$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateRound09_Start(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{107, 207});
            }
        }

        private class StateRound09_Start : TriggerState {
            internal StateRound09_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1009, 2009}, arg2: false);
                context.SetConversation(type: 1, spawnId: 1009, script: "$52000052_QD__04_FINDWAY__2$", arg4: 3, arg5: 2);
                context.SetUserValue(triggerId: 909, key: "MobWaveStart", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "09RoundSuccess") == 1) {
                    return new StateRound09_Sucess(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound09_Sucess : TriggerState {
            internal StateRound09_Sucess(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 2009, patrolName: "MS2PatrolData_2009");
                context.DestroyMonster(spawnIds: new []{1009});
                context.CreateMonster(spawnIds: new []{109}, arg2: false);
                context.SetMesh(triggerIds: new []{3009}, visible: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3109}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(triggerIds: new []{3009}, visible: false, arg3: 0, arg4: 0);
                context.SetMeshAnimation(triggerIds: new []{3109}, visible: true, arg3: 0, arg4: 0);
                context.SetEffect(triggerIds: new []{5209}, visible: true);
                context.SetConversation(type: 1, spawnId: 109, script: "$52000052_QD__04_FINDWAY__3$", arg4: 2, arg5: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateRound09_RouteSelect(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound09_RouteSelect : TriggerState {
            internal StateRound09_RouteSelect(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{2009});
                context.CreateMonster(spawnIds: new []{209}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 50f)) {
                    return new StateRound09_PickRoute_Left(context);
                }

                if (context.RandomCondition(rate: 50f)) {
                    return new StateRound09_PickRoute_Right(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound09_PickRoute_Left : TriggerState {
            internal StateRound09_PickRoute_Left(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1309, key: "MakeTrue", value: 1);
                context.SetUserValue(triggerId: 2309, key: "MakeFalse", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateGoToPortal15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGoToPortal15 : TriggerState {
            internal StateGoToPortal15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 109, patrolName: "MS2PatrolData_15");
                context.MoveNpc(spawnId: 209, patrolName: "MS2PatrolData_25");
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

        private class StateRound09_PickRoute_Right : TriggerState {
            internal StateRound09_PickRoute_Right(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1309, key: "MakeFalse", value: 1);
                context.SetUserValue(triggerId: 2309, key: "MakeTrue", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateGoToPortal16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGoToPortal16 : TriggerState {
            internal StateGoToPortal16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 12, key: "FindWay", value: 1);
                context.MoveNpc(spawnId: 109, patrolName: "MS2PatrolData_16");
                context.MoveNpc(spawnId: 209, patrolName: "MS2PatrolData_26");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{109, 209});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
