using System;

namespace Maple2.Trigger._52000052_qd {
    public static class _01_findway {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212},
                    arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {4100, 4101, 4102, 4103, 4104, 4105, 4106}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3101}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new int[] {3001}, arg2: true, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new int[] {3101}, arg2: false, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new int[] {5201}, arg2: false);
                context.SetEffect(arg1: new int[] {5000}, arg2: false);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9000, arg2: 1)) {
                    context.State = new StateLodingDelay01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLodingDelay01 : TriggerState {
            internal StateLodingDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {100, 200}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDialogue01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue01 : TriggerState {
            internal StateDialogue01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 500, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateDialogue02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue02 : TriggerState {
            internal StateDialogue02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$52000052_QD__01_FINDWAY__0$", arg4: 5);
                context.SetSkip(arg1: "Dialogue02Skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateDialogue02Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue02Skip : TriggerState {
            internal StateDialogue02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.CameraSelect(arg1: 500, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateReadyToWalkIn01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class StateReadyToWalkIn01 : TriggerState {
            internal StateReadyToWalkIn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_100");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_200");
                context.SetConversation(arg1: 1, arg2: 200, arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateReadyToWalkIn02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn02 : TriggerState {
            internal StateReadyToWalkIn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1301, key: "RouteSelected", value: 1);
                context.SetUserValue(triggerID: 2301, key: "RouteSelected", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateReadyToWalkIn03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn03 : TriggerState {
            internal StateReadyToWalkIn03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 200, arg3: "$52000052_QD__01_FINDWAY__1$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$52000052_QD__01_FINDWAY__2$", arg4: 2, arg5: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5300)) {
                    context.State = new StateRound01_Start(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new int[] {100, 200});
            }
        }

        private class StateRound01_Start : TriggerState {
            internal StateRound01_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1001}, arg2: false);
                context.CreateMonster(arg1: new int[] {2001}, arg2: false);
                context.SetUserValue(triggerID: 901, key: "MobWaveStart", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "01RoundSuccess", value: 1)) {
                    context.State = new StateRound01_Sucess(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound01_Sucess : TriggerState {
            internal StateRound01_Sucess(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2001, arg2: "MS2PatrolData_2001");
                context.DestroyMonster(arg1: new int[] {1001});
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
                context.SetEffect(arg1: new int[] {5201}, arg2: true);
                context.SetMesh(arg1: new int[] {3001}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3101}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new int[] {3001}, arg2: false, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new int[] {3101}, arg2: true, arg3: 0, arg4: 0);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52000052_QD__01_FINDWAY__3$", arg4: 2, arg5: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateRound01_RouteSelect(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound01_RouteSelect : TriggerState {
            internal StateRound01_RouteSelect(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {2001});
                context.CreateMonster(arg1: new int[] {201}, arg2: false);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateRound01_PickRoute_Left(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateRound01_PickRoute_Right(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound01_PickRoute_Left : TriggerState {
            internal StateRound01_PickRoute_Left(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1301, key: "MakeTrue", value: 1);
                context.SetUserValue(triggerID: 2301, key: "MakeFalse", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateGoToRound02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGoToRound02 : TriggerState {
            internal StateGoToRound02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 2, key: "FindWay", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound01_PickRoute_Right : TriggerState {
            internal StateRound01_PickRoute_Right(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1301, key: "MakeFalse", value: 1);
                context.SetUserValue(triggerID: 2301, key: "MakeTrue", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateGoToRound03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGoToRound03 : TriggerState {
            internal StateGoToRound03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 3, key: "FindWay", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}