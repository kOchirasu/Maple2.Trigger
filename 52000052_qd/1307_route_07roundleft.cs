namespace Maple2.Trigger._52000052_qd {
    public static class _1307_route_07roundleft {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{18071, 18072, 18073, 18074}, visible: true);
                context.SetEffect(triggerIds: new []{5007}, visible: false);
                context.SetMesh(triggerIds: new []{130700, 130701, 130702, 130703, 130704, 130705, 130706, 130707, 130708, 130709, 130710, 130711, 130712, 130713, 130714, 130715, 130716, 130717, 130718, 130719, 130720, 130721, 330700, 330701, 330702, 330703, 330704, 330705, 330706, 330707, 330708, 330709, 330710, 330711, 330712, 330713, 330714, 330715, 330716, 330717, 330718, 330719, 330720, 330721}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
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
                context.SetRandomMesh(triggerIds: new []{130700, 130701, 130702, 130703, 130704, 130705, 130706, 130707, 130708, 130709, 130710, 130711, 130712, 130713, 130714, 130715, 130716, 130717, 130718, 130719, 130720, 130721}, visible: true, meshCount: 7, arg4: 100, delay: 500);
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
                context.SetRandomMesh(triggerIds: new []{130700, 130701, 130702, 130703, 130704, 130705, 130706, 130707, 130708, 130709, 130710, 130711, 130712, 130713, 130714, 130715, 130716, 130717, 130718, 130719, 130720, 130721}, visible: false, meshCount: 22, arg4: 0, delay: 0);
            }
        }

        private class StateStartDazzlingRandom02 : TriggerState {
            internal StateStartDazzlingRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(triggerIds: new []{130700, 130701, 130702, 130703, 130704, 130705, 130706, 130707, 130708, 130709, 130710, 130711, 130712, 130713, 130714, 130715, 130716, 130717, 130718, 130719, 130720, 130721}, visible: true, meshCount: 7, arg4: 100, delay: 500);
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
                context.SetRandomMesh(triggerIds: new []{130700, 130701, 130702, 130703, 130704, 130705, 130706, 130707, 130708, 130709, 130710, 130711, 130712, 130713, 130714, 130715, 130716, 130717, 130718, 130719, 130720, 130721}, visible: false, meshCount: 22, arg4: 0, delay: 0);
            }
        }

        private class StateMakeTrue : TriggerState {
            internal StateMakeTrue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5007}, visible: true);
                context.SetMesh(triggerIds: new []{130700, 130701, 130702, 130703, 130704, 130705, 130706, 130707, 130708, 130709, 130710, 130711, 130712, 130713, 130714, 130715, 130716, 130717, 130718, 130719, 130720, 130721}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetRandomMesh(triggerIds: new []{330700, 330701, 330702, 330703, 330704, 330705, 330706, 330707, 330708, 330709, 330710, 330711, 330712, 330713, 330714, 330715, 330716, 330717, 330718, 330719, 330720, 330721}, visible: true, meshCount: 22, arg4: 100, delay: 50);
                context.SetAgent(triggerIds: new []{18071, 18072, 18073, 18074}, visible: false);
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
                context.SetMesh(triggerIds: new []{130700, 130701, 130702, 130703, 130704, 130705, 130706, 130707, 130708, 130709, 130710, 130711, 130712, 130713, 130714, 130715, 130716, 130717, 130718, 130719, 130720, 130721}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
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
