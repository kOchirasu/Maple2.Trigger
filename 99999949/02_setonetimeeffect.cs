namespace Maple2.Trigger._99999949 {
    public static class _02_setonetimeeffect {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_black.xml");
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"UGC_Test/Eff_Tutorial_Sound_target.xml");
                context.SetOnetimeEffect(id: 3, enabled: false, path: @"UGC_Test/Eff_Tutorial_Sound_target.xml");
                context.SetOnetimeEffect(id: 4, enabled: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9011})) {
                    return new StateGuide(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuide : TriggerState {
            internal StateGuide(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(message: "2번 영역에 들어가면 SetOnetimeEffect 트리거가 발동됩니다.");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9010})) {
                    return new StateSetOnetimeEffectReady01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetOnetimeEffectReady01 : TriggerState {
            internal StateSetOnetimeEffectReady01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(message: "SetOnetimeEffect 2초 후에 시작됩니다.");
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"UGC_Test/Eff_Tutorial_Sound_target.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSetOnetimeEffectReady02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetOnetimeEffectReady02 : TriggerState {
            internal StateSetOnetimeEffectReady02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enabled: true, path: @"UGC_Test/Eff_Tutorial_Sound_target.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSetOnetimeEffect01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetOnetimeEffect01 : TriggerState {
            internal StateSetOnetimeEffect01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(message: "SetOnetimeEffect 재생");
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_black.xml");
                context.SetOnetimeEffect(id: 4, enabled: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_black.xml");
                context.SetOnetimeEffect(id: 4, enabled: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.DebugString(message: "7초 후에 트리거가 리셋됩니다. 2번 영역 밖으로 나가세요.");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
