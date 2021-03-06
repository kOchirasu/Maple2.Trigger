namespace Maple2.Trigger._99999931 {
    public static class _startlever {
        public class StateStartLever : TriggerState {
            internal StateStartLever(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {211, 212}, arg2: true);
                context.SetMesh(arg1: new[] {551, 552}, arg2: false);
                context.SetPortal(portalId: 500, visible: false, enabled: true);
                context.SetBreakable(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000215}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000215}, arg2: 0)) {
                    return new State이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동 : TriggerState {
            internal State이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {201, 202, 203, 204, 205, 206, 207, 208}, arg2: false);
                context.SetPortal(portalId: 101, visible: false, enabled: false);
                context.SetPortal(portalId: 102, visible: false, enabled: false);
                context.SetPortal(portalId: 103, visible: false, enabled: false);
                context.SetPortal(portalId: 104, visible: false, enabled: false);
                context.SetPortal(portalId: 115, visible: false, enabled: false);
                context.SetPortal(portalId: 116, visible: false, enabled: false);
                context.SetPortal(portalId: 117, visible: false, enabled: false);
                context.SetPortal(portalId: 118, visible: false, enabled: false);
            }

            public override TriggerState Execute() {
                return new State게임Prepare(context);
            }

            public override void OnExit() { }
        }

        private class State게임Prepare : TriggerState {
            internal State게임Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "11", arg2: 3);
                context.SetEventUI(arg1: 1, script: "$99999931__STARTLEVER__0$", arg3: 4000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11")) {
                    return new StateStartLever(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}