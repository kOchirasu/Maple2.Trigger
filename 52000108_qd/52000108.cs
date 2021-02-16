namespace Maple2.Trigger._52000108_qd {
    public static class _52000108 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {2001}, arg2: false);
                context.CreateMonster(arg1: new[] {200}, arg2: false);
                context.SetEffect(arg1: new[] {5000, 5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012, 5013, 5014, 5015, 5016, 5017, 5018, 4000, 4001, 4002, 4002, 4003, 4004, 4005, 4006, 4007, 4008}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {10010}, arg2: new[] {20002301}, arg3: new byte[] {3})) {
                    context.MoveUser(arg1: 52000109, arg2: 1);
                }

                if (context.QuestUserDetected(arg1: new[] {10010}, arg2: new[] {20002297}, arg3: new byte[] {1})) {
                    return new State불끄기Quest01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {10010}, arg2: new[] {20002298}, arg3: new byte[] {1})) {
                    return new State워터슬라임Quest01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {10010}, arg2: new[] {20002300}, arg3: new byte[] {1})) {
                    return new State저항군로봇Quest01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {10010}, arg2: new[] {20002301}, arg3: new byte[] {1})) {
                    return new State저항군로봇Quest01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {10010}, arg2: new[] {20002300}, arg3: new byte[] {3})) {
                    return new State저항군로봇Quest01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {10010}, arg2: new[] {20002299}, arg3: new byte[] {3})) {
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
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new[] {2000}, arg2: false);
                context.MoveUser(arg1: 52000108, arg2: 10);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
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
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.AddCinematicTalk(npcId: 11003292, illustId: "0", msg: "$52000108_QD__52000108__0$", duration: 4000, align: "right");
                context.SetOnetimeEffect(id: 3000972, enable: true, path: @"BG/Common/Sound/Eff_Ayesha_IntroMovie_03000972.xml");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_ishaTrun");
                context.MoveUserPath(arg1: "MS2PatrolData_PCTrun");
            }

            public override TriggerState Execute() {
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
                context.AddCinematicTalk(npcId: 0, illustId: "0", msg: "$52000108_QD__52000108__1$", duration: 4000, align: "right");
            }

            public override TriggerState Execute() {
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
                context.AddCinematicTalk(npcId: 0, illustId: "0", msg: "$52000108_QD__52000108__2$", duration: 4000, align: "right");
                context.SetPcEmotionLoop(arg1: "Emotion_Dance_S", arg2: 4000f);
            }

            public override TriggerState Execute() {
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
                context.AddCinematicTalk(npcId: 0, illustId: "0", msg: "$52000108_QD__52000108__3$", duration: 4000, align: "right");
            }

            public override TriggerState Execute() {
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
                context.SetSound(arg1: 9000, arg2: true);
                context.CameraSelectPath(arg1: new[] {2002}, arg2: false);
                context.SetOnetimeEffect(id: 40, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.AddCinematicTalk(npcId: 11003292, illustId: "0", msg: "$52000108_QD__52000108__4$", duration: 6000, align: "right");
                context.SetOnetimeEffect(id: 3000973, enable: true, path: @"BG/Common/Sound/Eff_Ayesha_IntroMovie_03000973.xml");
            }

            public override TriggerState Execute() {
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
                context.SetOnetimeEffect(id: 50, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.AddCinematicTalk(npcId: 0, illustId: "0", msg: "$52000108_QD__52000108__5$", duration: 4000, align: "right");
            }

            public override TriggerState Execute() {
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
                context.AddCinematicTalk(npcId: 11003292, illustId: "$52000108_QD__52000108__45$", msg: "$52000108_QD__52000108__6$", duration: 4000, align: "right");
                context.SetOnetimeEffect(id: 3000974, enable: true, path: @"BG/Common/Sound/Eff_Ayesha_IntroMovie_03000974.xml");
                context.CameraSelectPath(arg1: new[] {2003}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.SetOnetimeEffect(id: 60, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.CameraSelectPath(arg1: new[] {2004}, arg2: false);
                context.SetMesh(arg1: new[] {2001}, arg2: true);
                context.AddCinematicTalk(npcId: 11003292, msg: "$52000108_QD__52000108__7$", duration: 8000, align: "right");
                context.SetOnetimeEffect(id: 3000975, enable: true, path: @"BG/Common/Sound/Eff_Ayesha_IntroMovie_03000975.xml");
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {2003}, arg2: false);
                context.AddCinematicTalk(npcId: 11003292, illustId: "0", msg: "$52000108_QD__52000108__8$", duration: 5000, align: "right");
                context.SetOnetimeEffect(id: 3000976, enable: true, path: @"BG/Common/Sound/Eff_Ayesha_IntroMovie_03000976.xml");
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {2008}, arg2: false);
                context.AddCinematicTalk(npcId: 0, illustId: "0", msg: "$52000108_QD__52000108__9$", duration: 2000, align: "right");
                context.SetPcEmotionSequence(arg1: "Emotion_Choice_A");
            }

            public override TriggerState Execute() {
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
                context.AddCinematicTalk(npcId: 0, illustId: "0", msg: "$52000108_QD__52000108__10$", duration: 4000, align: "right");
                context.SetPcEmotionLoop(arg1: "Snare_A", arg2: 5000f);
                context.FaceEmotion(spawnPointId: 0, emotionName: "PC_OutOfMind_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
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
                context.SetCinematicUI(arg1: 4);
                context.MoveUser(arg1: 52000108, arg2: 10);
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_ishaTrun");
                context.SetMesh(arg1: new[] {2001}, arg2: true);
                context.CameraReset(interpolationTime: 1.0f);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState Execute() {
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
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.ShowGuideSummary(entityId: 25201081, textId: 25201081, duration: 10000);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {10010}, arg2: new[] {20002298}, arg3: new byte[] {1})) {
                    return new State워터슬라임Quest01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State워터슬라임Quest01 : TriggerState {
            internal State워터슬라임Quest01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {300, 301, 302, 303, 304, 305}, arg2: false);
                context.MoveNpc(arg1: 203, arg2: "MS2PatrolData_caitSneak");
                context.ShowGuideSummary(entityId: 25201082, textId: 25201082, duration: 10000);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {10010}, arg2: new[] {20002299}, arg3: new byte[] {3})) {
                    return new State저항군로봇Quest01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State저항군로봇Quest01 : TriggerState {
            internal State저항군로봇Quest01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 9000, arg2: false);
                context.SetSound(arg1: 9001, arg2: true);
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new[] {2013, 2014}, arg2: false);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.MoveUser(arg1: 52000108, arg2: 12);
            }

            public override TriggerState Execute() {
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
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.AddCinematicTalk(npcId: 0, illustId: "0", msg: "$52000108_QD__52000108__11$", duration: 6000, align: "right");
                context.SetPcEmotionLoop(arg1: "Object_React_D", arg2: 25000f);
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_ishaCom");
            }

            public override TriggerState Execute() {
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
                context.AddCinematicTalk(npcId: 11003292, msg: "$52000108_QD__52000108__12$", duration: 4000, align: "right");
                context.SetOnetimeEffect(id: 3000977, enable: true, path: @"BG/Common/Sound/Eff_Ayesha_IntroMovie_03000977.xml");
                context.CameraSelectPath(arg1: new[] {2015}, arg2: false);
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_isha_8");
            }

            public override TriggerState Execute() {
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
                context.AddCinematicTalk(npcId: 0, illustId: "0", msg: "$52000108_QD__52000108__13$", duration: 4000, align: "right");
            }

            public override TriggerState Execute() {
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
                context.AddCinematicTalk(npcId: 0, illustId: "0", msg: "$52000108_QD__52000108__14$", duration: 4000, align: "right");
                context.CameraSelectPath(arg1: new[] {2016}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.AddCinematicTalk(npcId: 11003292, msg: "$52000108_QD__52000108__15$", duration: 6000, align: "right");
                context.SetOnetimeEffect(id: 3000978, enable: true, path: @"BG/Common/Sound/Eff_Ayesha_IntroMovie_03000978.xml");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_isha_9");
                context.CameraSelectPath(arg1: new[] {2017, 2018}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.AddCinematicTalk(npcId: 0, illustId: "0", msg: "$52000108_QD__52000108__16$", duration: 4000, align: "right");
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {2028}, arg2: false);
                context.AddCinematicTalk(npcId: 11003292, msg: "$52000108_QD__52000108__17$", duration: 6000, align: "right");
                context.SetOnetimeEffect(id: 3000979, enable: true, path: @"BG/Common/Sound/Eff_Ayesha_IntroMovie_03000979.xml");
            }

            public override TriggerState Execute() {
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
                context.SetSound(arg1: 9002, arg2: true);
                context.SetTimeScale(enable: true, startScale: 0.1f, endScale: 0.1f, duration: 7f, interpolator: 2);
                context.SetSkill(arg1: new[] {500}, arg2: true);
                context.CameraSelectPath(arg1: new[] {2010, 2019}, arg2: false);
                context.SetEffect(arg1: new[] {4000, 4001, 4002}, arg2: true);
                context.MoveUserPath(arg1: "MS2PatrolData_PC_TurnLeft");
            }

            public override TriggerState Execute() {
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
                context.FaceEmotion(spawnPointId: 0, emotionName: "PC_OutOfMind_01");
                context.CameraSelectPath(arg1: new[] {2031}, arg2: false);
                context.AddCinematicTalk(npcId: 0, illustId: "0", msg: "$52000108_QD__52000108__18$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {201, 202, 206}, arg2: false);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_Checky");
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_sigmund");
                context.MoveNpc(arg1: 206, arg2: "MS2PatrolData_henry");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_IshaCheck");
                context.CameraSelectPath(arg1: new[] {2011, 2012}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {2029, 2030}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {2020, 2021}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.ShowCaption(type: "NameCaption", title: "$52000108_QD__52000108__19$", align: "center", offsetRateX: -0.15f, offsetRateY: 0.15f, duration: 3500, scale: 2.0f);
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {2022, 2023}, arg2: false);
                context.ShowCaption(type: "NameCaption", title: "$52000108_QD__52000108__20$", align: "center", offsetRateX: -0.15f, offsetRateY: 0.15f, duration: 3500, scale: 2.0f);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 202, arg2: "Bore_B");
                context.CameraSelectPath(arg1: new[] {2024, 2025}, arg2: false);
                context.ShowCaption(type: "NameCaption", title: "$52000108_QD__52000108__22$", align: "center", offsetRateX: -0.15f, offsetRateY: 0.15f, duration: 3500, scale: 2.0f);
            }

            public override TriggerState Execute() {
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
                context.MoveUser(arg1: 52000108, arg2: 11);
                context.CameraSelectPath(arg1: new[] {2026, 2027}, arg2: false);
                context.ShowCaption(type: "NameCaption", title: "$52000108_QD__52000108__24$", desc: "$52000108_QD__52000108__25$", align: "topCenter", duration: 4000, scale: 3.0f);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
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
                context.SetCinematicUI(arg1: 4);
                context.MoveUser(arg1: 52000108, arg2: 11);
                context.CreateMonster(arg1: new[] {201, 202, 206}, arg2: false);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_Checky");
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_sigmund");
                context.MoveNpc(arg1: 206, arg2: "MS2PatrolData_henry");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_IshaCheck");
                context.SetSkill(arg1: new[] {500}, arg2: true);
                context.SetEffect(arg1: new[] {4000, 4001, 4002}, arg2: true);
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState Execute() {
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
                context.FaceEmotion(spawnPointId: 0);
                context.CameraReset(interpolationTime: 1.0f);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.ShowGuideSummary(entityId: 25201083, textId: 25201083, duration: 10000);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {10010}, arg2: new[] {20002301}, arg3: new byte[] {3})) {
                    context.MoveUser(arg1: 52000109, arg2: 1);
                }

                if (context.QuestUserDetected(arg1: new[] {10010}, arg2: new[] {20002301}, arg3: new byte[] {2})) {
                    return new State프로토콜해피01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {10010}, arg2: new[] {20002301}, arg3: new byte[] {1})) {
                    return new State체키등판Quest01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {10010}, arg2: new[] {20002300}, arg3: new byte[] {1})) {
                    return new State저항군로봇Quest17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State저항군로봇Quest17 : TriggerState {
            internal State저항군로봇Quest17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_sigmund_back");
                context.CreateMonster(arg1: new[] {306, 307, 308, 309, 310}, arg2: false);
                context.ShowGuideSummary(entityId: 25201084, textId: 25201084, duration: 10000);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {10010}, arg2: new[] {20002301}, arg3: new byte[] {1})) {
                    return new State체키등판Quest01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State체키등판Quest01 : TriggerState {
            internal State체키등판Quest01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new[] {2032, 2033}, arg2: false);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.MoveUser(arg1: 52000108, arg2: 11);
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_sigmund_back");
            }

            public override TriggerState Execute() {
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
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.AddCinematicTalk(npcId: 11003191, msg: "$52000108_QD__52000108__26$", duration: 4000, align: "right");
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {2034, 2035}, arg2: false);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_CheckyBoss");
                context.AddCinematicTalk(npcId: 11003191, msg: "$52000108_QD__52000108__27$", duration: 4000, align: "right");
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {2036}, arg2: false);
                context.AddCinematicTalk(npcId: 11003184, msg: "$52000108_QD__52000108__28$", duration: 4000, align: "right");
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {2037, 2038}, arg2: false);
                context.AddCinematicTalk(npcId: 11003191, msg: "$52000108_QD__52000108__29$", duration: 4000, align: "right");
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {2039, 2040}, arg2: false);
                context.AddCinematicTalk(npcId: 11003184, msg: "$52000108_QD__52000108__30$", duration: 4000, align: "right");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
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
                context.SetCinematicUI(arg1: 4);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_CheckyBoss");
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState Execute() {
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
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.DestroyMonster(arg1: new[] {201});
                context.CreateMonster(arg1: new[] {311}, arg2: false);
                context.AddBalloonTalk(spawnPointId: 0, msg: "$52000108_QD__52000108__31$", duration: 5000, delayTick: 1000);
                context.AddBalloonTalk(spawnPointId: 205, msg: "$52000108_QD__52000108__32$", duration: 6000, delayTick: 4000);
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_IshaOut");
                context.ShowGuideSummary(entityId: 25201085, textId: 25201085, duration: 10000);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {10010}, arg2: new[] {20002301}, arg3: new byte[] {2})) {
                    return new State프로토콜해피01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프로토콜해피01 : TriggerState {
            internal State프로토콜해피01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new[] {2041, 2042}, arg2: false);
                context.MoveUser(arg1: 52000108, arg2: 11);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.DestroyMonster(arg1: new[] {200, 201, 202, 311});
                context.CreateMonster(arg1: new[] {208, 209, 210}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.AddCinematicTalk(npcId: 11003191, msg: "$52000108_QD__52000108__33$", duration: 4000, align: "right");
            }

            public override TriggerState Execute() {
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
                context.MoveUserPath(arg1: "MS2PatrolData_PC_front");
                context.CameraSelectPath(arg1: new[] {2043}, arg2: false);
                context.AddCinematicTalk(npcId: 0, illustId: "0", msg: "$52000108_QD__52000108__34$", duration: 4000, align: "right");
            }

            public override TriggerState Execute() {
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
                context.FaceEmotion(spawnPointId: 0, emotionName: "ChaosMod_Start");
                context.CameraSelectPath(arg1: new[] {2044}, arg2: false);
                context.AddCinematicTalk(npcId: 0, illustId: "0", msg: "$52000108_QD__52000108__35$", duration: 2500, align: "right");
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionLoop(arg1: 208, arg2: "Attack_Idle_A", arg3: 20000f);
                context.CameraSelectPath(arg1: new[] {2045, 2046}, arg2: false);
                context.AddCinematicTalk(npcId: 11003292, msg: "$52000108_QD__52000108__36$", duration: 4000, align: "right");
                context.SetOnetimeEffect(id: 3000980, enable: true, path: @"BG/Common/Sound/Eff_Ayesha_IntroMovie_03000980.xml");
            }

            public override TriggerState Execute() {
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
                context.FaceEmotion(spawnPointId: 0);
                context.CameraSelectPath(arg1: new[] {2047}, arg2: false);
                context.AddCinematicTalk(npcId: 0, illustId: "0", msg: "$52000108_QD__52000108__37$", duration: 4000, align: "right");
            }

            public override TriggerState Execute() {
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
                context.FaceEmotion(spawnPointId: 209, emotionName: "Surprised");
                context.CameraSelectPath(arg1: new[] {2048}, arg2: false);
                context.AddCinematicTalk(npcId: 11003183, msg: "$52000108_QD__52000108__38$", duration: 4000, align: "right");
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {2049, 2050}, arg2: false);
                context.AddCinematicTalk(npcId: 0, illustId: "0", msg: "$52000108_QD__52000108__39$", duration: 4000, align: "right");
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {2051, 2053}, arg2: false);
                context.AddCinematicTalk(npcId: 0, illustId: "0", msg: "$52000108_QD__52000108__40$", duration: 4000, align: "right");
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 209, arg2: "Bore_A");
                context.CameraSelectPath(arg1: new[] {2052}, arg2: false);
                context.AddCinematicTalk(npcId: 11003183, msg: "$52000108_QD__52000108__41$", duration: 4000, align: "right");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
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
                context.SetCinematicUI(arg1: 4);
                context.CameraReset(interpolationTime: 1.0f);
                context.MoveUser(arg1: 52000108, arg2: 11);
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {4003, 4004, 4005, 4006, 4007, 4008}, arg2: true);
                context.DestroyMonster(arg1: new[] {209, 210, 206});
                context.SetEffect(arg1: new[] {5000, 5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012, 5013, 5014, 5015, 5016, 5017, 5018}, arg2: true);
                context.DestroyMonster(arg1: new[] {208});
                context.CreateMonster(arg1: new[] {211});
                context.CameraReset(interpolationTime: 1.0f);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.AddBalloonTalk(spawnPointId: 0, msg: "$52000108_QD__52000108__42$", duration: 6000, delayTick: 1000);
                context.ShowGuideSummary(entityId: 25201086, textId: 25201086, duration: 10000);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {10011})) {
                    return new State프로토콜해피12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프로토콜해피12 : TriggerState {
            internal State프로토콜해피12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 211, msg: "$52000108_QD__52000108__43$", duration: 6000, delayTick: 1000);
                context.SetOnetimeEffect(id: 3000981, enable: true, path: @"BG/Common/Sound/Eff_Ayesha_IntroMovie_03000981.xml");
                context.ShowGuideSummary(entityId: 25201086, textId: 25201086, duration: 10000);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {10010}, arg2: new[] {20002301}, arg3: new byte[] {3})) {
                    return new State프로토콜해피13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프로토콜해피13 : TriggerState {
            internal State프로토콜해피13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 211, arg2: "MS2PatrolData_fallback");
            }

            public override TriggerState Execute() {
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
                context.DestroyMonster(arg1: new[] {211});
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State프로토콜해피13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}