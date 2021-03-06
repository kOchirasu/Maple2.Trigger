using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52100102_qd {
    public static class _main {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {1000})) {
                    return new StateQuest체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest체크 : TriggerState {
            internal StateQuest체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {1000}, arg2: new[] {50100890}, arg3: new byte[] {3})) {
                    return new StateNPC소환(context);
                }

                if (context.QuestUserDetected(arg1: new[] {1000}, arg2: new[] {50100890}, arg3: new byte[] {2})) {
                    return new StateEndCinematic(context);
                }

                if (context.QuestUserDetected(arg1: new[] {1000}, arg2: new[] {50100890}, arg3: new byte[] {1})) {
                    return new StateEndCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC소환 : TriggerState {
            internal StateNPC소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(isVisible: false);
                context.SetEffect(arg1: new[] {600, 601, 602, 603, 604}, arg2: false);
                context.CreateMonster(arg1: new[] {100, 101, 102, 103, 104, 105, 200, 201, 202, 203, 204, 205, 206}, arg2: false);
                context.SetCinematicUI(type: 1);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {1000})) {
                    return new StateNarration01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNarration01 : TriggerState {
            internal StateNarration01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 9, script: "$52100102_QD__MAIN__0$");
                context.SetSceneSkip(state: new StateEndCinematic(context), arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateNarration02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNarration02 : TriggerState {
            internal StateNarration02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new[] {1, 2}, arg2: false);
                context.ShowCaption(type: CaptionType.Vertical, title: "$52100102_QD__MAIN__1$", script: "$52100102_QD__MAIN__2$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2.5f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State암전1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State암전1 : TriggerState {
            internal State암전1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateCamera무브1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera무브1 : TriggerState {
            internal StateCamera무브1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {3, 4}, arg2: false);
                context.MoveNpc(arg1: 202, arg2: "PatrolData_01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State위협1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State위협1 : TriggerState {
            internal State위협1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 8, arg2: true);
                context.AddCinematicTalk(npcId: 11004429, script: "$52100102_QD__MAIN__3$", duration: 3000, align: Align.Left);
                context.AddCinematicTalk(npcId: 11004429, script: "$52100102_QD__MAIN__4$", duration: 4000, align: Align.Left);
                context.SetNpcEmotionLoop(arg1: 202, arg2: "Bore_A", arg3: 1333f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State위협2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State위협2 : TriggerState {
            internal State위협2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 301, arg2: "Bore_B", arg3: 3667f);
                context.AddCinematicTalk(npcId: 11004426, script: "$52100102_QD__MAIN__5$", duration: 4000, align: Align.Left);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State투르카Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카Spawn : TriggerState {
            internal State투르카Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {6, 7, 9}, arg2: false);
                context.SetEffect(arg1: new[] {600}, arg2: true);
                context.CreateMonster(arg1: new[] {300}, arg2: false);
                context.AddCinematicTalk(npcId: 11004430, script: "$52100102_QD__MAIN__6$", duration: 3000, align: Align.Left);
                context.MoveNpc(arg1: 300, arg2: "PatrolData_Turka_1");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State투르카대사소개(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카대사소개 : TriggerState {
            internal State투르카대사소개(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.ShowCaption(type: CaptionType.Vertical, title: "$52100102_QD__MAIN__7$", script: "$52100102_QD__MAIN__8$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2.5f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State투르카Script1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카Script1 : TriggerState {
            internal State투르카Script1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 300, arg2: "Bore_A", arg3: 5400f);
                context.AddCinematicTalk(npcId: 11004430, script: "$52100102_QD__MAIN__9$", duration: 5000, align: Align.Left);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State검은군단물러서기_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검은군단물러서기_1 : TriggerState {
            internal State검은군단물러서기_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {600}, arg2: false);
                context.CameraSelect(arg1: 10, arg2: true);
                context.SetNpcRotation(arg1: 202, arg2: 180);
                context.AddCinematicTalk(npcId: 11004429, script: "$52100102_QD__MAIN__10$", duration: 2000, align: Align.Left);
                context.SetNpcRotation(arg1: 200, arg2: 225);
                context.SetNpcRotation(arg1: 201, arg2: 180);
                context.SetNpcRotation(arg1: 205, arg2: 225);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State검은군단돌아보기_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검은군단돌아보기_1 : TriggerState {
            internal State검은군단돌아보기_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcRotation(arg1: 203, arg2: 180);
                context.SetNpcRotation(arg1: 204, arg2: 135);
                context.SetNpcRotation(arg1: 206, arg2: 135);
                context.AddCinematicTalk(npcId: 11004430, script: "$52100102_QD__MAIN__11$", duration: 3000, align: Align.Left);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State검은군단물러서기_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검은군단물러서기_2 : TriggerState {
            internal State검은군단물러서기_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 300, arg2: "PatrolData_Turka_2");
                context.MoveNpc(arg1: 201, arg2: "PatrolData_back_201");
                context.MoveNpc(arg1: 202, arg2: "PatrolData_back_202");
                context.MoveNpc(arg1: 205, arg2: "PatrolData_back_205");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new State검은군단물러서기_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검은군단물러서기_3 : TriggerState {
            internal State검은군단물러서기_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 200, arg2: "PatrolData_back_200");
                context.MoveNpc(arg1: 204, arg2: "PatrolData_Back_204");
                context.MoveNpc(arg1: 206, arg2: "PatrolData_back_206");
                context.MoveNpc(arg1: 203, arg2: "PatrolData_back_203");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State검은군단소멸시키기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검은군단소멸시키기 : TriggerState {
            internal State검은군단소멸시키기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {200, 201, 202, 203, 204, 205, 206});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateCamera전환_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera전환_1 : TriggerState {
            internal StateCamera전환_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {300});
                context.CreateMonster(arg1: new[] {301}, arg2: false);
                context.CameraSelect(arg1: 11, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State투르카이동_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카이동_1 : TriggerState {
            internal State투르카이동_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 301, arg2: "PatrolData_Turka_2");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State게오르크장교대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게오르크장교대사 : TriggerState {
            internal State게오르크장교대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004426, script: "$52100102_QD__MAIN__12$", duration: 5000, align: Align.Left);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State투르카공격11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카공격11 : TriggerState {
            internal State투르카공격11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004430, script: "$52100102_QD__MAIN__13$", duration: 3000, align: Align.Left);
                context.SetNpcEmotionLoop(arg1: 301, arg2: "Bore_B", arg3: 3667f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State투르카공격12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카공격12 : TriggerState {
            internal State투르카공격12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 301, arg2: "PatrolData_Turka_Attack");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new State투르카공격13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카공격13 : TriggerState {
            internal State투르카공격13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 301, arg2: "Attack_01_B", arg3: 600f);
                context.SetEffect(arg1: new[] {601}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 600)) {
                    return new State투르카공격14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카공격14 : TriggerState {
            internal State투르카공격14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {11, 12}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 301, arg2: "Attack_02_B", arg3: 1400f);
                context.SetEffect(arg1: new[] {602, 603}, arg2: true);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Dead_A", arg3: 1333f);
                context.SetNpcEmotionLoop(arg1: 103, arg2: "Dead_A", arg3: 1333f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State투르카공격Camera(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카공격Camera : TriggerState {
            internal State투르카공격Camera(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 103});
                context.AddCinematicTalk(npcId: 11004425, script: "$52100102_QD__MAIN__14$", duration: 1000, align: Align.Left);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State투르카질문_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카질문_1 : TriggerState {
            internal State투르카질문_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {107});
                context.CreateMonster(arg1: new[] {108});
                context.CameraSelect(arg1: 13, arg2: true);
                context.AddCinematicTalk(npcId: 11004426, script: "$52100102_QD__MAIN__15$", duration: 3000, align: Align.Left);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State투르카질문_21(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카질문_21 : TriggerState {
            internal State투르카질문_21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 301, arg2: "Bore_B", arg3: 3667f);
                context.AddCinematicTalk(npcId: 11004430, script: "$52100102_QD__MAIN__16$", duration: 5000, align: Align.Left);
                context.AddCinematicTalk(npcId: 11004426, script: "$52100102_QD__MAIN__17$", duration: 3000, align: Align.Left);
                context.AddCinematicTalk(npcId: 11004430, script: "$52100102_QD__MAIN__18$", duration: 5000, align: Align.Left);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State투르카공격21(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카공격21 : TriggerState {
            internal State투르카공격21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 301, arg2: "Attack_01_B", arg3: 600f);
                context.SetEffect(arg1: new[] {601}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 600)) {
                    return new State투르카공격22(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카공격22 : TriggerState {
            internal State투르카공격22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 100, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_3sec.xml");
                context.CameraSelect(arg1: 14, arg2: true);
                context.SetTimeScale(enable: true, startScale: 0.3f, endScale: 1f, duration: 30f, interpolator: 1);
                context.SetNpcEmotionLoop(arg1: 301, arg2: "Attack_02_B", arg3: 1400f);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Dead_A", arg3: 1333f);
                context.AddCinematicTalk(npcId: 11004426, script: "$52100102_QD__MAIN__19$", duration: 1500, align: Align.Left);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State상황정리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State상황정리 : TriggerState {
            internal State상황정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimeScale(enable: false, startScale: 0.3f, endScale: 1f, duration: 50f, interpolator: 1);
                context.DestroyMonster(arg1: new[] {102, 103, 107, 108});
                context.CreateMonster(arg1: new[] {109});
                context.CreateMonster(arg1: new[] {110});
                context.CreateMonster(arg1: new[] {111});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State엔딩Camera1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔딩Camera1 : TriggerState {
            internal State엔딩Camera1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {301});
                context.CreateMonster(arg1: new[] {302});
                context.SetOnetimeEffect(id: 100, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_3sec.xml");
                context.CameraSelectPath(pathIds: new[] {15, 16}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State투르카엔딩Script_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카엔딩Script_1 : TriggerState {
            internal State투르카엔딩Script_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 17, arg2: true);
                context.MoveNpc(arg1: 302, arg2: "PatrolData_Turka_End_Move");
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.AddCinematicTalk(npcId: 11004430, script: "$52100102_QD__MAIN__20$", duration: 5000, align: Align.Left);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State엔딩암전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔딩암전 : TriggerState {
            internal State엔딩암전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 101, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEndCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndCinematic : TriggerState {
            internal StateEndCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {-1}, arg2: false);
                context.SetSkip();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.VisibleMyPc(isVisible: true);
                context.SetOnetimeEffect(id: 101, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(arg1: 02020029, arg2: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    // return new State(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}