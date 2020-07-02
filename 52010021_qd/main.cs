namespace Maple2.Trigger._52010021_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7001}, arg2: false);
                context.CreateMonster(arg1: new[] {101, 102, 103});
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002540}, arg3: new byte[] {3})) {
                    return new StateEvent_01_Idle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_01_Idle : TriggerState {
            internal StateEvent_01_Idle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveUser(arg1: 52010021, arg2: 3, arg3: 701);
                context.SetTimer(arg1: "2", arg2: 2);
                context.SetEffect(arg1: new[] {7001}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new StateEvent_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_01 : TriggerState {
            internal StateEvent_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.CreateMonster(arg1: new[] {104});
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_2001");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2002");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2004");
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_2003");
                context.CameraSelect(arg1: 8001, arg2: true);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateEvent_05(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CameraSelect(arg1: 8001, arg2: true);
            }
        }

        private class StateEvent_05 : TriggerState {
            internal StateEvent_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001285, arg3: "$52010021_QD__MAIN__0$", arg4: 4);
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateEnding(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding : TriggerState {
            internal StateEnding(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8001, 8002}, arg2: false);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2012");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2014");
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_2013");
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateOut(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 4);
            }
        }

        private class StateOut : TriggerState {
            internal StateOut(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 9, arg2: "$52010021_QD__MAIN__1$", arg3: true);
            }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateReal_end2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 9, arg2: "$52010021_QD__MAIN__2$", arg3: true);
                context.PlaySystemSoundInBox(arg2: "System_Laugh_01");
            }
        }

        private class StateReal_end2 : TriggerState {
            internal StateReal_end2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "4", arg2: 4);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    return new StateReal_end3(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 9, arg2: "$52010021_QD__MAIN__3$", arg3: true);
            }
        }

        private class StateReal_end3 : TriggerState {
            internal StateReal_end3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateReal_end4(context);
                }

                return null;
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(arg2: "System_Burp_01");
            }
        }

        private class StateReal_end4 : TriggerState {
            internal StateReal_end4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateReal_end(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReal_end : TriggerState {
            internal StateReal_end(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "mikaEpilogueEnd");
                context.MoveUser(arg1: 02010002, arg2: 1, arg3: 701);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}