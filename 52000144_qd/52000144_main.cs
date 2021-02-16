namespace Maple2.Trigger._52000144_qd {
    public static class _52000144_main {
        public class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CreateMonster(arg1: new[] {101}, arg2: false);
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
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {8004}, arg2: false);
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
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State입장_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State입장_01 : TriggerState {
            internal State입장_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_2001");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State입장_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State입장_02 : TriggerState {
            internal State입장_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State로베와대화_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State로베와대화_01 : TriggerState {
            internal State로베와대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Knight_Bore_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State로베와대화_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State로베와대화_02 : TriggerState {
            internal State로베와대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new State스킵도착_01(context), arg2: "exit");
                context.AddCinematicTalk(npcId: 0, msg: "$52000144_QD__52000144_MAIN__0$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State로베와대화_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State로베와대화_03 : TriggerState {
            internal State로베와대화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003401, msg: "$52000144_QD__52000144_MAIN__1$", duration: 3000, illustId: "Robe_normal", align: "right");
                context.AddCinematicTalk(npcId: 11003401, msg: "$52000144_QD__52000144_MAIN__2$", duration: 3500, illustId: "Robe_normal", align: "right");
                context.AddCinematicTalk(npcId: 11003401, msg: "$52000144_QD__52000144_MAIN__3$", duration: 3500, illustId: "Robe_normal", align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new State로베와대화_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State로베와대화_04 : TriggerState {
            internal State로베와대화_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000144_QD__52000144_MAIN__4$", duration: 4179, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State로베와대화_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State로베와대화_05 : TriggerState {
            internal State로베와대화_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003401, msg: "$52000144_QD__52000144_MAIN__5$", duration: 3000, illustId: "Robe_normal", align: "right");
                context.AddCinematicTalk(npcId: 11003401, msg: "$52000144_QD__52000144_MAIN__6$", duration: 3500, illustId: "Robe_normal", align: "right");
                context.AddCinematicTalk(npcId: 11003401, msg: "$52000144_QD__52000144_MAIN__7$", duration: 4000, illustId: "Robe_normal", align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    return new State로베와대화_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State로베와대화_06 : TriggerState {
            internal State로베와대화_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000144_QD__52000144_MAIN__8$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State로베와대화_06_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State로베와대화_06_1 : TriggerState {
            internal State로베와대화_06_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State로베와대화_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State로베와대화_07 : TriggerState {
            internal State로베와대화_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003401, msg: "$52000144_QD__52000144_MAIN__9$", duration: 3000, illustId: "Robe_normal", align: "right");
                context.AddCinematicTalk(npcId: 11003401, msg: "$52000144_QD__52000144_MAIN__10$", duration: 2500, illustId: "Robe_normal", align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State로베와대화_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State로베와대화_08 : TriggerState {
            internal State로베와대화_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Knight_Bore_A");
                context.AddCinematicTalk(npcId: 0, msg: "$52000144_QD__52000144_MAIN__11$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State로베와대화_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State로베와대화_09 : TriggerState {
            internal State로베와대화_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State마무리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스킵도착_01 : TriggerState {
            internal State스킵도착_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
                context.CameraSelectPath(arg1: new[] {8003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State마무리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마무리 : TriggerState {
            internal State마무리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
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