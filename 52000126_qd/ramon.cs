namespace Maple2.Trigger._52000126_qd {
    public static class _ramon {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60100205}, arg3: new byte[] {2})) {
                    return new StateFadein(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadein : TriggerState {
            internal StateFadein(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "end", arg2: "exit");
                context.CameraSelectPath(arg1: new[] {4101}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateFadeout(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeout : TriggerState {
            internal StateFadeout(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateCamera_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_01 : TriggerState {
            internal StateCamera_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Idle_A");
                context.CameraSelectPath(arg1: new[] {4101, 4102}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCamera_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_02 : TriggerState {
            internal StateCamera_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Idle_A");
                context.CameraSelectPath(arg1: new[] {4102, 4103}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCamera_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_03 : TriggerState {
            internal StateCamera_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 11003209, msg: "$52000126_QD__RAMON__0$", duration: 2000, align: "Left");
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

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraReset(interpolationTime: 0f);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}