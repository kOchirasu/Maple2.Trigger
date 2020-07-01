namespace Maple2.Trigger._52000052_qd {
    public static class _1310_route_10roundleft {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 17, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new[] {4017}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetAgent(arg1: new[] {18101, 18102}, arg2: true);
                context.SetEffect(arg1: new[] {5010}, arg2: false);
                context.SetMesh(arg1: new[] {131000, 131001, 131002, 131003, 131004, 131005, 131006, 131007, 131008, 131009, 131010, 131011, 331000, 331001, 331002, 331003, 331004, 331005, 331006, 331007, 331008, 331009, 331010, 331011}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
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
                context.SetRandomMesh(arg1: new[] {131000, 131001, 131002, 131003, 131004, 131005, 131006, 131007, 131008, 131009, 131010, 131011}, arg2: true, arg3: 4, arg4: 100, arg5: 500);
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
                context.SetRandomMesh(arg1: new[] {131000, 131001, 131002, 131003, 131004, 131005, 131006, 131007, 131008, 131009, 131010, 131011}, arg2: false, arg3: 12, arg4: 0, arg5: 0);
            }
        }

        private class StateStartDazzlingRandom02 : TriggerState {
            internal StateStartDazzlingRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(arg1: new[] {131000, 131001, 131002, 131003, 131004, 131005, 131006, 131007, 131008, 131009, 131010, 131011}, arg2: true, arg3: 4, arg4: 100, arg5: 500);
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
                context.SetRandomMesh(arg1: new[] {131000, 131001, 131002, 131003, 131004, 131005, 131006, 131007, 131008, 131009, 131010, 131011}, arg2: false, arg3: 12, arg4: 0, arg5: 0);
            }
        }

        private class StateMakeTrue : TriggerState {
            internal StateMakeTrue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5010}, arg2: true);
                context.SetMesh(arg1: new[] {131000, 131001, 131002, 131003, 131004, 131005, 131006, 131007, 131008, 131009, 131010, 131011}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetRandomMesh(arg1: new[] {331000, 331001, 331002, 331003, 331004, 331005, 331006, 331007, 331008, 331009, 331010, 331011}, arg2: true, arg3: 12, arg4: 100, arg5: 50);
                context.SetAgent(arg1: new[] {18101, 18102}, arg2: false);
                context.SetPortal(arg1: 17, arg2: true, arg3: true, arg4: false);
                context.SetMesh(arg1: new[] {4017}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
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
                context.SetMesh(arg1: new[] {131000, 131001, 131002, 131003, 131004, 131005, 131006, 131007, 131008, 131009, 131010, 131011}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
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