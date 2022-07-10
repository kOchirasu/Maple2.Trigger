namespace Maple2.Trigger._52000052_qd {
    public static class _01_findway {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{4100, 4101, 4102, 4103, 4104, 4105, 4106}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3001}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3101}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(triggerIds: new []{3001}, visible: true, arg3: 0, arg4: 0);
                context.SetMeshAnimation(triggerIds: new []{3101}, visible: false, arg3: 0, arg4: 0);
                context.SetEffect(triggerIds: new []{5201, 5000}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9000) == 1) {
                    return new StateLodingDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLodingDelay01 : TriggerState {
            internal StateLodingDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{100, 200}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDialogue01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDialogue01 : TriggerState {
            internal StateDialogue01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 500, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateDialogue02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDialogue02 : TriggerState {
            internal StateDialogue02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(type: 2, spawnId: 11001557, script: "$52000052_QD__01_FINDWAY__0$", arg4: 5);
                context.SetSkip(state: new StateDialogue02Skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateDialogue02Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDialogue02Skip : TriggerState {
            internal StateDialogue02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.CameraSelect(triggerId: 500, enable: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateReadyToWalkIn01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class StateReadyToWalkIn01 : TriggerState {
            internal StateReadyToWalkIn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 100, patrolName: "MS2PatrolData_100");
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_200");
                context.SetConversation(type: 1, spawnId: 200, arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateReadyToWalkIn02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn02 : TriggerState {
            internal StateReadyToWalkIn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1301, key: "RouteSelected", value: 1);
                context.SetUserValue(triggerId: 2301, key: "RouteSelected", value: 1);
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
                context.SetConversation(type: 1, spawnId: 200, script: "$52000052_QD__01_FINDWAY__1$", arg4: 3, arg5: 0);
                context.SetConversation(type: 1, spawnId: 100, script: "$52000052_QD__01_FINDWAY__2$", arg4: 2, arg5: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5300)) {
                    return new StateRound01_Start(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{100, 200});
            }
        }

        private class StateRound01_Start : TriggerState {
            internal StateRound01_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1001, 2001}, arg2: false);
                context.SetUserValue(triggerId: 901, key: "MobWaveStart", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "01RoundSuccess") == 1) {
                    return new StateRound01_Sucess(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound01_Sucess : TriggerState {
            internal StateRound01_Sucess(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 2001, patrolName: "MS2PatrolData_2001");
                context.DestroyMonster(spawnIds: new []{1001});
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.SetEffect(triggerIds: new []{5201}, visible: true);
                context.SetMesh(triggerIds: new []{3001}, visible: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3101}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(triggerIds: new []{3001}, visible: false, arg3: 0, arg4: 0);
                context.SetMeshAnimation(triggerIds: new []{3101}, visible: true, arg3: 0, arg4: 0);
                context.SetConversation(type: 1, spawnId: 101, script: "$52000052_QD__01_FINDWAY__3$", arg4: 2, arg5: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateRound01_RouteSelect(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound01_RouteSelect : TriggerState {
            internal StateRound01_RouteSelect(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{2001});
                context.CreateMonster(spawnIds: new []{201}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 50f)) {
                    return new StateRound01_PickRoute_Left(context);
                }

                if (context.RandomCondition(rate: 50f)) {
                    return new StateRound01_PickRoute_Right(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound01_PickRoute_Left : TriggerState {
            internal StateRound01_PickRoute_Left(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1301, key: "MakeTrue", value: 1);
                context.SetUserValue(triggerId: 2301, key: "MakeFalse", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateGoToRound02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGoToRound02 : TriggerState {
            internal StateGoToRound02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2, key: "FindWay", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound01_PickRoute_Right : TriggerState {
            internal StateRound01_PickRoute_Right(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1301, key: "MakeFalse", value: 1);
                context.SetUserValue(triggerId: 2301, key: "MakeTrue", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateGoToRound03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGoToRound03 : TriggerState {
            internal StateGoToRound03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3, key: "FindWay", value: 1);
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
