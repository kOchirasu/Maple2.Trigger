using System;

namespace Maple2.Trigger._02000378_bf {
    public static class _06_findway {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {4026}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3006}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3106}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new int[] {3006}, arg2: true, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new int[] {3106}, arg2: false, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new int[] {5206}, arg2: false);
                context.SetUserValue(key: "FindWay", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "FindWay", value: 1)) {
                    context.State = new StateReadyToWalkIn_FromPortal(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn_FromPortal : TriggerState {
            internal StateReadyToWalkIn_FromPortal(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {4026}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerID: 1306, key: "RouteSelected", value: 1);
                context.SetUserValue(triggerID: 2306, key: "RouteSelected", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateReadyToWalkIn_FromPortal02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new int[] {106}, arg2: false);
                context.CreateMonster(arg1: new int[] {2006}, arg2: false);
            }
        }

        private class StateReadyToWalkIn_FromPortal02 : TriggerState {
            internal StateReadyToWalkIn_FromPortal02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 106, arg3: "$02000378_BF__06_FINDWAY__1$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateRound06_Start(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new int[] {106});
            }
        }

        private class StateRound06_Start : TriggerState {
            internal StateRound06_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1006}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 1006, arg3: "$02000378_BF__06_FINDWAY__2$", arg4: 3, arg5: 2);
                context.SetUserValue(triggerID: 906, key: "MobWaveStart", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "06RoundSuccess", value: 1)) {
                    context.State = new StateRound06_Sucess(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound06_Sucess : TriggerState {
            internal StateRound06_Sucess(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2006, arg2: "MS2PatrolData_2006");
                context.DestroyMonster(arg1: new int[] {1006});
                context.CreateMonster(arg1: new int[] {106}, arg2: false);
                context.SetMesh(arg1: new int[] {3006}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3106}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new int[] {3006}, arg2: false, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new int[] {3106}, arg2: true, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new int[] {5206}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 106, arg3: "$02000378_BF__06_FINDWAY__3$", arg4: 2, arg5: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateRound06_RouteSelect(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound06_RouteSelect : TriggerState {
            internal StateRound06_RouteSelect(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {2006});
                context.CreateMonster(arg1: new int[] {206}, arg2: false);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateRound06_PickRoute_Left(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateRound06_PickRoute_Right(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound06_PickRoute_Left : TriggerState {
            internal StateRound06_PickRoute_Left(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1306, key: "MakeTrue", value: 1);
                context.SetUserValue(triggerID: 2306, key: "MakeFalse", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateGoToPortal13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGoToPortal13 : TriggerState {
            internal StateGoToPortal13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 106, arg2: "MS2PatrolData_13");
                context.MoveNpc(arg1: 206, arg2: "MS2PatrolData_23");
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

        private class StateRound06_PickRoute_Right : TriggerState {
            internal StateRound06_PickRoute_Right(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1306, key: "MakeFalse", value: 1);
                context.SetUserValue(triggerID: 2306, key: "MakeTrue", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateGoToPortal14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGoToPortal14 : TriggerState {
            internal StateGoToPortal14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 12, key: "FindWay", value: 1);
                context.MoveNpc(arg1: 106, arg2: "MS2PatrolData_14");
                context.MoveNpc(arg1: 206, arg2: "MS2PatrolData_24");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {106, 206});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}