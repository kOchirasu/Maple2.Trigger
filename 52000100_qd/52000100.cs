using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000100_qd {
    public static class _52000100 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{200}, arg2: false);
                context.SetEffect(triggerIds: new []{901, 902, 903, 904, 905, 906, 907, 908, 909, 5305, 5306, 5307, 5308, 5309, 5310, 5305, 5400, 5401, 5402, 5403, 5404, 5405, 5406, 5407}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002290}, questStates: new byte[]{3})) {
                    return new State케이틀린대련01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002292}, questStates: new byte[]{2})) {
                    return new State아시모프와대화01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002291}, questStates: new byte[]{1})) {
                    return new State케이틀린대련04(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002291}, questStates: new byte[]{2})) {
                    return new State대련종료씬시작02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002290}, questStates: new byte[]{1})) {
                    return new StateMonster소환교육04(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9003}, questIds: new []{20002286}, questStates: new byte[]{2})) {
                    return new State강의실입장01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002287}, questStates: new byte[]{1})) {
                    return new State참교육01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002288}, questStates: new byte[]{1})) {
                    return new State참교육02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002289}, questStates: new byte[]{1})) {
                    return new StateMonster소환교육01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State강의실입장01 : TriggerState {
            internal State강의실입장01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5305, 5306, 5307, 5308, 5309, 5310}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002286}, questStates: new byte[]{2})) {
                    return new State아노스Spawn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Spawn01 : TriggerState {
            internal State아노스Spawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.MoveUser(mapId: 52000100, portalId: 3);
                context.SetEffect(triggerIds: new []{5305, 5306, 5307, 5308, 5309, 5310}, visible: false);
            }

            public override TriggerState? Execute() {
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
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetPcEmotionLoop(sequenceName: "Emotion_Disappoint_Idle_A", duration: 2000f);
                context.CameraSelectPath(pathIds: new []{4000, 4001}, returnView: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 11003148, illustId: "Anos_normal", script: "$52000100_QD__52000100__0$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
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
                context.CameraSelectPath(pathIds: new []{4002}, returnView: false);
                context.ShowCaption(type: CaptionType.Name, title: "$52000100_QD__52000100__1$", script: "$52000100_QD__52000100__2$", align: Align.Center, offsetRateX: -0.05f, offsetRateY: 0.15f, duration: 10000, scale: 2.0f);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002287}, questStates: new byte[]{1})) {
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

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002288}, questStates: new byte[]{1})) {
                    return new State참교육02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State참교육02 : TriggerState {
            internal State참교육02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5400, 5401, 5402, 5403, 5404, 5405, 5406, 5407}, visible: true);
                context.ShowGuideSummary(entityId: 25201003, textId: 25201003, duration: 8000);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002288}, questStates: new byte[]{2})) {
                    return new State참교육완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State참교육완료 : TriggerState {
            internal State참교육완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5400, 5401, 5402, 5403, 5404, 5405, 5406, 5407}, visible: false);
                context.ShowGuideSummary(entityId: 25201003, textId: 25201003, duration: 8000);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002289}, questStates: new byte[]{1})) {
                    return new StateMonster소환교육01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster소환교육01 : TriggerState {
            internal StateMonster소환교육01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5400, 5401, 5402, 5403, 5404, 5405, 5406, 5407}, visible: false);
                context.CreateMonster(spawnIds: new []{300, 301, 302, 303, 304, 305}, arg2: false);
                context.MoveNpc(spawnId: 203, patrolName: "MS2PatrolData_caitSneak");
                context.ShowGuideSummary(entityId: 25201004, textId: 25201004, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{300, 301, 302, 303, 304, 305})) {
                    return new StateMonster소환교육02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster소환교육02 : TriggerState {
            internal StateMonster소환교육02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002290}, questStates: new byte[]{1})) {
                    return new StateMonster소환교육04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster소환교육04 : TriggerState {
            internal StateMonster소환교육04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{400, 401, 402, 403, 404, 405}, arg2: false);
                context.ShowGuideSummary(entityId: 25201005, textId: 25201005, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002290}, questStates: new byte[]{3})) {
                    return new State케이틀린대련01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린대련01 : TriggerState {
            internal State케이틀린대련01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 9006, enabled: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CreateMonster(spawnIds: new []{203}, arg2: false);
                context.MoveNpc(spawnId: 203, patrolName: "MS2PatrolData_caitComeOut");
                context.CameraSelectPath(pathIds: new []{4003, 4004}, returnView: false);
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_turnAnos");
            }

            public override TriggerState? Execute() {
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
                context.FaceEmotion(spawnId: 200, emotionName: "UpSet");
                context.AddCinematicTalk(npcId: 11003146, illustId: "Caitlyn_normal", script: "$52000100_QD__52000100__3$", duration: 4000, align: Align.Right);
                context.SetOnetimeEffect(id: 3000950, enabled: true, path: @"BG/Common/Sound/Eff_Caitlyn_IntroQuest_03000950.xml");
            }

            public override TriggerState? Execute() {
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
                context.SetOnetimeEffect(id: 3000951, enabled: true, path: @"BG/Common/Sound/Eff_Caitlyn_IntroQuest_03000951.xml");
            }

            public override TriggerState? Execute() {
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
                context.SetOnetimeEffect(id: 3000952, enabled: true, path: @"BG/Common/Sound/Eff_Caitlyn_IntroQuest_03000952.xml");
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002291}, questStates: new byte[]{3})) {
                    return new State대련종료씬시작01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002291}, questStates: new byte[]{2})) {
                    return new State대련종료씬시작01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002291}, questStates: new byte[]{1})) {
                    return new State케이틀린대련04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린대련04 : TriggerState {
            internal State케이틀린대련04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{9003}, skillId: 70000109, level: 1, arg4: false, arg5: false);
                context.SetSound(triggerId: 9006, enabled: true);
                context.DestroyMonster(spawnIds: new []{203});
                context.CreateMonster(spawnIds: new []{500}, arg2: false);
                context.ShowGuideSummary(entityId: 25201007, textId: 25201007, duration: 5000);
                context.AddBuff(boxIds: new []{9001}, skillId: 99910231, level: 1, arg4: false, arg5: false);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{500})) {
                    return new State대련종료씬시작01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작01 : TriggerState {
            internal State대련종료씬시작01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.DestroyMonster(spawnIds: new []{203});
            }

            public override TriggerState? Execute() {
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
                context.RemoveBuff(boxId: 9001, skillId: 99910231);
                context.SetCinematicUI(type: 1);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CreateMonster(spawnIds: new []{501}, arg2: false);
                context.MoveUser(mapId: 52000100, portalId: 4);
                context.MoveNpc(spawnId: 501, patrolName: "MS2PatrolData_caitRun");
            }

            public override TriggerState? Execute() {
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
                context.MoveUserPath(patrolName: "MS2PatrolData_PCRun");
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{4005, 4006}, returnView: false);
            }

            public override TriggerState? Execute() {
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
                context.SetNpcEmotionSequence(spawnId: 501, sequenceName: "Bore_A");
                context.SetEffect(triggerIds: new []{902}, visible: true);
                context.SetTimeScale(enabled: true, startScale: 0.6f, endScale: 0.1f, duration: 3.5f, interpolator: 2);
                context.CameraSelectPath(pathIds: new []{4007, 4008}, returnView: false);
            }

            public override TriggerState? Execute() {
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
                context.CameraSelectPath(pathIds: new []{4009, 4010, 4027}, returnView: false);
                context.SetTimeScale(enabled: false, startScale: 1f, endScale: 0.1f, duration: 2.5f, interpolator: 2);
            }

            public override TriggerState? Execute() {
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
                context.SetPcEmotionSequence(sequenceNames: new []{"Wizard_Enterance_A"});
                context.SetPcEmotionLoop(sequenceName: "Wizard_Enterance_A", duration: 5000f);
                context.SetEffect(triggerIds: new []{901}, visible: true);
                context.SetTimeScale(enabled: true, startScale: 1f, endScale: 0.1f, duration: 5.5f, interpolator: 2);
            }

            public override TriggerState? Execute() {
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
                context.SetTimeScale(enabled: true, startScale: 0.1f, endScale: 0.1f, duration: 6.5f, interpolator: 2);
                context.SetNpcEmotionLoop(spawnId: 501, sequenceName: "Attack_Idle_A", duration: 17500f);
                context.SetPcEmotionLoop(sequenceName: "Wizard_Enterance_A", duration: 5000f);
                context.CameraSelectPath(pathIds: new []{4011, 4012}, returnView: false);
                context.SetEffect(triggerIds: new []{908, 909}, visible: true);
                context.SetOnetimeEffect(id: 3, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOutFast.xml");
            }

            public override TriggerState? Execute() {
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
                context.SetEffect(triggerIds: new []{901, 902}, visible: false);
                context.SetOnetimeEffect(id: 3, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOut.xml");
                context.MoveUser(mapId: 52000100, portalId: 5);
                context.CameraSelectPath(pathIds: new []{4013, 4014}, returnView: false);
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_anosCare");
            }

            public override TriggerState? Execute() {
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
                context.SetPcEmotionLoop(sequenceName: "Down_Idle_A", duration: 12000f);
                context.SetSkill(triggerIds: new []{7005}, enabled: true);
            }

            public override TriggerState? Execute() {
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
                context.MoveNpc(spawnId: 501, patrolName: "MS2PatrolData_caitRun2");
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{4015}, returnView: false);
                context.AddCinematicTalk(npcId: 11003147, script: "$52000100_QD__52000100__6$", duration: 4000, align: Align.Right);
                context.SetOnetimeEffect(id: 3000964, enabled: true, path: @"BG/Common/Sound/Eff_Caitlyn_IntroQuest_03000964.xml");
            }

            public override TriggerState? Execute() {
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
                context.CameraSelectPath(pathIds: new []{4016}, returnView: false);
                context.AddCinematicTalk(npcId: 11003147, script: "$52000100_QD__52000100__7$", duration: 4000, align: Align.Right);
                context.SetOnetimeEffect(id: 3000965, enabled: true, path: @"BG/Common/Sound/Eff_Caitlyn_IntroQuest_03000965.xml");
            }

            public override TriggerState? Execute() {
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
                context.CameraSelectPath(pathIds: new []{4017}, returnView: false);
                context.AddCinematicTalk(npcId: 11003148, script: "$52000100_QD__52000100__8$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
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
                context.FaceEmotion(spawnId: 200, emotionName: "Surprised");
                context.CameraSelectPath(pathIds: new []{4018}, returnView: false);
                context.AddCinematicTalk(npcId: 11003148, script: "$52000100_QD__52000100__9$", duration: 4000, align: Align.Right);
                context.SetEffect(triggerIds: new []{902, 903, 904, 905, 906, 907}, visible: true);
            }

            public override TriggerState? Execute() {
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
                context.CameraSelectPath(pathIds: new []{4019}, returnView: false);
            }

            public override TriggerState? Execute() {
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
                context.CameraSelectPath(pathIds: new []{4020, 4021}, returnView: false);
                context.AddCinematicTalk(npcId: 11003147, script: "$52000100_QD__52000100__10$", duration: 4000, align: Align.Right);
                context.SetOnetimeEffect(id: 3000966, enabled: true, path: @"BG/Common/Sound/Eff_Caitlyn_IntroQuest_03000966.xml");
                context.MoveNpc(spawnId: 501, patrolName: "MS2PatrolData_caitlookBack");
            }

            public override TriggerState? Execute() {
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
                context.CameraSelectPath(pathIds: new []{4022, 4023}, returnView: false);
                context.AddCinematicTalk(npcId: 11003147, script: "$52000100_QD__52000100__11$", duration: 4000, align: Align.Right);
                context.SetOnetimeEffect(id: 3000967, enabled: true, path: @"BG/Common/Sound/Eff_Caitlyn_IntroQuest_03000967.xml");
            }

            public override TriggerState? Execute() {
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
                context.SetOnetimeEffect(id: 3000968, enabled: true, path: @"BG/Common/Sound/Eff_Caitlyn_IntroQuest_03000968.xml");
            }

            public override TriggerState? Execute() {
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
                context.AddBalloonTalk(spawnId: 0, msg: "$52000100_QD__52000100__13$", duration: 6000, delayTick: 1000);
                context.AddCinematicTalk(npcId: 11003147, script: "$52000100_QD__52000100__14$", duration: 4000, align: Align.Right);
                context.SetOnetimeEffect(id: 3000969, enabled: true, path: @"BG/Common/Sound/Eff_Caitlyn_IntroQuest_03000969.xml");
                context.CameraSelectPath(pathIds: new []{4024, 4025}, returnView: false);
                context.MoveNpc(spawnId: 501, patrolName: "MS2PatrolData_caitOut");
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 3, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOut.xml");
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_anosCare");
                context.SetEffect(triggerIds: new []{901, 902, 903, 904, 905, 906, 907, 908, 909}, visible: false);
                context.SetEffect(triggerIds: new []{902, 903, 904, 905, 906, 907}, visible: true);
                context.DestroyMonster(spawnIds: new []{501});
            }

            public override TriggerState? Execute() {
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
                context.DestroyMonster(spawnIds: new []{501});
                context.RemoveBuff(boxId: 9003, skillId: 70000109);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002291}, questStates: new byte[]{3})) {
                    return new State아시모프와대화01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아시모프와대화01 : TriggerState {
            internal State아시모프와대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_Pc_stepAside");
                context.SetCinematicUI(type: 1);
                context.CreateMonster(spawnIds: new []{202}, arg2: false);
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_asmovMove");
                context.AddBalloonTalk(spawnId: 202, msg: "$52000100_QD__52000100__15$", duration: 5000, delayTick: 1000);
            }

            public override TriggerState? Execute() {
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
                context.CameraSelectPath(pathIds: new []{4028}, returnView: false);
                context.ShowCaption(type: CaptionType.Name, title: "$52000100_QD__52000100__16$", script: "$52000100_QD__52000100__17$", align: Align.Center, offsetRateX: -0.05f, offsetRateY: 0.15f, duration: 10000, scale: 2.0f);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002292}, questStates: new byte[]{2})) {
                    return new State아시모프와대화05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아시모프와대화05 : TriggerState {
            internal State아시모프와대화05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 202, msg: "$52000100_QD__52000100__18$", duration: 6000, delayTick: 1000);
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_anos_goRoom");
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_asimov_goRoom");
                context.ShowGuideSummary(entityId: 25201009, textId: 25201009, duration: 5000);
            }

            public override TriggerState? Execute() {
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
                context.MoveUser(mapId: 52000102, portalId: 1);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9003, spawnIds: new []{202})) {
                    return new State아시모프와대화04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
