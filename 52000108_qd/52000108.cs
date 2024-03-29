using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000108_qd {
    public static class _52000108 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{2001}, visible: false);
                context.CreateMonster(spawnIds: new []{200}, arg2: false);
                context.SetEffect(triggerIds: new []{5000, 5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012, 5013, 5014, 5015, 5016, 5017, 5018, 4000, 4001, 4002, 4002, 4003, 4004, 4005, 4006, 4007, 4008}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10010}, questIds: new []{20002301}, questStates: new byte[]{3})) {
                    context.MoveUser(mapId: 52000109, portalId: 1);
                }

                if (context.QuestUserDetected(boxIds: new []{10010}, questIds: new []{20002297}, questStates: new byte[]{1})) {
                    return new State불끄기Quest01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10010}, questIds: new []{20002298}, questStates: new byte[]{1})) {
                    return new State워터슬라임Quest01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10010}, questIds: new []{20002300}, questStates: new byte[]{1})) {
                    return new State저항군로봇Quest01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10010}, questIds: new []{20002301}, questStates: new byte[]{1})) {
                    return new State저항군로봇Quest01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10010}, questIds: new []{20002300}, questStates: new byte[]{3})) {
                    return new State저항군로봇Quest01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10010}, questIds: new []{20002299}, questStates: new byte[]{3})) {
                    return new State저항군로봇Quest01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State불끄기Quest01 : TriggerState {
            internal State불끄기Quest01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{2000}, returnView: false);
                context.MoveUser(mapId: 52000108, portalId: 10);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State불끄기Quest02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State불끄기Quest02 : TriggerState {
            internal State불끄기Quest02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.AddCinematicTalk(npcId: 11003292, illustId: "0", script: "$52000108_QD__52000108__0$", duration: 4000, align: Align.Right);
                context.SetOnetimeEffect(id: 3000972, enabled: true, path: @"BG/Common/Sound/Eff_Ayesha_IntroMovie_03000972.xml");
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_ishaTrun");
                context.MoveUserPath(patrolName: "MS2PatrolData_PCTrun");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State불끄기Quest03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State불끄기Quest03 : TriggerState {
            internal State불끄기Quest03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, illustId: "0", script: "$52000108_QD__52000108__1$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State불끄기Quest04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State불끄기Quest04 : TriggerState {
            internal State불끄기Quest04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, illustId: "0", script: "$52000108_QD__52000108__2$", duration: 4000, align: Align.Right);
                context.SetPcEmotionLoop(sequenceName: "Emotion_Dance_S", duration: 4000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State불끄기Quest05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State불끄기Quest05 : TriggerState {
            internal State불끄기Quest05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, illustId: "0", script: "$52000108_QD__52000108__3$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State불끄기Quest06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State불끄기Quest06 : TriggerState {
            internal State불끄기Quest06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 9000, enabled: true);
                context.CameraSelectPath(pathIds: new []{2002}, returnView: false);
                context.SetOnetimeEffect(id: 40, enabled: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.AddCinematicTalk(npcId: 11003292, illustId: "0", script: "$52000108_QD__52000108__4$", duration: 6000, align: Align.Right);
                context.SetOnetimeEffect(id: 3000973, enabled: true, path: @"BG/Common/Sound/Eff_Ayesha_IntroMovie_03000973.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State불끄기Quest07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State불끄기Quest07 : TriggerState {
            internal State불끄기Quest07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 50, enabled: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.AddCinematicTalk(npcId: 0, illustId: "0", script: "$52000108_QD__52000108__5$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State불끄기Quest08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State불끄기Quest08 : TriggerState {
            internal State불끄기Quest08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003292, illustId: "$52000108_QD__52000108__45$", script: "$52000108_QD__52000108__6$", duration: 4000, align: Align.Right);
                context.SetOnetimeEffect(id: 3000974, enabled: true, path: @"BG/Common/Sound/Eff_Ayesha_IntroMovie_03000974.xml");
                context.CameraSelectPath(pathIds: new []{2003}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State불끄기Quest09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State불끄기Quest09 : TriggerState {
            internal State불끄기Quest09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 60, enabled: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.CameraSelectPath(pathIds: new []{2004}, returnView: false);
                context.SetMesh(triggerIds: new []{2001}, visible: true);
                context.AddCinematicTalk(npcId: 11003292, script: "$52000108_QD__52000108__7$", duration: 8000, align: Align.Right);
                context.SetOnetimeEffect(id: 3000975, enabled: true, path: @"BG/Common/Sound/Eff_Ayesha_IntroMovie_03000975.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9500)) {
                    return new State불끄기Quest10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State불끄기Quest10 : TriggerState {
            internal State불끄기Quest10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{2003}, returnView: false);
                context.AddCinematicTalk(npcId: 11003292, illustId: "0", script: "$52000108_QD__52000108__8$", duration: 5000, align: Align.Right);
                context.SetOnetimeEffect(id: 3000976, enabled: true, path: @"BG/Common/Sound/Eff_Ayesha_IntroMovie_03000976.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State불끄기Quest11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State불끄기Quest11 : TriggerState {
            internal State불끄기Quest11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{2008}, returnView: false);
                context.AddCinematicTalk(npcId: 0, illustId: "0", script: "$52000108_QD__52000108__9$", duration: 2000, align: Align.Right);
                context.SetPcEmotionSequence(sequenceNames: new []{"Emotion_Choice_A"});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State불끄기Quest12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State불끄기Quest12 : TriggerState {
            internal State불끄기Quest12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, illustId: "0", script: "$52000108_QD__52000108__10$", duration: 4000, align: Align.Right);
                context.SetPcEmotionLoop(sequenceName: "Snare_A", duration: 5000f);
                context.FaceEmotion(spawnId: 0, emotionName: "PC_OutOfMind_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State불끄기Quest13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State불끄기Quest13 : TriggerState {
            internal State불끄기Quest13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State20002300QuestWait01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.MoveUser(mapId: 52000108, portalId: 10);
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_ishaTrun");
                context.SetMesh(triggerIds: new []{2001}, visible: true);
                context.CameraReset(interpolationTime: 1.0f);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State20002300QuestWait01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20002300QuestWait01 : TriggerState {
            internal State20002300QuestWait01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.ShowGuideSummary(entityId: 25201081, textId: 25201081, duration: 10000);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10010}, questIds: new []{20002298}, questStates: new byte[]{1})) {
                    return new State워터슬라임Quest01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State워터슬라임Quest01 : TriggerState {
            internal State워터슬라임Quest01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{300, 301, 302, 303, 304, 305}, arg2: false);
                context.MoveNpc(spawnId: 203, patrolName: "MS2PatrolData_caitSneak");
                context.ShowGuideSummary(entityId: 25201082, textId: 25201082, duration: 10000);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10010}, questIds: new []{20002299}, questStates: new byte[]{3})) {
                    return new State저항군로봇Quest01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State저항군로봇Quest01 : TriggerState {
            internal State저항군로봇Quest01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 9000, enabled: false);
                context.SetSound(triggerId: 9001, enabled: true);
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{2013, 2014}, returnView: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUser(mapId: 52000108, portalId: 12);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State저항군로봇Quest02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State저항군로봇Quest02 : TriggerState {
            internal State저항군로봇Quest02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateSkip_2(context), arg2: "nextState");
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.AddCinematicTalk(npcId: 0, illustId: "0", script: "$52000108_QD__52000108__11$", duration: 6000, align: Align.Right);
                context.SetPcEmotionLoop(sequenceName: "Object_React_D", duration: 25000f);
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_ishaCom");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State저항군로봇Quest03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State저항군로봇Quest03 : TriggerState {
            internal State저항군로봇Quest03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003292, script: "$52000108_QD__52000108__12$", duration: 4000, align: Align.Right);
                context.SetOnetimeEffect(id: 3000977, enabled: true, path: @"BG/Common/Sound/Eff_Ayesha_IntroMovie_03000977.xml");
                context.CameraSelectPath(pathIds: new []{2015}, returnView: false);
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_isha_8");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State저항군로봇Quest04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State저항군로봇Quest04 : TriggerState {
            internal State저항군로봇Quest04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, illustId: "0", script: "$52000108_QD__52000108__13$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State저항군로봇Quest05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State저항군로봇Quest05 : TriggerState {
            internal State저항군로봇Quest05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, illustId: "0", script: "$52000108_QD__52000108__14$", duration: 4000, align: Align.Right);
                context.CameraSelectPath(pathIds: new []{2016}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State저항군로봇Quest06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State저항군로봇Quest06 : TriggerState {
            internal State저항군로봇Quest06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003292, script: "$52000108_QD__52000108__15$", duration: 6000, align: Align.Right);
                context.SetOnetimeEffect(id: 3000978, enabled: true, path: @"BG/Common/Sound/Eff_Ayesha_IntroMovie_03000978.xml");
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_isha_9");
                context.CameraSelectPath(pathIds: new []{2017, 2018}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State저항군로봇Quest07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State저항군로봇Quest07 : TriggerState {
            internal State저항군로봇Quest07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, illustId: "0", script: "$52000108_QD__52000108__16$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State저항군로봇Quest08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State저항군로봇Quest08 : TriggerState {
            internal State저항군로봇Quest08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{2028}, returnView: false);
                context.AddCinematicTalk(npcId: 11003292, script: "$52000108_QD__52000108__17$", duration: 6000, align: Align.Right);
                context.SetOnetimeEffect(id: 3000979, enabled: true, path: @"BG/Common/Sound/Eff_Ayesha_IntroMovie_03000979.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State저항군로봇Quest09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State저항군로봇Quest09 : TriggerState {
            internal State저항군로봇Quest09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 9002, enabled: true);
                context.SetTimeScale(enabled: true, startScale: 0.1f, endScale: 0.1f, duration: 7f, interpolator: 2);
                context.SetSkill(triggerIds: new []{500}, enabled: true);
                context.CameraSelectPath(pathIds: new []{2010, 2019}, returnView: false);
                context.SetEffect(triggerIds: new []{4000, 4001, 4002}, visible: true);
                context.MoveUserPath(patrolName: "MS2PatrolData_PC_TurnLeft");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new State저항군로봇Quest10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State저항군로봇Quest10 : TriggerState {
            internal State저항군로봇Quest10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnId: 0, emotionName: "PC_OutOfMind_01");
                context.CameraSelectPath(pathIds: new []{2031}, returnView: false);
                context.AddCinematicTalk(npcId: 0, illustId: "0", script: "$52000108_QD__52000108__18$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State저항군로봇Quest11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State저항군로봇Quest11 : TriggerState {
            internal State저항군로봇Quest11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{201, 202, 206}, arg2: false);
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_Checky");
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_sigmund");
                context.MoveNpc(spawnId: 206, patrolName: "MS2PatrolData_henry");
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_IshaCheck");
                context.CameraSelectPath(pathIds: new []{2011, 2012}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State저항군로봇Quest12a(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State저항군로봇Quest12a : TriggerState {
            internal State저항군로봇Quest12a(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{2029, 2030}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State저항군로봇Quest12_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State저항군로봇Quest12_b : TriggerState {
            internal State저항군로봇Quest12_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{2020, 2021}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State저항군로봇Quest12_c(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State저항군로봇Quest12_c : TriggerState {
            internal State저항군로봇Quest12_c(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: CaptionType.Name, title: "$52000108_QD__52000108__19$", align: Align.Center, offsetRateX: -0.15f, offsetRateY: 0.15f, duration: 3500, scale: 2.0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4100)) {
                    return new State저항군로봇Quest13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State저항군로봇Quest13 : TriggerState {
            internal State저항군로봇Quest13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{2022, 2023}, returnView: false);
                context.ShowCaption(type: CaptionType.Name, title: "$52000108_QD__52000108__20$", align: Align.Center, offsetRateX: -0.15f, offsetRateY: 0.15f, duration: 3500, scale: 2.0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4100)) {
                    return new State저항군로봇Quest14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State저항군로봇Quest14 : TriggerState {
            internal State저항군로봇Quest14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 202, sequenceName: "Bore_B");
                context.CameraSelectPath(pathIds: new []{2024, 2025}, returnView: false);
                context.ShowCaption(type: CaptionType.Name, title: "$52000108_QD__52000108__22$", align: Align.Center, offsetRateX: -0.15f, offsetRateY: 0.15f, duration: 3500, scale: 2.0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4100)) {
                    return new State저항군로봇Quest15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State저항군로봇Quest15 : TriggerState {
            internal State저항군로봇Quest15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000108, portalId: 11);
                context.CameraSelectPath(pathIds: new []{2026, 2027}, returnView: false);
                context.ShowCaption(type: CaptionType.Name, title: "$52000108_QD__52000108__24$", script: "$52000108_QD__52000108__25$", align: Align.Top | Align.Center, duration: 4000, scale: 3.0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4100)) {
                    return new State저항군로봇Quest15_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State저항군로봇Quest15_1 : TriggerState {
            internal State저항군로봇Quest15_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State저항군로봇Quest16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_2 : TriggerState {
            internal StateSkip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.MoveUser(mapId: 52000108, portalId: 11);
                context.CreateMonster(spawnIds: new []{201, 202, 206}, arg2: false);
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_Checky");
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_sigmund");
                context.MoveNpc(spawnId: 206, patrolName: "MS2PatrolData_henry");
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_IshaCheck");
                context.SetSkill(triggerIds: new []{500}, enabled: true);
                context.SetEffect(triggerIds: new []{4000, 4001, 4002}, visible: true);
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State저항군로봇Quest16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State저항군로봇Quest16 : TriggerState {
            internal State저항군로봇Quest16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnId: 0);
                context.CameraReset(interpolationTime: 1.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.ShowGuideSummary(entityId: 25201083, textId: 25201083, duration: 10000);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10010}, questIds: new []{20002301}, questStates: new byte[]{3})) {
                    context.MoveUser(mapId: 52000109, portalId: 1);
                }

                if (context.QuestUserDetected(boxIds: new []{10010}, questIds: new []{20002301}, questStates: new byte[]{2})) {
                    return new State프로토콜해피01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10010}, questIds: new []{20002301}, questStates: new byte[]{1})) {
                    return new State체키등판Quest01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10010}, questIds: new []{20002300}, questStates: new byte[]{1})) {
                    return new State저항군로봇Quest17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State저항군로봇Quest17 : TriggerState {
            internal State저항군로봇Quest17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_sigmund_back");
                context.CreateMonster(spawnIds: new []{306, 307, 308, 309, 310}, arg2: false);
                context.ShowGuideSummary(entityId: 25201084, textId: 25201084, duration: 10000);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10010}, questIds: new []{20002301}, questStates: new byte[]{1})) {
                    return new State체키등판Quest01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State체키등판Quest01 : TriggerState {
            internal State체키등판Quest01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{2032, 2033}, returnView: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUser(mapId: 52000108, portalId: 11);
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_sigmund_back");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State체키등판Quest02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State체키등판Quest02 : TriggerState {
            internal State체키등판Quest02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateSkip_3(context), arg2: "nextState");
                context.SetOnetimeEffect(id: 3, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.AddCinematicTalk(npcId: 11003191, script: "$52000108_QD__52000108__26$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State체키등판Quest03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State체키등판Quest03 : TriggerState {
            internal State체키등판Quest03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{2034, 2035}, returnView: false);
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_CheckyBoss");
                context.AddCinematicTalk(npcId: 11003191, script: "$52000108_QD__52000108__27$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State체키등판Quest04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State체키등판Quest04 : TriggerState {
            internal State체키등판Quest04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{2036}, returnView: false);
                context.AddCinematicTalk(npcId: 11003184, script: "$52000108_QD__52000108__28$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5459)) {
                    return new State체키등판Quest05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State체키등판Quest05 : TriggerState {
            internal State체키등판Quest05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{2037, 2038}, returnView: false);
                context.AddCinematicTalk(npcId: 11003191, script: "$52000108_QD__52000108__29$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State체키등판Quest06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State체키등판Quest06 : TriggerState {
            internal State체키등판Quest06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{2039, 2040}, returnView: false);
                context.AddCinematicTalk(npcId: 11003184, script: "$52000108_QD__52000108__30$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4388)) {
                    return new State체키등판Quest06_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State체키등판Quest06_1 : TriggerState {
            internal State체키등판Quest06_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State체키등판Quest07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_3 : TriggerState {
            internal StateSkip_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_CheckyBoss");
                context.SetOnetimeEffect(id: 3, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State체키등판Quest07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State체키등판Quest07 : TriggerState {
            internal State체키등판Quest07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.DestroyMonster(spawnIds: new []{201});
                context.CreateMonster(spawnIds: new []{311}, arg2: false);
                context.AddBalloonTalk(spawnId: 0, msg: "$52000108_QD__52000108__31$", duration: 5000, delayTick: 1000);
                context.AddBalloonTalk(spawnId: 205, msg: "$52000108_QD__52000108__32$", duration: 6000, delayTick: 4000);
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_IshaOut");
                context.ShowGuideSummary(entityId: 25201085, textId: 25201085, duration: 10000);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10010}, questIds: new []{20002301}, questStates: new byte[]{2})) {
                    return new State프로토콜해피01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프로토콜해피01 : TriggerState {
            internal State프로토콜해피01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{2041, 2042}, returnView: false);
                context.MoveUser(mapId: 52000108, portalId: 11);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.DestroyMonster(spawnIds: new []{200, 201, 202, 311});
                context.CreateMonster(spawnIds: new []{208, 209, 210}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State프로토콜해피02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프로토콜해피02 : TriggerState {
            internal State프로토콜해피02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateSkip_4(context), arg2: "nextState");
                context.SetOnetimeEffect(id: 4, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.AddCinematicTalk(npcId: 11003191, script: "$52000108_QD__52000108__33$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State프로토콜해피03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프로토콜해피03 : TriggerState {
            internal State프로토콜해피03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_PC_front");
                context.CameraSelectPath(pathIds: new []{2043}, returnView: false);
                context.AddCinematicTalk(npcId: 0, illustId: "0", script: "$52000108_QD__52000108__34$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State프로토콜해피04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프로토콜해피04 : TriggerState {
            internal State프로토콜해피04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnId: 0, emotionName: "ChaosMod_Start");
                context.CameraSelectPath(pathIds: new []{2044}, returnView: false);
                context.AddCinematicTalk(npcId: 0, illustId: "0", script: "$52000108_QD__52000108__35$", duration: 2500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State프로토콜해피05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프로토콜해피05 : TriggerState {
            internal State프로토콜해피05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 208, sequenceName: "Attack_Idle_A", duration: 20000f);
                context.CameraSelectPath(pathIds: new []{2045, 2046}, returnView: false);
                context.AddCinematicTalk(npcId: 11003292, script: "$52000108_QD__52000108__36$", duration: 4000, align: Align.Right);
                context.SetOnetimeEffect(id: 3000980, enabled: true, path: @"BG/Common/Sound/Eff_Ayesha_IntroMovie_03000980.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State프로토콜해피06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프로토콜해피06 : TriggerState {
            internal State프로토콜해피06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnId: 0);
                context.CameraSelectPath(pathIds: new []{2047}, returnView: false);
                context.AddCinematicTalk(npcId: 0, illustId: "0", script: "$52000108_QD__52000108__37$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State프로토콜해피07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프로토콜해피07 : TriggerState {
            internal State프로토콜해피07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnId: 209, emotionName: "Surprised");
                context.CameraSelectPath(pathIds: new []{2048}, returnView: false);
                context.AddCinematicTalk(npcId: 11003183, script: "$52000108_QD__52000108__38$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State프로토콜해피08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프로토콜해피08 : TriggerState {
            internal State프로토콜해피08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{2049, 2050}, returnView: false);
                context.AddCinematicTalk(npcId: 0, illustId: "0", script: "$52000108_QD__52000108__39$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State프로토콜해피09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프로토콜해피09 : TriggerState {
            internal State프로토콜해피09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{2051, 2053}, returnView: false);
                context.AddCinematicTalk(npcId: 0, illustId: "0", script: "$52000108_QD__52000108__40$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State프로토콜해피10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프로토콜해피10 : TriggerState {
            internal State프로토콜해피10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 209, sequenceName: "Bore_A");
                context.CameraSelectPath(pathIds: new []{2052}, returnView: false);
                context.AddCinematicTalk(npcId: 11003183, script: "$52000108_QD__52000108__41$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State프로토콜해피10_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프로토콜해피10_1 : TriggerState {
            internal State프로토콜해피10_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State프로토콜해피11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_4 : TriggerState {
            internal StateSkip_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.CameraReset(interpolationTime: 1.0f);
                context.MoveUser(mapId: 52000108, portalId: 11);
                context.SetOnetimeEffect(id: 4, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State프로토콜해피11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프로토콜해피11 : TriggerState {
            internal State프로토콜해피11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{4003, 4004, 4005, 4006, 4007, 4008}, visible: true);
                context.DestroyMonster(spawnIds: new []{209, 210, 206});
                context.SetEffect(triggerIds: new []{5000, 5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012, 5013, 5014, 5015, 5016, 5017, 5018}, visible: true);
                context.DestroyMonster(spawnIds: new []{208});
                context.CreateMonster(spawnIds: new []{211});
                context.CameraReset(interpolationTime: 1.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.AddBalloonTalk(spawnId: 0, msg: "$52000108_QD__52000108__42$", duration: 6000, delayTick: 1000);
                context.ShowGuideSummary(entityId: 25201086, textId: 25201086, duration: 10000);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{10011})) {
                    return new State프로토콜해피12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프로토콜해피12 : TriggerState {
            internal State프로토콜해피12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 211, msg: "$52000108_QD__52000108__43$", duration: 6000, delayTick: 1000);
                context.SetOnetimeEffect(id: 3000981, enabled: true, path: @"BG/Common/Sound/Eff_Ayesha_IntroMovie_03000981.xml");
                context.ShowGuideSummary(entityId: 25201086, textId: 25201086, duration: 10000);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10010}, questIds: new []{20002301}, questStates: new byte[]{3})) {
                    return new State프로토콜해피13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프로토콜해피13 : TriggerState {
            internal State프로토콜해피13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 211, patrolName: "MS2PatrolData_fallback");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State프로토콜해피14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프로토콜해피14 : TriggerState {
            internal State프로토콜해피14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{211});
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State프로토콜해피13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
