namespace Maple2.Trigger._52010017_qd {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 401, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 402, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 403, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 404, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 405, arg2: false, arg3: false, arg4: 0);
                context.CreateMonster(arg1: new[] {1001}, arg2: false);
                context.SetMesh(arg1: new[] {3001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3003}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3005}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3006}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3007}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3008}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {102}, arg2: new[] {10002851}, arg3: new byte[] {1})) {
                    context.CreateMonster(arg1: new[] {1002, 1003, 1004}, arg2: false);
                    context.CreateMonster(arg1: new[] {2001}, arg2: true);
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
                context.CameraSelect(arg1: 301, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State미카Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미카Script01 : TriggerState {
            internal State미카Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1001});
                context.CreateMonster(arg1: new[] {1005}, arg2: false);
                context.MoveNpc(arg1: 1005, arg2: "MS2PatrolData_1005");
                context.SetLadder(arg1: 401, arg2: true, arg3: true, arg4: 0);
                context.SetLadder(arg1: 402, arg2: true, arg3: true, arg4: 0);
                context.SetLadder(arg1: 403, arg2: true, arg3: true, arg4: 0);
                context.SetLadder(arg1: 404, arg2: true, arg3: true, arg4: 0);
                context.SetLadder(arg1: 405, arg2: true, arg3: true, arg4: 0);
                context.SetConversation(arg1: 2, arg2: 11001285, script: "$52010017_QD__MAIN__0$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State체크포인트01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State체크포인트01 : TriggerState {
            internal State체크포인트01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(arg1: 301, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.CreateMonster(arg1: new[] {2002}, arg2: true);
                    return new StateCameraCinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraCinematic02 : TriggerState {
            internal StateCameraCinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(arg1: 302, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State미카Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미카Script02 : TriggerState {
            internal State미카Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001285, script: "$52010017_QD__MAIN__1$", arg4: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.CameraSelect(arg1: 302, arg2: false);
                    return new State체크포인트02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State체크포인트02 : TriggerState {
            internal State체크포인트02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002_A");
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003_A");
                context.MoveNpc(arg1: 1004, arg2: "MS2PatrolData_1004_A");
                context.MoveNpc(arg1: 1005, arg2: "MS2PatrolData_1005_A");
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2002})) {
                    return new State미키이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미키이동01 : TriggerState {
            internal State미키이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1005, arg2: "MS2PatrolData_1005_A2");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 103, arg2: new[] {1005})) {
                    return new State오브젝트01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오브젝트01 : TriggerState {
            internal State오브젝트01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetMesh(arg1: new[] {3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(arg1: new[] {3002}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateCameraCinematic03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraCinematic03 : TriggerState {
            internal StateCameraCinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State타라Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State타라Script01 : TriggerState {
            internal State타라Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001218, script: "$52010017_QD__MAIN__2$", arg4: 2);
                context.CameraSelect(arg1: 303, arg2: true);
                context.CreateMonster(arg1: new[] {2003}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State체크포인트03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State체크포인트03 : TriggerState {
            internal State체크포인트03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(arg1: 303, arg2: false);
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002_B");
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003_B");
                context.MoveNpc(arg1: 1004, arg2: "MS2PatrolData_1004_B");
                context.MoveNpc(arg1: 1005, arg2: "MS2PatrolData_1005_B");
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2003})) {
                    return new State미키이동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미키이동02 : TriggerState {
            internal State미키이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1005, arg2: "MS2PatrolData_1005_B2");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 104, arg2: new[] {1005})) {
                    return new State오브젝트02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오브젝트02 : TriggerState {
            internal State오브젝트02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetMesh(arg1: new[] {3003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(arg1: new[] {3004}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateCameraCinematic04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraCinematic04 : TriggerState {
            internal StateCameraCinematic04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State둔바Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State둔바Script01 : TriggerState {
            internal State둔바Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 304, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001217, script: "$52010017_QD__MAIN__3$", arg4: 2);
                context.CreateMonster(arg1: new[] {2004}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State체크포인트04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State체크포인트04 : TriggerState {
            internal State체크포인트04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(arg1: 304, arg2: false);
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002_C");
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003_C");
                context.MoveNpc(arg1: 1004, arg2: "MS2PatrolData_1004_C");
                context.MoveNpc(arg1: 1005, arg2: "MS2PatrolData_1005_C");
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2004})) {
                    return new State미키이동03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미키이동03 : TriggerState {
            internal State미키이동03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1005, arg2: "MS2PatrolData_1005_C2");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 105, arg2: new[] {1005})) {
                    return new State오브젝트03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오브젝트03 : TriggerState {
            internal State오브젝트03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetMesh(arg1: new[] {3005}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(arg1: new[] {3006}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateCameraCinematic05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraCinematic05 : TriggerState {
            internal StateCameraCinematic05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State스타츠Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스타츠Script01 : TriggerState {
            internal State스타츠Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 305, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001292, script: "$52010017_QD__MAIN__4$", arg4: 2);
                context.CreateMonster(arg1: new[] {2005}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State체크포인트05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State체크포인트05 : TriggerState {
            internal State체크포인트05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(arg1: 305, arg2: false);
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002_D");
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003_D");
                context.MoveNpc(arg1: 1004, arg2: "MS2PatrolData_1004_D");
                context.MoveNpc(arg1: 1005, arg2: "MS2PatrolData_1005_D");
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2005})) {
                    return new State미키이동04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미키이동04 : TriggerState {
            internal State미키이동04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1005, arg2: "MS2PatrolData_1005_D2");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 106, arg2: new[] {1005})) {
                    return new State오브젝트04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오브젝트04 : TriggerState {
            internal State오브젝트04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetMesh(arg1: new[] {3007}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(arg1: new[] {3008}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateCameraCinematic06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraCinematic06 : TriggerState {
            internal StateCameraCinematic06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1005, arg2: "MS2PatrolData_1005_D3");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State미카Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미카Script03 : TriggerState {
            internal State미카Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001285, script: "$52010017_QD__MAIN__5$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State미카Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미카Script04 : TriggerState {
            internal State미카Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001285, script: "$52010017_QD__MAIN__6$", arg4: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State이동Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동Wait : TriggerState {
            internal State이동Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetAchievement(arg1: 110, arg2: "trigger", arg3: "Getalllamestone");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.MoveUser(arg1: 02010034, arg2: 3, arg3: 110);
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