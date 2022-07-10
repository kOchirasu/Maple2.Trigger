namespace Maple2.Trigger._50000006_dl {
    public static class _03_vrmachine {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "machineon", value: 0);
                context.SetInteractObject(interactIds: new []{10001246}, state: 2);
                context.SetPortal(portalId: 3, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "machineon") == 1) {
                    return new StateMachineOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMachineOn : TriggerState {
            internal StateMachineOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001246}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001246}, arg2: 0)) {
                    return new StatePortalOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalOn : TriggerState {
            internal StatePortalOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "DungeonRoomOpened", value: 1);
                context.SetPortal(portalId: 3, visible: false, enabled: true, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateResetDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateResetDelay : TriggerState {
            internal StateResetDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 3, visible: false, enabled: false, minimapVisible: false);
                context.SetInteractObject(interactIds: new []{10001246}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001246}, arg2: 0)) {
                    return new StatePortalOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
