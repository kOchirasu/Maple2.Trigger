namespace Maple2.Trigger._52020022_qd {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 102, 103, 104, 111, 115});
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
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
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001791},
                    arg3: new byte[] {3})) {
                    context.State = new State빈방(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001791},
                    arg3: new byte[] {2})) {
                    context.State = new State기본_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001791},
                    arg3: new byte[] {1})) {
                    context.State = new State기본_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001790},
                    arg3: new byte[] {3})) {
                    context.State = new State기본_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001790},
                    arg3: new byte[] {2})) {
                    context.State = new State기본_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001790},
                    arg3: new byte[] {1})) {
                    context.State = new State기본_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001784},
                    arg3: new byte[] {3})) {
                    context.State = new State기본_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001784},
                    arg3: new byte[] {2})) {
                    context.State = new State세리하_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001784},
                    arg3: new byte[] {1})) {
                    context.State = new State기본_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001783},
                    arg3: new byte[] {3})) {
                    context.State = new State기본_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001783},
                    arg3: new byte[] {2})) {
                    context.State = new State기본_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001783},
                    arg3: new byte[] {1})) {
                    context.State = new State기본_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001782},
                    arg3: new byte[] {3})) {
                    context.State = new State기본_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001782},
                    arg3: new byte[] {2})) {
                    context.State = new State기본_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001782},
                    arg3: new byte[] {1})) {
                    context.State = new State기본_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001781},
                    arg3: new byte[] {3})) {
                    context.State = new State기본_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001781},
                    arg3: new byte[] {2})) {
                    context.State = new State기본_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001781},
                    arg3: new byte[] {1})) {
                    context.State = new State기본_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001780},
                    arg3: new byte[] {3})) {
                    context.State = new State기본_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001780},
                    arg3: new byte[] {2})) {
                    context.State = new State아르망_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001780},
                    arg3: new byte[] {1})) {
                    context.State = new State레지스탕스_대기(context);
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

        private class State기본_대기 : TriggerState {
            internal State기본_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {111}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001791},
                    arg3: new byte[] {3})) {
                    context.State = new State빈방(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001784},
                    arg3: new byte[] {2})) {
                    context.State = new State세리하_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001780},
                    arg3: new byte[] {2})) {
                    context.State = new State아르망_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001780},
                    arg3: new byte[] {1})) {
                    context.State = new State레지스탕스_대기(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레지스탕스_대기 : TriggerState {
            internal State레지스탕스_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {102, 103, 104}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001780},
                    arg3: new byte[] {1})) {
                    context.State = new State퀘스트조건체크(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State레지스탕스_준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레지스탕스_준비 : TriggerState {
            internal State레지스탕스_준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8000, 8001}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State레지스탕스_연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레지스탕스_연출시작 : TriggerState {
            internal State레지스탕스_연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(arg1: "레지스탕스_스킵완료", arg2: "exit");
                context.MoveUserPath(arg1: "MS2PatrolData_PC_Walkin");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State레지스탕스_체키01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레지스탕스_체키01 : TriggerState {
            internal State레지스탕스_체키01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
                context.AddCinematicTalk(npcId: 11003661, illustId: "Checky_normal", msg: "여기 뭐가 있긴 있는 거야?",
                    duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State레지스탕스_헨리테01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레지스탕스_헨리테01 : TriggerState {
            internal State레지스탕스_헨리테01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8003}, arg2: false);
                context.AddCinematicTalk(npcId: 11003662, illustId: "henritte_normal",
                    msg: "여기 뭔가 있다는 소문도 사실은 거짓 정보 아니야?", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State레지스탕스_지그문트01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레지스탕스_지그문트01 : TriggerState {
            internal State레지스탕스_지그문트01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8004}, arg2: false);
                context.AddCinematicTalk(npcId: 11003663, illustId: "sigmund_normal",
                    msg: @"아니야. 연출이 있는 건 사실이지만 보강 예정이라고.\n1월 마감 이전에 업데이트한대.", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State레지스탕스_이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레지스탕스_이동 : TriggerState {
            internal State레지스탕스_이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8006}, arg2: false);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_Goingout_Checky");
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_Goingout_Henritte");
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_Goingout_Sigmund");
                context.AddCinematicTalk(npcId: 11003663, illustId: "sigmund_normal", msg: "그럼, 조금만 기다려 주시길...",
                    duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State레지스탕스_마무리(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레지스탕스_마무리 : TriggerState {
            internal State레지스탕스_마무리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {102, 103, 104});
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State레지스탕스_연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레지스탕스_스킵완료 : TriggerState {
            internal State레지스탕스_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 102, 103, 104});
                context.CreateMonster(arg1: new[] {101});
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State레지스탕스_연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레지스탕스_연출종료 : TriggerState {
            internal State레지스탕스_연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
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

        private class State조건확인_대기01 : TriggerState {
            internal State조건확인_대기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001780},
                    arg3: new byte[] {2})) {
                    context.State = new State아르망_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001780},
                    arg3: new byte[] {1})) {
                    context.State = new State조건확인_대기02(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001763},
                    arg3: new byte[] {3})) {
                    context.State = new State조건확인_대기02(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001763},
                    arg3: new byte[] {2})) {
                    context.State = new State조건확인_대기02(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001780},
                    arg3: new byte[] {2})) {
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
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001780},
                    arg3: new byte[] {2})) {
                    context.State = new State아르망_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001780},
                    arg3: new byte[] {1})) {
                    context.State = new State조건확인_대기01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001763},
                    arg3: new byte[] {3})) {
                    context.State = new State조건확인_대기01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001763},
                    arg3: new byte[] {2})) {
                    context.State = new State조건확인_대기01(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001780},
                    arg3: new byte[] {2})) {
                    context.State = new State조건확인_대기01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아르망_대기 : TriggerState {
            internal State아르망_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101}, arg2: false);
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001780},
                    arg3: new byte[] {2})) {
                    context.State = new State퀘스트조건체크(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State아르망_준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아르망_준비 : TriggerState {
            internal State아르망_준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8010}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State아르망_연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아르망_연출시작 : TriggerState {
            internal State아르망_연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(arg1: "아르망_스킵완료", arg2: "exit");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State아르망_연출01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아르망_연출01 : TriggerState {
            internal State아르망_연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8010, 8011}, arg2: false);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_Armand_comingout");
                context.MoveUserPath(arg1: "MS2PatrolData_PC_Surprised");
                context.AddCinematicTalk(npcId: 11003672, illustId: "Armand_normal", msg: "연출 추가 예정입니다.",
                    duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State아르망_마무리(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아르망_마무리 : TriggerState {
            internal State아르망_마무리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 111});
                context.CreateMonster(arg1: new[] {111});
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

        private class State아르망_스킵완료 : TriggerState {
            internal State아르망_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 111});
                context.CreateMonster(arg1: new[] {111});
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세리하_대기 : TriggerState {
            internal State세리하_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {111, 115}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001784},
                    arg3: new byte[] {2})) {
                    context.State = new State퀘스트조건체크(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State세리하_준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세리하_준비 : TriggerState {
            internal State세리하_준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8014}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.VisibleMyPc(isVisible: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State세리하_연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세리하_연출시작 : TriggerState {
            internal State세리하_연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(arg1: "세리하_스킵완료", arg2: "exit");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State세리하_연출01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세리하_연출01 : TriggerState {
            internal State세리하_연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8021}, arg2: false);
                context.AddCinematicTalk(npcId: 11003660, illustId: "Seriha_normal", msg: "1월 중 연출 보강 예정",
                    duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State세리하_연출02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세리하_연출02 : TriggerState {
            internal State세리하_연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8014}, arg2: false);
                context.AddCinematicTalk(npcId: 11003672, illustId: "Armand_normal", msg: "대사 위주 보강 예정",
                    duration: 4000);
                context.VisibleMyPc(isVisible: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State세리하_마무리(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세리하_마무리 : TriggerState {
            internal State세리하_마무리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {115});
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

        private class State세리하_스킵완료 : TriggerState {
            internal State세리하_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {115});
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State빈방 : TriggerState {
            internal State빈방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 102, 103, 104, 111, 115}, arg2: false);
            }

            public override void Execute() {
                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001791},
                    arg3: new byte[] {3})) {
                    context.State = new State퀘스트조건체크(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State종료(context);
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