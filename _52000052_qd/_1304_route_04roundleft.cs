namespace Maple2.Trigger._52000052_qd {
    public static class _1304_route_04roundleft {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "18041", arg2: true);
                context.SetAgent(arg1: "18042", arg2: true);
                context.SetAgent(arg1: "18043", arg2: true);
                context.SetAgent(arg1: "18044", arg2: true);
                context.SetEffect(arg1: new[] {5004}, arg2: false);
                context.SetMesh(
                    arg1: new[] {
                        130400, 130401, 130402, 130403, 130404, 130405, 130406, 130407, 130408, 130409, 130410, 130411,
                        130412, 130413, 130414, 130415, 130416, 130417, 130418, 130419
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new[] {
                        330400, 330401, 330402, 330403, 330404, 330405, 330406, 330407, 330408, 330409, 330410, 330411,
                        330412, 330413, 330414, 330415, 330416, 330417, 330418, 330419
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(key: "RouteSelected", value: 0);
                context.SetUserValue(key: "MakeTrue", value: 0);
                context.SetUserValue(key: "MakeFalse", value: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9000) == 1) {
                    context.State = new StateStartDazzling01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStartDazzling01 : TriggerState {
            internal StateStartDazzling01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "RouteSelected") == 1) {
                    context.State = new StateStartDazzlingRandom01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStartDazzlingRandom01 : TriggerState {
            internal StateStartDazzlingRandom01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(
                    arg1: new[] {
                        130400, 130401, 130402, 130403, 130404, 130405, 130406, 130407, 130408, 130409, 130410, 130411,
                        130412, 130413, 130414, 130415, 130416, 130417, 130418, 130419
                    }, arg2: true, arg3: 6, arg4: 100, arg5: 500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateStartDazzlingRandom02(context);
                    return;
                }

                if (context.GetUserValue(key: "MakeTrue") == 1) {
                    context.State = new StateMakeTrue(context);
                    return;
                }

                if (context.GetUserValue(key: "MakeFalse") == 1) {
                    context.State = new StateMakeFalse(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetRandomMesh(
                    arg1: new[] {
                        130400, 130401, 130402, 130403, 130404, 130405, 130406, 130407, 130408, 130409, 130410, 130411,
                        130412, 130413, 130414, 130415, 130416, 130417, 130418, 130419
                    }, arg2: false, arg3: 20, arg4: 0, arg5: 0);
            }
        }

        private class StateStartDazzlingRandom02 : TriggerState {
            internal StateStartDazzlingRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(
                    arg1: new[] {
                        130400, 130401, 130402, 130403, 130404, 130405, 130406, 130407, 130408, 130409, 130410, 130411,
                        130412, 130413, 130414, 130415, 130416, 130417, 130418, 130419
                    }, arg2: true, arg3: 6, arg4: 100, arg5: 500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateStartDazzlingRandom01(context);
                    return;
                }

                if (context.GetUserValue(key: "MakeTrue") == 1) {
                    context.State = new StateMakeTrue(context);
                    return;
                }

                if (context.GetUserValue(key: "MakeFalse") == 1) {
                    context.State = new StateMakeFalse(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetRandomMesh(
                    arg1: new[] {
                        130400, 130401, 130402, 130403, 130404, 130405, 130406, 130407, 130408, 130409, 130410, 130411,
                        130412, 130413, 130414, 130415, 130416, 130417, 130418, 130419
                    }, arg2: false, arg3: 20, arg4: 0, arg5: 0);
            }
        }

        private class StateMakeTrue : TriggerState {
            internal StateMakeTrue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5004}, arg2: true);
                context.SetMesh(
                    arg1: new[] {
                        130400, 130401, 130402, 130403, 130404, 130405, 130406, 130407, 130408, 130409, 130410, 130411,
                        130412, 130413, 130414, 130415, 130416, 130417, 130418, 130419
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetRandomMesh(
                    arg1: new[] {
                        330400, 330401, 330402, 330403, 330404, 330405, 330406, 330407, 330408, 330409, 330410, 330411,
                        330412, 330413, 330414, 330415, 330416, 330417, 330418, 330419
                    }, arg2: true, arg3: 20, arg4: 100, arg5: 50);
                context.SetAgent(arg1: "18041", arg2: false);
                context.SetAgent(arg1: "18042", arg2: false);
                context.SetAgent(arg1: "18043", arg2: false);
                context.SetAgent(arg1: "18044", arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMakeFalse : TriggerState {
            internal StateMakeFalse(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new[] {
                        130400, 130401, 130402, 130403, 130404, 130405, 130406, 130407, 130408, 130409, 130410, 130411,
                        130412, 130413, 130414, 130415, 130416, 130417, 130418, 130419
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}