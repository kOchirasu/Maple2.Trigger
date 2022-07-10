namespace Maple2.Trigger._52010066_qd {
    public static class _main {
        public class StateCinematic01 : TriggerState {
            internal StateCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount() > 0) {
                    context.VisibleMyPc(visible: false);
                    context.SetMeshAnimation(triggerIds: new []{9002}, visible: false, arg3: 0, arg4: 0);
                    context.SetCinematicUI(type: 1);
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

            public override TriggerState? Execute() {
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
                context.CameraSelectPath(pathIds: new []{2000, 2001, 2002, 2003}, returnView: false);
            }

            public override TriggerState? Execute() {
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
                context.SetMeshAnimation(triggerIds: new []{9002}, visible: true, arg3: 0, arg4: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6800)) {
                    return new StateCinematic04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic04 : TriggerState {
            internal StateCinematic04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
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
                context.MoveUser(mapId: 02000422, portalId: 3);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
