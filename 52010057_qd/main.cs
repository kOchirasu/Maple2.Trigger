namespace Maple2.Trigger._52010057_qd {
    public static class _main {
        public class StateCinematic01 : TriggerState {
            internal StateCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    context.VisibleMyPc(isVisible: false);
                    context.SetMeshAnimation(arg1: new[] {9002}, arg2: false, arg3: 0, arg4: 0);
                    context.SetCinematicUI(arg1: 1);
                    return new StateCinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic02 : TriggerState {
            internal StateCinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCinematic03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic03 : TriggerState {
            internal StateCinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimeScale(enable: true, startScale: 0.8f, endScale: 0.8f, duration: 8.0f, interpolator: 1);
                context.CameraSelectPath(arg1: new[] {2000, 2001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateCinematic04_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic04_b : TriggerState {
            internal StateCinematic04_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMeshAnimation(arg1: new[] {9002}, arg2: true, arg3: 0, arg4: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCinematic04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic04 : TriggerState {
            internal StateCinematic04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCinematic05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic05 : TriggerState {
            internal StateCinematic05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {2002, 2003, 2004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCinematic06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic06 : TriggerState {
            internal StateCinematic06(ITriggerContext context) : base(context) { }

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