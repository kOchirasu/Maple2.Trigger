namespace Maple2.Trigger._63000029_cs {
    public static class _earthquake02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5910, 5810, 5811, 5812, 5813, 5814, 5815, 5816, 5817, 5818, 5802}, visible: false);
                context.SetMesh(triggerIds: new []{3600, 3601, 3602, 3603, 3604, 3605, 3606, 3607, 3608, 3609, 3610, 3611, 3612, 3613, 3614, 3615}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(key: "EarthquakeStart", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "EarthquakeStart") == 1) {
                    return new StateDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay01 : TriggerState {
            internal StateDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3600, 3601, 3602, 3603, 3604, 3605, 3606, 3607, 3608, 3609, 3610, 3611, 3612, 3613, 3614, 3615}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateCollapse00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCollapse00 : TriggerState {
            internal StateCollapse00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5910, 5802, 5810}, visible: true);
                context.SetMesh(triggerIds: new []{3600}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3601}, visible: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3602}, visible: false, arg3: 250, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3603}, visible: false, arg3: 300, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCollapse01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCollapse01 : TriggerState {
            internal StateCollapse01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5817, 5818}, visible: true);
                context.SetMesh(triggerIds: new []{3604}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3605}, visible: false, arg3: 150, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateCollapse02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCollapse02 : TriggerState {
            internal StateCollapse02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5814}, visible: true);
                context.SetMesh(triggerIds: new []{3606}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3607}, visible: false, arg3: 100, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCollapse03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCollapse03 : TriggerState {
            internal StateCollapse03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5816, 5810}, visible: true);
                context.SetMesh(triggerIds: new []{3608}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3609}, visible: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3600, 3601, 3602, 3603}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateCollapse04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCollapse04 : TriggerState {
            internal StateCollapse04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5910, 5811}, visible: true);
                context.SetMesh(triggerIds: new []{3600}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3601}, visible: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3602}, visible: false, arg3: 250, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3603}, visible: false, arg3: 300, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateCollapse05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCollapse05 : TriggerState {
            internal StateCollapse05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3610}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3611}, visible: false, arg3: 500, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{5815}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateCollapse06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCollapse06 : TriggerState {
            internal StateCollapse06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5818, 5812}, visible: true);
                context.SetMesh(triggerIds: new []{3612}, visible: false, arg3: 500, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCollapse07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCollapse07 : TriggerState {
            internal StateCollapse07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5910, 5813}, visible: true);
                context.SetMesh(triggerIds: new []{3613}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3614}, visible: false, arg3: 300, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3615}, visible: false, arg3: 700, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCollapse08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCollapse08 : TriggerState {
            internal StateCollapse08(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9900})) {
                    return new StateDelay01(context);
                }

                if (!context.UserDetected(boxIds: new []{9900})) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5802, 5810, 5811, 5812, 5813, 5814, 5815, 5816, 5817}, visible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
