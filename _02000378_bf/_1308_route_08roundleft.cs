namespace Maple2.Trigger._02000378_bf {
    public static class _1308_route_08roundleft {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {18081, 18082, 18083, 18084}, arg2: true);
                context.SetEffect(arg1: new[] {5008}, arg2: false);
                context.SetMesh(arg1: new[] {130800, 130801, 130802, 130803, 130804, 130805, 130806, 130807, 130808, 130809, 130810, 130811, 130812, 130813, 130814, 130815, 130816, 130817, 130818, 130819, 330800, 330801, 330802, 330803, 330804, 330805, 330806, 330807, 330808, 330809, 330810, 330811, 330812, 330813, 330814, 330815, 330816, 330817, 330818, 330819}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
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
                context.SetRandomMesh(arg1: new[] {130800, 130801, 130802, 130803, 130804, 130805, 130806, 130807, 130808, 130809, 130810, 130811, 130812, 130813, 130814, 130815, 130816, 130817, 130818, 130819}, arg2: true, arg3: 6, arg4: 100, arg5: 500);
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
                context.SetRandomMesh(arg1: new[] {130800, 130801, 130802, 130803, 130804, 130805, 130806, 130807, 130808, 130809, 130810, 130811, 130812, 130813, 130814, 130815, 130816, 130817, 130818, 130819}, arg2: false, arg3: 20, arg4: 0, arg5: 0);
            }
        }

        private class StateStartDazzlingRandom02 : TriggerState {
            internal StateStartDazzlingRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(arg1: new[] {130800, 130801, 130802, 130803, 130804, 130805, 130806, 130807, 130808, 130809, 130810, 130811, 130812, 130813, 130814, 130815, 130816, 130817, 130818, 130819}, arg2: true, arg3: 6, arg4: 100, arg5: 500);
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
                context.SetRandomMesh(arg1: new[] {130800, 130801, 130802, 130803, 130804, 130805, 130806, 130807, 130808, 130809, 130810, 130811, 130812, 130813, 130814, 130815, 130816, 130817, 130818, 130819}, arg2: false, arg3: 20, arg4: 0, arg5: 0);
            }
        }

        private class StateMakeTrue : TriggerState {
            internal StateMakeTrue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5008}, arg2: true);
                context.SetMesh(arg1: new[] {130800, 130801, 130802, 130803, 130804, 130805, 130806, 130807, 130808, 130809, 130810, 130811, 130812, 130813, 130814, 130815, 130816, 130817, 130818, 130819}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetRandomMesh(arg1: new[] {330800, 330801, 330802, 330803, 330804, 330805, 330806, 330807, 330808, 330809, 330810, 330811, 330812, 330813, 330814, 330815, 330816, 330817, 330818, 330819}, arg2: true, arg3: 20, arg4: 100, arg5: 50);
                context.SetAgent(arg1: new[] {18081, 18082, 18083, 18084}, arg2: false);
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
                context.SetMesh(arg1: new[] {130800, 130801, 130802, 130803, 130804, 130805, 130806, 130807, 130808, 130809, 130810, 130811, 130812, 130813, 130814, 130815, 130816, 130817, 130818, 130819}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
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