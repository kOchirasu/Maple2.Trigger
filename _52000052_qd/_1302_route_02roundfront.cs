namespace Maple2.Trigger._52000052_qd {
    public static class _1302_route_02roundfront {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {18021, 18022, 18023, 18024}, arg2: true);
                context.SetEffect(arg1: new[] {5002}, arg2: false);
                context.SetMesh(arg1: new[] {130200, 130201, 130202, 130203, 130204, 130205, 130206, 130207, 130208, 130209, 130210, 130211, 130212, 130213, 130214, 130215, 130216, 130217, 130218, 130219, 130220, 130221, 330200, 330201, 330202, 330203, 330204, 330205, 330206, 330207, 330208, 330209, 330210, 330211, 330212, 330213, 330214, 330215, 330216, 330217, 330218, 330219, 330220, 330221}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
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
                context.SetRandomMesh(arg1: new[] {130200, 130201, 130202, 130203, 130204, 130205, 130206, 130207, 130208, 130209, 130210, 130211, 130212, 130213, 130214, 130215, 130216, 130217, 130218, 130219, 130220, 130221}, arg2: true, arg3: 7, arg4: 100, arg5: 500);
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
                context.SetRandomMesh(arg1: new[] {130200, 130201, 130202, 130203, 130204, 130205, 130206, 130207, 130208, 130209, 130210, 130211, 130212, 130213, 130214, 130215, 130216, 130217, 130218, 130219, 130220, 130221}, arg2: false, arg3: 22, arg4: 0, arg5: 0);
            }
        }

        private class StateStartDazzlingRandom02 : TriggerState {
            internal StateStartDazzlingRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(arg1: new[] {130200, 130201, 130202, 130203, 130204, 130205, 130206, 130207, 130208, 130209, 130210, 130211, 130212, 130213, 130214, 130215, 130216, 130217, 130218, 130219, 130220, 130221}, arg2: true, arg3: 7, arg4: 100, arg5: 500);
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
                context.SetRandomMesh(arg1: new[] {130200, 130201, 130202, 130203, 130204, 130205, 130206, 130207, 130208, 130209, 130210, 130211, 130212, 130213, 130214, 130215, 130216, 130217, 130218, 130219, 130220, 130221}, arg2: false, arg3: 22, arg4: 0, arg5: 0);
            }
        }

        private class StateMakeTrue : TriggerState {
            internal StateMakeTrue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5002}, arg2: true);
                context.SetMesh(arg1: new[] {130200, 130201, 130202, 130203, 130204, 130205, 130206, 130207, 130208, 130209, 130210, 130211, 130212, 130213, 130214, 130215, 130216, 130217, 130218, 130219, 130220, 130221}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetRandomMesh(arg1: new[] {330200, 330201, 330202, 330203, 330204, 330205, 330206, 330207, 330208, 330209, 330210, 330211, 330212, 330213, 330214, 330215, 330216, 330217, 330218, 330219, 330220, 330221}, arg2: true, arg3: 22, arg4: 100, arg5: 50);
                context.SetAgent(arg1: new[] {18021, 18022, 18023, 18024}, arg2: false);
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
                context.SetMesh(arg1: new[] {130200, 130201, 130202, 130203, 130204, 130205, 130206, 130207, 130208, 130209, 130210, 130211, 130212, 130213, 130214, 130215, 130216, 130217, 130218, 130219, 130220, 130221}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
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