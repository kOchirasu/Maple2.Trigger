using System;

namespace Maple2.Trigger._52020003_qd {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {101, 102, 111, 112, 113, 121, 122, 123, 124, 125, 126});
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
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001760},
                    arg3: new byte[] {3})) {
                    context.State = new State기본(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001760},
                    arg3: new byte[] {2})) {
                    context.State = new State제이든등장_완료(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001760},
                    arg3: new byte[] {1})) {
                    context.State = new State제이든등장_완료(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001759},
                    arg3: new byte[] {3})) {
                    context.State = new State제이든등장_완료(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001759},
                    arg3: new byte[] {2})) {
                    context.State = new State제이든등장_완료(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001759},
                    arg3: new byte[] {1})) {
                    context.State = new State흑성회전투_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001758},
                    arg3: new byte[] {3})) {
                    context.State = new State기본(context);
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

        private class State흑성회전투_대기 : TriggerState {
            internal State흑성회전투_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(arg1: 52020003, arg2: 10);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePC등장_준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC등장_준비 : TriggerState {
            internal StatePC등장_준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePC등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC등장 : TriggerState {
            internal StatePC등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8000}, arg2: 0);
                context.MoveUserPath(arg1: "MS2PatrolData_PC_Walkin_01");
                context.AddBalloonTalk(spawnPointID: 0, msg: "꽤 넓네, 생각보다…", duration: 2000, delayTick: 0);
                context.SetSceneSkip(arg1: "전투직전_스킵완료", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State누군가있다(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State누군가있다 : TriggerState {
            internal State누군가있다(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8001}, arg2: 0);
                context.MoveUserPath(arg1: "MS2PatrolData_PC_Walkin_02");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State누군가있다_발견(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State누군가있다_발견 : TriggerState {
            internal State누군가있다_발견(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8001}, arg2: 0);
                context.AddBalloonTalk(spawnPointID: 0, msg: "잠깐… 누가 있나?", duration: 3000, delayTick: 0);
                context.MoveUserPath(arg1: "MS2PatrolData_PC_Walkin_03");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State요원등장_준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State요원등장_준비 : TriggerState {
            internal State요원등장_준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8002}, arg2: 0);
                context.CreateMonster(arg1: new int[] {113}, arg2: false);
                context.AddBalloonTalk(spawnPointID: 113, msg: "하하하!", duration: 2000, delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State요원등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State요원등장 : TriggerState {
            internal State요원등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003666, msg: @"아주 멍청하지는 않구나.\n내 존재를 눈치채다니.", duration: 3000,
                    align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StatePC반응01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC반응01 : TriggerState {
            internal StatePC반응01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8003}, arg2: 0);
                context.AddCinematicTalk(npcID: 0, msg: "흑성회…? 여기서 뭘 하는 거지?", duration: 3000, align: "left");
                context.SetPcEmotionLoop(arg1: "Talk_B", arg2: 3000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State요원협박(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State요원협박 : TriggerState {
            internal State요원협박(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8002}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003666, msg: @"그건 알 필요 없고, 서로 바쁜데 시간 끌지 말자고~\n찾아낸 물건이 있으면 순순히 넘겨라.",
                    duration: 3000, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StatePC반응02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC반응02 : TriggerState {
            internal StatePC반응02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8003}, arg2: 0);
                context.AddCinematicTalk(npcID: 0, msg: @"그런 건 없고… 오히려 듣고 싶은 이야기가 많은데.\n여기서 뭘 하고 있었던 건지 말해 보라고.",
                    duration: 3000, align: "left");
                context.SetPcEmotionLoop(arg1: "Emotion_Cinematic_ShakeHead_A", arg2: 3000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State요원반응(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State요원반응 : TriggerState {
            internal State요원반응(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8002}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003666, msg: @"그럴 시간 없어. 우린 아주 바쁘거든.\n얘들아! 제압하자!", duration: 3000,
                    align: "left");
                context.CreateMonster(arg1: new int[] {111, 112}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State요원소환01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State요원소환01 : TriggerState {
            internal State요원소환01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8010}, arg2: 0);
                context.MoveNpc(arg1: 111, arg2: "111_blackstars_patrol_00");
                context.AddBalloonTalk(spawnPointID: 111, msg: "각오해라!", duration: 2000, delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State요원소환02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State요원소환02 : TriggerState {
            internal State요원소환02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8011}, arg2: 0);
                context.MoveNpc(arg1: 112, arg2: "112_blackstars_patrol_01");
                context.AddBalloonTalk(spawnPointID: 112, msg: "혼내주마!", duration: 2000, delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State전투대기00(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투대기00 : TriggerState {
            internal State전투대기00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 4);
                context.DestroyMonster(arg1: new int[] {111, 112, 113});
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State전투직전_스킵완료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투직전_스킵완료 : TriggerState {
            internal State전투직전_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 4);
                context.DestroyMonster(arg1: new int[] {111, 112, 113});
                context.MoveUser(arg1: 52020003, arg2: 11);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State전투시작01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투시작01 : TriggerState {
            internal State전투시작01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.CreateMonster(arg1: new int[] {121, 122}, arg2: true);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {121, 122})) {
                    context.State = new State전투시작02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투시작02 : TriggerState {
            internal State전투시작02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {123, 124}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {123, 124})) {
                    context.State = new State전투시작03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투시작03 : TriggerState {
            internal State전투시작03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {125, 126}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {125, 126})) {
                    context.State = new State전투끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투끝 : TriggerState {
            internal State전투끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State암전(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State암전 : TriggerState {
            internal State암전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(arg1: 52020003, arg2: 11);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State제이든_등장_대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State제이든_등장_대기 : TriggerState {
            internal State제이든_등장_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {111, 112, 113, 121, 122, 123, 124, 125, 126});
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State제이든대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State제이든대기 : TriggerState {
            internal State제이든대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcID: 11003539, msg: "…$MyPCName$?", duration: 3000, align: "left");
                context.SetSceneSkip(arg1: "제이든등장_스킵완료", arg2: "exit");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State제이든대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State제이든대사01 : TriggerState {
            internal State제이든대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8001}, arg2: 0);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcID: 11003541, msg: "아주 시끄러운 소리가 난 것 같은데…", duration: 2000, align: "left");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_PC_Walkin_01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State제이든대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State제이든대사02 : TriggerState {
            internal State제이든대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8021, 8022}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003541, msg: "무슨 일 있었어?", duration: 3000, align: "left");
                context.MoveNpc(arg1: 101, arg2: "101_MS2PatrolData_Jaiden_Walkin");
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State제이든등장_스킵완료 : TriggerState {
            internal State제이든등장_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 4);
                context.DestroyMonster(arg1: new int[] {101});
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 9000, arg2: "trigger", arg3: "BlackStarAttack01");
                context.CameraReset(interpolationTime: 2.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State제이든등장_완료 : TriggerState {
            internal State제이든등장_완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {101, 111, 112, 113, 121, 122, 123, 124, 125, 126});
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State종료(context);
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