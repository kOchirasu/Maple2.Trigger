namespace Maple2.Trigger._99999844 {
    public static class _cube8_1 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "CubeOff") == 1) {
                    return new StateOff_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOff_1 : TriggerState {
            internal StateOff_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{5011, 5012, 5013}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateOn_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOn_1 : TriggerState {
            internal StateOn_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{5011, 5012, 5013}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateOff_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOff_2 : TriggerState {
            internal StateOff_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{5011, 5012, 5013}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateOn_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOn_2 : TriggerState {
            internal StateOn_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{5011, 5012, 5013}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateOff_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOff_3 : TriggerState {
            internal StateOff_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{5011, 5012, 5013}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateOn_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOn_3 : TriggerState {
            internal StateOn_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{5011, 5012, 5013}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateOff_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOff_4 : TriggerState {
            internal StateOff_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{5011, 5012, 5013}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 150)) {
                    return new StateOn_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOn_4 : TriggerState {
            internal StateOn_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{5011, 5012, 5013}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 150)) {
                    return new StateOff_5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOff_5 : TriggerState {
            internal StateOff_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{5011, 5012, 5013}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 150)) {
                    return new StateOn_5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOn_5 : TriggerState {
            internal StateOn_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{5011, 5012, 5013}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 150)) {
                    return new StateOff_6(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOff_6 : TriggerState {
            internal StateOff_6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{5011, 5012, 5013}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 150)) {
                    return new StateOn_6(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOn_6 : TriggerState {
            internal StateOn_6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{5011, 5012, 5013}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 150)) {
                    return new StateOff_7(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOff_7 : TriggerState {
            internal StateOff_7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{5011, 5012, 5013}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    context.SetUserValue(triggerId: 920008, key: "CubeOff", value: 0);
                    context.SetUserValue(triggerId: 910008, key: "Cube", value: 2);
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
