namespace Maple2.Trigger._52000052_qd {
    public static class _1308_route_08roundleft {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{18081, 18082, 18083, 18084}, visible: true);
                context.SetEffect(triggerIds: new []{5008}, visible: false);
                context.SetMesh(triggerIds: new []{130800, 130801, 130802, 130803, 130804, 130805, 130806, 130807, 130808, 130809, 130810, 130811, 130812, 130813, 130814, 130815, 130816, 130817, 130818, 130819, 330800, 330801, 330802, 330803, 330804, 330805, 330806, 330807, 330808, 330809, 330810, 330811, 330812, 330813, 330814, 330815, 330816, 330817, 330818, 330819}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(key: "RouteSelected", value: 0);
                context.SetUserValue(key: "MakeTrue", value: 0);
                context.SetUserValue(key: "MakeFalse", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9000) == 1) {
                    return new StateStartDazzling01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartDazzling01 : TriggerState {
            internal StateStartDazzling01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
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
                context.SetRandomMesh(triggerIds: new []{130800, 130801, 130802, 130803, 130804, 130805, 130806, 130807, 130808, 130809, 130810, 130811, 130812, 130813, 130814, 130815, 130816, 130817, 130818, 130819}, visible: true, meshCount: 6, arg4: 100, delay: 500);
            }

            public override TriggerState? Execute() {
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
                context.SetRandomMesh(triggerIds: new []{130800, 130801, 130802, 130803, 130804, 130805, 130806, 130807, 130808, 130809, 130810, 130811, 130812, 130813, 130814, 130815, 130816, 130817, 130818, 130819}, visible: false, meshCount: 20, arg4: 0, delay: 0);
            }
        }

        private class StateStartDazzlingRandom02 : TriggerState {
            internal StateStartDazzlingRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(triggerIds: new []{130800, 130801, 130802, 130803, 130804, 130805, 130806, 130807, 130808, 130809, 130810, 130811, 130812, 130813, 130814, 130815, 130816, 130817, 130818, 130819}, visible: true, meshCount: 6, arg4: 100, delay: 500);
            }

            public override TriggerState? Execute() {
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
                context.SetRandomMesh(triggerIds: new []{130800, 130801, 130802, 130803, 130804, 130805, 130806, 130807, 130808, 130809, 130810, 130811, 130812, 130813, 130814, 130815, 130816, 130817, 130818, 130819}, visible: false, meshCount: 20, arg4: 0, delay: 0);
            }
        }

        private class StateMakeTrue : TriggerState {
            internal StateMakeTrue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5008}, visible: true);
                context.SetMesh(triggerIds: new []{130800, 130801, 130802, 130803, 130804, 130805, 130806, 130807, 130808, 130809, 130810, 130811, 130812, 130813, 130814, 130815, 130816, 130817, 130818, 130819}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetRandomMesh(triggerIds: new []{330800, 330801, 330802, 330803, 330804, 330805, 330806, 330807, 330808, 330809, 330810, 330811, 330812, 330813, 330814, 330815, 330816, 330817, 330818, 330819}, visible: true, meshCount: 20, arg4: 100, delay: 50);
                context.SetAgent(triggerIds: new []{18081, 18082, 18083, 18084}, visible: false);
            }

            public override TriggerState? Execute() {
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
                context.SetMesh(triggerIds: new []{130800, 130801, 130802, 130803, 130804, 130805, 130806, 130807, 130808, 130809, 130810, 130811, 130812, 130813, 130814, 130815, 130816, 130817, 130818, 130819}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
