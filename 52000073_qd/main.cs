using System.Numerics;

namespace Maple2.Trigger._52000073_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {60100115}, arg3: new byte[] {1})) {
                    return new State레논Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레논Spawn : TriggerState {
            internal State레논Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG\weather\Eff_monochrome_03.xml");
                context.SetSound(arg1: 7001, arg2: true);
                context.DestroyMonster(arg1: new[] {101});
                context.VisibleMyPc(isVisible: false);
                context.SetAmbientLight(arg1: new Vector3(0f, 0f, 0f));
                context.SetAmbientLight(arg1: new Vector3(1f, 1f, 1f));
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CreateMonster(arg1: new[] {302});
                context.CreateMonster(arg1: new[] {301});
                context.CameraSelectPath(arg1: new[] {8001, 8002}, arg2: false);
                context.SetSceneSkip(state: new State다크윈드통로(context), arg2: "exit");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State계단이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State계단이동 : TriggerState {
            internal State계단이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8003, 8004}, arg2: false);
                context.MoveNpc(arg1: 301, arg2: "MS2PatrolData_2001");
                context.SetConversation(arg1: 1, arg2: 301, arg3: "$52000073_QD__MAIN__0$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State시체발견(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시체발견 : TriggerState {
            internal State시체발견(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 301, arg3: "$52000073_QD__MAIN__1$", arg4: 2, arg5: 0);
                context.MoveNpc(arg1: 301, arg2: "MS2PatrolData_2002");
                context.CameraSelectPath(arg1: new[] {8005}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State의문(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State의문 : TriggerState {
            internal State의문(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 301, arg3: "$52000073_QD__MAIN__2$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State상황파악(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State상황파악 : TriggerState {
            internal State상황파악(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 7002, arg2: true);
                context.CameraSelectPath(arg1: new[] {8006}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 301, arg3: "$52000073_QD__MAIN__3$", arg4: 3, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 301, arg2: "Sit_down_A", arg3: 5000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State현장목격(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State현장목격 : TriggerState {
            internal State현장목격(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8007}, arg2: false);
                context.CreateMonster(arg1: new[] {303});
                context.CreateMonster(arg1: new[] {304});
                context.SetConversation(arg1: 1, arg2: 303, arg3: "$52000073_QD__MAIN__4$", arg4: 3, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 303, arg2: "Attack_Idle_A", arg3: 1500f);
                context.SetNpcEmotionLoop(arg1: 304, arg2: "Attack_Idle_A", arg3: 1500f);
                context.MoveNpc(arg1: 301, arg2: "MS2PatrolData_2005");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State오해1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오해1 : TriggerState {
            internal State오해1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 303, arg3: "$52000073_QD__MAIN__5$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 304, arg3: "$52000073_QD__MAIN__6$", arg4: 3, arg5: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State오해2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오해2 : TriggerState {
            internal State오해2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 303, arg3: "$52000073_QD__MAIN__7$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 301, arg3: "$52000073_QD__MAIN__8$", arg4: 3, arg5: 1);
                context.SetNpcEmotionLoop(arg1: 303, arg2: "Attack_01_A", arg3: 2000f);
                context.SetNpcEmotionLoop(arg1: 301, arg2: "Talk_A", arg3: 3000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State오해3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오해3 : TriggerState {
            internal State오해3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 303, arg3: "$52000073_QD__MAIN__9$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 304, arg3: "$52000073_QD__MAIN__10$", arg4: 3, arg5: 2);
                context.MoveNpc(arg1: 303, arg2: "MS2PatrolData_2003");
                context.MoveNpc(arg1: 304, arg2: "MS2PatrolData_2004");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State오해4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오해4 : TriggerState {
            internal State오해4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 303, arg2: "Attack_Idle_A", arg3: 5000f);
                context.SetConversation(arg1: 1, arg2: 303, arg3: "$52000073_QD__MAIN__11$", arg4: 3, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 304, arg2: "Attack_Idle_A", arg3: 5000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State오해5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오해5 : TriggerState {
            internal State오해5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 301, arg3: "$52000073_QD__MAIN__12$", arg4: 5, arg5: 0);
                context.MoveNpc(arg1: 301, arg2: "MS2PatrolData_2006");
                context.SetNpcEmotionLoop(arg1: 303, arg2: "Attack_Idle_A", arg3: 6000f);
                context.SetNpcEmotionLoop(arg1: 304, arg2: "Attack_Idle_A", arg3: 6000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State쓰러짐(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쓰러짐 : TriggerState {
            internal State쓰러짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 303, arg2: "Down_Idle_A", arg3: 500000f);
                context.SetNpcEmotionLoop(arg1: 304, arg2: "Down_Idle_A", arg3: 500000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State탈출(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈출 : TriggerState {
            internal State탈출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 301, arg2: "MS2PatrolData_2007");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State레논탈출(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레논탈출 : TriggerState {
            internal State레논탈출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {301});
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCamera시점변경_ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera시점변경_ready : TriggerState {
            internal StateCamera시점변경_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCamera시점변경(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera시점변경 : TriggerState {
            internal StateCamera시점변경(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(arg1: new[] {8008}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State카트반Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카트반Spawn : TriggerState {
            internal State카트반Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {305});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State카트반이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카트반이동 : TriggerState {
            internal State카트반이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 305, arg2: "MS2PatrolData_2008");
                context.SetConversation(arg1: 1, arg2: 305, arg3: "$52000073_QD__MAIN__13$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State의미심장(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State의미심장 : TriggerState {
            internal State의미심장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcId: 11001024, msg: "$52000073_QD__MAIN__14$", duration: 3000, align: "center");
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State다크윈드통로(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다크윈드통로 : TriggerState {
            internal State다크윈드통로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(isVisible: true);
                context.CreateMonster(arg1: new[] {101});
                context.DestroyMonster(arg1: new[] {301, 302, 303, 304, 305});
                context.SetCinematicUI(arg1: 2);
                context.MoveUser(arg1: 52000138, arg2: 0);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}