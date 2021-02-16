namespace Maple2.Trigger._52100202_qd {
    public static class _52100202 {
        public class StateWait_01 : TriggerState {
            internal StateWait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {10003250}, arg3: new byte[] {2})) {
                    return new StateWait_01_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_01_02 : TriggerState {
            internal StateWait_01_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new[] {4001}, arg2: false);
                context.SetCinematicUI(type: 1);
                context.MoveUser(arg1: 52100202, arg2: 6001);
                context.SetMesh(arg1: new[] {4026}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State티마이온(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State티마이온 : TriggerState {
            internal State티마이온(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State티마이온_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State티마이온_02 : TriggerState {
            internal State티마이온_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4005}, arg2: false);
                context.SetCinematicUI(type: 3);
                context.MoveUserPath(arg1: "MS2PatrolData_3001");
                context.AddCinematicTalk(npcId: 0, script: "$52100202_QD__52100202__0$", duration: 3500);
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State티마이온_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State티마이온_03 : TriggerState {
            internal State티마이온_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4002}, arg2: false);
                context.CreateMonster(arg1: new[] {101}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State티마이온_03_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State티마이온_03_01 : TriggerState {
            internal State티마이온_03_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4003}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Attack_Idle", arg3: 3000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State티마이온_03_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State티마이온_03_02 : TriggerState {
            internal State티마이온_03_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 101, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Attack_01_J");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State티마이온_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State티마이온_04 : TriggerState {
            internal State티마이온_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4004, 4006}, arg2: false);
                context.FaceEmotion(spawnPointId: 0, emotionName: "Trigger_serious");
                context.AddCinematicTalk(npcId: 0, script: "$52100202_QD__52100202__1$", duration: 4500);
                context.AddCinematicTalk(npcId: 0, script: "$52100202_QD__52100202__2$", duration: 4500);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new State정리_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State정리_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정리_02 : TriggerState {
            internal State정리_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State정리_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정리_03 : TriggerState {
            internal State정리_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02020036, arg2: 6001);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}