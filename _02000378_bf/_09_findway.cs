using System;

namespace Maple2.Trigger._02000378_bf {
    public static class _09_findway {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {4029}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3009}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3109}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new int[] {3009}, arg2: true, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new int[] {3109}, arg2: false, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new int[] {5209}, arg2: false);
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
                context.SetMesh(arg1: new int[] {4029}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerID: 1309, key: "RouteSelected", value: 1);
                context.SetUserValue(triggerID: 2309, key: "RouteSelected", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateReadyToWalkIn_FromPortal02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new int[] {109}, arg2: false);
                context.CreateMonster(arg1: new int[] {2009}, arg2: false);
            }
        }

        private class StateReadyToWalkIn_FromPortal02 : TriggerState {
            internal StateReadyToWalkIn_FromPortal02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 109, arg3: "$02000378_BF__09_FINDWAY__1$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateRound09_Start(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new int[] {109});
            }
        }

        private class StateRound09_Start : TriggerState {
            internal StateRound09_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1009}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 1009, arg3: "$02000378_BF__09_FINDWAY__2$", arg4: 3, arg5: 2);
                context.SetUserValue(triggerID: 909, key: "MobWaveStart", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "09RoundSuccess", value: 1)) {
                    context.State = new StateRound09_Sucess(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound09_Sucess : TriggerState {
            internal StateRound09_Sucess(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2009, arg2: "MS2PatrolData_2009");
                context.DestroyMonster(arg1: new int[] {1009});
                context.CreateMonster(arg1: new int[] {109}, arg2: false);
                context.SetMesh(arg1: new int[] {3009}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3109}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new int[] {3009}, arg2: false, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new int[] {3109}, arg2: true, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new int[] {5209}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 109, arg3: "$02000378_BF__09_FINDWAY__3$", arg4: 2, arg5: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateRound09_RouteSelect(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound09_RouteSelect : TriggerState {
            internal StateRound09_RouteSelect(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {2009});
                context.CreateMonster(arg1: new int[] {209}, arg2: false);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateRound09_PickRoute_Left(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateRound09_PickRoute_Right(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound09_PickRoute_Left : TriggerState {
            internal StateRound09_PickRoute_Left(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1309, key: "MakeTrue", value: 1);
                context.SetUserValue(triggerID: 2309, key: "MakeFalse", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateGoToPortal15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGoToPortal15 : TriggerState {
            internal StateGoToPortal15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 109, arg2: "MS2PatrolData_15");
                context.MoveNpc(arg1: 209, arg2: "MS2PatrolData_25");
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

        private class StateRound09_PickRoute_Right : TriggerState {
            internal StateRound09_PickRoute_Right(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1309, key: "MakeFalse", value: 1);
                context.SetUserValue(triggerID: 2309, key: "MakeTrue", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateGoToPortal16(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGoToPortal16 : TriggerState {
            internal StateGoToPortal16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 12, key: "FindWay", value: 1);
                context.MoveNpc(arg1: 109, arg2: "MS2PatrolData_16");
                context.MoveNpc(arg1: 209, arg2: "MS2PatrolData_26");
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
                context.DestroyMonster(arg1: new int[] {109, 209});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}