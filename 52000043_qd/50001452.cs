namespace Maple2.Trigger._52000043_qd {
    public static class _50001452 {
        public class State선행Quest체크 : TriggerState {
            internal State선행Quest체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001017, 10001018, 10001019, 10001020, 10001021}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001451}, arg3: new byte[] {3})) {
                    context.DestroyMonster(arg1: new[] {1001, 2001});
                    return new StateStart조건(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart조건 : TriggerState {
            internal StateStart조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1001, 2001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001452}, arg3: new byte[] {1})) {
                    return new StateStartCinematic(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001452}, arg3: new byte[] {2})) {
                    context.DestroyMonster(arg1: new[] {1003, 2003});
                    return new StateNPC만배치(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001452}, arg3: new byte[] {3})) {
                    context.DestroyMonster(arg1: new[] {1003, 2003});
                    return new StateNPC만배치(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC만배치 : TriggerState {
            internal StateNPC만배치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1001, 2001});
                context.CreateMonster(arg1: new[] {1003, 2003}, arg2: false);
                context.SetMesh(arg1: new[] {3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001454}, arg3: new byte[] {2})) {
                    context.DestroyMonster(arg1: new[] {1003, 2003});
                    return new StateEnd(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001454}, arg3: new byte[] {3})) {
                    context.DestroyMonster(arg1: new[] {1003, 2003});
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1001, 2001});
                context.CreateMonster(arg1: new[] {1002, 2002}, arg2: false);
                context.SetMesh(arg1: new[] {3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.CameraSelect(arg1: 304, arg2: true);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateNPC이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동01 : TriggerState {
            internal StateNPC이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002A");
                context.MoveNpc(arg1: 2002, arg2: "MS2PatrolData_2002A");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 101, arg2: new[] {2002})) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 304, arg2: false);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002B");
                context.MoveNpc(arg1: 2002, arg2: "MS2PatrolData_2002B");
                context.SetInteractObject(arg1: new[] {10001017, 10001018, 10001019}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001019}, arg2: 0)) {
                    return new State부서짐Cinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부서짐Cinematic : TriggerState {
            internal State부서짐Cinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001017, 10001018}, arg2: 2);
                context.SetInteractObject(arg1: new[] {10001020}, arg2: 1);
                context.SetMesh(arg1: new[] {3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017}, arg2: false, arg3: 0, arg4: 200, arg5: 2f);
                context.CameraSelect(arg1: 306, arg2: true);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetSkip(state: new State향로반응Wait(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State향로반응Wait(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CameraSelect(arg1: 306, arg2: false);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }
        }

        private class State향로반응Wait : TriggerState {
            internal State향로반응Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001452}, arg3: new byte[] {2})) {
                    return new StateNPC이동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동02 : TriggerState {
            internal StateNPC이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002C");
                context.MoveNpc(arg1: 2002, arg2: "MS2PatrolData_2002C");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 102, arg2: new[] {1002})) {
                    return new StateNPC교체01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC교체01 : TriggerState {
            internal StateNPC교체01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1002});
                context.CreateMonster(arg1: new[] {1003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 103, arg2: new[] {2002})) {
                    return new StateNPC교체02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC교체02 : TriggerState {
            internal StateNPC교체02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {2002});
                context.CreateMonster(arg1: new[] {2003}, arg2: false);
            }

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

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}