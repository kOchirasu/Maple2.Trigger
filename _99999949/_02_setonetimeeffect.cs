namespace Maple2.Trigger._99999949 {
    public static class _02_setonetimeeffect {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_black.xml");
                context.SetOnetimeEffect(id: 2, enable: false, path: @"UGC_Test/Eff_Tutorial_Sound_target.xml");
                context.SetOnetimeEffect(id: 3, enable: false, path: @"UGC_Test/Eff_Tutorial_Sound_target.xml");
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9011})) {
                    context.State = new StateGuide(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGuide : TriggerState {
            internal StateGuide(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(message: "2번 영역에 들어가면 SetOnetimeEffect 트리거가 발동됩니다.");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9010})) {
                    context.State = new StateSetOnetimeEffectReady01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSetOnetimeEffectReady01 : TriggerState {
            internal StateSetOnetimeEffectReady01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(message: "SetOnetimeEffect 2초 후에 시작됩니다.");
                context.SetOnetimeEffect(id: 2, enable: true, path: @"UGC_Test/Eff_Tutorial_Sound_target.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSetOnetimeEffectReady02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSetOnetimeEffectReady02 : TriggerState {
            internal StateSetOnetimeEffectReady02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"UGC_Test/Eff_Tutorial_Sound_target.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSetOnetimeEffect01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSetOnetimeEffect01 : TriggerState {
            internal StateSetOnetimeEffect01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(message: "SetOnetimeEffect 재생");
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_black.xml");
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_black.xml");
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.DebugString(message: "7초 후에 트리거가 리셋됩니다. 2번 영역 밖으로 나가세요.");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}