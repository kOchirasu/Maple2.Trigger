namespace Maple2.Trigger._52010032_qd {
    public static class _main_quest10003095 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5001, 5002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {10003095}, arg3: new byte[] {1})) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetCinematicUI(arg1: 4);
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
                context.CameraSelectPath(arg1: new[] {4001}, arg2: false);
                context.MoveUser(arg1: 52010032, arg2: 7001);
                context.CreateMonster(arg1: new[] {101}, arg2: true);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Dead_Idle_A", arg3: 100000000f);
                context.FaceEmotion(spawnPointId: 101, emotionName: "Trigger_Dead");
                context.DestroyMonster(arg1: new[] {202});
                context.CreateMonster(arg1: new[] {201}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State치유의식_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State치유의식_01 : TriggerState {
            internal State치유의식_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003389, msg: "$52010032_QD__MAIN_QUEST10003095__0$", duration: 4000);
                context.AddBalloonTalk(spawnPointId: 0, msg: "$52010032_QD__MAIN_QUEST10003095__1$", duration: 2000, delayTick: 2000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State치유의식_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State치유의식_02 : TriggerState {
            internal State치유의식_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4002, 4003}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_3002");
                context.SetNpcEmotionSequence(arg1: 401, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 11003389, msg: "$52010032_QD__MAIN_QUEST10003095__2$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new State치유의식_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State치유의식_03 : TriggerState {
            internal State치유의식_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Bore_B");
                context.SetEffect(arg1: new[] {5001}, arg2: true);
                context.SetPcEmotionLoop(arg1: "Emotion_Dance_Event01", arg2: 7000f);
                context.AddCinematicTalk(npcId: 11003389, msg: "$52010032_QD__MAIN_QUEST10003095__3$", duration: 5000);
                context.AddCinematicTalk(npcId: 11003389, msg: "$52010032_QD__MAIN_QUEST10003095__4$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new State치유의식_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State치유의식_04 : TriggerState {
            internal State치유의식_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State치유의식_04_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State치유의식_04_1 : TriggerState {
            internal State치유의식_04_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetEffect(arg1: new[] {5001}, arg2: false);
                context.SetEffect(arg1: new[] {5002}, arg2: true);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Down_Idle_A", arg3: 100000000f);
                context.AddCinematicTalk(npcId: 11003406, msg: "$52010032_QD__MAIN_QUEST10003095__5$", duration: 4000);
                context.AddCinematicTalk(npcId: 11003389, msg: "$52010032_QD__MAIN_QUEST10003095__6$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003406, msg: "$52010032_QD__MAIN_QUEST10003095__7$", duration: 3000);
                context.AddBalloonTalk(spawnPointId: 0, msg: "$52010032_QD__MAIN_QUEST10003095__8$", duration: 2000, delayTick: 6000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    return new State치유의식_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State치유의식_05 : TriggerState {
            internal State치유의식_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State치유의식_05_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State치유의식_05_1 : TriggerState {
            internal State치유의식_05_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(arg1: new[] {4003, 4001}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Bore_B");
                context.SetEffect(arg1: new[] {5001, 5002}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Dead_Idle_A", arg3: 100000000f);
                context.FaceEmotion(spawnPointId: 101, emotionName: "Trigger_Dead");
                context.SetPcEmotionSequence(arg1: "Talk_A");
                context.AddCinematicTalk(npcId: 0, msg: "$52010032_QD__MAIN_QUEST10003095__9$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003389, msg: "$52010032_QD__MAIN_QUEST10003095__10$", duration: 4000);
                context.AddCinematicTalk(npcId: 11003389, msg: "$52010032_QD__MAIN_QUEST10003095__11$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new State의식종료_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State의식종료_01 : TriggerState {
            internal State의식종료_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Bore_A");
                context.MoveUserPath(arg1: "MS2PatrolData_3007");
                context.AddCinematicTalk(npcId: 0, msg: "$52010032_QD__MAIN_QUEST10003095__12$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003389, msg: "$52010032_QD__MAIN_QUEST10003095__13$", duration: 3000);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State의식종료_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State의식종료_02 : TriggerState {
            internal State의식종료_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 2001, arg2: "trigger", arg3: "Namid2");
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 4);
                context.SetAchievement(arg1: 2001, arg2: "trigger", arg3: "Namid2");
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetEffect(arg1: new[] {5001, 5002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0f);
                context.CreateMonster(arg1: new[] {202}, arg2: true);
                context.DestroyMonster(arg1: new[] {201});
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.DestroyMonster(arg1: new[] {101});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    // return new State(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}