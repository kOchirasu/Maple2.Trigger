namespace Maple2.Trigger._52020003_qd {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 102, 111, 112, 113, 121, 122, 123, 124, 125, 126});
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    return new StateQuest조건체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest조건체크 : TriggerState {
            internal StateQuest조건체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001760}, arg3: new byte[] {3})) {
                    return new State기본(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001760}, arg3: new byte[] {2})) {
                    return new State제이든Appear_완료(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001760}, arg3: new byte[] {1})) {
                    return new State제이든Appear_완료(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001759}, arg3: new byte[] {3})) {
                    return new State제이든Appear_완료(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001759}, arg3: new byte[] {2})) {
                    return new State제이든Appear_완료(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001759}, arg3: new byte[] {1})) {
                    return new State흑성회전투_대기(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001758}, arg3: new byte[] {3})) {
                    return new State기본(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State기본 : TriggerState {
            internal State기본(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State흑성회전투_대기 : TriggerState {
            internal State흑성회전투_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(arg1: 52020003, arg2: 10);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePCAppear_준비(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCAppear_준비 : TriggerState {
            internal StatePCAppear_준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePCAppear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCAppear : TriggerState {
            internal StatePCAppear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8000}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_PC_Walkin_01");
                context.AddBalloonTalk(spawnPointId: 0, msg: "꽤 넓네, 생각보다…", duration: 2000, delayTick: 0);
                context.SetSceneSkip(arg1: "전투직전_스킵완료", arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State누군가있다(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State누군가있다 : TriggerState {
            internal State누군가있다(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_PC_Walkin_02");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State누군가있다_발견(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State누군가있다_발견 : TriggerState {
            internal State누군가있다_발견(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
                context.AddBalloonTalk(spawnPointId: 0, msg: "잠깐… 누가 있나?", duration: 3000, delayTick: 0);
                context.MoveUserPath(arg1: "MS2PatrolData_PC_Walkin_03");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State요원Appear_준비(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State요원Appear_준비 : TriggerState {
            internal State요원Appear_준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
                context.CreateMonster(arg1: new[] {113}, arg2: false);
                context.AddBalloonTalk(spawnPointId: 113, msg: "하하하!", duration: 2000, delayTick: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State요원Appear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State요원Appear : TriggerState {
            internal State요원Appear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003666, msg: @"아주 멍청하지는 않구나.\n내 존재를 눈치채다니.", duration: 3000, align: "left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePC반응01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC반응01 : TriggerState {
            internal StatePC반응01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8003}, arg2: false);
                context.AddCinematicTalk(npcId: 0, msg: "흑성회…? 여기서 뭘 하는 거지?", duration: 3000, align: "left");
                context.SetPcEmotionLoop(arg1: "Talk_B", arg2: 3000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State요원협박(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State요원협박 : TriggerState {
            internal State요원협박(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
                context.AddCinematicTalk(npcId: 11003666, msg: @"그건 알 필요 없고, 서로 바쁜데 시간 끌지 말자고~\n찾아낸 물건이 있으면 순순히 넘겨라.", duration: 3000, align: "left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePC반응02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC반응02 : TriggerState {
            internal StatePC반응02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8003}, arg2: false);
                context.AddCinematicTalk(npcId: 0, msg: @"그런 건 없고… 오히려 듣고 싶은 이야기가 많은데.\n여기서 뭘 하고 있었던 건지 말해 보라고.", duration: 3000, align: "left");
                context.SetPcEmotionLoop(arg1: "Emotion_Cinematic_ShakeHead_A", arg2: 3000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State요원반응(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State요원반응 : TriggerState {
            internal State요원반응(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
                context.AddCinematicTalk(npcId: 11003666, msg: @"그럴 시간 없어. 우린 아주 바쁘거든.\n얘들아! 제압하자!", duration: 3000, align: "left");
                context.CreateMonster(arg1: new[] {111, 112}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State요원소환01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State요원소환01 : TriggerState {
            internal State요원소환01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8010}, arg2: false);
                context.MoveNpc(arg1: 111, arg2: "111_blackstars_patrol_00");
                context.AddBalloonTalk(spawnPointId: 111, msg: "각오해라!", duration: 2000, delayTick: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State요원소환02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State요원소환02 : TriggerState {
            internal State요원소환02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8011}, arg2: false);
                context.MoveNpc(arg1: 112, arg2: "112_blackstars_patrol_01");
                context.AddBalloonTalk(spawnPointId: 112, msg: "혼내주마!", duration: 2000, delayTick: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateWaitCombat00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitCombat00 : TriggerState {
            internal StateWaitCombat00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 4);
                context.DestroyMonster(arg1: new[] {111, 112, 113});
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State전투직전_스킵완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투직전_스킵완료 : TriggerState {
            internal State전투직전_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 4);
                context.DestroyMonster(arg1: new[] {111, 112, 113});
                context.MoveUser(arg1: 52020003, arg2: 11);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBattleStart01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart01 : TriggerState {
            internal StateBattleStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.CreateMonster(arg1: new[] {121, 122}, arg2: true);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {121, 122})) {
                    return new StateBattleStart02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart02 : TriggerState {
            internal StateBattleStart02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {123, 124}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {123, 124})) {
                    return new StateBattleStart03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart03 : TriggerState {
            internal StateBattleStart03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {125, 126}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {125, 126})) {
                    return new State전투끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투끝 : TriggerState {
            internal State전투끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State암전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State암전 : TriggerState {
            internal State암전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(arg1: 52020003, arg2: 11);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State제이든_Appear_대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제이든_Appear_대기 : TriggerState {
            internal State제이든_Appear_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {111, 112, 113, 121, 122, 123, 124, 125, 126});
                context.CreateMonster(arg1: new[] {101}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State제이든대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제이든대기 : TriggerState {
            internal State제이든대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcId: 11003539, msg: "…$MyPCName$?", duration: 3000, align: "left");
                context.SetSceneSkip(arg1: "제이든등장_스킵완료", arg2: "exit");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State제이든대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제이든대사01 : TriggerState {
            internal State제이든대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcId: 11003541, msg: "아주 시끄러운 소리가 난 것 같은데…", duration: 2000, align: "left");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_PC_Walkin_01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State제이든대사02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제이든대사02 : TriggerState {
            internal State제이든대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8021, 8022}, arg2: false);
                context.AddCinematicTalk(npcId: 11003541, msg: "무슨 일 있었어?", duration: 3000, align: "left");
                context.MoveNpc(arg1: 101, arg2: "101_MS2PatrolData_Jaiden_Walkin");
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제이든Appear_스킵완료 : TriggerState {
            internal State제이든Appear_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 4);
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {102}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 9000, arg2: "trigger", arg3: "BlackStarAttack01");
                context.CameraReset(interpolationTime: 2.0f);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제이든Appear_완료 : TriggerState {
            internal State제이든Appear_완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 111, 112, 113, 121, 122, 123, 124, 125, 126});
                context.CreateMonster(arg1: new[] {102}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
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