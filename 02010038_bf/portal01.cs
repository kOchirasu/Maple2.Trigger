namespace Maple2.Trigger._02010038_bf {
    public static class _portal01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 50, visible: false, enabled: false, minimapVisible: false);
                context.SetActor(arg1: 1000, arg2: true, arg3: "co_functobj_sensor_A01_Off");
                context.SetInteractObject(arg1: new[] {10000881}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000881}, arg2: 0)) {
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
                context.SetActor(arg1: 1000, arg2: true, arg3: "co_functobj_sensor_A01_On");
                context.SetTimer(id: "2", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
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
                context.SetTimer(id: "3", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}