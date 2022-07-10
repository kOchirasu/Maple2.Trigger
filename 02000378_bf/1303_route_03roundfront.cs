namespace Maple2.Trigger._02000378_bf {
    public static class _1303_route_03roundfront {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{18031, 18032, 18033, 18034}, visible: true);
                context.SetEffect(triggerIds: new []{5003}, visible: false);
                context.SetMesh(triggerIds: new []{130300, 130301, 130302, 130303, 130304, 130305, 130306, 130307, 130308, 130309, 130310, 130311, 130312, 130313, 130314, 130315, 130316, 130317, 130318, 130319, 130320, 130321, 330300, 330301, 330302, 330303, 330304, 330305, 330306, 330307, 330308, 330309, 330310, 330311, 330312, 330313, 330314, 330315, 330316, 330317, 330318, 330319, 330320, 330321}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
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
                context.SetRandomMesh(triggerIds: new []{130300, 130301, 130302, 130303, 130304, 130305, 130306, 130307, 130308, 130309, 130310, 130311, 130312, 130313, 130314, 130315, 130316, 130317, 130318, 130319, 130320, 130321}, visible: true, meshCount: 7, arg4: 100, delay: 500);
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
                context.SetRandomMesh(triggerIds: new []{130300, 130301, 130302, 130303, 130304, 130305, 130306, 130307, 130308, 130309, 130310, 130311, 130312, 130313, 130314, 130315, 130316, 130317, 130318, 130319, 130320, 130321}, visible: false, meshCount: 22, arg4: 0, delay: 0);
            }
        }

        private class StateStartDazzlingRandom02 : TriggerState {
            internal StateStartDazzlingRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(triggerIds: new []{130300, 130301, 130302, 130303, 130304, 130305, 130306, 130307, 130308, 130309, 130310, 130311, 130312, 130313, 130314, 130315, 130316, 130317, 130318, 130319, 130320, 130321}, visible: true, meshCount: 7, arg4: 100, delay: 500);
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
                context.SetRandomMesh(triggerIds: new []{130300, 130301, 130302, 130303, 130304, 130305, 130306, 130307, 130308, 130309, 130310, 130311, 130312, 130313, 130314, 130315, 130316, 130317, 130318, 130319, 130320, 130321}, visible: false, meshCount: 22, arg4: 0, delay: 0);
            }
        }

        private class StateMakeTrue : TriggerState {
            internal StateMakeTrue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5003}, visible: true);
                context.SetMesh(triggerIds: new []{130300, 130301, 130302, 130303, 130304, 130305, 130306, 130307, 130308, 130309, 130310, 130311, 130312, 130313, 130314, 130315, 130316, 130317, 130318, 130319, 130320, 130321}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetRandomMesh(triggerIds: new []{330300, 330301, 330302, 330303, 330304, 330305, 330306, 330307, 330308, 330309, 330310, 330311, 330312, 330313, 330314, 330315, 330316, 330317, 330318, 330319, 330320, 330321}, visible: true, meshCount: 22, arg4: 100, delay: 50);
                context.SetAgent(triggerIds: new []{18031, 18032, 18033, 18034}, visible: false);
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
                context.SetMesh(triggerIds: new []{130300, 130301, 130302, 130303, 130304, 130305, 130306, 130307, 130308, 130309, 130310, 130311, 130312, 130313, 130314, 130315, 130316, 130317, 130318, 130319, 130320, 130321}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
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
