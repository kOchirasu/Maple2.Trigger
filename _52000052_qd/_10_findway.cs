using System;

namespace Maple2.Trigger._52000052_qd {
    public static class _10_findway {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {4030}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3010}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3110}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new int[] {3010}, arg2: true, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new int[] {3110}, arg2: false, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new int[] {5210}, arg2: false);
                context.SetUserValue(key: "FindWayLeft", value: 0);
                context.SetUserValue(key: "FindWayRight", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "FindWayLeft", value: 1)) {
                    context.State = new StateReadyToWalkIn_FromLeft01(context);
                    return;
                }

                if (context.UserValue(key: "FindWayRight", value: 1)) {
                    context.State = new StateReadyToWalkIn_FromRight01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn_FromLeft01 : TriggerState {
            internal StateReadyToWalkIn_FromLeft01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {4030}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveNpc(arg1: 107, arg2: "MS2PatrolData_110L");
                context.MoveNpc(arg1: 207, arg2: "MS2PatrolData_210L");
                context.SetConversation(arg1: 1, arg2: 207, arg3: "$52000052_QD__04_FINDWAY__0$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateReadyToWalkIn_FromLeft02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn_FromLeft02 : TriggerState {
            internal StateReadyToWalkIn_FromLeft02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1310, key: "RouteSelected", value: 1);
                context.SetUserValue(triggerID: 2310, key: "RouteSelected", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateReadyToWalkIn_FromLeft03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn_FromLeft03 : TriggerState {
            internal StateReadyToWalkIn_FromLeft03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 107, arg3: "$52000052_QD__04_FINDWAY__1$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateRound10_Start(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new int[] {107, 207});
            }
        }

        private class StateReadyToWalkIn_FromRight01 : TriggerState {
            internal StateReadyToWalkIn_FromRight01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {4030}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveNpc(arg1: 108, arg2: "MS2PatrolData_110R");
                context.MoveNpc(arg1: 208, arg2: "MS2PatrolData_210R");
                context.SetConversation(arg1: 1, arg2: 208, arg3: "$52000052_QD__04_FINDWAY__0$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateReadyToWalkIn_FromRight02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn_FromRight02 : TriggerState {
            internal StateReadyToWalkIn_FromRight02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1310, key: "RouteSelected", value: 1);
                context.SetUserValue(triggerID: 2310, key: "RouteSelected", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateReadyToWalkIn_FromRight03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn_FromRight03 : TriggerState {
            internal StateReadyToWalkIn_FromRight03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 108, arg3: "$52000052_QD__04_FINDWAY__1$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateRound10_Start(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new int[] {108, 208});
            }
        }

        private class StateRound10_Start : TriggerState {
            internal StateRound10_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1010}, arg2: false);
                context.CreateMonster(arg1: new int[] {2010}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 1010, arg3: "$52000052_QD__04_FINDWAY__2$", arg4: 3, arg5: 2);
                context.SetUserValue(triggerID: 910, key: "MobWaveStart", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "10RoundSuccess", value: 1)) {
                    context.State = new StateRound10_Sucess01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound10_Sucess01 : TriggerState {
            internal StateRound10_Sucess01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2010, arg2: "MS2PatrolData_2010");
                context.DestroyMonster(arg1: new int[] {1010});
                context.CreateMonster(arg1: new int[] {110}, arg2: false);
                context.SetMesh(arg1: new int[] {3010}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3110}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new int[] {3010}, arg2: false, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new int[] {3110}, arg2: true, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new int[] {5210}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$52000052_QD__04_FINDWAY__3$", arg4: 2, arg5: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateRound10_RouteSelect(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound10_RouteSelect : TriggerState {
            internal StateRound10_RouteSelect(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {2010});
                context.CreateMonster(arg1: new int[] {210}, arg2: false);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateRound10_PickRoute_Left(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateRound10_PickRoute_Right(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound10_PickRoute_Left : TriggerState {
            internal StateRound10_PickRoute_Left(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1310, key: "MakeTrue", value: 1);
                context.SetUserValue(triggerID: 2310, key: "MakeFalse", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateGoToPortal17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGoToPortal17 : TriggerState {
            internal StateGoToPortal17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 110, arg2: "MS2PatrolData_17");
                context.MoveNpc(arg1: 210, arg2: "MS2PatrolData_27");
                context.SetUserValue(triggerID: 12, key: "FindWay", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound10_PickRoute_Right : TriggerState {
            internal StateRound10_PickRoute_Right(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1310, key: "MakeFalse", value: 1);
                context.SetUserValue(triggerID: 2310, key: "MakeTrue", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateGoToPortal18(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGoToPortal18 : TriggerState {
            internal StateGoToPortal18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 110, arg2: "MS2PatrolData_18");
                context.MoveNpc(arg1: 210, arg2: "MS2PatrolData_28");
                context.SetUserValue(triggerID: 12, key: "FindWay", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {110, 210});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}