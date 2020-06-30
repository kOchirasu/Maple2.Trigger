using System;

namespace Maple2.Trigger._52000052_qd {
    public static class _11_findway {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {4031}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3011}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3111}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new int[] {3011}, arg2: true, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new int[] {3111}, arg2: false, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new int[] {5211}, arg2: false);
                context.SetUserValue(key: "FindWay", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "FindWay", value: 1)) {
                    context.State = new StateReadyToWalkIn01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn01 : TriggerState {
            internal StateReadyToWalkIn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {4031}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveNpc(arg1: 108, arg2: "MS2PatrolData_111");
                context.MoveNpc(arg1: 208, arg2: "MS2PatrolData_211");
                context.SetConversation(arg1: 1, arg2: 208, arg3: "$52000052_QD__04_FINDWAY__0$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateReadyToWalkIn02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn02 : TriggerState {
            internal StateReadyToWalkIn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1311, key: "RouteSelected", value: 1);
                context.SetUserValue(triggerID: 2311, key: "RouteSelected", value: 1);
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
                context.SetConversation(arg1: 1, arg2: 108, arg3: "$52000052_QD__04_FINDWAY__1$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateRound11_Start(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new int[] {108, 208});
            }
        }

        private class StateRound11_Start : TriggerState {
            internal StateRound11_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1011}, arg2: false);
                context.CreateMonster(arg1: new int[] {2011}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 1011, arg3: "$52000052_QD__04_FINDWAY__2$", arg4: 3, arg5: 2);
                context.SetUserValue(triggerID: 911, key: "MobWaveStart", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "11RoundSuccess", value: 1)) {
                    context.State = new StateRound11_Sucess(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound11_Sucess : TriggerState {
            internal StateRound11_Sucess(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2011, arg2: "MS2PatrolData_2011");
                context.DestroyMonster(arg1: new int[] {1011});
                context.CreateMonster(arg1: new int[] {111}, arg2: false);
                context.SetMesh(arg1: new int[] {3011}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3111}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new int[] {3011}, arg2: false, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new int[] {3111}, arg2: true, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new int[] {5211}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 111, arg3: "$52000052_QD__04_FINDWAY__3$", arg4: 2, arg5: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateRound11_RouteSelect(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound11_RouteSelect : TriggerState {
            internal StateRound11_RouteSelect(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {2011});
                context.CreateMonster(arg1: new int[] {211}, arg2: false);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateRound11_PickRoute_Left(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateRound11_PickRoute_Right(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound11_PickRoute_Left : TriggerState {
            internal StateRound11_PickRoute_Left(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1311, key: "MakeTrue", value: 1);
                context.SetUserValue(triggerID: 2311, key: "MakeFalse", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateGoToPortal19(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGoToPortal19 : TriggerState {
            internal StateGoToPortal19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 111, arg2: "MS2PatrolData_19");
                context.MoveNpc(arg1: 211, arg2: "MS2PatrolData_29");
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

        private class StateRound11_PickRoute_Right : TriggerState {
            internal StateRound11_PickRoute_Right(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1311, key: "MakeFalse", value: 1);
                context.SetUserValue(triggerID: 2311, key: "MakeTrue", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateGoToPortal10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGoToPortal10 : TriggerState {
            internal StateGoToPortal10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 12, key: "FindWay", value: 1);
                context.MoveNpc(arg1: 111, arg2: "MS2PatrolData_10");
                context.MoveNpc(arg1: 211, arg2: "MS2PatrolData_20");
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
                context.DestroyMonster(arg1: new int[] {111, 211});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}