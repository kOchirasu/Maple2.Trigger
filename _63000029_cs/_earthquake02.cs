namespace Maple2.Trigger._63000029_cs {
    public static class _earthquake02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5910}, arg2: false);
                context.SetEffect(arg1: new[] {5810}, arg2: false);
                context.SetEffect(arg1: new[] {5811}, arg2: false);
                context.SetEffect(arg1: new[] {5812}, arg2: false);
                context.SetEffect(arg1: new[] {5813}, arg2: false);
                context.SetEffect(arg1: new[] {5814}, arg2: false);
                context.SetEffect(arg1: new[] {5815}, arg2: false);
                context.SetEffect(arg1: new[] {5816}, arg2: false);
                context.SetEffect(arg1: new[] {5817}, arg2: false);
                context.SetEffect(arg1: new[] {5818}, arg2: false);
                context.SetEffect(arg1: new[] {5802}, arg2: false);
                context.SetMesh(
                    arg1: new[] {
                        3600, 3601, 3602, 3603, 3604, 3605, 3606, 3607, 3608, 3609, 3610, 3611, 3612, 3613, 3614, 3615
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(key: "EarthquakeStart", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "EarthquakeStart") == 1) {
                    context.State = new StateDelay01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay01 : TriggerState {
            internal StateDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new[] {
                        3600, 3601, 3602, 3603, 3604, 3605, 3606, 3607, 3608, 3609, 3610, 3611, 3612, 3613, 3614, 3615
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateCollapse00(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCollapse00 : TriggerState {
            internal StateCollapse00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5910}, arg2: true);
                context.SetEffect(arg1: new[] {5802}, arg2: true);
                context.SetEffect(arg1: new[] {5810}, arg2: true);
                context.SetMesh(arg1: new[] {3600}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3601}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3602}, arg2: false, arg3: 250, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3603}, arg2: false, arg3: 300, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCollapse01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCollapse01 : TriggerState {
            internal StateCollapse01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5817}, arg2: true);
                context.SetEffect(arg1: new[] {5818}, arg2: true);
                context.SetMesh(arg1: new[] {3604}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3605}, arg2: false, arg3: 150, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateCollapse02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCollapse02 : TriggerState {
            internal StateCollapse02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5814}, arg2: true);
                context.SetMesh(arg1: new[] {3606}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3607}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCollapse03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCollapse03 : TriggerState {
            internal StateCollapse03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5816}, arg2: true);
                context.SetEffect(arg1: new[] {5810}, arg2: true);
                context.SetMesh(arg1: new[] {3608}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3609}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3600}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3601}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3602}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3603}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateCollapse04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCollapse04 : TriggerState {
            internal StateCollapse04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5910}, arg2: true);
                context.SetEffect(arg1: new[] {5811}, arg2: true);
                context.SetMesh(arg1: new[] {3600}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3601}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3602}, arg2: false, arg3: 250, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3603}, arg2: false, arg3: 300, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateCollapse05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCollapse05 : TriggerState {
            internal StateCollapse05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3610}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3611}, arg2: false, arg3: 500, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {5815}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateCollapse06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCollapse06 : TriggerState {
            internal StateCollapse06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5818}, arg2: true);
                context.SetEffect(arg1: new[] {5812}, arg2: true);
                context.SetMesh(arg1: new[] {3612}, arg2: false, arg3: 500, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCollapse07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCollapse07 : TriggerState {
            internal StateCollapse07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5910}, arg2: true);
                context.SetEffect(arg1: new[] {5813}, arg2: true);
                context.SetMesh(arg1: new[] {3613}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3614}, arg2: false, arg3: 300, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3615}, arg2: false, arg3: 700, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateCollapse08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCollapse08 : TriggerState {
            internal StateCollapse08(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9900})) {
                    context.State = new StateDelay01(context);
                    return;
                }

                if (!context.UserDetected(arg1: new[] {9900})) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5802}, arg2: false);
                context.SetEffect(arg1: new[] {5810}, arg2: false);
                context.SetEffect(arg1: new[] {5811}, arg2: false);
                context.SetEffect(arg1: new[] {5812}, arg2: false);
                context.SetEffect(arg1: new[] {5813}, arg2: false);
                context.SetEffect(arg1: new[] {5814}, arg2: false);
                context.SetEffect(arg1: new[] {5815}, arg2: false);
                context.SetEffect(arg1: new[] {5816}, arg2: false);
                context.SetEffect(arg1: new[] {5817}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}