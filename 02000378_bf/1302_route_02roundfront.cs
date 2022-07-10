namespace Maple2.Trigger._02000378_bf {
    public static class _1302_route_02roundfront {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{18021, 18022, 18023, 18024}, visible: true);
                context.SetEffect(triggerIds: new []{5002}, visible: false);
                context.SetMesh(triggerIds: new []{130200, 130201, 130202, 130203, 130204, 130205, 130206, 130207, 130208, 130209, 130210, 130211, 130212, 130213, 130214, 130215, 130216, 130217, 130218, 130219, 130220, 130221, 330200, 330201, 330202, 330203, 330204, 330205, 330206, 330207, 330208, 330209, 330210, 330211, 330212, 330213, 330214, 330215, 330216, 330217, 330218, 330219, 330220, 330221}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(key: "RouteSelected", value: 0);
                context.SetUserValue(key: "MakeTrue", value: 0);
                context.SetUserValue(key: "MakeFalse", value: 0);
            }

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
                context.SetRandomMesh(triggerIds: new []{130200, 130201, 130202, 130203, 130204, 130205, 130206, 130207, 130208, 130209, 130210, 130211, 130212, 130213, 130214, 130215, 130216, 130217, 130218, 130219, 130220, 130221}, visible: true, meshCount: 7, arg4: 100, delay: 500);
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
                context.SetRandomMesh(triggerIds: new []{130200, 130201, 130202, 130203, 130204, 130205, 130206, 130207, 130208, 130209, 130210, 130211, 130212, 130213, 130214, 130215, 130216, 130217, 130218, 130219, 130220, 130221}, visible: false, meshCount: 22, arg4: 0, delay: 0);
            }
        }

        private class StateStartDazzlingRandom02 : TriggerState {
            internal StateStartDazzlingRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(triggerIds: new []{130200, 130201, 130202, 130203, 130204, 130205, 130206, 130207, 130208, 130209, 130210, 130211, 130212, 130213, 130214, 130215, 130216, 130217, 130218, 130219, 130220, 130221}, visible: true, meshCount: 7, arg4: 100, delay: 500);
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
                context.SetRandomMesh(triggerIds: new []{130200, 130201, 130202, 130203, 130204, 130205, 130206, 130207, 130208, 130209, 130210, 130211, 130212, 130213, 130214, 130215, 130216, 130217, 130218, 130219, 130220, 130221}, visible: false, meshCount: 22, arg4: 0, delay: 0);
            }
        }

        private class StateMakeTrue : TriggerState {
            internal StateMakeTrue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5002}, visible: true);
                context.SetMesh(triggerIds: new []{130200, 130201, 130202, 130203, 130204, 130205, 130206, 130207, 130208, 130209, 130210, 130211, 130212, 130213, 130214, 130215, 130216, 130217, 130218, 130219, 130220, 130221}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetRandomMesh(triggerIds: new []{330200, 330201, 330202, 330203, 330204, 330205, 330206, 330207, 330208, 330209, 330210, 330211, 330212, 330213, 330214, 330215, 330216, 330217, 330218, 330219, 330220, 330221}, visible: true, meshCount: 22, arg4: 100, delay: 50);
                context.SetAgent(triggerIds: new []{18021, 18022, 18023, 18024}, visible: false);
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
                context.SetMesh(triggerIds: new []{130200, 130201, 130202, 130203, 130204, 130205, 130206, 130207, 130208, 130209, 130210, 130211, 130212, 130213, 130214, 130215, 130216, 130217, 130218, 130219, 130220, 130221}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
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
