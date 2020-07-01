namespace Maple2.Trigger._02000378_bf {
    public static class _2302_route_02roundback {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {28021, 28022, 28023, 28024}, arg2: true);
                context.SetMesh(arg1: new[] {230200, 230201, 230202, 230203, 230204, 230205, 230206, 230207, 230208, 230209, 230210, 230211, 230212, 230213, 230214, 230215, 230216, 230217, 230218, 230219, 430200, 430201, 430202, 430203, 430204, 430205, 430206, 430207, 430208, 430209, 430210, 430211, 430212, 430213, 430214, 430215, 430216, 430217, 430218, 430219}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
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
                context.SetRandomMesh(arg1: new[] {230200, 230201, 230202, 230203, 230204, 230205, 230206, 230207, 230208, 230209, 230210, 230211, 230212, 230213, 230214, 230215, 230216, 230217, 230218, 230219}, arg2: true, arg3: 6, arg4: 100, arg5: 500);
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
                context.SetRandomMesh(arg1: new[] {230200, 230201, 230202, 230203, 230204, 230205, 230206, 230207, 230208, 230209, 230210, 230211, 230212, 230213, 230214, 230215, 230216, 230217, 230218, 230219}, arg2: false, arg3: 20, arg4: 0, arg5: 0);
            }
        }

        private class StateStartDazzlingRandom02 : TriggerState {
            internal StateStartDazzlingRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(arg1: new[] {230200, 230201, 230202, 230203, 230204, 230205, 230206, 230207, 230208, 230209, 230210, 230211, 230212, 230213, 230214, 230215, 230216, 230217, 230218, 230219}, arg2: true, arg3: 6, arg4: 100, arg5: 500);
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
                context.SetRandomMesh(arg1: new[] {230200, 230201, 230202, 230203, 230204, 230205, 230206, 230207, 230208, 230209, 230210, 230211, 230212, 230213, 230214, 230215, 230216, 230217, 230218, 230219}, arg2: false, arg3: 20, arg4: 0, arg5: 0);
            }
        }

        private class StateMakeTrue : TriggerState {
            internal StateMakeTrue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5002}, arg2: true);
                context.SetMesh(arg1: new[] {230200, 230201, 230202, 230203, 230204, 230205, 230206, 230207, 230208, 230209, 230210, 230211, 230212, 230213, 230214, 230215, 230216, 230217, 230218, 230219}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetRandomMesh(arg1: new[] {430200, 430201, 430202, 430203, 430204, 430205, 430206, 430207, 430208, 430209, 430210, 430211, 430212, 430213, 430214, 430215, 430216, 430217, 430218, 430219}, arg2: true, arg3: 20, arg4: 100, arg5: 50);
                context.SetAgent(arg1: new[] {28021, 28022, 28023, 28024}, arg2: false);
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
                context.SetMesh(arg1: new[] {230200, 230201, 230202, 230203, 230204, 230205, 230206, 230207, 230208, 230209, 230210, 230211, 230212, 230213, 230214, 230215, 230216, 230217, 230218, 230219}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
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