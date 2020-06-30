using System;

namespace Maple2.Trigger._52020005_qd {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101, 102}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9000")) {
                    context.State = new State퀘스트조건체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트조건체크 : TriggerState {
            internal State퀘스트조건체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001773},
                    arg3: new byte[] {3})) {
                    context.State = new State빈방(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001773},
                    arg3: new byte[] {2})) {
                    context.State = new State빈방(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001773},
                    arg3: new byte[] {1})) {
                    context.State = new StatePC내보내기연출_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001772},
                    arg3: new byte[] {3})) {
                    context.State = new State기본_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001772},
                    arg3: new byte[] {2})) {
                    context.State = new State기본_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001772},
                    arg3: new byte[] {1})) {
                    context.State = new State기본_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001771},
                    arg3: new byte[] {3})) {
                    context.State = new State기본_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001771},
                    arg3: new byte[] {2})) {
                    context.State = new State기본_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001771},
                    arg3: new byte[] {1})) {
                    context.State = new State기본_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001770},
                    arg3: new byte[] {3})) {
                    context.State = new State기본_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001770},
                    arg3: new byte[] {2})) {
                    context.State = new State기본_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001770},
                    arg3: new byte[] {1})) {
                    context.State = new State기본_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001763},
                    arg3: new byte[] {3})) {
                    context.State = new State기본_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001763},
                    arg3: new byte[] {2})) {
                    context.State = new State첫만남_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001763},
                    arg3: new byte[] {1})) {
                    context.State = new State돌아가_대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State기본 : TriggerState {
            internal State기본(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State돌아가_대기 : TriggerState {
            internal State돌아가_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001773},
                    arg3: new byte[] {1})) {
                    context.State = new State지하피난처로돌아가(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001773},
                    arg3: new byte[] {1})) {
                    context.State = new State퀘스트조건체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State지하피난처로돌아가 : TriggerState {
            internal State지하피난처로돌아가(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52020004, arg2: 1);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State지하피난처로돌아가(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State첫만남_대기 : TriggerState {
            internal State첫만남_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001763},
                    arg3: new byte[] {2})) {
                    context.State = new State첫만남_연출시작(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001773},
                    arg3: new byte[] {1})) {
                    context.State = new State퀘스트조건체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State기본_대기 : TriggerState {
            internal State기본_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001773},
                    arg3: new byte[] {3})) {
                    context.State = new State빈방(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001773},
                    arg3: new byte[] {2})) {
                    context.State = new State빈방(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001773},
                    arg3: new byte[] {1})) {
                    context.State = new StatePC내보내기연출_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001763},
                    arg3: new byte[] {3})) {
                    context.State = new State조건확인_대기01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001763},
                    arg3: new byte[] {2})) {
                    context.State = new State조건확인_대기01(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001773},
                    arg3: new byte[] {1})) {
                    context.State = new State퀘스트조건체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State조건확인_대기01 : TriggerState {
            internal State조건확인_대기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001773},
                    arg3: new byte[] {1})) {
                    context.State = new StatePC내보내기연출_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001763},
                    arg3: new byte[] {3})) {
                    context.State = new State조건확인_대기02(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001763},
                    arg3: new byte[] {2})) {
                    context.State = new State조건확인_대기02(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001773},
                    arg3: new byte[] {1})) {
                    context.State = new State조건확인_대기02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State조건확인_대기02 : TriggerState {
            internal State조건확인_대기02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001773},
                    arg3: new byte[] {1})) {
                    context.State = new StatePC내보내기연출_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001763},
                    arg3: new byte[] {3})) {
                    context.State = new State조건확인_대기01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001763},
                    arg3: new byte[] {2})) {
                    context.State = new State조건확인_대기01(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001773},
                    arg3: new byte[] {1})) {
                    context.State = new State조건확인_대기01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State빈방 : TriggerState {
            internal State빈방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {101, 102});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State첫만남_연출시작 : TriggerState {
            internal State첫만남_연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State일어나00(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State일어나00 : TriggerState {
            internal State일어나00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52020005, arg2: 10);
                context.SetSceneSkip(arg1: "일어나_스킵완료", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State일어나01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State일어나01 : TriggerState {
            internal State일어나01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003667, illustID: "Krantz_normal", msg: @"이봐. 눈을 떠 봐.\n정신이 드나?",
                    duration: 2000);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Talk_A", arg3: 3000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State일어나02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State일어나02 : TriggerState {
            internal State일어나02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003572, illustID: "Eone_normal", msg: "흠, 부상은 크지 않은 것 같은데.",
                    duration: 3000);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 3000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State일어나03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State일어나03 : TriggerState {
            internal State일어나03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003667, illustID: "Krantz_normal",
                    msg: @"그렇다면, 빠르게 정신이 들도록…\n(스르릉, 하고 들려오는 이 소리는… 검을 뽑는 소리…?)", duration: 3000);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Talk_A", arg3: 3000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State일어나04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State일어나04 : TriggerState {
            internal State일어나04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003572, illustID: "Eone_normal",
                    msg: "그 검으로 찌르면 정신이 들자마자 저 세상으로 가고 말걸.", duration: 3000);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 3000f);
                context.SetPcEmotionLoop(arg1: "Emotion_Sleep_Idle_A", arg2: 5000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State일어나05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State일어나05 : TriggerState {
            internal State일어나05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcID: 11003667, illustID: "Krantz_normal",
                    msg: @"이 자의 운명이라면 받아들여야 할 터…. \n그것이 세상의 아름다운 섭리입니다.", duration: 3000);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Talk_A", arg3: 3000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State일어나06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State일어나06 : TriggerState {
            internal State일어나06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 0, msg: "(빨리 일어나지 않으면 목숨이 위험할 것 같다. 어서 일어나자.)", duration: 2000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State일어나07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State일어나07 : TriggerState {
            internal State일어나07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8000}, arg2: 0);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcID: 11003572, illustID: "Eone_normal", msg: "…눈을 떴군.", duration: 2000);
                context.SetPcEmotionLoop(arg1: "Emotion_Surprise_A", arg2: 3000f);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 3000f);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State일어나_연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State일어나_스킵완료 : TriggerState {
            internal State일어나_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State일어나_연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State일어나_연출종료 : TriggerState {
            internal State일어나_연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State조건확인_대기01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC내보내기연출_대기 : TriggerState {
            internal StatePC내보내기연출_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveUser(arg1: 52020005, arg2: 10);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(arg1: "PC퇴장_스킵완료", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePC내보내기연출_시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC내보내기연출_시작 : TriggerState {
            internal StatePC내보내기연출_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8000}, arg2: 0);
                context.MoveUserPath(arg1: "MS2PatrolData_PC_Walkout");
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State공주와기사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State공주와기사01 : TriggerState {
            internal State공주와기사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003572, illustID: "Eone_normal", msg: "이 연출은 제작 중이다. ",
                    duration: 3000);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_Krantz_walking");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State공주와기사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State공주와기사02 : TriggerState {
            internal State공주와기사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8001}, arg2: 0);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_Eone");
                context.AddCinematicTalk(npcID: 11003667, illustID: "Krantz_normal", msg: "그렇다. 제작 중이다.",
                    duration: 3000);
                context.VisibleMyPc(isVisible: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State공주와기사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State공주와기사03 : TriggerState {
            internal State공주와기사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8002}, arg2: 0);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_Krantz_promise");
                context.AddCinematicTalk(npcID: 11003572, illustID: "Eone_normal", msg: "기다려 달라.", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State공주와기사04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State공주와기사04 : TriggerState {
            internal State공주와기사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003667, illustID: "Krantz_normal", msg: "그렇다. 좀 기다려 달라.",
                    duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State마무리(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마무리 : TriggerState {
            internal State마무리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8002}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003572, illustID: "Eone_normal", msg: "1월까지 완료될 것이다.",
                    duration: 3000);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 3000f);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StatePC퇴장_연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC퇴장_스킵완료 : TriggerState {
            internal StatePC퇴장_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePC퇴장_연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC퇴장_연출종료 : TriggerState {
            internal StatePC퇴장_연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
                context.SetAchievement(arg1: 9000, arg2: "trigger", arg3: "PrincessAndHerKnight");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State최종맵이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State최종맵이동 : TriggerState {
            internal State최종맵이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02020013, arg2: 10);
                context.VisibleMyPc(isVisible: true);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State최종맵이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}