namespace Maple2.Trigger._52000052_qd {
    public static class _2310_route_10roundright {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 18, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(arg1: new[] {4018}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetAgent(arg1: new[] {28101, 28102}, arg2: true);
                context.SetMesh(arg1: new[] {231000, 231001, 231002, 231003, 231004, 231005, 231006, 231007, 231008, 231009, 231010, 231011, 431000, 431001, 431002, 431003, 431004, 431005, 431006, 431007, 431008, 431009, 431010, 431011}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(key: "RouteSelected", value: 0);
                context.SetUserValue(key: "MakeTrue", value: 0);
                context.SetUserValue(key: "MakeFalse", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "RouteSelected") == 1) {
                    return new StateStartDazzlingRandom01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartDazzlingRandom01 : TriggerState {
            internal StateStartDazzlingRandom01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(arg1: new[] {231000, 231001, 231002, 231003, 231004, 231005, 231006, 231007, 231008, 231009, 231010, 231011}, arg2: true, arg3: 4, arg4: 100, arg5: 500);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateStartDazzlingRandom02(context);
                }

                if (context.GetUserValue(key: "MakeTrue") == 1) {
                    return new StateMakeTrue(context);
                }

                if (context.GetUserValue(key: "MakeFalse") == 1) {
                    return new StateMakeFalse(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetRandomMesh(arg1: new[] {231000, 231001, 231002, 231003, 231004, 231005, 231006, 231007, 231008, 231009, 231010, 231011}, arg2: false, arg3: 12, arg4: 0, arg5: 0);
            }
        }

        private class StateStartDazzlingRandom02 : TriggerState {
            internal StateStartDazzlingRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(arg1: new[] {231000, 231001, 231002, 231003, 231004, 231005, 231006, 231007, 231008, 231009, 231010, 231011}, arg2: true, arg3: 4, arg4: 100, arg5: 500);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateStartDazzlingRandom01(context);
                }

                if (context.GetUserValue(key: "MakeTrue") == 1) {
                    return new StateMakeTrue(context);
                }

                if (context.GetUserValue(key: "MakeFalse") == 1) {
                    return new StateMakeFalse(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetRandomMesh(arg1: new[] {231000, 231001, 231002, 231003, 231004, 231005, 231006, 231007, 231008, 231009, 231010, 231011}, arg2: false, arg3: 12, arg4: 0, arg5: 0);
            }
        }

        private class StateMakeTrue : TriggerState {
            internal StateMakeTrue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5010}, arg2: true);
                context.SetMesh(arg1: new[] {231000, 231001, 231002, 231003, 231004, 231005, 231006, 231007, 231008, 231009, 231010, 231011}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetRandomMesh(arg1: new[] {431000, 431001, 431002, 431003, 431004, 431005, 431006, 431007, 431008, 431009, 431010, 431011}, arg2: true, arg3: 12, arg4: 0, arg5: 50);
                context.SetAgent(arg1: new[] {28101, 28102}, arg2: false);
                context.SetPortal(portalId: 18, visible: true, enabled: true, minimapVisible: false);
                context.SetMesh(arg1: new[] {4018}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMakeFalse : TriggerState {
            internal StateMakeFalse(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {231000, 231001, 231002, 231003, 231004, 231005, 231006, 231007, 231008, 231009, 231010, 231011}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}