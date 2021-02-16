namespace Maple2.Trigger._52000013_qd {
    public static class _patrol {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetActor(arg1: 6000, arg2: false, arg3: "Idle_A");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    return new State어린벨라Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어린벨라Spawn : TriggerState {
            internal State어린벨라Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "10", arg2: 1);
                context.CreateMonster(arg1: new[] {5000}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    return new State어린벨라패트롤01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어린벨라패트롤01 : TriggerState {
            internal State어린벨라패트롤01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 5000, arg2: "MS2PatrolData_1001");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9001, arg2: new[] {5000})) {
                    return new State어린벨라대화01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어린벨라대화01 : TriggerState {
            internal State어린벨라대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "11", arg2: 3);
                context.SetConversation(arg1: 1, arg2: 5000, script: "$52000013_QD__MAIN__1$", arg4: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11")) {
                    return new State어린벨라패트롤02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어린벨라패트롤02 : TriggerState {
            internal State어린벨라패트롤02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 5000, arg2: "MS2PatrolData_1002");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9002, arg2: new[] {5000})) {
                    return new State어린벨라대화02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어린벨라대화02 : TriggerState {
            internal State어린벨라대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "12", arg2: 3);
                context.SetConversation(arg1: 1, arg2: 5000, script: "$52000013_QD__MAIN__2$", arg4: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "12")) {
                    return new State어린벨라패트롤03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어린벨라패트롤03 : TriggerState {
            internal State어린벨라패트롤03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 5000, arg2: "MS2PatrolData_1003");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9003, arg2: new[] {5000})) {
                    return new StateCameraCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraCinematic01 : TriggerState {
            internal StateCameraCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetTimer(id: "12", arg2: 6);
                context.CameraSelectPath(pathIds: new[] {901}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9004, arg2: new[] {5000})) {
                    return new StateCameraCinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraCinematic02 : TriggerState {
            internal StateCameraCinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "13", arg2: 12);
                context.SetActor(arg1: 6000, arg2: true, arg3: "Idle_A");
                context.CameraSelectPath(pathIds: new[] {902, 903}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "13")) {
                    return new State화면끄기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State화면끄기 : TriggerState {
            internal State화면끄기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "14", arg2: 2);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "14")) {
                    return new State어린벨라소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어린벨라소멸 : TriggerState {
            internal State어린벨라소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "15", arg2: 1);
                context.DestroyMonster(arg1: new[] {5000});
                context.SetActor(arg1: 6000, arg2: false, arg3: "Idle_A");
                context.CreateMonster(arg1: new[] {6001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "15")) {
                    return new State벨라Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라Cinematic01 : TriggerState {
            internal State벨라Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "16", arg2: 8);
                context.SetCinematicUI(type: 4);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveNpc(arg1: 6001, arg2: "MS2PatrolData_2001");
                context.CameraSelectPath(pathIds: new[] {904, 905}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "16")) {
                    return new State벨라StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라StopCinematic : TriggerState {
            internal State벨라StopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "17", arg2: 8);
                context.CameraSelect(arg1: 905, arg2: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "17")) {
                    return new State이동Delay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동Delay : TriggerState {
            internal State이동Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {10000}, arg2: new[] {10002611}, arg3: new byte[] {3})) {
                    return new State강제이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State강제이동 : TriggerState {
            internal State강제이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "19", arg2: 10);
                context.MoveUser(arg1: 03009017, arg2: 50);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "19")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "20", arg2: 10);
                context.DestroyMonster(arg1: new[] {6001});
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "20")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}