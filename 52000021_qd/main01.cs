namespace Maple2.Trigger._52000021_qd {
    public static class _main01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6000, 6100, 6200, 6201, 6202, 6300, 6301, 6400, 6401, 6500, 6600, 6700}, arg2: false);
                context.SetMesh(arg1: new[] {5000, 5001, 5002, 4000, 4001, 4002, 4003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000831}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000832}, arg2: 2);
                context.CreateMonster(arg1: new[] {111, 311}, arg2: true);
                context.MoveNpc(arg1: 311, arg2: "MS2PatrolData_311");
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {60001030}, arg3: new byte[] {1})) {
                    return new StateSetupCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupCinematic : TriggerState {
            internal StateSetupCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {111, 311});
                context.SetTimer(arg1: "1", arg2: 2);
                context.SetMesh(arg1: new[] {5000, 5001, 5002}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {6100}, arg2: true);
                context.CameraSelect(arg1: 600, arg2: true);
                context.CreateMonster(arg1: new[] {101, 201, 301}, arg2: true);
                context.SetEffect(arg1: new[] {6200, 6300, 6201, 6301}, arg2: true);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetCinematicUI(arg1: 4);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateDelay(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }
        }

        private class StateDelay : TriggerState {
            internal StateDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 1);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new StateCameraStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraStartCinematic : TriggerState {
            internal StateCameraStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 6);
                context.CameraSelectPath(arg1: new[] {600, 601, 602}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateIshura대화01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshura대화01 : TriggerState {
            internal StateIshura대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "4", arg2: 5);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000021_QD__MAIN01__0$", arg4: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    return new StateIshura대화02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshura대화02 : TriggerState {
            internal StateIshura대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000021_QD__MAIN01__1$", arg4: 5);
                context.SetInteractObject(arg1: new[] {10000831}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State주문석반응Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State주문석반응Wait : TriggerState {
            internal State주문석반응Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 602, arg2: false);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000831}, arg2: 0)) {
                    return new State보호막설정01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new[] {10000831}, arg2: 2);
                context.SetInteractObject(arg1: new[] {10000832}, arg2: 0);
                context.SetEffect(arg1: new[] {6000}, arg2: true);
                context.SetMesh(arg1: new[] {4000, 4001, 4002, 4003}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }
        }

        private class State보호막설정01 : TriggerState {
            internal State보호막설정01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 1);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelect(arg1: 603, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    return new State목표전달01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State목표전달01 : TriggerState {
            internal State목표전달01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "11", arg2: 4);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000021_QD__MAIN01__2$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11")) {
                    return new State목표전달02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State목표전달02 : TriggerState {
            internal State목표전달02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "12", arg2: 2);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraSelect(arg1: 603, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "12")) {
                    return new StateUserDetection01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateUserDetection01 : TriggerState {
            internal StateUserDetection01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9001})) {
                    return new State탈출경고01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈출경고01 : TriggerState {
            internal State탈출경고01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "20", arg2: 4);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52000021_QD__MAIN01__3$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 301, arg3: "$52000021_QD__MAIN01__4$", arg4: 3, arg5: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "20")) {
                    return new State탈출경고02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈출경고02 : TriggerState {
            internal State탈출경고02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "21", arg2: 4);
                context.SetEffect(arg1: new[] {6400}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 301, arg3: "$52000021_QD__MAIN01__5$", arg4: 3, arg5: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "21")) {
                    return new State탈출경고03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈출경고03 : TriggerState {
            internal State탈출경고03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "22", arg2: 4);
                context.SetConversation(arg1: 1, arg2: 301, arg3: "$52000021_QD__MAIN01__6$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "22")) {
                    return new State탈출경고04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈출경고04 : TriggerState {
            internal State탈출경고04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "25", arg2: 3);
                context.SetEffect(arg1: new[] {6401}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52000021_QD__MAIN01__7$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "25")) {
                    return new State탈출경고05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈출경고05 : TriggerState {
            internal State탈출경고05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "26", arg2: 3);
                context.SetEffect(arg1: new[] {6401}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52000021_QD__MAIN01__8$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "26")) {
                    return new State탈출경고06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈출경고06 : TriggerState {
            internal State탈출경고06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "26", arg2: 3);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52000021_QD__MAIN01__9$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "26")) {
                    return new State탈출가능01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈출가능01 : TriggerState {
            internal State탈출가능01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000832}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000832}, arg2: 0)) {
                    return new State보호막해제01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new[] {10000832}, arg2: 2);
            }
        }

        private class State보호막해제01 : TriggerState {
            internal State보호막해제01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "30", arg2: 1);
                context.SetEffect(arg1: new[] {6000, 6400, 6401}, arg2: false);
                context.SetEffect(arg1: new[] {6202}, arg2: true);
                context.SetMesh(arg1: new[] {4000, 4001, 4002, 4003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelect(arg1: 610, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "30")) {
                    return new State홀슈타트Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {6200, 6201, 6300, 6301, 6100}, arg2: false);
            }
        }

        private class State홀슈타트Cinematic01 : TriggerState {
            internal State홀슈타트Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "31", arg2: 2);
                context.SetEffect(arg1: new[] {6202}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000021_QD__MAIN01__10$", arg4: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "31")) {
                    return new State홀슈타트Cinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State홀슈타트Cinematic02 : TriggerState {
            internal State홀슈타트Cinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "32", arg2: 3);
                context.CameraSelect(arg1: 611, arg2: true);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_201");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9010, arg2: new[] {201})) {
                    return new State홀슈타트Cinematic03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State홀슈타트Cinematic03 : TriggerState {
            internal State홀슈타트Cinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "33", arg2: 1);
                context.SetEffect(arg1: new[] {6700, 6600, 6500}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000021_QD__MAIN01__11$", arg4: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "33")) {
                    return new State홀슈타트Cinematic04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State홀슈타트Cinematic04 : TriggerState {
            internal State홀슈타트Cinematic04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "35", arg2: 1);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_202");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "35")) {
                    return new StateStopCinematicPrepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematicPrepare : TriggerState {
            internal StateStopCinematicPrepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "34", arg2: 2);
                context.SetCinematicUI(arg1: 4);
                context.DestroyMonster(arg1: new[] {201, 101, 301});
                context.CreateMonster(arg1: new[] {111, 311}, arg2: true);
                context.MoveNpc(arg1: 311, arg2: "MS2PatrolData_311");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "34")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(arg1: 4);
            }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraSelect(arg1: 611, arg2: false);
                context.SetAchievement(arg1: 9900, arg2: "trigger", arg3: "EscapeHallstatt");
                context.SetMesh(arg1: new[] {5000, 5001, 5002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}