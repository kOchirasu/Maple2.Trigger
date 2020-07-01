namespace Maple2.Trigger._52000052_qd {
    public static class _07_findway {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 22, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new[] {4027}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3007}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3107}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new[] {3007}, arg2: true, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new[] {3107}, arg2: false, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new[] {5207}, arg2: false);
                context.SetUserValue(key: "FindWay", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "FindWay") == 1) {
                    context.State = new StateReadyToWalkIn01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn01 : TriggerState {
            internal StateReadyToWalkIn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4027}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_107");
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_207");
                context.SetConversation(arg1: 1, arg2: 202, arg3: "$52000052_QD__04_FINDWAY__0$", arg4: 2, arg5: 0);
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
                context.SetUserValue(triggerId: 1307, key: "RouteSelected", value: 1);
                context.SetUserValue(triggerId: 2307, key: "RouteSelected", value: 1);
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
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$52000052_QD__04_FINDWAY__1$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateRound07_Start(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {102, 202});
            }
        }

        private class StateRound07_Start : TriggerState {
            internal StateRound07_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1007}, arg2: false);
                context.CreateMonster(arg1: new[] {2007}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 1007, arg3: "$52000052_QD__04_FINDWAY__2$", arg4: 3, arg5: 2);
                context.SetUserValue(triggerId: 907, key: "MobWaveStart", value: 1);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "07RoundSuccess") == 1) {
                    context.State = new StateRound07_Sucess02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound07_Sucess02 : TriggerState {
            internal StateRound07_Sucess02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2007, arg2: "MS2PatrolData_2007");
                context.DestroyMonster(arg1: new[] {1007});
                context.CreateMonster(arg1: new[] {107}, arg2: false);
                context.SetMesh(arg1: new[] {3007}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new[] {3007}, arg2: false, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new[] {5207}, arg2: true);
                context.SetPortal(arg1: 22, arg2: true, arg3: true, arg4: false);
                context.SetConversation(arg1: 1, arg2: 107, arg3: "$52000052_QD__04_FINDWAY__3$", arg4: 2, arg5: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateRound07_RouteSelect(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound07_RouteSelect : TriggerState {
            internal StateRound07_RouteSelect(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {2007});
                context.CreateMonster(arg1: new[] {207}, arg2: false);
                context.MoveNpc(arg1: 107, arg2: "MS2PatrolData_107New");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateGoToRound12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGoToRound12 : TriggerState {
            internal StateGoToRound12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {107});
                context.MoveNpc(arg1: 207, arg2: "MS2PatrolData_207New");
                context.SetUserValue(triggerId: 12, key: "FindWay", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateQuit02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit02 : TriggerState {
            internal StateQuit02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {207});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class StateRound07_PickRoute_Left : TriggerState {
            internal StateRound07_PickRoute_Left(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1307, key: "MakeTrue", value: 1);
                context.SetUserValue(triggerId: 2307, key: "MakeFalse", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateGoToRound09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGoToRound09 : TriggerState {
            internal StateGoToRound09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9, key: "FindWay", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound07_PickRoute_Right : TriggerState {
            internal StateRound07_PickRoute_Right(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1307, key: "MakeFalse", value: 1);
                context.SetUserValue(triggerId: 2307, key: "MakeTrue", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateGoToRound10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGoToRound10 : TriggerState {
            internal StateGoToRound10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 10, key: "FindWayLeft", value: 1);
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