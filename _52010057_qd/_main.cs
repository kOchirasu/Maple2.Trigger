namespace Maple2.Trigger._52010057_qd {
    public static class _main {
        public class State연출01 : TriggerState {
            internal State연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    context.VisibleMyPc(isVisible: false);
                    context.SetMeshAnimation(arg1: new[] {9002}, arg2: false, arg3: 0, arg4: 0);
                    context.SetProductionUI(arg1: 1);
                    return new State연출02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연출02 : TriggerState {
            internal State연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State연출03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연출03 : TriggerState {
            internal State연출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimeScale(enable: true, startScale: 0.8f, endScale: 0.8f, duration: 8.0f, interpolator: 1);
                context.CameraSelectPath(arg1: new[] {2000, 2001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State연출04_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연출04_b : TriggerState {
            internal State연출04_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMeshAnimation(arg1: new[] {9002}, arg2: true, arg3: 0, arg4: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State연출04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연출04 : TriggerState {
            internal State연출04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State연출05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연출05 : TriggerState {
            internal State연출05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {2002, 2003, 2004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State연출06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연출06 : TriggerState {
            internal State연출06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000422, arg2: 3);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}