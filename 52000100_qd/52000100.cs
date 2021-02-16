using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000100_qd {
    public static class _52000100 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {200}, arg2: false);
                context.SetEffect(arg1: new[] {901, 902, 903, 904, 905, 906, 907, 908, 909, 5305, 5306, 5307, 5308, 5309, 5310, 5305, 5400, 5401, 5402, 5403, 5404, 5405, 5406, 5407}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002290}, arg3: new byte[] {3})) {
                    return new State케이틀린대련01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002292}, arg3: new byte[] {2})) {
                    return new State아시모프와대화01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002291}, arg3: new byte[] {1})) {
                    return new State케이틀린대련04(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002291}, arg3: new byte[] {2})) {
                    return new State대련종료씬시작02(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002290}, arg3: new byte[] {1})) {
                    return new StateMonster소환교육04(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9003}, arg2: new[] {20002286}, arg3: new byte[] {2})) {
                    return new State강의실입장01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002287}, arg3: new byte[] {1})) {
                    return new State참교육01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002288}, arg3: new byte[] {1})) {
                    return new State참교육02(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002289}, arg3: new byte[] {1})) {
                    return new StateMonster소환교육01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State강의실입장01 : TriggerState {
            internal State강의실입장01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5305, 5306, 5307, 5308, 5309, 5310}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002286}, arg3: new byte[] {2})) {
                    return new State아노스Spawn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Spawn01 : TriggerState {
            internal State아노스Spawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.MoveUser(arg1: 52000100, arg2: 3);
                context.SetEffect(arg1: new[] {5305, 5306, 5307, 5308, 5309, 5310}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State아노스Spawn02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Spawn02 : TriggerState {
            internal State아노스Spawn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetPcEmotionLoop(arg1: "Emotion_Disappoint_Idle_A", arg2: 2000f);
                context.CameraSelectPath(pathIds: new[] {4000, 4001}, arg2: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 11003148, illustId: "Anos_normal", script: "$52000100_QD__52000100__0$", duration: 4000, align: Align.Right);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State아노스Spawn03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Spawn03 : TriggerState {
            internal State아노스Spawn03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4002}, arg2: false);
                context.ShowCaption(type: CaptionType.Name, title: "$52000100_QD__52000100__1$", script: "$52000100_QD__52000100__2$", align: Align.Center, offsetRateX: -0.05f, offsetRateY: 0.15f, duration: 10000, scale: 2.0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State아노스Spawn03_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Spawn03_1 : TriggerState {
            internal State아노스Spawn03_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State아노스Spawn04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State아노스Spawn04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Spawn04 : TriggerState {
            internal State아노스Spawn04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.5f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.ShowGuideSummary(entityId: 25201001, textId: 25201001, duration: 8000);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002287}, arg3: new byte[] {1})) {
                    return new State참교육01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State참교육01 : TriggerState {
            internal State참교육01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25201002, textId: 25201002, duration: 8000);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002288}, arg3: new byte[] {1})) {
                    return new State참교육02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State참교육02 : TriggerState {
            internal State참교육02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5400, 5401, 5402, 5403, 5404, 5405, 5406, 5407}, arg2: true);
                context.ShowGuideSummary(entityId: 25201003, textId: 25201003, duration: 8000);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002288}, arg3: new byte[] {2})) {
                    return new State참교육완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State참교육완료 : TriggerState {
            internal State참교육완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5400, 5401, 5402, 5403, 5404, 5405, 5406, 5407}, arg2: false);
                context.ShowGuideSummary(entityId: 25201003, textId: 25201003, duration: 8000);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002289}, arg3: new byte[] {1})) {
                    return new StateMonster소환교육01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster소환교육01 : TriggerState {
            internal StateMonster소환교육01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5400, 5401, 5402, 5403, 5404, 5405, 5406, 5407}, arg2: false);
                context.CreateMonster(arg1: new[] {300, 301, 302, 303, 304, 305}, arg2: false);
                context.MoveNpc(arg1: 203, arg2: "MS2PatrolData_caitSneak");
                context.ShowGuideSummary(entityId: 25201004, textId: 25201004, duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {300, 301, 302, 303, 304, 305})) {
                    return new StateMonster소환교육02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster소환교육02 : TriggerState {
            internal StateMonster소환교육02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002290}, arg3: new byte[] {1})) {
                    return new StateMonster소환교육04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster소환교육04 : TriggerState {
            internal StateMonster소환교육04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {400, 401, 402, 403, 404, 405}, arg2: false);
                context.ShowGuideSummary(entityId: 25201005, textId: 25201005, duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002290}, arg3: new byte[] {3})) {
                    return new State케이틀린대련01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린대련01 : TriggerState {
            internal State케이틀린대련01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 9006, arg2: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CreateMonster(arg1: new[] {203}, arg2: false);
                context.MoveNpc(arg1: 203, arg2: "MS2PatrolData_caitComeOut");
                context.CameraSelectPath(pathIds: new[] {4003, 4004}, arg2: false);
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_turnAnos");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State케이틀린대련02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린대련02 : TriggerState {
            internal State케이틀린대련02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateSkip_2(context), arg2: "nextState");
                context.FaceEmotion(spawnPointId: 200, emotionName: "UpSet");
                context.AddCinematicTalk(npcId: 11003146, illustId: "Caitlyn_normal", script: "$52000100_QD__52000100__3$", duration: 4000, align: Align.Right);
                context.SetOnetimeEffect(id: 3000950, enable: true, path: @"BG/Common/Sound/Eff_Caitlyn_IntroQuest_03000950.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State케이틀린대련03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린대련03 : TriggerState {
            internal State케이틀린대련03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003146, illustId: "Caitlyn_normal", script: "$52000100_QD__52000100__4$", duration: 4000, align: Align.Right);
                context.SetOnetimeEffect(id: 3000951, enable: true, path: @"BG/Common/Sound/Eff_Caitlyn_IntroQuest_03000951.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State케이틀린대련03_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린대련03_b : TriggerState {
            internal State케이틀린대련03_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003146, illustId: "Caitlyn_normal", script: "$52000100_QD__52000100__5$", duration: 4000, align: Align.Right);
                context.SetOnetimeEffect(id: 3000952, enable: true, path: @"BG/Common/Sound/Eff_Caitlyn_IntroQuest_03000952.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State케이틀린대련03_b_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린대련03_b_1 : TriggerState {
            internal State케이틀린대련03_b_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State케이틀린대련03_c(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_2 : TriggerState {
            internal StateSkip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State케이틀린대련03_c(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린대련03_c : TriggerState {
            internal State케이틀린대련03_c(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.5f);
                context.ShowGuideSummary(entityId: 25201006, textId: 25201006, duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002291}, arg3: new byte[] {3})) {
                    return new State대련종료씬시작01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002291}, arg3: new byte[] {2})) {
                    return new State대련종료씬시작01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002291}, arg3: new byte[] {1})) {
                    return new State케이틀린대련04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린대련04 : TriggerState {
            internal State케이틀린대련04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {9003}, arg2: 70000109, arg3: 1, arg4: false, arg5: false);
                context.SetSound(arg1: 9006, arg2: true);
                context.DestroyMonster(arg1: new[] {203});
                context.CreateMonster(arg1: new[] {500}, arg2: false);
                context.ShowGuideSummary(entityId: 25201007, textId: 25201007, duration: 5000);
                context.AddBuff(arg1: new[] {9001}, arg2: 99910231, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State케이틀린대련05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린대련05 : TriggerState {
            internal State케이틀린대련05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25201008, textId: 25201008, duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {500})) {
                    return new State대련종료씬시작01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작01 : TriggerState {
            internal State대련종료씬시작01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.DestroyMonster(arg1: new[] {203});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State대련종료씬시작02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작02 : TriggerState {
            internal State대련종료씬시작02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 9001, arg2: 99910231);
                context.SetCinematicUI(type: 1);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CreateMonster(arg1: new[] {501}, arg2: false);
                context.MoveUser(arg1: 52000100, arg2: 4);
                context.MoveNpc(arg1: 501, arg2: "MS2PatrolData_caitRun");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State대련종료씬시작03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작03 : TriggerState {
            internal State대련종료씬시작03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateSkip_3(context), arg2: "nextState");
                context.MoveUserPath(arg1: "MS2PatrolData_PCRun");
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new[] {4005, 4006}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State대련종료씬시작04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작04 : TriggerState {
            internal State대련종료씬시작04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 501, arg2: "Bore_A");
                context.SetEffect(arg1: new[] {902}, arg2: true);
                context.SetTimeScale(enable: true, startScale: 0.6f, endScale: 0.1f, duration: 3.5f, interpolator: 2);
                context.CameraSelectPath(pathIds: new[] {4007, 4008}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new State대련종료씬시작05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작05 : TriggerState {
            internal State대련종료씬시작05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4009, 4010, 4027}, arg2: false);
                context.SetTimeScale(enable: false, startScale: 1f, endScale: 0.1f, duration: 2.5f, interpolator: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State대련종료씬시작06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작06 : TriggerState {
            internal State대련종료씬시작06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Wizard_Enterance_A");
                context.SetPcEmotionLoop(arg1: "Wizard_Enterance_A", arg2: 5000f);
                context.SetEffect(arg1: new[] {901}, arg2: true);
                context.SetTimeScale(enable: true, startScale: 1f, endScale: 0.1f, duration: 5.5f, interpolator: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State대련종료씬시작07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작07 : TriggerState {
            internal State대련종료씬시작07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimeScale(enable: true, startScale: 0.1f, endScale: 0.1f, duration: 6.5f, interpolator: 2);
                context.SetNpcEmotionLoop(arg1: 501, arg2: "Attack_Idle_A", arg3: 17500f);
                context.SetPcEmotionLoop(arg1: "Wizard_Enterance_A", arg2: 5000f);
                context.CameraSelectPath(pathIds: new[] {4011, 4012}, arg2: false);
                context.SetEffect(arg1: new[] {908, 909}, arg2: true);
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOutFast.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    return new State대련종료씬시작08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작08 : TriggerState {
            internal State대련종료씬시작08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {901, 902}, arg2: false);
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOut.xml");
                context.MoveUser(arg1: 52000100, arg2: 5);
                context.CameraSelectPath(pathIds: new[] {4013, 4014}, arg2: false);
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_anosCare");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State대련종료씬시작09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작09 : TriggerState {
            internal State대련종료씬시작09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Down_Idle_A", arg2: 12000f);
                context.SetSkill(arg1: new[] {7005}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State대련종료씬시작09_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작09_b : TriggerState {
            internal State대련종료씬시작09_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 501, arg2: "MS2PatrolData_caitRun2");
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new[] {4015}, arg2: false);
                context.AddCinematicTalk(npcId: 11003147, script: "$52000100_QD__52000100__6$", duration: 4000, align: Align.Right);
                context.SetOnetimeEffect(id: 3000964, enable: true, path: @"BG/Common/Sound/Eff_Caitlyn_IntroQuest_03000964.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State대련종료씬시작10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작10 : TriggerState {
            internal State대련종료씬시작10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4016}, arg2: false);
                context.AddCinematicTalk(npcId: 11003147, script: "$52000100_QD__52000100__7$", duration: 4000, align: Align.Right);
                context.SetOnetimeEffect(id: 3000965, enable: true, path: @"BG/Common/Sound/Eff_Caitlyn_IntroQuest_03000965.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State대련종료씬시작11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작11 : TriggerState {
            internal State대련종료씬시작11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4017}, arg2: false);
                context.AddCinematicTalk(npcId: 11003148, script: "$52000100_QD__52000100__8$", duration: 4000, align: Align.Right);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State대련종료씬시작12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작12 : TriggerState {
            internal State대련종료씬시작12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnPointId: 200, emotionName: "Surprised");
                context.CameraSelectPath(pathIds: new[] {4018}, arg2: false);
                context.AddCinematicTalk(npcId: 11003148, script: "$52000100_QD__52000100__9$", duration: 4000, align: Align.Right);
                context.SetEffect(arg1: new[] {902, 903, 904, 905, 906, 907}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State대련종료씬시작14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작14 : TriggerState {
            internal State대련종료씬시작14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4019}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State대련종료씬시작15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작15 : TriggerState {
            internal State대련종료씬시작15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4020, 4021}, arg2: false);
                context.AddCinematicTalk(npcId: 11003147, script: "$52000100_QD__52000100__10$", duration: 4000, align: Align.Right);
                context.SetOnetimeEffect(id: 3000966, enable: true, path: @"BG/Common/Sound/Eff_Caitlyn_IntroQuest_03000966.xml");
                context.MoveNpc(arg1: 501, arg2: "MS2PatrolData_caitlookBack");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State대련종료씬시작17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작17 : TriggerState {
            internal State대련종료씬시작17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4022, 4023}, arg2: false);
                context.AddCinematicTalk(npcId: 11003147, script: "$52000100_QD__52000100__11$", duration: 4000, align: Align.Right);
                context.SetOnetimeEffect(id: 3000967, enable: true, path: @"BG/Common/Sound/Eff_Caitlyn_IntroQuest_03000967.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State대련종료씬시작17_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작17_b : TriggerState {
            internal State대련종료씬시작17_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003147, script: "$52000100_QD__52000100__12$", duration: 4000, align: Align.Right);
                context.SetOnetimeEffect(id: 3000968, enable: true, path: @"BG/Common/Sound/Eff_Caitlyn_IntroQuest_03000968.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new State대련종료씬시작18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작18 : TriggerState {
            internal State대련종료씬시작18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 0, msg: "$52000100_QD__52000100__13$", duration: 6000, delayTick: 1000);
                context.AddCinematicTalk(npcId: 11003147, script: "$52000100_QD__52000100__14$", duration: 4000, align: Align.Right);
                context.SetOnetimeEffect(id: 3000969, enable: true, path: @"BG/Common/Sound/Eff_Caitlyn_IntroQuest_03000969.xml");
                context.CameraSelectPath(pathIds: new[] {4024, 4025}, arg2: false);
                context.MoveNpc(arg1: 501, arg2: "MS2PatrolData_caitOut");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State대련종료씬시작18_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작18_1 : TriggerState {
            internal State대련종료씬시작18_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State대련종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_3 : TriggerState {
            internal StateSkip_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOut.xml");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_anosCare");
                context.SetEffect(arg1: new[] {901, 902, 903, 904, 905, 906, 907, 908, 909}, arg2: false);
                context.SetEffect(arg1: new[] {902, 903, 904, 905, 906, 907}, arg2: true);
                context.DestroyMonster(arg1: new[] {501});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State대련종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대련종료 : TriggerState {
            internal State대련종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.DestroyMonster(arg1: new[] {501});
                context.RemoveBuff(arg1: 9003, arg2: 70000109);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002291}, arg3: new byte[] {3})) {
                    return new State아시모프와대화01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아시모프와대화01 : TriggerState {
            internal State아시모프와대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_Pc_stepAside");
                context.SetCinematicUI(type: 1);
                context.CreateMonster(arg1: new[] {202}, arg2: false);
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_asmovMove");
                context.AddBalloonTalk(spawnPointId: 202, msg: "$52000100_QD__52000100__15$", duration: 5000, delayTick: 1000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State아시모프와대화03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아시모프와대화03 : TriggerState {
            internal State아시모프와대화03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateSkip_4(context), arg2: "nextState");
                context.CameraSelectPath(pathIds: new[] {4028}, arg2: false);
                context.ShowCaption(type: CaptionType.Name, title: "$52000100_QD__52000100__16$", script: "$52000100_QD__52000100__17$", align: Align.Center, offsetRateX: -0.05f, offsetRateY: 0.15f, duration: 10000, scale: 2.0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State아시모프와대화03_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아시모프와대화03_1 : TriggerState {
            internal State아시모프와대화03_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State아시모프와대화04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_4 : TriggerState {
            internal StateSkip_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.CameraReset(interpolationTime: 0.5f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State아시모프와대화04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아시모프와대화04 : TriggerState {
            internal State아시모프와대화04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002292}, arg3: new byte[] {2})) {
                    return new State아시모프와대화05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아시모프와대화05 : TriggerState {
            internal State아시모프와대화05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 202, msg: "$52000100_QD__52000100__18$", duration: 6000, delayTick: 1000);
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_anos_goRoom");
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_asimov_goRoom");
                context.ShowGuideSummary(entityId: 25201009, textId: 25201009, duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State아시모프와대화06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아시모프와대화06 : TriggerState {
            internal State아시모프와대화06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000102, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9003, arg2: new[] {202})) {
                    return new State아시모프와대화04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}