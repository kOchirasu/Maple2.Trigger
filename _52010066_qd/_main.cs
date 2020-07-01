namespace Maple2.Trigger._52010066_qd {
    public static class _main {
        public class State연출01 : TriggerState {
            internal State연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount() > 0) {
                    context.VisibleMyPc(isVisible: false);
                    context.SetMeshAnimation(arg1: new[] {9002}, arg2: false, arg3: 0, arg4: 0);
                    context.SetProductionUI(arg1: 1);
                    context.State = new State연출02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출02 : TriggerState {
            internal State연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State연출03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출03 : TriggerState {
            internal State연출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimeScale(enable: true, startScale: 0.8f, endScale: 0.8f, duration: 8.0f, interpolator: 1);
                context.CameraSelectPath(arg1: new[] {2000, 2001, 2002, 2003}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State연출04_b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출04_b : TriggerState {
            internal State연출04_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMeshAnimation(arg1: new[] {9002}, arg2: true, arg3: 0, arg4: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6800)) {
                    context.State = new State연출04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출04 : TriggerState {
            internal State연출04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statequit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statequit : TriggerState {
            internal Statequit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000422, arg2: 3);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}