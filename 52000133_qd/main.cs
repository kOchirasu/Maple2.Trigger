namespace Maple2.Trigger._52000133_qd {
    public static class _main {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 111, 112});
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    return new StateQuestConditionCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestConditionCheck : TriggerState {
            internal StateQuestConditionCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001599}, arg3: new byte[] {3})) {
                    return new State빈집(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001599}, arg3: new byte[] {2})) {
                    return new State예민한아노스(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001599}, arg3: new byte[] {1})) {
                    return new State예민한아노스(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001598}, arg3: new byte[] {3})) {
                    return new State예민한아노스(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001598}, arg3: new byte[] {2})) {
                    return new State예민한아노스_SetupCinematic(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001584}, arg3: new byte[] {2})) {
                    return new State케이틀린첫만남(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001584}, arg3: new byte[] {1})) {
                    return new State케이틀린첫만남(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001583}, arg3: new byte[] {3})) {
                    return new State케이틀린첫만남(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001583}, arg3: new byte[] {2})) {
                    return new State케이틀린첫만남(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001583}, arg3: new byte[] {1})) {
                    return new State케이틀린첫만남(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001582}, arg3: new byte[] {3})) {
                    return new State케이틀린첫만남(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001582}, arg3: new byte[] {2})) {
                    return new State케이틀린첫만남_StartCinematic(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001582}, arg3: new byte[] {1})) {
                    return new State빈집(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001581}, arg3: new byte[] {3})) {
                    return new State빈집(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린첫만남 : TriggerState {
            internal State케이틀린첫만남(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101});
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린첫만남_StartCinematic : TriggerState {
            internal State케이틀린첫만남_StartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8000}, arg2: false);
                context.CreateMonster(arg1: new[] {101});
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.MoveUser(arg1: 52000133, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State전경스케치01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전경스케치01 : TriggerState {
            internal State전경스케치01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State전경스케치02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전경스케치02 : TriggerState {
            internal State전경스케치02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, illustId: "0", msg: "$52000133_QD__MAIN__0$", duration: 2000, align: "left");
                context.SetSceneSkip(state: new State케이틀린첫만남_스킵완료(context), arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State전경스케치03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전경스케치03 : TriggerState {
            internal State전경스케치03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_PC01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State전경스케치04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전경스케치04 : TriggerState {
            internal State전경스케치04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8003}, arg2: false);
                context.AddCinematicTalk(npcId: 11003254, illustId: "Caitlyn_normal", msg: "$52000133_QD__MAIN__1$", duration: 3000, align: "center");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State전경스케치05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전경스케치05 : TriggerState {
            internal State전경스케치05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8004}, arg2: false);
                context.AddBalloonTalk(spawnPointId: 101, msg: "$52000133_QD__MAIN__2$", duration: 3000, delayTick: 0);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Bore_A", arg3: 3000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State전경스케치06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전경스케치06 : TriggerState {
            internal State전경스케치06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8010}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_PC02");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State전경스케치07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전경스케치07 : TriggerState {
            internal State전경스케치07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: "NameCaption", title: "$52000133_QD__MAIN__3$", desc: "$52000133_QD__MAIN__4$", align: "centerRight", offsetRateX: -0.05f, offsetRateY: 0.15f, duration: 10000, scale: 2.0f);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Bore_B", arg3: 4000f);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린첫만남_스킵완료 : TriggerState {
            internal State케이틀린첫만남_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 4);
                context.MoveUser(arg1: 52000133, arg2: 12);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State예민한아노스 : TriggerState {
            internal State예민한아노스(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {111, 113});
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State예민한아노스_SetupCinematic : TriggerState {
            internal State예민한아노스_SetupCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {111});
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.MoveUser(arg1: 52000133, arg2: 11);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State예민한아노스_StartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State예민한아노스_StartCinematic : TriggerState {
            internal State예민한아노스_StartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8100}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State케이틀린Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린Script01 : TriggerState {
            internal State케이틀린Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8101}, arg2: false);
                context.AddCinematicTalk(npcId: 11003258, illustId: "Caitlyn_normal", msg: "$52000133_QD__MAIN__5$", duration: 3000, align: "right");
                context.SetNpcEmotionLoop(arg1: 111, arg2: "Bore_A", arg3: 4600f);
                context.MoveUserPath(arg1: "2_MS2PatrolData_PC01");
                context.SetSceneSkip(state: new State예민한아노스_스킵완료(context), arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePCScript01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCScript01 : TriggerState {
            internal StatePCScript01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8120}, arg2: false);
                context.AddCinematicTalk(npcId: 0, illustId: "0", msg: "$52000133_QD__MAIN__6$", duration: 3000);
                context.SetPcEmotionLoop(arg1: "Talk_A", arg2: 2000f);
                context.MoveUserPath(arg1: "2_MS2PatrolData_PC02");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State케이틀린Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린Script02 : TriggerState {
            internal State케이틀린Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003258, illustId: "Caitlyn_normal", msg: "$52000133_QD__MAIN__7$", duration: 3000, align: "right");
                context.MoveNpc(arg1: 111, arg2: "2_MS2PatrolData_Katelyn01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePCScript02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCScript02 : TriggerState {
            internal StatePCScript02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, illustId: "0", msg: "$52000133_QD__MAIN__8$", duration: 3000, align: "right");
                context.MoveUserPath(arg1: "2_MS2PatrolData_PC03");
                context.SetPcEmotionLoop(arg1: "Talk_A", arg2: 2000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State케이틀린Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린Script03 : TriggerState {
            internal State케이틀린Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8110}, arg2: false);
                context.CreateMonster(arg1: new[] {112});
                context.AddCinematicTalk(npcId: 11003258, illustId: "Caitlyn_normal", msg: "$52000133_QD__MAIN__9$", duration: 4000, align: "right");
                context.SetNpcEmotionLoop(arg1: 111, arg2: "Talk_A", arg3: 8200f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State아노스걸어나옴(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스걸어나옴 : TriggerState {
            internal State아노스걸어나옴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8140}, arg2: false);
                context.AddCinematicTalk(npcId: 11003259, illustId: "Anos_normal", msg: "$52000133_QD__MAIN__10$", duration: 3000, align: "left");
                context.MoveNpc(arg1: 112, arg2: "2_MS2PatrolData_Anos01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아노스Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Script01 : TriggerState {
            internal State아노스Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003259, illustId: "Anos_normal", msg: "$52000133_QD__MAIN__11$", duration: 3000, align: "left");
                context.MoveNpc(arg1: 111, arg2: "2_MS2PatrolData_Katelyn02");
                context.SetNpcEmotionLoop(arg1: 112, arg2: "Talk_A", arg3: 3600f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePCScript03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCScript03 : TriggerState {
            internal StatePCScript03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, illustId: "0", msg: "$52000133_QD__MAIN__12$", align: "center", duration: 3000);
                context.SetPcEmotionLoop(arg1: "Emotion_Hello_A", arg2: 2000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아노스Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Script02 : TriggerState {
            internal State아노스Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003259, illustId: "Anos_normal", msg: "$52000133_QD__MAIN__13$", duration: 3000, align: "left");
                context.SetNpcEmotionLoop(arg1: 112, arg2: "ChatUp_A", arg3: 7000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePCScript04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCScript04 : TriggerState {
            internal StatePCScript04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8131}, arg2: false);
                context.AddCinematicTalk(npcId: 0, illustId: "0", msg: "$52000133_QD__MAIN__14$", duration: 3000, align: "right");
                context.SetPcEmotionSequence(arg1: "Emotion_Surprise_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아노스Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Script03 : TriggerState {
            internal State아노스Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003259, illustId: "Anos_normal", msg: "$52000133_QD__MAIN__15$", duration: 3000, align: "left");
                context.SetNpcEmotionLoop(arg1: 112, arg2: "Bore_A", arg3: 8100f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State케이틀린Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린Script04 : TriggerState {
            internal State케이틀린Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8132}, arg2: false);
                context.AddCinematicTalk(npcId: 11003258, illustId: "Caitlyn_normal", msg: "$52000133_QD__MAIN__16$", duration: 3000, align: "right");
                context.SetNpcEmotionLoop(arg1: 111, arg2: "Talk_A", arg3: 12000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아노스Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Script04 : TriggerState {
            internal State아노스Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003259, illustId: "Anos_normal", msg: "$52000133_QD__MAIN__17$", duration: 3000, align: "left");
                context.SetNpcEmotionLoop(arg1: 112, arg2: "Bore_B", arg3: 9500f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아노스Script05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Script05 : TriggerState {
            internal State아노스Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8133}, arg2: false);
                context.AddCinematicTalk(npcId: 11003259, illustId: "Anos_normal", msg: "$52000133_QD__MAIN__18$", duration: 3000, align: "left");
                context.SetNpcEmotionLoop(arg1: 112, arg2: "Talk_A", arg3: 6300f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State케이틀린Script05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린Script05 : TriggerState {
            internal State케이틀린Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003258, illustId: "Caitlyn_normal", msg: "$52000133_QD__MAIN__19$", duration: 3000, align: "right");
                context.SetNpcEmotionLoop(arg1: 111, arg2: "Bore_B", arg3: 7900f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State케이틀린Script06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린Script06 : TriggerState {
            internal State케이틀린Script06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003258, illustId: "Caitlyn_normal", msg: "$52000133_QD__MAIN__20$", duration: 3000, align: "right");
                context.SetNpcEmotionLoop(arg1: 111, arg2: "Talk_A", arg3: 6800f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아노스Script06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Script06 : TriggerState {
            internal State아노스Script06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8140}, arg2: false);
                context.AddCinematicTalk(npcId: 11003259, illustId: "Anos_serious", msg: "$52000133_QD__MAIN__21$", duration: 3000, align: "left");
                context.SetNpcEmotionLoop(arg1: 112, arg2: "Bore_A", arg3: 5800f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아노스Script07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Script07 : TriggerState {
            internal State아노스Script07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8140}, arg2: false);
                context.AddCinematicTalk(npcId: 11003259, illustId: "Anos_serious", msg: "$52000133_QD__MAIN__22$", duration: 3000, align: "left");
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State예민한아노스_스킵완료 : TriggerState {
            internal State예민한아노스_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 4);
                context.CreateMonster(arg1: new[] {113});
                context.DestroyMonster(arg1: new[] {112});
                context.MoveUser(arg1: 52000133, arg2: 13);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State빈집 : TriggerState {
            internal State빈집(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
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
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
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