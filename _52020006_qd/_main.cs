using System;

namespace Maple2.Trigger._52020006_qd {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {101, 102, 103, 104});
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
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001797},
                    arg3: new byte[] {3})) {
                    context.State = new State빈방(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001797},
                    arg3: new byte[] {2})) {
                    context.State = new State빈방(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001797},
                    arg3: new byte[] {1})) {
                    context.State = new State제이든_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001796},
                    arg3: new byte[] {3})) {
                    context.State = new State제이든_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001796},
                    arg3: new byte[] {2})) {
                    context.State = new State제이든_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001796},
                    arg3: new byte[] {1})) {
                    context.State = new State세리하와함께전투_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001795},
                    arg3: new byte[] {3})) {
                    context.State = new State세리하_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001795},
                    arg3: new byte[] {2})) {
                    context.State = new State세리하_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001795},
                    arg3: new byte[] {1})) {
                    context.State = new State세리하와아르망_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001794},
                    arg3: new byte[] {3})) {
                    context.State = new State세리하_대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세리하_대기 : TriggerState {
            internal State세리하_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {101, 102, 105});
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001796},
                    arg3: new byte[] {1})) {
                    context.State = new State세리하와함께전투_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001795},
                    arg3: new byte[] {1})) {
                    context.State = new State세리하와아르망_대기(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State조건확인_대기01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State제이든_대기 : TriggerState {
            internal State제이든_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {101, 102, 105});
                context.CreateMonster(arg1: new int[] {105}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001796},
                    arg3: new byte[] {1})) {
                    context.State = new State세리하와함께전투_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001795},
                    arg3: new byte[] {1})) {
                    context.State = new State세리하와아르망_대기(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State조건확인_대기01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State빈방 : TriggerState {
            internal State빈방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {101, 102, 105});
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001796},
                    arg3: new byte[] {1})) {
                    context.State = new State세리하와함께전투_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001795},
                    arg3: new byte[] {1})) {
                    context.State = new State세리하와아르망_대기(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State조건확인_대기01 : TriggerState {
            internal State조건확인_대기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001796},
                    arg3: new byte[] {1})) {
                    context.State = new State세리하와함께전투_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001795},
                    arg3: new byte[] {1})) {
                    context.State = new State세리하와아르망_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001795},
                    arg3: new byte[] {3})) {
                    context.State = new State조건확인_대기02(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001795},
                    arg3: new byte[] {2})) {
                    context.State = new State조건확인_대기02(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001796},
                    arg3: new byte[] {1})) {
                    context.State = new State조건확인_대기02(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001795},
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
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001796},
                    arg3: new byte[] {1})) {
                    context.State = new State세리하와함께전투_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001795},
                    arg3: new byte[] {1})) {
                    context.State = new State세리하와아르망_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001795},
                    arg3: new byte[] {3})) {
                    context.State = new State조건확인_대기01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001795},
                    arg3: new byte[] {2})) {
                    context.State = new State조건확인_대기01(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001796},
                    arg3: new byte[] {1})) {
                    context.State = new State조건확인_대기01(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001795},
                    arg3: new byte[] {1})) {
                    context.State = new State조건확인_대기01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세리하와아르망_대기 : TriggerState {
            internal State세리하와아르망_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {101, 102, 105});
                context.CreateMonster(arg1: new int[] {101, 102}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (!context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001795},
                    arg3: new byte[] {1})) {
                    context.State = new State퀘스트조건체크(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State세리하와아르망_준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세리하와아르망_준비 : TriggerState {
            internal State세리하와아르망_준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.VisibleMyPc(isVisible: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State세리하와아르망_연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세리하와아르망_연출시작 : TriggerState {
            internal State세리하와아르망_연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(arg1: "세리하와아르망_스킵완료", arg2: "exit");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State세리하와아르망_연출01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세리하와아르망_연출01 : TriggerState {
            internal State세리하와아르망_연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8000}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003548, illustID: "Seriha_normal", msg: "연출 보강 예정", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State세리하와아르망_연출02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세리하와아르망_연출02 : TriggerState {
            internal State세리하와아르망_연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8000}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003658, illustID: "Armand_normal", msg: "조금만 기다려 주세요",
                    duration: 3000);
                context.VisibleMyPc(isVisible: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State세리하와아르망_연출03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세리하와아르망_연출03 : TriggerState {
            internal State세리하와아르망_연출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8000}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003548, illustID: "Seriha_normal", msg: "죄송합니다", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State세리하와아르망_마무리(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세리하와아르망_마무리 : TriggerState {
            internal State세리하와아르망_마무리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {102});
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State세리하와아르망_연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세리하와아르망_스킵완료 : TriggerState {
            internal State세리하와아르망_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {101, 102, 105});
                context.CreateMonster(arg1: new int[] {101});
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State세리하와아르망_연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세리하와아르망_연출종료 : TriggerState {
            internal State세리하와아르망_연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetAchievement(arg1: 9000, arg2: "trigger", arg3: "Armandsidentity");
                context.VisibleMyPc(isVisible: true);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State조건확인_대기01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세리하와함께전투_대기 : TriggerState {
            internal State세리하와함께전투_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {101, 102, 105});
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (!context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001796},
                    arg3: new byte[] {1})) {
                    context.State = new State퀘스트조건체크(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State세리하와함께전투_준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세리하와함께전투_준비 : TriggerState {
            internal State세리하와함께전투_준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {150, 151, 152, 153}, arg2: true);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State세리하와함께전투_연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세리하와함께전투_연출시작 : TriggerState {
            internal State세리하와함께전투_연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(arg1: "세리하와함께전투_전투직전스킵", arg2: "exit");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State세리하와함께전투_연출01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세리하와함께전투_연출01 : TriggerState {
            internal State세리하와함께전투_연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8000}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003548, illustID: "Seriha_normal", msg: "그럼 누가 먼저 저것들을 쓸어버리나 내기하자고.",
                    duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State세리하와함께전투_연출02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세리하와함께전투_연출02 : TriggerState {
            internal State세리하와함께전투_연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8002}, arg2: 0);
                context.AddCinematicTalk(npcID: 0, msg: "임시연출이라 몬스터가 허약할 거야.", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State세리하와함께전투_연출03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세리하와함께전투_연출03 : TriggerState {
            internal State세리하와함께전투_연출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {101});
                context.CreateMonster(arg1: new int[] {111}, arg2: false);
                context.CameraSelectPath(arg1: new int[] {8010}, arg2: 0);
                context.AddCinematicTalk(npcID: 29000335, illustID: "Seriha_normal", msg: "간다!", duration: 3000);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State전투대기01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세리하와함께전투_전투직전스킵 : TriggerState {
            internal State세리하와함께전투_전투직전스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {101, 102, 105});
                context.CreateMonster(arg1: new int[] {101});
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State전투대기01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투대기01 : TriggerState {
            internal State전투대기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State전투준비01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투준비01 : TriggerState {
            internal State전투준비01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {150, 151, 152, 153})) {
                    context.State = new State전투끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투끝 : TriggerState {
            internal State전투끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8040}, arg2: 0);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State암전02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State암전02 : TriggerState {
            internal State암전02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statenpc교체01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statenpc교체01 : TriggerState {
            internal Statenpc교체01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {111});
                context.CreateMonster(arg1: new int[] {110}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State전투후제이든등장_연출준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투후제이든등장_연출준비 : TriggerState {
            internal State전투후제이든등장_연출준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {111});
                context.CreateMonster(arg1: new int[] {110}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(arg1: new int[] {8020}, arg2: 0);
                context.SetSceneSkip(arg1: "전투후제이든등장_스킵완료", arg2: "exit");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State전투후제이든등장_01_세리하소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투후제이든등장_01_세리하소멸 : TriggerState {
            internal State전투후제이든등장_01_세리하소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003548, illustID: "Seriha_normal", msg: "내가 이긴 듯. 그럼 이만!",
                    duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State전투후제이든등장_02_PC독백(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투후제이든등장_02_PC독백 : TriggerState {
            internal State전투후제이든등장_02_PC독백(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {110});
                context.AddCinematicTalk(npcID: 0, illustID: "Seriha_normal", msg: "이제 저 너머로 갈 차례인가...",
                    duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State전투후제이든등장_03_제이든등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투후제이든등장_03_제이든등장 : TriggerState {
            internal State전투후제이든등장_03_제이든등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {105}, arg2: false);
                context.AddCinematicTalk(npcID: 11003677, illustID: "Jaiden_normal", msg: "무사했구나, $MyPCName$.",
                    duration: 3000);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State세리하와함께전투_제이든등장_연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투후제이든등장_스킵완료 : TriggerState {
            internal State전투후제이든등장_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {101, 102, 105, 110, 111, 150, 151, 152, 153});
                context.CreateMonster(arg1: new int[] {105});
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    // context.State = new State세리하와함께전투_연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세리하와함께전투_제이든등장_연출종료 : TriggerState {
            internal State세리하와함께전투_제이든등장_연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetAchievement(arg1: 9000, arg2: "trigger", arg3: "FightingSeriha");
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
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