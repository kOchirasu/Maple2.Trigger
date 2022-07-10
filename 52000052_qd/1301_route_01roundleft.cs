namespace Maple2.Trigger._52000052_qd {
    public static class _1301_route_01roundleft {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{18011, 18012, 18013, 18014}, visible: true);
                context.SetEffect(triggerIds: new []{5001}, visible: false);
                context.SetMesh(triggerIds: new []{130100, 130101, 130102, 130103, 130104, 130105, 130106, 130107, 130108, 130109, 130110, 130111, 130112, 130113, 130114, 130115, 130116, 130117, 130118, 130119, 130120, 130121, 130122, 130123, 330100, 330101, 330102, 330103, 330104, 330105, 330106, 330107, 330108, 330109, 330110, 330111, 330112, 330113, 330114, 330115, 330116, 330117, 330118, 330119, 330120, 330121, 330122, 330123}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
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
                context.SetRandomMesh(triggerIds: new []{130100, 130101, 130102, 130103, 130104, 130105, 130106, 130107, 130108, 130109, 130110, 130111, 130112, 130113, 130114, 130115, 130116, 130117, 130118, 130119, 130120, 130121, 130122, 130123}, visible: true, meshCount: 8, arg4: 100, delay: 500);
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
                context.SetRandomMesh(triggerIds: new []{130100, 130101, 130102, 130103, 130104, 130105, 130106, 130107, 130108, 130109, 130110, 130111, 130112, 130113, 130114, 130115, 130116, 130117, 130118, 130119, 130120, 130121, 130122, 130123}, visible: false, meshCount: 24, arg4: 0, delay: 0);
            }
        }

        private class StateStartDazzlingRandom02 : TriggerState {
            internal StateStartDazzlingRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(triggerIds: new []{130100, 130101, 130102, 130103, 130104, 130105, 130106, 130107, 130108, 130109, 130110, 130111, 130112, 130113, 130114, 130115, 130116, 130117, 130118, 130119, 130120, 130121, 130122, 130123}, visible: true, meshCount: 8, arg4: 100, delay: 500);
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
                context.SetRandomMesh(triggerIds: new []{130100, 130101, 130102, 130103, 130104, 130105, 130106, 130107, 130108, 130109, 130110, 130111, 130112, 130113, 130114, 130115, 130116, 130117, 130118, 130119, 130120, 130121, 130122, 130123}, visible: false, meshCount: 24, arg4: 0, delay: 0);
            }
        }

        private class StateMakeTrue : TriggerState {
            internal StateMakeTrue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001}, visible: true);
                context.SetMesh(triggerIds: new []{130100, 130101, 130102, 130103, 130104, 130105, 130106, 130107, 130108, 130109, 130110, 130111, 130112, 130113, 130114, 130115, 130116, 130117, 130118, 130119, 130120, 130121, 130122, 130123}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetRandomMesh(triggerIds: new []{330100, 330101, 330102, 330103, 330104, 330105, 330106, 330107, 330108, 330109, 330110, 330111, 330112, 330113, 330114, 330115, 330116, 330117, 330118, 330119, 330120, 330121, 330122, 330123}, visible: true, meshCount: 24, arg4: 100, delay: 50);
                context.SetAgent(triggerIds: new []{18011, 18012, 18013, 18014}, visible: false);
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
                context.SetMesh(triggerIds: new []{130100, 130101, 130102, 130103, 130104, 130105, 130106, 130107, 130108, 130109, 130110, 130111, 130112, 130113, 130114, 130115, 130116, 130117, 130118, 130119, 130120, 130121, 130122, 130123}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
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
