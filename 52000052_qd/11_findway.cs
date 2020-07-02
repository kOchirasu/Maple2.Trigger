namespace Maple2.Trigger._52000052_qd {
    public static class _11_findway {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4031, 3011}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3111}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new[] {3011}, arg2: true, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new[] {3111}, arg2: false, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new[] {5211}, arg2: false);
                context.SetUserValue(key: "FindWay", value: 0);
            }

            public override TriggerState Execute() {
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
                context.SetMesh(arg1: new[] {4031}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveNpc(arg1: 108, arg2: "MS2PatrolData_111");
                context.MoveNpc(arg1: 208, arg2: "MS2PatrolData_211");
                context.SetConversation(arg1: 1, arg2: 208, arg3: "$52000052_QD__04_FINDWAY__0$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
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
                context.SetUserValue(triggerId: 1311, key: "RouteSelected", value: 1);
                context.SetUserValue(triggerId: 2311, key: "RouteSelected", value: 1);
            }

            public override TriggerState Execute() {
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
                context.SetConversation(arg1: 1, arg2: 108, arg3: "$52000052_QD__04_FINDWAY__1$", arg4: 2, arg5: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateRound11_Start(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {108, 208});
            }
        }

        private class StateRound11_Start : TriggerState {
            internal StateRound11_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1011, 2011}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 1011, arg3: "$52000052_QD__04_FINDWAY__2$", arg4: 3, arg5: 2);
                context.SetUserValue(triggerId: 911, key: "MobWaveStart", value: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "11RoundSuccess") == 1) {
                    return new StateRound11_Sucess(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound11_Sucess : TriggerState {
            internal StateRound11_Sucess(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2011, arg2: "MS2PatrolData_2011");
                context.DestroyMonster(arg1: new[] {1011});
                context.CreateMonster(arg1: new[] {111}, arg2: false);
                context.SetMesh(arg1: new[] {3011}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3111}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new[] {3011}, arg2: false, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new[] {3111}, arg2: true, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new[] {5211}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 111, arg3: "$52000052_QD__04_FINDWAY__3$", arg4: 2, arg5: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateRound11_RouteSelect(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound11_RouteSelect : TriggerState {
            internal StateRound11_RouteSelect(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {2011});
                context.CreateMonster(arg1: new[] {211}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    return new StateRound11_PickRoute_Left(context);
                }

                if (context.RandomCondition(arg1: 50f)) {
                    return new StateRound11_PickRoute_Right(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound11_PickRoute_Left : TriggerState {
            internal StateRound11_PickRoute_Left(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1311, key: "MakeTrue", value: 1);
                context.SetUserValue(triggerId: 2311, key: "MakeFalse", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateGoToPortal19(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGoToPortal19 : TriggerState {
            internal StateGoToPortal19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 111, arg2: "MS2PatrolData_19");
                context.MoveNpc(arg1: 211, arg2: "MS2PatrolData_29");
                context.SetUserValue(triggerId: 12, key: "FindWay", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound11_PickRoute_Right : TriggerState {
            internal StateRound11_PickRoute_Right(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1311, key: "MakeFalse", value: 1);
                context.SetUserValue(triggerId: 2311, key: "MakeTrue", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateGoToPortal10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGoToPortal10 : TriggerState {
            internal StateGoToPortal10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 12, key: "FindWay", value: 1);
                context.MoveNpc(arg1: 111, arg2: "MS2PatrolData_10");
                context.MoveNpc(arg1: 211, arg2: "MS2PatrolData_20");
            }

            public override TriggerState Execute() {
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
                context.DestroyMonster(arg1: new[] {111, 211});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}