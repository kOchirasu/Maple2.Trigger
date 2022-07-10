namespace Maple2.Trigger._52000052_qd {
    public static class _1304_route_04roundleft {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{18041, 18042, 18043, 18044}, visible: true);
                context.SetEffect(triggerIds: new []{5004}, visible: false);
                context.SetMesh(triggerIds: new []{130400, 130401, 130402, 130403, 130404, 130405, 130406, 130407, 130408, 130409, 130410, 130411, 130412, 130413, 130414, 130415, 130416, 130417, 130418, 130419, 330400, 330401, 330402, 330403, 330404, 330405, 330406, 330407, 330408, 330409, 330410, 330411, 330412, 330413, 330414, 330415, 330416, 330417, 330418, 330419}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
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
                context.SetRandomMesh(triggerIds: new []{130400, 130401, 130402, 130403, 130404, 130405, 130406, 130407, 130408, 130409, 130410, 130411, 130412, 130413, 130414, 130415, 130416, 130417, 130418, 130419}, visible: true, meshCount: 6, arg4: 100, delay: 500);
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
                context.SetRandomMesh(triggerIds: new []{130400, 130401, 130402, 130403, 130404, 130405, 130406, 130407, 130408, 130409, 130410, 130411, 130412, 130413, 130414, 130415, 130416, 130417, 130418, 130419}, visible: false, meshCount: 20, arg4: 0, delay: 0);
            }
        }

        private class StateStartDazzlingRandom02 : TriggerState {
            internal StateStartDazzlingRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(triggerIds: new []{130400, 130401, 130402, 130403, 130404, 130405, 130406, 130407, 130408, 130409, 130410, 130411, 130412, 130413, 130414, 130415, 130416, 130417, 130418, 130419}, visible: true, meshCount: 6, arg4: 100, delay: 500);
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
                context.SetRandomMesh(triggerIds: new []{130400, 130401, 130402, 130403, 130404, 130405, 130406, 130407, 130408, 130409, 130410, 130411, 130412, 130413, 130414, 130415, 130416, 130417, 130418, 130419}, visible: false, meshCount: 20, arg4: 0, delay: 0);
            }
        }

        private class StateMakeTrue : TriggerState {
            internal StateMakeTrue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5004}, visible: true);
                context.SetMesh(triggerIds: new []{130400, 130401, 130402, 130403, 130404, 130405, 130406, 130407, 130408, 130409, 130410, 130411, 130412, 130413, 130414, 130415, 130416, 130417, 130418, 130419}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetRandomMesh(triggerIds: new []{330400, 330401, 330402, 330403, 330404, 330405, 330406, 330407, 330408, 330409, 330410, 330411, 330412, 330413, 330414, 330415, 330416, 330417, 330418, 330419}, visible: true, meshCount: 20, arg4: 100, delay: 50);
                context.SetAgent(triggerIds: new []{18041, 18042, 18043, 18044}, visible: false);
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
                context.SetMesh(triggerIds: new []{130400, 130401, 130402, 130403, 130404, 130405, 130406, 130407, 130408, 130409, 130410, 130411, 130412, 130413, 130414, 130415, 130416, 130417, 130418, 130419}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
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
