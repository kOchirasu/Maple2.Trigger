namespace Maple2.Trigger._02000397_bf {
    public static class _06_gratingdown {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001153, 10001154}, state: 0);
                context.SetMesh(triggerIds: new []{6200, 6201, 6202, 6203, 6204, 6205, 6206, 6207, 6208, 6209, 6210, 6211}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{6300, 6301, 6302, 6303, 6304, 6305}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3901}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetBreakable(triggerIds: new []{6000, 6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010, 6011}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{6000, 6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010, 6011}, arg2: false);
                context.SetBreakable(triggerIds: new []{6100, 6101, 6102, 6103, 6104, 6105, 6106, 6107, 6108, 6109, 6110, 6111}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{6100, 6101, 6102, 6103, 6104, 6105, 6106, 6107, 6108, 6109, 6110, 6111}, arg2: false);
                context.SetAgent(triggerIds: new []{8000, 8001, 8002}, visible: false);
                context.SetUserValue(key: "BlockEnable", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BlockEnable") == 1) {
                    return new StateBlockEnable(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlockEnable : TriggerState {
            internal StateBlockEnable(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001153}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001153}, arg2: 0)) {
                    return new StateBlockStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlockStart : TriggerState {
            internal StateBlockStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{6300, 6301, 6302, 6303, 6304, 6305}, visible: false, arg3: 100, arg4: 0, arg5: 2f);
                context.SetBreakable(triggerIds: new []{6000, 6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010, 6011}, enabled: true);
                context.SetVisibleBreakableObject(triggerIds: new []{6000, 6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010, 6011}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBlockIng(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlockIng : TriggerState {
            internal StateBlockIng(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3901}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetAgent(triggerIds: new []{8000, 8001, 8002}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBlockEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlockEnd : TriggerState {
            internal StateBlockEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{6200, 6201, 6202, 6203, 6204, 6205, 6206, 6207, 6208, 6209, 6210, 6211}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetBreakable(triggerIds: new []{6000, 6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010, 6011}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{6000, 6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010, 6011}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBlockDisable(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlockDisable : TriggerState {
            internal StateBlockDisable(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001154}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001154}, arg2: 0)) {
                    return new StateBlockOffStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlockOffStart : TriggerState {
            internal StateBlockOffStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{6200, 6201, 6202, 6203, 6204, 6205, 6206, 6207, 6208, 6209, 6210, 6211}, visible: false, arg3: 100, arg4: 0, arg5: 2f);
                context.SetBreakable(triggerIds: new []{6100, 6101, 6102, 6103, 6104, 6105, 6106, 6107, 6108, 6109, 6110, 6111}, enabled: true);
                context.SetVisibleBreakableObject(triggerIds: new []{6100, 6101, 6102, 6103, 6104, 6105, 6106, 6107, 6108, 6109, 6110, 6111}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBlockOffIng(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlockOffIng : TriggerState {
            internal StateBlockOffIng(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3901}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetAgent(triggerIds: new []{8000, 8001, 8002}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBlockOffEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlockOffEnd : TriggerState {
            internal StateBlockOffEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{6300, 6301, 6302, 6303, 6304, 6305}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetBreakable(triggerIds: new []{6100, 6101, 6102, 6103, 6104, 6105, 6106, 6107, 6108, 6109, 6110, 6111}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{6100, 6101, 6102, 6103, 6104, 6105, 6106, 6107, 6108, 6109, 6110, 6111}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBlockEnable(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
