using System;

namespace Maple2.Trigger._02000378_bf {
    public static class _02_findway {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 24, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new int[] {4022}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3002}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3102}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new int[] {3002}, arg2: true, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new int[] {3102}, arg2: false, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new int[] {5202}, arg2: false);
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
                context.SetMesh(arg1: new int[] {4022}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new int[] {901, 902, 903}, arg2: false);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_102");
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_202");
                context.SetConversation(arg1: 1, arg2: 201, arg3: "$02000378_BF__02_FINDWAY__0$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateReadyToWalkIn02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn02 : TriggerState {
            internal StateReadyToWalkIn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1302, key: "RouteSelected", value: 1);
                context.SetUserValue(triggerID: 2302, key: "RouteSelected", value: 1);
                context.SetConversation(arg1: 1, arg2: 201, arg3: "$02000378_BF__02_FINDWAY__1$", arg4: 2, arg5: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateReadyToWalkIn03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn03 : TriggerState {
            internal StateReadyToWalkIn03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$02000378_BF__02_FINDWAY__2$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateRound02_Start(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new int[] {101, 201});
            }
        }

        private class StateRound02_Start : TriggerState {
            internal StateRound02_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1002}, arg2: false);
                context.CreateMonster(arg1: new int[] {2002}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 1002, arg3: "$02000378_BF__02_FINDWAY__3$", arg4: 3, arg5: 2);
                context.SetUserValue(triggerID: 902, key: "MobWaveStart", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "02RoundSuccess", value: 1)) {
                    context.State = new StateRound02_Sucess02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound02_Sucess02 : TriggerState {
            internal StateRound02_Sucess02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2002, arg2: "MS2PatrolData_2002");
                context.DestroyMonster(arg1: new int[] {1002});
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
                context.SetMesh(arg1: new int[] {3002}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new int[] {3002}, arg2: false, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new int[] {5202}, arg2: true);
                context.SetPortal(arg1: 24, arg2: true, arg3: true, arg4: false);
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$02000378_BF__02_FINDWAY__4$", arg4: 2, arg5: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateRound02_RouteSelect(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound02_RouteSelect : TriggerState {
            internal StateRound02_RouteSelect(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {2002});
                context.CreateMonster(arg1: new int[] {202}, arg2: false);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_102New");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateGoToRound12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGoToRound12 : TriggerState {
            internal StateGoToRound12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {102});
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_202New");
                context.SetUserValue(triggerID: 12, key: "FindWay", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateQuit02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit02 : TriggerState {
            internal StateQuit02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {202});
                context.DestroyMonster(arg1: new int[] {901, 902, 903});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}