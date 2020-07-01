namespace Maple2.Trigger._63000077_cs {
    public static class _63000077_main {
        public class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 102}, arg2: false);
                context.SetActor(arg1: 3001, arg2: false, arg3: "0", arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {30000379}, arg3: new byte[] {3})) {
                    return new State일반사냥(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {30000378}, arg3: new byte[] {2})) {
                    return new State일반사냥(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {30000378}, arg3: new byte[] {1})) {
                    return new State30000378수락_01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {30000377}, arg3: new byte[] {3})) {
                    return new State30000377완료_01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {30000377}, arg3: new byte[] {2})) {
                    return new State화난보보스_01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {30000377}, arg3: new byte[] {1})) {
                    return new State잠시대기_01(context);
                }

                if (context.UserDetected(arg1: new[] {701})) {
                    return new State일반사냥(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State30000378수락_01 : TriggerState {
            internal State30000378수락_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State30000378수락_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State30000378수락_02 : TriggerState {
            internal State30000378수락_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {106, 108}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State에블린일기_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State30000377완료_01 : TriggerState {
            internal State30000377완료_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State30000377완료_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State30000377완료_02 : TriggerState {
            internal State30000377완료_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {106, 108}, arg2: false);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State클라우스대화_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State잠시대기_01 : TriggerState {
            internal State잠시대기_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetActor(arg1: 3001, arg2: true, arg3: "Talk_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State잠시대기_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State잠시대기_02 : TriggerState {
            internal State잠시대기_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 8001, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State보보스의오해_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보보스의오해_01 : TriggerState {
            internal State보보스의오해_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetSceneSkip(arg1: "화난보보스_01", arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State보보스의오해_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보보스의오해_02 : TriggerState {
            internal State보보스의오해_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State보보스의오해_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보보스의오해_03 : TriggerState {
            internal State보보스의오해_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004373, msg: "$63000077_CS__63000077_MAIN__0$", duration: 3500, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State보보스의오해_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보보스의오해_04 : TriggerState {
            internal State보보스의오해_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State보보스의오해_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보보스의오해_05 : TriggerState {
            internal State보보스의오해_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 102, msg: "$63000077_CS__63000077_MAIN__1$", duration: 2000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State보보스의오해_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보보스의오해_06 : TriggerState {
            internal State보보스의오해_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 8004, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State보보스의오해_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보보스의오해_07 : TriggerState {
            internal State보보스의오해_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Emotion_Angry_A");
                context.AddCinematicTalk(npcId: 0, msg: "$63000077_CS__63000077_MAIN__2$", duration: 2800, align: "right");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2001");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State보보스의오해_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보보스의오해_08 : TriggerState {
            internal State보보스의오해_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 8005, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State보보스의오해_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보보스의오해_09 : TriggerState {
            internal State보보스의오해_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004373, msg: "$63000077_CS__63000077_MAIN__3$", duration: 3500, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State보보스의오해_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보보스의오해_10 : TriggerState {
            internal State보보스의오해_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 8006, arg2: true);
                context.FaceEmotion(spawnPointId: 0, emotionName: "Angry");
                context.MoveUserPath(arg1: "MS2PatrolData_2002");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State보보스의오해_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보보스의오해_11 : TriggerState {
            internal State보보스의오해_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$63000077_CS__63000077_MAIN__4$", duration: 4000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new State보보스의오해_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보보스의오해_12 : TriggerState {
            internal State보보스의오해_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 8005, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State보보스의오해_13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보보스의오해_13 : TriggerState {
            internal State보보스의오해_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004373, msg: "$63000077_CS__63000077_MAIN__5$", duration: 2500, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State보보스의오해_14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보보스의오해_14 : TriggerState {
            internal State보보스의오해_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004373, msg: "$63000077_CS__63000077_MAIN__6$", duration: 3500, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State보보스의오해_15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보보스의오해_15 : TriggerState {
            internal State보보스의오해_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 8006, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State보보스의오해_16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보보스의오해_16 : TriggerState {
            internal State보보스의오해_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnPointId: 0, emotionName: "Trigger_disappoint");
                context.AddCinematicTalk(npcId: 0, msg: "$63000077_CS__63000077_MAIN__7$", duration: 2500, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State보보스의오해_17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보보스의오해_17 : TriggerState {
            internal State보보스의오해_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnPointId: 0, emotionName: "Trigger_panic");
                context.AddCinematicTalk(npcId: 0, msg: "$63000077_CS__63000077_MAIN__8$", duration: 2500, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State보보스의오해_18(context);
                }

                return null;
            }

            public override void OnExit() {
                context.FaceEmotion(spawnPointId: 0);
            }
        }

        private class State보보스의오해_18 : TriggerState {
            internal State보보스의오해_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 8005, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State보보스의오해_19(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보보스의오해_19 : TriggerState {
            internal State보보스의오해_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004373, msg: "$63000077_CS__63000077_MAIN__9$", duration: 2500, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State보보스의오해_20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보보스의오해_20 : TriggerState {
            internal State보보스의오해_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004373, msg: "$63000077_CS__63000077_MAIN__10$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State보보스의오해_21(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보보스의오해_21 : TriggerState {
            internal State보보스의오해_21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8007}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State보보스의오해_22(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보보스의오해_22 : TriggerState {
            internal State보보스의오해_22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004373, msg: "$63000077_CS__63000077_MAIN__11$", duration: 2000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State보보스의오해_23(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보보스의오해_23 : TriggerState {
            internal State보보스의오해_23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004373, msg: "$63000077_CS__63000077_MAIN__12$", duration: 2000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State화난보보스_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State화난보보스_01 : TriggerState {
            internal State화난보보스_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State화난보보스_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State화난보보스_02 : TriggerState {
            internal State화난보보스_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.DestroyMonster(arg1: new[] {101, 102});
                context.CreateMonster(arg1: new[] {220, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State화난보보스_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State화난보보스_03 : TriggerState {
            internal State화난보보스_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {30000377}, arg3: new byte[] {2})) {
                    return new State패배한보보스_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State일반사냥 : TriggerState {
            internal State일반사냥(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 3001, arg2: false, arg3: "0", arg4: false, arg5: false);
                context.DestroyMonster(arg1: new[] {101, 102});
                context.CreateMonster(arg1: new[] {201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State패배한보보스_01 : TriggerState {
            internal State패배한보보스_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State패배한보보스_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State패배한보보스_02 : TriggerState {
            internal State패배한보보스_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 220});
                context.CreateMonster(arg1: new[] {106, 107}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 106, arg2: "Cry_A", arg3: 35000f);
                context.SetActor(arg1: 3001, arg2: false, arg3: "Talk_A");
                context.MoveUser(arg1: 63000077, arg2: 4);
                context.CameraSelect(arg1: 8008, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State패배한보보스_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State패배한보보스_03 : TriggerState {
            internal State패배한보보스_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetSceneSkip(arg1: "클라우스대화_03", arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State클라우스대화_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State클라우스대화_01 : TriggerState {
            internal State클라우스대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004368, msg: "$63000077_CS__63000077_MAIN__13$", duration: 2500, align: "left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State클라우스대화_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State클라우스대화_02 : TriggerState {
            internal State클라우스대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004368, msg: "$63000077_CS__63000077_MAIN__14$", duration: 2500, align: "left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State클라우스대화_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State클라우스대화_03 : TriggerState {
            internal State클라우스대화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State클라우스대화_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State클라우스대화_04 : TriggerState {
            internal State클라우스대화_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {107});
                context.CreateMonster(arg1: new[] {108}, arg2: false);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State클라우스대화_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State클라우스대화_05 : TriggerState {
            internal State클라우스대화_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {30000378}, arg3: new byte[] {1})) {
                    return new State에블린일기_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에블린일기_01 : TriggerState {
            internal State에블린일기_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State에블린일기_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에블린일기_02 : TriggerState {
            internal State에블린일기_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$63000077_CS__63000077_MAIN__15$");
                context.MoveUser(arg1: 63000077, arg2: 4);
                context.CameraSelect(arg1: 8008, arg2: true);
                context.SetSceneSkip(arg1: "업적_01", arg2: "exit");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State에블린일기_03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State에블린일기_03 : TriggerState {
            internal State에블린일기_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 5, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State다시만난가족_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시만난가족_01 : TriggerState {
            internal State다시만난가족_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004368, msg: "$63000077_CS__63000077_MAIN__16$", duration: 3500, illustId: "June_normal", align: "left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State다시만난가족_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시만난가족_02 : TriggerState {
            internal State다시만난가족_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004368, msg: "$63000077_CS__63000077_MAIN__17$", duration: 3000, illustId: "June_normal", align: "left");
                context.CreateMonster(arg1: new[] {103, 104, 105}, arg2: false);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_2003");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State다시만난가족_03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.MoveNpc(arg1: 108, arg2: "MS2PatrolData_2006");
            }
        }

        private class State다시만난가족_03 : TriggerState {
            internal State다시만난가족_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004356, msg: "$63000077_CS__63000077_MAIN__18$", duration: 2000, align: "left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State다시만난가족_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시만난가족_04 : TriggerState {
            internal State다시만난가족_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8009}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State다시만난가족_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시만난가족_05 : TriggerState {
            internal State다시만난가족_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004356, msg: "$63000077_CS__63000077_MAIN__19$", duration: 3500, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State다시만난가족_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시만난가족_06 : TriggerState {
            internal State다시만난가족_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 8012, arg2: true);
                context.AddCinematicTalk(npcId: 11004373, msg: "$63000077_CS__63000077_MAIN__20$", duration: 2000, align: "left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State다시만난가족_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시만난가족_07 : TriggerState {
            internal State다시만난가족_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 106, arg2: "MS2PatrolData_2007");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State다시만난가족_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시만난가족_08 : TriggerState {
            internal State다시만난가족_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004373, msg: "$63000077_CS__63000077_MAIN__21$", duration: 3500, align: "left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State다시만난가족_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시만난가족_09 : TriggerState {
            internal State다시만난가족_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 8011, arg2: true);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_2008");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State다시만난가족_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시만난가족_10 : TriggerState {
            internal State다시만난가족_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004356, msg: "$63000077_CS__63000077_MAIN__22$", duration: 3500, illustId: "Evelyn_glad", align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State다시만난가족_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시만난가족_11 : TriggerState {
            internal State다시만난가족_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_2004");
                context.MoveNpc(arg1: 105, arg2: "MS2PatrolData_2005");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State다시만난가족_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시만난가족_12 : TriggerState {
            internal State다시만난가족_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004373, msg: "$63000077_CS__63000077_MAIN__23$", duration: 4000, align: "left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new State다시만난가족_13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시만난가족_13 : TriggerState {
            internal State다시만난가족_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004373, msg: "$63000077_CS__63000077_MAIN__24$", duration: 3000, align: "left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State다시만난가족_14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시만난가족_14 : TriggerState {
            internal State다시만난가족_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 8011, arg2: true);
                context.AddCinematicTalk(npcId: 11004361, msg: "$63000077_CS__63000077_MAIN__25$", duration: 4000, illustId: "Aiden_smile", align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new State다시만난가족_15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시만난가족_15 : TriggerState {
            internal State다시만난가족_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004365, msg: "$63000077_CS__63000077_MAIN__26$", duration: 3500, illustId: "Mia_happy", align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State다시만난가족_16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시만난가족_16 : TriggerState {
            internal State다시만난가족_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004356, msg: "$63000077_CS__63000077_MAIN__27$", duration: 2000, illustId: "Evelyn_normal", align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State다시만난가족_17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시만난가족_17 : TriggerState {
            internal State다시만난가족_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004356, msg: "$63000077_CS__63000077_MAIN__28$", duration: 3500, illustId: "Evelyn_sad", align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State다시만난가족_18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시만난가족_18 : TriggerState {
            internal State다시만난가족_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004368, msg: "$63000077_CS__63000077_MAIN__29$", duration: 3000, illustId: "June_smile", align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State다시만난가족_19(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시만난가족_19 : TriggerState {
            internal State다시만난가족_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004356, msg: "$63000077_CS__63000077_MAIN__30$", duration: 3500, illustId: "Evelyn_glad", align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State다시만난가족_20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시만난가족_20 : TriggerState {
            internal State다시만난가족_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8013}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State업적_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State업적_01 : TriggerState {
            internal State업적_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetOnetimeEffect(id: 6, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State업적_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State업적_02 : TriggerState {
            internal State업적_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "ChristmasWish");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State강제이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State강제이동 : TriggerState {
            internal State강제이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 63000075, arg2: 10);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}