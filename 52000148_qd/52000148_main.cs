namespace Maple2.Trigger._52000148_qd {
    public static class _52000148_main {
        public class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetEffect(arg1: new[] {5001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {701})) {
                    return new StateWait_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_01 : TriggerState {
            internal StateWait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateWait_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_02 : TriggerState {
            internal StateWait_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
                context.MoveUser(arg1: 52000148, arg2: 99);
                context.CreateMonster(arg1: new[] {101}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_03 : TriggerState {
            internal StateWait_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Sit_Ground_Idle_A", arg2: 130000f);
                context.FaceEmotion(spawnPointId: 0, emotionName: "Think_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStart_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_01 : TriggerState {
            internal StateStart_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52000148_QD__52000148_MAIN__0$");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStart_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class StateStart_02 : TriggerState {
            internal StateStart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStart_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_03 : TriggerState {
            internal StateStart_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State오스카와대화_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스카와대화_01 : TriggerState {
            internal State오스카와대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000148_QD__52000148_MAIN__1$", duration: 2500, align: "right");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2001");
                context.SetSceneSkip(arg1: "오스카퇴장_02", arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State오스카와대화_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스카와대화_02 : TriggerState {
            internal State오스카와대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003380, msg: "$52000148_QD__52000148_MAIN__2$", duration: 3000, align: "left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State오스카와대화_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스카와대화_03 : TriggerState {
            internal State오스카와대화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000148_QD__52000148_MAIN__3$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State오스카와대화_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스카와대화_04 : TriggerState {
            internal State오스카와대화_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003380, msg: "$52000148_QD__52000148_MAIN__4$", duration: 3000, align: "left");
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State오스카와대화_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스카와대화_05 : TriggerState {
            internal State오스카와대화_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003380, msg: "$52000148_QD__52000148_MAIN__5$", duration: 4000, align: "left");
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new State오스카와대화_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스카와대화_06 : TriggerState {
            internal State오스카와대화_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000148_QD__52000148_MAIN__6$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State오스카와대화_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스카와대화_07 : TriggerState {
            internal State오스카와대화_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003380, msg: "$52000148_QD__52000148_MAIN__7$", duration: 3000, align: "left");
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003380, msg: "$52000148_QD__52000148_MAIN__8$", duration: 4000, align: "left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State오스카와대화_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스카와대화_08 : TriggerState {
            internal State오스카와대화_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State오스카와대화_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스카와대화_09 : TriggerState {
            internal State오스카와대화_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000148_QD__52000148_MAIN__9$", duration: 3000, align: "right");
                context.AddCinematicTalk(npcId: 0, msg: "$52000148_QD__52000148_MAIN__10$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State오스카와대화_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스카와대화_10 : TriggerState {
            internal State오스카와대화_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8005}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State오스카와대화_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스카와대화_11 : TriggerState {
            internal State오스카와대화_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003380, msg: "$52000148_QD__52000148_MAIN__11$", duration: 2500, illustId: "Oskhal_normal", align: "left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State오스카와대화_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스카와대화_12 : TriggerState {
            internal State오스카와대화_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000148_QD__52000148_MAIN__12$", duration: 3000, align: "right");
                context.AddCinematicTalk(npcId: 0, msg: "$52000148_QD__52000148_MAIN__13$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State오스카와대화_13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스카와대화_13 : TriggerState {
            internal State오스카와대화_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003380, msg: "$52000148_QD__52000148_MAIN__14$", duration: 3500, illustId: "Oskhal_normal", align: "left");
                context.AddCinematicTalk(npcId: 11003380, msg: "$52000148_QD__52000148_MAIN__15$", duration: 3500, illustId: "Oskhal_normal", align: "left");
                context.AddCinematicTalk(npcId: 11003380, msg: "$52000148_QD__52000148_MAIN__16$", duration: 2500, illustId: "Oskhal_normal", align: "left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 16613)) {
                    return new State오스카와대화_14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스카와대화_14 : TriggerState {
            internal State오스카와대화_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000148_QD__52000148_MAIN__17$", duration: 2500, align: "right");
                context.AddCinematicTalk(npcId: 0, msg: "$52000148_QD__52000148_MAIN__18$", duration: 4000, align: "right");
                context.AddCinematicTalk(npcId: 0, msg: "$52000148_QD__52000148_MAIN__19$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new State오스카와대화_15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스카와대화_15 : TriggerState {
            internal State오스카와대화_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003380, msg: "$52000148_QD__52000148_MAIN__20$", duration: 3000, illustId: "Oskhal_normal", align: "left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State오스카와대화_16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스카와대화_16 : TriggerState {
            internal State오스카와대화_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000148_QD__52000148_MAIN__21$", duration: 4000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State오스카와대화_17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스카와대화_17 : TriggerState {
            internal State오스카와대화_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003380, msg: "$52000148_QD__52000148_MAIN__22$", duration: 3000, illustId: "Oskhal_normal", align: "left");
                context.AddCinematicTalk(npcId: 11003380, msg: "$52000148_QD__52000148_MAIN__23$", duration: 3000, illustId: "Oskhal_normal", align: "left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State오스카와대화_18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스카와대화_18 : TriggerState {
            internal State오스카와대화_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000148_QD__52000148_MAIN__24$", duration: 2500, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State오스카와대화_19(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스카와대화_19 : TriggerState {
            internal State오스카와대화_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003380, msg: "$52000148_QD__52000148_MAIN__25$", duration: 3000, illustId: "Oskhal_normal", align: "left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State오스카퇴장_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스카퇴장_01 : TriggerState {
            internal State오스카퇴장_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State오스카퇴장_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스카퇴장_02 : TriggerState {
            internal State오스카퇴장_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2002");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State독백_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State독백_01 : TriggerState {
            internal State독백_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State독백_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State독백_02 : TriggerState {
            internal State독백_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000148_QD__52000148_MAIN__26$", duration: 2500, align: "right");
                context.SetSceneSkip(arg1: "마무리_01", arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State독백_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State독백_03 : TriggerState {
            internal State독백_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8004}, arg2: false);
                context.SetEffect(arg1: new[] {5001}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State독백_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State독백_04 : TriggerState {
            internal State독백_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000148_QD__52000148_MAIN__27$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State독백_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State독백_05 : TriggerState {
            internal State독백_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State독백_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State독백_06 : TriggerState {
            internal State독백_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000148_QD__52000148_MAIN__28$", duration: 3500, align: "right");
                context.FaceEmotion(spawnPointId: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State마무리_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마무리_01 : TriggerState {
            internal State마무리_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State마무리_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마무리_02 : TriggerState {
            internal State마무리_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52000148_QD__52000148_MAIN__29$");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State강제이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State강제이동 : TriggerState {
            internal State강제이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000062, arg2: 13);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}