using System;

namespace Maple2.Trigger._99999949 {
    public static class _05_whitein {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_white.xml");
                context.SetOnetimeEffect(id: 2, enable: false, path: @"UGC_Test/Eff_Tutorial_Sound_target.xml");
                context.SetOnetimeEffect(id: 3, enable: false, path: @"UGC_Test/Eff_Tutorial_Sound_target.xml");
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9041")) {
                    context.State = new StateGuide(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGuide : TriggerState {
            internal StateGuide(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(@string: "5번 영역에 들어가면 SetOnetimeEffect 트리거가 발동됩니다.");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9040")) {
                    context.State = new StateSetOnetimeEffectReady01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSetOnetimeEffectReady01 : TriggerState {
            internal StateSetOnetimeEffectReady01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(@string: "SetOnetimeEffect 2초 후에 시작됩니다.");
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
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.DebugString(@string: "SetOnetimeEffect 재생");
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_white.xml");
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_white.xml");
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.DebugString(@string: "5초 후에 트리거가 리셋됩니다. 5번 영역 밖으로 나가세요.");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}