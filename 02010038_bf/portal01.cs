namespace Maple2.Trigger._02010038_bf {
    public static class _portal01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 50, visible: false, enabled: false, minimapVisible: false);
                context.SetActor(triggerId: 1000, visible: true, initialSequence: "co_functobj_sensor_A01_Off");
                context.SetInteractObject(interactIds: new []{10000881}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000881}, arg2: 0)) {
                    return new State이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동 : TriggerState {
            internal State이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 50, visible: false, enabled: true, minimapVisible: false);
                context.SetActor(triggerId: 1000, visible: true, initialSequence: "co_functobj_sensor_A01_On");
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    context.SetPortal(portalId: 50, visible: false, enabled: false, minimapVisible: false);
                    return new State재사용Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재사용Wait : TriggerState {
            internal State재사용Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
