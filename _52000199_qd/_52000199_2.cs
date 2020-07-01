namespace Maple2.Trigger._52000199_qd {
    public static class _52000199_2 {
        public class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {10003448},
                    arg3: new byte[] {2})) {
                    context.State = new StateCameraEffect01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect01 : TriggerState {
            internal StateCameraEffect01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.MoveUser(arg1: 52000199, arg2: 5001);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateCameraEffect02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect02 : TriggerState {
            internal StateCameraEffect02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52000199_QD__52000199_2__0$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new StateCameraEffect02_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect02_2 : TriggerState {
            internal StateCameraEffect02_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetVisibleUI(uiName: "MessengerBrowser,GroupMessengerBrowser,HighlightGameMenu",
                    visible: false);
                context.AddBuff(arg1: new[] {2001}, arg2: 99910403, arg3: 1, arg4: false, arg5: true);
                context.AddBuff(arg1: new[] {2001}, arg2: 99910403, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCameraEffect03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03 : TriggerState {
            internal StateCameraEffect03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}