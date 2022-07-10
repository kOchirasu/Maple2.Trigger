namespace Maple2.Trigger._52000199_qd {
    public static class _52000199_2 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{10003448}, questStates: new byte[]{2})) {
                    return new StateCameraEffect01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect01 : TriggerState {
            internal StateCameraEffect01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.MoveUser(mapId: 52000199, portalId: 5001);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCameraEffect02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect02 : TriggerState {
            internal StateCameraEffect02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52000199_QD__52000199_2__0$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateCameraEffect02_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect02_2 : TriggerState {
            internal StateCameraEffect02_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetVisibleUI(uiNames: new []{"MessengerBrowser", "GroupMessengerBrowser", "HighlightGameMenu"}, visible: false);
                context.AddBuff(boxIds: new []{2001}, skillId: 99910403, level: 1, arg4: false, arg5: true);
                context.AddBuff(boxIds: new []{2001}, skillId: 99910403, level: 1, arg4: false, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraEffect03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03 : TriggerState {
            internal StateCameraEffect03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
