namespace Maple2.Trigger._52000073_qd {
    public static class _hiddendoor02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 3000, visible: true, initialSequence: "Closed");
                context.SetMesh(triggerIds: new []{2000}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetBreakable(triggerIds: new []{4000}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{4000}, visible: false);
                context.SetInteractObject(interactIds: new []{10001082}, state: 1);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001082}, arg2: 0)) {
                    return new StateBookCaseMove01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBookCaseMove01 : TriggerState {
            internal StateBookCaseMove01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(triggerIds: new []{4000}, enabled: true);
                context.SetVisibleBreakableObject(triggerIds: new []{4000}, visible: true);
                context.SetMesh(triggerIds: new []{2000}, visible: false, arg3: 0, arg4: 0, arg5: 3f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDoorOpen01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDoorOpen01 : TriggerState {
            internal StateDoorOpen01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 3000, visible: true, initialSequence: "Opened");
                context.SetPortal(portalId: 2, visible: true, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDoorOpen02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDoorOpen02 : TriggerState {
            internal StateDoorOpen02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 57000)) {
                    return new StateDoorClose01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDoorClose01 : TriggerState {
            internal StateDoorClose01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 3000, visible: true, initialSequence: "Closed");
                context.SetPortal(portalId: 2, visible: true, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDoorClose02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDoorClose02 : TriggerState {
            internal StateDoorClose02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(triggerIds: new []{4000}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{4000}, visible: false);
                context.SetMesh(triggerIds: new []{2000}, visible: true, arg3: 0, arg4: 0, arg5: 3f);
                context.SetInteractObject(interactIds: new []{10001082}, state: 1);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001082}, arg2: 0)) {
                    return new StateBookCaseMove01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
