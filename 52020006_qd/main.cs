namespace Maple2.Trigger._52020006_qd {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 102, 103, 104});
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
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001797}, arg3: new byte[] {3})) {
                    return new State빈방(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001797}, arg3: new byte[] {2})) {
                    return new State빈방(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001797}, arg3: new byte[] {1})) {
                    return new State제이든_대기(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001796}, arg3: new byte[] {3})) {
                    return new State제이든_대기(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001796}, arg3: new byte[] {2})) {
                    return new State제이든_대기(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001796}, arg3: new byte[] {1})) {
                    return new State세리하와함께전투_대기(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001795}, arg3: new byte[] {3})) {
                    return new State세리하_대기(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001795}, arg3: new byte[] {2})) {
                    return new State세리하_대기(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001795}, arg3: new byte[] {1})) {
                    return new State세리하와아르망_대기(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001794}, arg3: new byte[] {3})) {
                    return new State세리하_대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하_대기 : TriggerState {
            internal State세리하_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 102, 105});
                context.CreateMonster(arg1: new[] {101}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001796}, arg3: new byte[] {1})) {
                    return new State세리하와함께전투_대기(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001795}, arg3: new byte[] {1})) {
                    return new State세리하와아르망_대기(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new State조건확인_대기01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제이든_대기 : TriggerState {
            internal State제이든_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 102, 105});
                context.CreateMonster(arg1: new[] {105}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001796}, arg3: new byte[] {1})) {
                    return new State세리하와함께전투_대기(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001795}, arg3: new byte[] {1})) {
                    return new State세리하와아르망_대기(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new State조건확인_대기01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State빈방 : TriggerState {
            internal State빈방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 102, 105});
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001796}, arg3: new byte[] {1})) {
                    return new State세리하와함께전투_대기(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001795}, arg3: new byte[] {1})) {
                    return new State세리하와아르망_대기(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조건확인_대기01 : TriggerState {
            internal State조건확인_대기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001796}, arg3: new byte[] {1})) {
                    return new State세리하와함께전투_대기(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001795}, arg3: new byte[] {1})) {
                    return new State세리하와아르망_대기(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001795}, arg3: new byte[] {3})) {
                    return new State조건확인_대기02(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001795}, arg3: new byte[] {2})) {
                    return new State조건확인_대기02(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001796}, arg3: new byte[] {1})) {
                    return new State조건확인_대기02(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001795}, arg3: new byte[] {1})) {
                    return new State조건확인_대기02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조건확인_대기02 : TriggerState {
            internal State조건확인_대기02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001796}, arg3: new byte[] {1})) {
                    return new State세리하와함께전투_대기(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001795}, arg3: new byte[] {1})) {
                    return new State세리하와아르망_대기(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001795}, arg3: new byte[] {3})) {
                    return new State조건확인_대기01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001795}, arg3: new byte[] {2})) {
                    return new State조건확인_대기01(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001796}, arg3: new byte[] {1})) {
                    return new State조건확인_대기01(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001795}, arg3: new byte[] {1})) {
                    return new State조건확인_대기01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하와아르망_대기 : TriggerState {
            internal State세리하와아르망_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 102, 105});
                context.CreateMonster(arg1: new[] {101, 102}, arg2: false);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001795}, arg3: new byte[] {1})) {
                    return new StateQuest조건체크(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new State세리하와아르망_준비(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하와아르망_준비 : TriggerState {
            internal State세리하와아르망_준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.VisibleMyPc(isVisible: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State세리하와아르망_StartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하와아르망_StartCinematic : TriggerState {
            internal State세리하와아르망_StartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(arg1: "세리하와아르망_스킵완료", arg2: "exit");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State세리하와아르망_Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하와아르망_Cinematic01 : TriggerState {
            internal State세리하와아르망_Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8000}, arg2: false);
                context.AddCinematicTalk(npcId: 11003548, illustId: "Seriha_normal", msg: "연출 보강 예정", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State세리하와아르망_Cinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하와아르망_Cinematic02 : TriggerState {
            internal State세리하와아르망_Cinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8000}, arg2: false);
                context.AddCinematicTalk(npcId: 11003658, illustId: "Armand_normal", msg: "조금만 기다려 주세요", duration: 3000);
                context.VisibleMyPc(isVisible: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State세리하와아르망_Cinematic03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하와아르망_Cinematic03 : TriggerState {
            internal State세리하와아르망_Cinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8000}, arg2: false);
                context.AddCinematicTalk(npcId: 11003548, illustId: "Seriha_normal", msg: "죄송합니다", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State세리하와아르망_마무리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하와아르망_마무리 : TriggerState {
            internal State세리하와아르망_마무리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {102});
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State세리하와아르망_StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하와아르망_스킵완료 : TriggerState {
            internal State세리하와아르망_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 102, 105});
                context.CreateMonster(arg1: new[] {101});
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State세리하와아르망_StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하와아르망_StopCinematic : TriggerState {
            internal State세리하와아르망_StopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.SetAchievement(arg1: 9000, arg2: "trigger", arg3: "Armandsidentity");
                context.VisibleMyPc(isVisible: true);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State조건확인_대기01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하와함께전투_대기 : TriggerState {
            internal State세리하와함께전투_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 102, 105});
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001796}, arg3: new byte[] {1})) {
                    return new StateQuest조건체크(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new State세리하와함께전투_준비(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하와함께전투_준비 : TriggerState {
            internal State세리하와함께전투_준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {150, 151, 152, 153}, arg2: true);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State세리하와함께전투_StartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하와함께전투_StartCinematic : TriggerState {
            internal State세리하와함께전투_StartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(arg1: "세리하와함께전투_전투직전스킵", arg2: "exit");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State세리하와함께전투_Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하와함께전투_Cinematic01 : TriggerState {
            internal State세리하와함께전투_Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8000}, arg2: false);
                context.AddCinematicTalk(npcId: 11003548, illustId: "Seriha_normal", msg: "그럼 누가 먼저 저것들을 쓸어버리나 내기하자고.", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State세리하와함께전투_Cinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하와함께전투_Cinematic02 : TriggerState {
            internal State세리하와함께전투_Cinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
                context.AddCinematicTalk(npcId: 0, msg: "임시연출이라 몬스터가 허약할 거야.", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State세리하와함께전투_Cinematic03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하와함께전투_Cinematic03 : TriggerState {
            internal State세리하와함께전투_Cinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {111}, arg2: false);
                context.CameraSelectPath(arg1: new[] {8010}, arg2: false);
                context.AddCinematicTalk(npcId: 29000335, illustId: "Seriha_normal", msg: "간다!", duration: 3000);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateWaitCombat01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하와함께전투_전투직전스킵 : TriggerState {
            internal State세리하와함께전투_전투직전스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 102, 105});
                context.CreateMonster(arg1: new[] {101});
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWaitCombat01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitCombat01 : TriggerState {
            internal StateWaitCombat01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State전투준비01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투준비01 : TriggerState {
            internal State전투준비01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {150, 151, 152, 153})) {
                    return new State전투끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투끝 : TriggerState {
            internal State전투끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8040}, arg2: false);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State암전02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State암전02 : TriggerState {
            internal State암전02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateNpc교체01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpc교체01 : TriggerState {
            internal StateNpc교체01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {111});
                context.CreateMonster(arg1: new[] {110}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State전투후제이든Appear_SetupCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후제이든Appear_SetupCinematic : TriggerState {
            internal State전투후제이든Appear_SetupCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {111});
                context.CreateMonster(arg1: new[] {110}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(arg1: new[] {8020}, arg2: false);
                context.SetSceneSkip(arg1: "전투후제이든등장_스킵완료", arg2: "exit");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State전투후제이든Appear_01_세리하소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후제이든Appear_01_세리하소멸 : TriggerState {
            internal State전투후제이든Appear_01_세리하소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003548, illustId: "Seriha_normal", msg: "내가 이긴 듯. 그럼 이만!", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State전투후제이든Appear_02_PC독백(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후제이든Appear_02_PC독백 : TriggerState {
            internal State전투후제이든Appear_02_PC독백(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {110});
                context.AddCinematicTalk(npcId: 0, illustId: "Seriha_normal", msg: "이제 저 너머로 갈 차례인가...", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State전투후제이든Appear_03_제이든Appear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후제이든Appear_03_제이든Appear : TriggerState {
            internal State전투후제이든Appear_03_제이든Appear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {105}, arg2: false);
                context.AddCinematicTalk(npcId: 11003677, illustId: "Jaiden_normal", msg: "무사했구나, $MyPCName$.", duration: 3000);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State세리하와함께전투_제이든Appear_StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후제이든Appear_스킵완료 : TriggerState {
            internal State전투후제이든Appear_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 102, 105, 110, 111, 150, 151, 152, 153});
                context.CreateMonster(arg1: new[] {105});
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    // return new State세리하와함께전투_StopCinematic(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하와함께전투_제이든Appear_StopCinematic : TriggerState {
            internal State세리하와함께전투_제이든Appear_StopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.SetAchievement(arg1: 9000, arg2: "trigger", arg3: "FightingSeriha");
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
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