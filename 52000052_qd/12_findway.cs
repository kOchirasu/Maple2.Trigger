namespace Maple2.Trigger._52000052_qd {
    public static class _12_findway {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetActor(arg1: 4000, arg2: true, arg3: "or_fi_struc_stonegate_A01_off");
                context.SetEffect(arg1: new[] {5012, 5013}, arg2: false);
                context.SetMesh(arg1: new[] {331200, 331201, 331202, 331203, 331204, 331205, 331206, 331207, 331208, 331209, 331210, 331211, 331212, 331213, 331214, 331215, 331216, 331217, 331218, 331219, 331220, 331221, 331222, 331223, 331224, 331225, 331226, 331227, 331228, 331229, 331230, 331231, 331232, 331233, 331234, 331235, 331236, 331237, 331238, 331239, 331240, 331241, 331242, 331243, 331244, 331245, 331246, 331247, 331248, 331249, 331250, 331251, 331252, 331253, 331254, 331255, 331256, 331257, 331258, 331259, 331260, 331261, 331262, 331263, 331264, 331265, 331266, 331267, 331268, 331269, 331270, 331271, 331272, 331273, 331274, 331275, 331276, 331277}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {4032, 3012}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3112}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new[] {3012}, arg2: true, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new[] {3112}, arg2: false, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new[] {5212}, arg2: false);
                context.SetUserValue(key: "FindWay", value: 0);
                context.SetAgent(arg1: new[] {28120, 28121, 28122}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "FindWay") == 1) {
                    return new StateMovingDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMovingDelay01 : TriggerState {
            internal StateMovingDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateReadyToWalkIn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn01 : TriggerState {
            internal StateReadyToWalkIn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {112, 212}, arg2: false);
                context.SetMesh(arg1: new[] {4032}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveNpc(arg1: 112, arg2: "MS2PatrolData_112");
                context.MoveNpc(arg1: 212, arg2: "MS2PatrolData_212");
                context.SetConversation(arg1: 1, arg2: 212, script: "$52000052_QD__12_FINDWAY__0$", arg4: 3, arg5: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateReadyToWalkIn02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn02 : TriggerState {
            internal StateReadyToWalkIn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 112, script: "$52000052_QD__12_FINDWAY__1$", arg4: 3, arg5: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateRound12_Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound12_Start : TriggerState {
            internal StateRound12_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {112, 212});
                context.CreateMonster(arg1: new[] {1012, 2012}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 1012, script: "$52000052_QD__12_FINDWAY__2$", arg4: 3, arg5: 2);
                context.SetUserValue(triggerId: 912, key: "MobWaveStart", value: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "12RoundSuccess") == 1) {
                    return new StateRound12_Sucess01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound12_Sucess01 : TriggerState {
            internal StateRound12_Sucess01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9012, arg2: new[] {2212})) {
                    return new StateRound12_Sucess02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound12_Sucess02 : TriggerState {
            internal StateRound12_Sucess02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2212, arg2: "MS2PatrolData_2012");
                context.DestroyMonster(arg1: new[] {1012});
                context.CreateMonster(arg1: new[] {113}, arg2: false);
                context.SetMesh(arg1: new[] {3012}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3112}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new[] {3012}, arg2: false, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new[] {3112}, arg2: true, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new[] {5212}, arg2: true);
                context.SetAgent(arg1: new[] {28120, 28121, 28122}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateRound12_RouteSelect(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound12_RouteSelect : TriggerState {
            internal StateRound12_RouteSelect(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {2213, 2212});
                context.CreateMonster(arg1: new[] {213}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 113, script: "$52000052_QD__12_FINDWAY__3$", arg4: 3, arg5: 0);
                context.MoveNpc(arg1: 113, arg2: "MS2PatrolData_199");
                context.MoveNpc(arg1: 213, arg2: "MS2PatrolData_299");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateRound12_RouteApp01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound12_RouteApp01 : TriggerState {
            internal StateRound12_RouteApp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5012}, arg2: true);
                context.SetRandomMesh(arg1: new[] {331200, 331201, 331202, 331203, 331204, 331205, 331206, 331207, 331208, 331209, 331210, 331211, 331212, 331213, 331214, 331215, 331216, 331217, 331218, 331219, 331220, 331221, 331222, 331223, 331224, 331225, 331226, 331227, 331228, 331229, 331230, 331231, 331232, 331233, 331234, 331235, 331236, 331237, 331238, 331239, 331240, 331241, 331242, 331243, 331244, 331245, 331246, 331247, 331248, 331249, 331250, 331251, 331252, 331253, 331254, 331255, 331256, 331257, 331258, 331259, 331260, 331261, 331262, 331263, 331264, 331265, 331266, 331267, 331268, 331269, 331270, 331271, 331272, 331273, 331274, 331275, 331276, 331277}, arg2: true, arg3: 78, arg4: 100, arg5: 30);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateRound12_RouteApp02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound12_RouteApp02 : TriggerState {
            internal StateRound12_RouteApp02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5013}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateRound12_RouteApp03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound12_RouteApp03 : TriggerState {
            internal StateRound12_RouteApp03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4000, arg2: true, arg3: "or_fi_struc_stonegate_A01_on");
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9013, arg2: new[] {213})) {
                    return new StateGoToNextMap01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGoToNextMap01 : TriggerState {
            internal StateGoToNextMap01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {213});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateGoToNextMap02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGoToNextMap02 : TriggerState {
            internal StateGoToNextMap02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {113});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}