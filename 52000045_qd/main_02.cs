namespace Maple2.Trigger._52000045_qd {
    public static class _main_02 {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {701}, arg2: 100)) {
                    context.SetActor(arg1: 5001, arg2: false, arg3: "Idle_A");
                    context.SetActor(arg1: 5002, arg2: false, arg3: "Idle_A");
                    context.SetActor(arg1: 5003, arg2: false, arg3: "Idle_A");
                    return new StateReady_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady_02 : TriggerState {
            internal StateReady_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000045, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {902}, arg2: false);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.MoveUserPath(arg1: "MS2PatrolData_2010");
                context.CameraSelectPath(arg1: new[] {8004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02 : TriggerState {
            internal StateStart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 902, arg2: "MS2PatrolData_2004");
                context.MoveUserPath(arg1: "MS2PatrolData_2003");
                context.CameraSelectPath(arg1: new[] {8010}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateSetup_userscript01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup_userscript01 : TriggerState {
            internal StateSetup_userscript01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000045_QD__MAIN_02__0$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStart_A_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_A_03 : TriggerState {
            internal StateStart_A_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8010, 8013}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000045_QD__MAIN_02__3$", arg4: 3);
                context.SetConversation(arg1: 1, arg2: 902, arg3: "$52000045_QD__MAIN_02__4$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStart_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_03 : TriggerState {
            internal StateStart_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 902, arg3: "$52000045_QD__MAIN_02__1$", arg4: 3, arg5: 1);
                context.SetNpcEmotionLoop(arg1: 902, arg2: "Talk_A", arg3: 3000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_04 : TriggerState {
            internal StateStart_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7003}, arg2: true);
                context.CreateMonster(arg1: new[] {887, 886, 888}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 902, arg3: "$52000045_QD__MAIN_02__5$", arg4: 1, arg5: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateStart_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_05 : TriggerState {
            internal StateStart_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8014}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000045_QD__MAIN_02__6$", arg4: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2200)) {
                    return new StateStart_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_06 : TriggerState {
            internal StateStart_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Down2_A,Down_Idle_A,Down_Idle_A,Down_Idle_A,Down_Idle_A,Down_Idle_A");
                context.SetEffect(arg1: new[] {7005, 7004}, arg2: true);
                context.CreateMonster(arg1: new[] {872, 873}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2050)) {
                    return new StateStart_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_07 : TriggerState {
            internal StateStart_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8014, 8015}, arg2: false);
                context.CreateMonster(arg1: new[] {871, 876}, arg2: false);
                context.SetPcEmotionLoop(arg1: "Down_Idle_A", arg2: 80000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 900)) {
                    return new StateStart_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_08 : TriggerState {
            internal StateStart_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {872, 875, 871, 876}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStart_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_09 : TriggerState {
            internal StateStart_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7005}, arg2: false);
                context.CreateMonster(arg1: new[] {874, 873, 872}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateStart_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_10 : TriggerState {
            internal StateStart_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "InvestgatedScretroom");
                context.MoveUser(arg1: 52000046, arg2: 1);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}