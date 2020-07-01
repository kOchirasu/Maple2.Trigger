namespace Maple2.Trigger._02000378_bf {
    public static class _2310_route_10roundright {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 18, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new[] {4018}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetAgent(arg1: "28101", arg2: true);
                context.SetAgent(arg1: "28102", arg2: true);
                context.SetMesh(
                    arg1: new[] {
                        231000, 231001, 231002, 231003, 231004, 231005, 231006, 231007, 231008, 231009, 231010, 231011
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new[] {
                        431000, 431001, 431002, 431003, 431004, 431005, 431006, 431007, 431008, 431009, 431010, 431011
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(key: "RouteSelected", value: 0);
                context.SetUserValue(key: "MakeTrue", value: 0);
                context.SetUserValue(key: "MakeFalse", value: 0);
            }

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
                        231000, 231001, 231002, 231003, 231004, 231005, 231006, 231007, 231008, 231009, 231010, 231011
                    }, arg2: true, arg3: 4, arg4: 100, arg5: 500);
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
                        231000, 231001, 231002, 231003, 231004, 231005, 231006, 231007, 231008, 231009, 231010, 231011
                    }, arg2: false, arg3: 12, arg4: 0, arg5: 0);
            }
        }

        private class StateStartDazzlingRandom02 : TriggerState {
            internal StateStartDazzlingRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(
                    arg1: new[] {
                        231000, 231001, 231002, 231003, 231004, 231005, 231006, 231007, 231008, 231009, 231010, 231011
                    }, arg2: true, arg3: 4, arg4: 100, arg5: 500);
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
                        231000, 231001, 231002, 231003, 231004, 231005, 231006, 231007, 231008, 231009, 231010, 231011
                    }, arg2: false, arg3: 12, arg4: 0, arg5: 0);
            }
        }

        private class StateMakeTrue : TriggerState {
            internal StateMakeTrue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5010}, arg2: true);
                context.SetMesh(
                    arg1: new[] {
                        231000, 231001, 231002, 231003, 231004, 231005, 231006, 231007, 231008, 231009, 231010, 231011
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetRandomMesh(
                    arg1: new[] {
                        431000, 431001, 431002, 431003, 431004, 431005, 431006, 431007, 431008, 431009, 431010, 431011
                    }, arg2: true, arg3: 12, arg4: 0, arg5: 50);
                context.SetAgent(arg1: "28101", arg2: false);
                context.SetAgent(arg1: "28102", arg2: false);
                context.SetPortal(arg1: 18, arg2: true, arg3: true, arg4: false);
                context.SetMesh(arg1: new[] {4018}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
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
                        231000, 231001, 231002, 231003, 231004, 231005, 231006, 231007, 231008, 231009, 231010, 231011
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