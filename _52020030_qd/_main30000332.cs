namespace Maple2.Trigger._52020030_qd {
    public static class _main30000332 {
        public class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5001, 5002, 5003}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {2002}, arg2: new[] {30000332}, arg3: new byte[] {1})) {
                    context.State = new State천공의탑전경보여주기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State천공의탑전경보여주기 : TriggerState {
            internal State천공의탑전경보여주기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State천공의탑전경보여주기02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State천공의탑전경보여주기02 : TriggerState {
            internal State천공의탑전경보여주기02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(arg1: new[] {4008, 4010}, arg2: false);
                context.ShowCaption(type: "VerticalCaption", title: "천공의 탑", desc: "크리티아스 마법 연구소", align: "centerLeft", offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State천공의탑전경보여주기03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State천공의탑전경보여주기03 : TriggerState {
            internal State천공의탑전경보여주기03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(arg1: 52020030, arg2: 6006);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State천공의탑전경보여주기04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State천공의탑전경보여주기04 : TriggerState {
            internal State천공의탑전경보여주기04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}