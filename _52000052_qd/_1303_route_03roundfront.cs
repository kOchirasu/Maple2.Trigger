namespace Maple2.Trigger._52000052_qd {
    public static class _1303_route_03roundfront {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {18031, 18032, 18033, 18034}, arg2: true);
                context.SetEffect(arg1: new[] {5003}, arg2: false);
                context.SetMesh(arg1: new[] {130300, 130301, 130302, 130303, 130304, 130305, 130306, 130307, 130308, 130309, 130310, 130311, 130312, 130313, 130314, 130315, 130316, 130317, 130318, 130319, 130320, 130321, 330300, 330301, 330302, 330303, 330304, 330305, 330306, 330307, 330308, 330309, 330310, 330311, 330312, 330313, 330314, 330315, 330316, 330317, 330318, 330319, 330320, 330321}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
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
                context.SetRandomMesh(arg1: new[] {130300, 130301, 130302, 130303, 130304, 130305, 130306, 130307, 130308, 130309, 130310, 130311, 130312, 130313, 130314, 130315, 130316, 130317, 130318, 130319, 130320, 130321}, arg2: true, arg3: 7, arg4: 100, arg5: 500);
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
                context.SetRandomMesh(arg1: new[] {130300, 130301, 130302, 130303, 130304, 130305, 130306, 130307, 130308, 130309, 130310, 130311, 130312, 130313, 130314, 130315, 130316, 130317, 130318, 130319, 130320, 130321}, arg2: false, arg3: 22, arg4: 0, arg5: 0);
            }
        }

        private class StateStartDazzlingRandom02 : TriggerState {
            internal StateStartDazzlingRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(arg1: new[] {130300, 130301, 130302, 130303, 130304, 130305, 130306, 130307, 130308, 130309, 130310, 130311, 130312, 130313, 130314, 130315, 130316, 130317, 130318, 130319, 130320, 130321}, arg2: true, arg3: 7, arg4: 100, arg5: 500);
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
                context.SetRandomMesh(arg1: new[] {130300, 130301, 130302, 130303, 130304, 130305, 130306, 130307, 130308, 130309, 130310, 130311, 130312, 130313, 130314, 130315, 130316, 130317, 130318, 130319, 130320, 130321}, arg2: false, arg3: 22, arg4: 0, arg5: 0);
            }
        }

        private class StateMakeTrue : TriggerState {
            internal StateMakeTrue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5003}, arg2: true);
                context.SetMesh(arg1: new[] {130300, 130301, 130302, 130303, 130304, 130305, 130306, 130307, 130308, 130309, 130310, 130311, 130312, 130313, 130314, 130315, 130316, 130317, 130318, 130319, 130320, 130321}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetRandomMesh(arg1: new[] {330300, 330301, 330302, 330303, 330304, 330305, 330306, 330307, 330308, 330309, 330310, 330311, 330312, 330313, 330314, 330315, 330316, 330317, 330318, 330319, 330320, 330321}, arg2: true, arg3: 22, arg4: 100, arg5: 50);
                context.SetAgent(arg1: new[] {18031, 18032, 18033, 18034}, arg2: false);
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
                context.SetMesh(arg1: new[] {130300, 130301, 130302, 130303, 130304, 130305, 130306, 130307, 130308, 130309, 130310, 130311, 130312, 130313, 130314, 130315, 130316, 130317, 130318, 130319, 130320, 130321}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
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