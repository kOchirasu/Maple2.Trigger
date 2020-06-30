using System;

namespace Maple2.Trigger._52000100_qd {
    public static class _52000100 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {200}, arg2: false);
                context.SetEffect(arg1: new int[] {901}, arg2: false);
                context.SetEffect(arg1: new int[] {902}, arg2: false);
                context.SetEffect(arg1: new int[] {903}, arg2: false);
                context.SetEffect(arg1: new int[] {904}, arg2: false);
                context.SetEffect(arg1: new int[] {905}, arg2: false);
                context.SetEffect(arg1: new int[] {906}, arg2: false);
                context.SetEffect(arg1: new int[] {907}, arg2: false);
                context.SetEffect(arg1: new int[] {908}, arg2: false);
                context.SetEffect(arg1: new int[] {909}, arg2: false);
                context.SetEffect(arg1: new int[] {5305}, arg2: false);
                context.SetEffect(arg1: new int[] {5306}, arg2: false);
                context.SetEffect(arg1: new int[] {5307}, arg2: false);
                context.SetEffect(arg1: new int[] {5308}, arg2: false);
                context.SetEffect(arg1: new int[] {5309}, arg2: false);
                context.SetEffect(arg1: new int[] {5310}, arg2: false);
                context.SetEffect(arg1: new int[] {5305}, arg2: false);
                context.SetEffect(arg1: new int[] {5400}, arg2: false);
                context.SetEffect(arg1: new int[] {5401}, arg2: false);
                context.SetEffect(arg1: new int[] {5402}, arg2: false);
                context.SetEffect(arg1: new int[] {5403}, arg2: false);
                context.SetEffect(arg1: new int[] {5404}, arg2: false);
                context.SetEffect(arg1: new int[] {5405}, arg2: false);
                context.SetEffect(arg1: new int[] {5406}, arg2: false);
                context.SetEffect(arg1: new int[] {5407}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002290},
                    arg3: new byte[] {3})) {
                    context.State = new State케이틀린대련01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002292},
                    arg3: new byte[] {2})) {
                    context.State = new State아시모프와대화01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002291},
                    arg3: new byte[] {1})) {
                    context.State = new State케이틀린대련04(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002291},
                    arg3: new byte[] {2})) {
                    context.State = new State대련종료씬시작02(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002290},
                    arg3: new byte[] {1})) {
                    context.State = new State몬스터소환교육04(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9003}, arg2: new int[] {20002286},
                    arg3: new byte[] {2})) {
                    context.State = new State강의실입장01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002287},
                    arg3: new byte[] {1})) {
                    context.State = new State참교육01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002288},
                    arg3: new byte[] {1})) {
                    context.State = new State참교육02(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002289},
                    arg3: new byte[] {1})) {
                    context.State = new State몬스터소환교육01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State강의실입장01 : TriggerState {
            internal State강의실입장01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5305}, arg2: true);
                context.SetEffect(arg1: new int[] {5306}, arg2: true);
                context.SetEffect(arg1: new int[] {5307}, arg2: true);
                context.SetEffect(arg1: new int[] {5308}, arg2: true);
                context.SetEffect(arg1: new int[] {5309}, arg2: true);
                context.SetEffect(arg1: new int[] {5310}, arg2: true);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002286},
                    arg3: new byte[] {2})) {
                    context.State = new State아노스등장01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스등장01 : TriggerState {
            internal State아노스등장01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.MoveUser(arg1: 52000100, arg2: 3);
                context.SetEffect(arg1: new int[] {5305}, arg2: false);
                context.SetEffect(arg1: new int[] {5306}, arg2: false);
                context.SetEffect(arg1: new int[] {5307}, arg2: false);
                context.SetEffect(arg1: new int[] {5308}, arg2: false);
                context.SetEffect(arg1: new int[] {5309}, arg2: false);
                context.SetEffect(arg1: new int[] {5310}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State아노스등장02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스등장02 : TriggerState {
            internal State아노스등장02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetPcEmotionLoop(arg1: "Emotion_Disappoint_Idle_A", arg2: 2000f);
                context.CameraSelectPath(arg1: new int[] {4000, 4001}, arg2: 0);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcID: 11003148, illustID: "Anos_normal", msg: "$52000100_QD__52000100__0$",
                    duration: 4000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State아노스등장03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스등장03 : TriggerState {
            internal State아노스등장03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4002}, arg2: 0);
                context.ShowCaption(type: "NameCaption", title: "$52000100_QD__52000100__1$",
                    desc: "$52000100_QD__52000100__2$", align: "center", offsetRateX: -0.05f, offsetRateY: 0.15f,
                    duration: 10000, scale: 2.0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State아노스등장03_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스등장03_1 : TriggerState {
            internal State아노스등장03_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State아노스등장04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State아노스등장04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스등장04 : TriggerState {
            internal State아노스등장04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.5f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.ShowGuideSummary(entityID: 25201001, textID: 25201001, durationTime: 8000);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002287},
                    arg3: new byte[] {1})) {
                    context.State = new State참교육01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State참교육01 : TriggerState {
            internal State참교육01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 25201002, textID: 25201002, durationTime: 8000);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002288},
                    arg3: new byte[] {1})) {
                    context.State = new State참교육02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State참교육02 : TriggerState {
            internal State참교육02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5400}, arg2: true);
                context.SetEffect(arg1: new int[] {5401}, arg2: true);
                context.SetEffect(arg1: new int[] {5402}, arg2: true);
                context.SetEffect(arg1: new int[] {5403}, arg2: true);
                context.SetEffect(arg1: new int[] {5404}, arg2: true);
                context.SetEffect(arg1: new int[] {5405}, arg2: true);
                context.SetEffect(arg1: new int[] {5406}, arg2: true);
                context.SetEffect(arg1: new int[] {5407}, arg2: true);
                context.ShowGuideSummary(entityID: 25201003, textID: 25201003, durationTime: 8000);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002288},
                    arg3: new byte[] {2})) {
                    context.State = new State참교육완료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State참교육완료 : TriggerState {
            internal State참교육완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5400}, arg2: false);
                context.SetEffect(arg1: new int[] {5401}, arg2: false);
                context.SetEffect(arg1: new int[] {5402}, arg2: false);
                context.SetEffect(arg1: new int[] {5403}, arg2: false);
                context.SetEffect(arg1: new int[] {5404}, arg2: false);
                context.SetEffect(arg1: new int[] {5405}, arg2: false);
                context.SetEffect(arg1: new int[] {5406}, arg2: false);
                context.SetEffect(arg1: new int[] {5407}, arg2: false);
                context.ShowGuideSummary(entityID: 25201003, textID: 25201003, durationTime: 8000);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002289},
                    arg3: new byte[] {1})) {
                    context.State = new State몬스터소환교육01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터소환교육01 : TriggerState {
            internal State몬스터소환교육01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5400}, arg2: false);
                context.SetEffect(arg1: new int[] {5401}, arg2: false);
                context.SetEffect(arg1: new int[] {5402}, arg2: false);
                context.SetEffect(arg1: new int[] {5403}, arg2: false);
                context.SetEffect(arg1: new int[] {5404}, arg2: false);
                context.SetEffect(arg1: new int[] {5405}, arg2: false);
                context.SetEffect(arg1: new int[] {5406}, arg2: false);
                context.SetEffect(arg1: new int[] {5407}, arg2: false);
                context.CreateMonster(arg1: new int[] {300, 301, 302, 303, 304, 305}, arg2: false);
                context.MoveNpc(arg1: 203, arg2: "MS2PatrolData_caitSneak");
                context.ShowGuideSummary(entityID: 25201004, textID: 25201004, durationTime: 5000);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {300, 301, 302, 303, 304, 305})) {
                    context.State = new State몬스터소환교육02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터소환교육02 : TriggerState {
            internal State몬스터소환교육02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002290},
                    arg3: new byte[] {1})) {
                    context.State = new State몬스터소환교육04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터소환교육04 : TriggerState {
            internal State몬스터소환교육04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {400, 401, 402, 403, 404, 405}, arg2: false);
                context.ShowGuideSummary(entityID: 25201005, textID: 25201005, durationTime: 5000);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002290},
                    arg3: new byte[] {3})) {
                    context.State = new State케이틀린대련01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린대련01 : TriggerState {
            internal State케이틀린대련01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 9006, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CreateMonster(arg1: new int[] {203}, arg2: false);
                context.MoveNpc(arg1: 203, arg2: "MS2PatrolData_caitComeOut");
                context.CameraSelectPath(arg1: new int[] {4003, 4004}, arg2: 0);
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_turnAnos");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State케이틀린대련02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린대련02 : TriggerState {
            internal State케이틀린대련02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Skip_2", arg2: "nextState");
                context.FaceEmotion(spawnPointID: 200, emotionName: "UpSet");
                context.AddCinematicTalk(npcID: 11003146, illustID: "Caitlyn_normal", msg: "$52000100_QD__52000100__3$",
                    duration: 4000, align: "right");
                context.SetOnetimeEffect(id: 3000950, enable: true,
                    path: @"BG/Common/Sound/Eff_Caitlyn_IntroQuest_03000950.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State케이틀린대련03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린대련03 : TriggerState {
            internal State케이틀린대련03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003146, illustID: "Caitlyn_normal", msg: "$52000100_QD__52000100__4$",
                    duration: 4000, align: "right");
                context.SetOnetimeEffect(id: 3000951, enable: true,
                    path: @"BG/Common/Sound/Eff_Caitlyn_IntroQuest_03000951.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State케이틀린대련03_b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린대련03_b : TriggerState {
            internal State케이틀린대련03_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003146, illustID: "Caitlyn_normal", msg: "$52000100_QD__52000100__5$",
                    duration: 4000, align: "right");
                context.SetOnetimeEffect(id: 3000952, enable: true,
                    path: @"BG/Common/Sound/Eff_Caitlyn_IntroQuest_03000952.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State케이틀린대련03_b_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린대련03_b_1 : TriggerState {
            internal State케이틀린대련03_b_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State케이틀린대련03_c(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_2 : TriggerState {
            internal StateSkip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State케이틀린대련03_c(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린대련03_c : TriggerState {
            internal State케이틀린대련03_c(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.5f);
                context.ShowGuideSummary(entityID: 25201006, textID: 25201006, durationTime: 5000);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002291},
                    arg3: new byte[] {3})) {
                    context.State = new State대련종료씬시작01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002291},
                    arg3: new byte[] {2})) {
                    context.State = new State대련종료씬시작01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002291},
                    arg3: new byte[] {1})) {
                    context.State = new State케이틀린대련04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린대련04 : TriggerState {
            internal State케이틀린대련04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {9003}, arg2: 70000109, arg3: 1, arg4: false, arg5: false);
                context.SetSound(arg1: 9006, arg2: true);
                context.DestroyMonster(arg1: new int[] {203});
                context.CreateMonster(arg1: new int[] {500}, arg2: false);
                context.ShowGuideSummary(entityID: 25201007, textID: 25201007, durationTime: 5000);
                context.AddBuff(arg1: new int[] {9001}, arg2: 99910231, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State케이틀린대련05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린대련05 : TriggerState {
            internal State케이틀린대련05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 25201008, textID: 25201008, durationTime: 5000);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {500})) {
                    context.State = new State대련종료씬시작01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작01 : TriggerState {
            internal State대련종료씬시작01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.DestroyMonster(arg1: new int[] {203});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State대련종료씬시작02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작02 : TriggerState {
            internal State대련종료씬시작02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 9001, arg2: 99910231);
                context.SetProductionUI(arg1: 1);
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CreateMonster(arg1: new int[] {501}, arg2: false);
                context.MoveUser(arg1: 52000100, arg2: 4);
                context.MoveNpc(arg1: 501, arg2: "MS2PatrolData_caitRun");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State대련종료씬시작03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작03 : TriggerState {
            internal State대련종료씬시작03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Skip_3", arg2: "nextState");
                context.MoveUserPath(arg1: "MS2PatrolData_PCRun");
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new int[] {4005, 4006}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State대련종료씬시작04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작04 : TriggerState {
            internal State대련종료씬시작04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 501, arg2: "Bore_A");
                context.SetEffect(arg1: new int[] {902}, arg2: true);
                context.SetTimeScale(enable: true, startScale: 0.6f, endScale: 0.1f, duration: 3.5f, interpolator: 2);
                context.CameraSelectPath(arg1: new int[] {4007, 4008}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    context.State = new State대련종료씬시작05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작05 : TriggerState {
            internal State대련종료씬시작05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4009, 4010, 4027}, arg2: 0);
                context.SetTimeScale(enable: false, startScale: 1f, endScale: 0.1f, duration: 2.5f, interpolator: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State대련종료씬시작06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작06 : TriggerState {
            internal State대련종료씬시작06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Wizard_Enterance_A");
                context.SetPcEmotionLoop(arg1: "Wizard_Enterance_A", arg2: 5000f);
                context.SetEffect(arg1: new int[] {901}, arg2: true);
                context.SetTimeScale(enable: true, startScale: 1f, endScale: 0.1f, duration: 5.5f, interpolator: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State대련종료씬시작07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작07 : TriggerState {
            internal State대련종료씬시작07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimeScale(enable: true, startScale: 0.1f, endScale: 0.1f, duration: 6.5f, interpolator: 2);
                context.SetNpcEmotionLoop(arg1: 501, arg2: "Attack_Idle_A", arg3: 17500f);
                context.SetPcEmotionLoop(arg1: "Wizard_Enterance_A", arg2: 5000f);
                context.CameraSelectPath(arg1: new int[] {4011, 4012}, arg2: 0);
                context.SetEffect(arg1: new int[] {908}, arg2: true);
                context.SetEffect(arg1: new int[] {909}, arg2: true);
                context.SetOnetimeEffect(id: 3, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOutFast.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    context.State = new State대련종료씬시작08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작08 : TriggerState {
            internal State대련종료씬시작08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {901}, arg2: false);
                context.SetEffect(arg1: new int[] {902}, arg2: false);
                context.SetOnetimeEffect(id: 3, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOut.xml");
                context.MoveUser(arg1: 52000100, arg2: 5);
                context.CameraSelectPath(arg1: new int[] {4013, 4014}, arg2: 0);
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_anosCare");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State대련종료씬시작09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작09 : TriggerState {
            internal State대련종료씬시작09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Down_Idle_A", arg2: 12000f);
                context.SetSkill(arg1: new int[] {7005}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State대련종료씬시작09_b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작09_b : TriggerState {
            internal State대련종료씬시작09_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 501, arg2: "MS2PatrolData_caitRun2");
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new int[] {4015}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003147, msg: "$52000100_QD__52000100__6$", duration: 4000,
                    align: "right");
                context.SetOnetimeEffect(id: 3000964, enable: true,
                    path: @"BG/Common/Sound/Eff_Caitlyn_IntroQuest_03000964.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State대련종료씬시작10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작10 : TriggerState {
            internal State대련종료씬시작10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4016}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003147, msg: "$52000100_QD__52000100__7$", duration: 4000,
                    align: "right");
                context.SetOnetimeEffect(id: 3000965, enable: true,
                    path: @"BG/Common/Sound/Eff_Caitlyn_IntroQuest_03000965.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State대련종료씬시작11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작11 : TriggerState {
            internal State대련종료씬시작11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4017}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003148, msg: "$52000100_QD__52000100__8$", duration: 4000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State대련종료씬시작12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작12 : TriggerState {
            internal State대련종료씬시작12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnPointID: 200, emotionName: "Surprised");
                context.CameraSelectPath(arg1: new int[] {4018}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003148, msg: "$52000100_QD__52000100__9$", duration: 4000,
                    align: "right");
                context.SetEffect(arg1: new int[] {902}, arg2: true);
                context.SetEffect(arg1: new int[] {903}, arg2: true);
                context.SetEffect(arg1: new int[] {904}, arg2: true);
                context.SetEffect(arg1: new int[] {905}, arg2: true);
                context.SetEffect(arg1: new int[] {906}, arg2: true);
                context.SetEffect(arg1: new int[] {907}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State대련종료씬시작14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작14 : TriggerState {
            internal State대련종료씬시작14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4019}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State대련종료씬시작15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작15 : TriggerState {
            internal State대련종료씬시작15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4020, 4021}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003147, msg: "$52000100_QD__52000100__10$", duration: 4000,
                    align: "right");
                context.SetOnetimeEffect(id: 3000966, enable: true,
                    path: @"BG/Common/Sound/Eff_Caitlyn_IntroQuest_03000966.xml");
                context.MoveNpc(arg1: 501, arg2: "MS2PatrolData_caitlookBack");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State대련종료씬시작17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작17 : TriggerState {
            internal State대련종료씬시작17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4022, 4023}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003147, msg: "$52000100_QD__52000100__11$", duration: 4000,
                    align: "right");
                context.SetOnetimeEffect(id: 3000967, enable: true,
                    path: @"BG/Common/Sound/Eff_Caitlyn_IntroQuest_03000967.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State대련종료씬시작17_b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작17_b : TriggerState {
            internal State대련종료씬시작17_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003147, msg: "$52000100_QD__52000100__12$", duration: 4000,
                    align: "right");
                context.SetOnetimeEffect(id: 3000968, enable: true,
                    path: @"BG/Common/Sound/Eff_Caitlyn_IntroQuest_03000968.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    context.State = new State대련종료씬시작18(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작18 : TriggerState {
            internal State대련종료씬시작18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 0, msg: "$52000100_QD__52000100__13$", duration: 6000,
                    delayTick: 1000);
                context.AddCinematicTalk(npcID: 11003147, msg: "$52000100_QD__52000100__14$", duration: 4000,
                    align: "right");
                context.SetOnetimeEffect(id: 3000969, enable: true,
                    path: @"BG/Common/Sound/Eff_Caitlyn_IntroQuest_03000969.xml");
                context.CameraSelectPath(arg1: new int[] {4024, 4025}, arg2: 0);
                context.MoveNpc(arg1: 501, arg2: "MS2PatrolData_caitOut");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State대련종료씬시작18_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작18_1 : TriggerState {
            internal State대련종료씬시작18_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State대련종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_3 : TriggerState {
            internal StateSkip_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 3, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOut.xml");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_anosCare");
                context.SetEffect(arg1: new int[] {901}, arg2: false);
                context.SetEffect(arg1: new int[] {902}, arg2: false);
                context.SetEffect(arg1: new int[] {903}, arg2: false);
                context.SetEffect(arg1: new int[] {904}, arg2: false);
                context.SetEffect(arg1: new int[] {905}, arg2: false);
                context.SetEffect(arg1: new int[] {906}, arg2: false);
                context.SetEffect(arg1: new int[] {907}, arg2: false);
                context.SetEffect(arg1: new int[] {908}, arg2: false);
                context.SetEffect(arg1: new int[] {909}, arg2: false);
                context.SetEffect(arg1: new int[] {902}, arg2: true);
                context.SetEffect(arg1: new int[] {903}, arg2: true);
                context.SetEffect(arg1: new int[] {904}, arg2: true);
                context.SetEffect(arg1: new int[] {905}, arg2: true);
                context.SetEffect(arg1: new int[] {906}, arg2: true);
                context.SetEffect(arg1: new int[] {907}, arg2: true);
                context.DestroyMonster(arg1: new int[] {501});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State대련종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대련종료 : TriggerState {
            internal State대련종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.DestroyMonster(arg1: new int[] {501});
                context.RemoveBuff(arg1: 9003, arg2: 70000109);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002291},
                    arg3: new byte[] {3})) {
                    context.State = new State아시모프와대화01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아시모프와대화01 : TriggerState {
            internal State아시모프와대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_Pc_stepAside");
                context.SetProductionUI(arg1: 1);
                context.CreateMonster(arg1: new int[] {202}, arg2: false);
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_asmovMove");
                context.AddBalloonTalk(spawnPointID: 202, msg: "$52000100_QD__52000100__15$", duration: 5000,
                    delayTick: 1000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State아시모프와대화03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아시모프와대화03 : TriggerState {
            internal State아시모프와대화03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Skip_4", arg2: "nextState");
                context.CameraSelectPath(arg1: new int[] {4028}, arg2: 0);
                context.ShowCaption(type: "NameCaption", title: "$52000100_QD__52000100__16$",
                    desc: "$52000100_QD__52000100__17$", align: "center", offsetRateX: -0.05f, offsetRateY: 0.15f,
                    duration: 10000, scale: 2.0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State아시모프와대화03_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아시모프와대화03_1 : TriggerState {
            internal State아시모프와대화03_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State아시모프와대화04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_4 : TriggerState {
            internal StateSkip_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.CameraReset(interpolationTime: 0.5f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State아시모프와대화04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아시모프와대화04 : TriggerState {
            internal State아시모프와대화04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002292},
                    arg3: new byte[] {2})) {
                    context.State = new State아시모프와대화05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아시모프와대화05 : TriggerState {
            internal State아시모프와대화05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 202, msg: "$52000100_QD__52000100__18$", duration: 6000,
                    delayTick: 1000);
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_anos_goRoom");
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_asimov_goRoom");
                context.ShowGuideSummary(entityID: 25201009, textID: 25201009, durationTime: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State아시모프와대화06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아시모프와대화06 : TriggerState {
            internal State아시모프와대화06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000102, arg2: 1);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9003, arg2: new int[] {202})) {
                    context.State = new State아시모프와대화04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}