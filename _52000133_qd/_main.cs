using System;

namespace Maple2.Trigger._52000133_qd {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Statestart(context);

        private class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {101, 111, 112});
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
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
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001599},
                    arg3: new byte[] {3})) {
                    context.State = new State빈집(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001599},
                    arg3: new byte[] {2})) {
                    context.State = new State예민한아노스(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001599},
                    arg3: new byte[] {1})) {
                    context.State = new State예민한아노스(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001598},
                    arg3: new byte[] {3})) {
                    context.State = new State예민한아노스(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001598},
                    arg3: new byte[] {2})) {
                    context.State = new State예민한아노스_연출준비(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001584},
                    arg3: new byte[] {2})) {
                    context.State = new State케이틀린첫만남(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001584},
                    arg3: new byte[] {1})) {
                    context.State = new State케이틀린첫만남(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001583},
                    arg3: new byte[] {3})) {
                    context.State = new State케이틀린첫만남(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001583},
                    arg3: new byte[] {2})) {
                    context.State = new State케이틀린첫만남(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001583},
                    arg3: new byte[] {1})) {
                    context.State = new State케이틀린첫만남(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001582},
                    arg3: new byte[] {3})) {
                    context.State = new State케이틀린첫만남(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001582},
                    arg3: new byte[] {2})) {
                    context.State = new State케이틀린첫만남_연출시작(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001582},
                    arg3: new byte[] {1})) {
                    context.State = new State빈집(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001581},
                    arg3: new byte[] {3})) {
                    context.State = new State빈집(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린첫만남 : TriggerState {
            internal State케이틀린첫만남(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101});
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린첫만남_연출시작 : TriggerState {
            internal State케이틀린첫만남_연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8000}, arg2: 0);
                context.CreateMonster(arg1: new int[] {101});
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveUser(arg1: 52000133, arg2: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State전경스케치01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전경스케치01 : TriggerState {
            internal State전경스케치01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8001}, arg2: 0);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State전경스케치02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전경스케치02 : TriggerState {
            internal State전경스케치02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 0, illustID: "0", msg: "$52000133_QD__MAIN__0$", duration: 2000,
                    align: "left");
                context.SetSceneSkip(arg1: "케이틀린첫만남_스킵완료", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State전경스케치03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전경스케치03 : TriggerState {
            internal State전경스케치03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8002}, arg2: 0);
                context.MoveUserPath(arg1: "MS2PatrolData_PC01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State전경스케치04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전경스케치04 : TriggerState {
            internal State전경스케치04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8003}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003254, illustID: "Caitlyn_normal", msg: "$52000133_QD__MAIN__1$",
                    duration: 3000, align: "center");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State전경스케치05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전경스케치05 : TriggerState {
            internal State전경스케치05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8004}, arg2: 0);
                context.AddBalloonTalk(spawnPointID: 101, msg: "$52000133_QD__MAIN__2$", duration: 3000, delayTick: 0);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Bore_A", arg3: 3000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State전경스케치06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전경스케치06 : TriggerState {
            internal State전경스케치06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8010}, arg2: 0);
                context.MoveUserPath(arg1: "MS2PatrolData_PC02");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State전경스케치07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전경스케치07 : TriggerState {
            internal State전경스케치07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: "NameCaption", title: "$52000133_QD__MAIN__3$",
                    desc: "$52000133_QD__MAIN__4$", align: "centerRight", offsetRateX: -0.05f, offsetRateY: 0.15f,
                    duration: 10000, scale: 2.0f);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Bore_B", arg3: 4000f);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린첫만남_스킵완료 : TriggerState {
            internal State케이틀린첫만남_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 4);
                context.MoveUser(arg1: 52000133, arg2: 12);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State예민한아노스 : TriggerState {
            internal State예민한아노스(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {111, 113});
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State예민한아노스_연출준비 : TriggerState {
            internal State예민한아노스_연출준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {111});
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveUser(arg1: 52000133, arg2: 11);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State예민한아노스_연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State예민한아노스_연출시작 : TriggerState {
            internal State예민한아노스_연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8100}, arg2: 0);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State케이틀린대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린대사01 : TriggerState {
            internal State케이틀린대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8101}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003258, illustID: "Caitlyn_normal", msg: "$52000133_QD__MAIN__5$",
                    duration: 3000, align: "right");
                context.SetNpcEmotionLoop(arg1: 111, arg2: "Bore_A", arg3: 4600f);
                context.MoveUserPath(arg1: "2_MS2PatrolData_PC01");
                context.SetSceneSkip(arg1: "예민한아노스_스킵완료", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StatePC대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC대사01 : TriggerState {
            internal StatePC대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8120}, arg2: 0);
                context.AddCinematicTalk(npcID: 0, illustID: "0", msg: "$52000133_QD__MAIN__6$", duration: 3000);
                context.SetPcEmotionLoop(arg1: "Talk_A", arg2: 2000f);
                context.MoveUserPath(arg1: "2_MS2PatrolData_PC02");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State케이틀린대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린대사02 : TriggerState {
            internal State케이틀린대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003258, illustID: "Caitlyn_normal", msg: "$52000133_QD__MAIN__7$",
                    duration: 3000, align: "right");
                context.MoveNpc(arg1: 111, arg2: "2_MS2PatrolData_Katelyn01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StatePC대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC대사02 : TriggerState {
            internal StatePC대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 0, illustID: "0", msg: "$52000133_QD__MAIN__8$", duration: 3000,
                    align: "right");
                context.MoveUserPath(arg1: "2_MS2PatrolData_PC03");
                context.SetPcEmotionLoop(arg1: "Talk_A", arg2: 2000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State케이틀린대사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린대사03 : TriggerState {
            internal State케이틀린대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8110}, arg2: 0);
                context.CreateMonster(arg1: new int[] {112});
                context.AddCinematicTalk(npcID: 11003258, illustID: "Caitlyn_normal", msg: "$52000133_QD__MAIN__9$",
                    duration: 4000, align: "right");
                context.SetNpcEmotionLoop(arg1: 111, arg2: "Talk_A", arg3: 8200f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State아노스걸어나옴(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스걸어나옴 : TriggerState {
            internal State아노스걸어나옴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8140}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003259, illustID: "Anos_normal", msg: "$52000133_QD__MAIN__10$",
                    duration: 3000, align: "left");
                context.MoveNpc(arg1: 112, arg2: "2_MS2PatrolData_Anos01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State아노스대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스대사01 : TriggerState {
            internal State아노스대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003259, illustID: "Anos_normal", msg: "$52000133_QD__MAIN__11$",
                    duration: 3000, align: "left");
                context.MoveNpc(arg1: 111, arg2: "2_MS2PatrolData_Katelyn02");
                context.SetNpcEmotionLoop(arg1: 112, arg2: "Talk_A", arg3: 3600f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StatePC대사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC대사03 : TriggerState {
            internal StatePC대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 0, illustID: "0", msg: "$52000133_QD__MAIN__12$", align: "center",
                    duration: 3000);
                context.SetPcEmotionLoop(arg1: "Emotion_Hello_A", arg2: 2000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State아노스대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스대사02 : TriggerState {
            internal State아노스대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003259, illustID: "Anos_normal", msg: "$52000133_QD__MAIN__13$",
                    duration: 3000, align: "left");
                context.SetNpcEmotionLoop(arg1: 112, arg2: "ChatUp_A", arg3: 7000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StatePC대사04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC대사04 : TriggerState {
            internal StatePC대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8131}, arg2: 0);
                context.AddCinematicTalk(npcID: 0, illustID: "0", msg: "$52000133_QD__MAIN__14$", duration: 3000,
                    align: "right");
                context.SetPcEmotionSequence(arg1: "Emotion_Surprise_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State아노스대사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스대사03 : TriggerState {
            internal State아노스대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003259, illustID: "Anos_normal", msg: "$52000133_QD__MAIN__15$",
                    duration: 3000, align: "left");
                context.SetNpcEmotionLoop(arg1: 112, arg2: "Bore_A", arg3: 8100f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State케이틀린대사04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린대사04 : TriggerState {
            internal State케이틀린대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8132}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003258, illustID: "Caitlyn_normal", msg: "$52000133_QD__MAIN__16$",
                    duration: 3000, align: "right");
                context.SetNpcEmotionLoop(arg1: 111, arg2: "Talk_A", arg3: 12000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State아노스대사04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스대사04 : TriggerState {
            internal State아노스대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003259, illustID: "Anos_normal", msg: "$52000133_QD__MAIN__17$",
                    duration: 3000, align: "left");
                context.SetNpcEmotionLoop(arg1: 112, arg2: "Bore_B", arg3: 9500f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State아노스대사05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스대사05 : TriggerState {
            internal State아노스대사05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8133}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003259, illustID: "Anos_normal", msg: "$52000133_QD__MAIN__18$",
                    duration: 3000, align: "left");
                context.SetNpcEmotionLoop(arg1: 112, arg2: "Talk_A", arg3: 6300f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State케이틀린대사05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린대사05 : TriggerState {
            internal State케이틀린대사05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003258, illustID: "Caitlyn_normal", msg: "$52000133_QD__MAIN__19$",
                    duration: 3000, align: "right");
                context.SetNpcEmotionLoop(arg1: 111, arg2: "Bore_B", arg3: 7900f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State케이틀린대사06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린대사06 : TriggerState {
            internal State케이틀린대사06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003258, illustID: "Caitlyn_normal", msg: "$52000133_QD__MAIN__20$",
                    duration: 3000, align: "right");
                context.SetNpcEmotionLoop(arg1: 111, arg2: "Talk_A", arg3: 6800f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State아노스대사06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스대사06 : TriggerState {
            internal State아노스대사06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8140}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003259, illustID: "Anos_serious", msg: "$52000133_QD__MAIN__21$",
                    duration: 3000, align: "left");
                context.SetNpcEmotionLoop(arg1: 112, arg2: "Bore_A", arg3: 5800f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State아노스대사07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스대사07 : TriggerState {
            internal State아노스대사07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8140}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003259, illustID: "Anos_serious", msg: "$52000133_QD__MAIN__22$",
                    duration: 3000, align: "left");
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State예민한아노스_스킵완료 : TriggerState {
            internal State예민한아노스_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 4);
                context.CreateMonster(arg1: new int[] {113});
                context.DestroyMonster(arg1: new int[] {112});
                context.MoveUser(arg1: 52000133, arg2: 13);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State빈집 : TriggerState {
            internal State빈집(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
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
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
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