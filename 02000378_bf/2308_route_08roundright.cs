namespace Maple2.Trigger._02000378_bf {
    public static class _2308_route_08roundright {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{28081, 28082, 28083, 28084}, visible: true);
                context.SetMesh(triggerIds: new []{230800, 230801, 230802, 230803, 230804, 230805, 230806, 230807, 230808, 230809, 230810, 230811, 230812, 230813, 230814, 230815, 230816, 230817, 230818, 230819, 230820, 230821, 430800, 430801, 430802, 430803, 430804, 430805, 430806, 430807, 430808, 430809, 430810, 430811, 430812, 430813, 430814, 430815, 430816, 430817, 430818, 430819, 430820, 430821}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
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
                context.SetRandomMesh(triggerIds: new []{230800, 230801, 230802, 230803, 230804, 230805, 230806, 230807, 230808, 230809, 230810, 230811, 230812, 230813, 230814, 230815, 230816, 230817, 230818, 230819, 230820, 230821}, visible: true, meshCount: 7, arg4: 100, delay: 500);
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
                context.SetRandomMesh(triggerIds: new []{230800, 230801, 230802, 230803, 230804, 230805, 230806, 230807, 230808, 230809, 230810, 230811, 230812, 230813, 230814, 230815, 230816, 230817, 230818, 230819, 230820, 230821}, visible: false, meshCount: 22, arg4: 0, delay: 0);
            }
        }

        private class StateStartDazzlingRandom02 : TriggerState {
            internal StateStartDazzlingRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(triggerIds: new []{230800, 230801, 230802, 230803, 230804, 230805, 230806, 230807, 230808, 230809, 230810, 230811, 230812, 230813, 230814, 230815, 230816, 230817, 230818, 230819, 230820, 230821}, visible: true, meshCount: 7, arg4: 100, delay: 500);
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
                context.SetRandomMesh(triggerIds: new []{230800, 230801, 230802, 230803, 230804, 230805, 230806, 230807, 230808, 230809, 230810, 230811, 230812, 230813, 230814, 230815, 230816, 230817, 230818, 230819, 230820, 230821}, visible: false, meshCount: 22, arg4: 0, delay: 0);
            }
        }

        private class StateMakeTrue : TriggerState {
            internal StateMakeTrue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5008}, visible: true);
                context.SetMesh(triggerIds: new []{230800, 230801, 230802, 230803, 230804, 230805, 230806, 230807, 230808, 230809, 230810, 230811, 230812, 230813, 230814, 230815, 230816, 230817, 230818, 230819, 230820, 230821}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetRandomMesh(triggerIds: new []{430800, 430801, 430802, 430803, 430804, 430805, 430806, 430807, 430808, 430809, 430810, 430811, 430812, 430813, 430814, 430815, 430816, 430817, 430818, 430819, 430820, 430821}, visible: true, meshCount: 22, arg4: 0, delay: 50);
                context.SetAgent(triggerIds: new []{28081, 28082, 28083, 28084}, visible: false);
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
                context.SetMesh(triggerIds: new []{230800, 230801, 230802, 230803, 230804, 230805, 230806, 230807, 230808, 230809, 230810, 230811, 230812, 230813, 230814, 230815, 230816, 230817, 230818, 230819, 230820, 230821}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
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
