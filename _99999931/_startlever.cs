namespace Maple2.Trigger._99999931 {
    public static class _startlever {
        public class State시작레버 : TriggerState {
            internal State시작레버(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {211, 212}, arg2: true);
                context.SetMesh(arg1: new[] {551, 552}, arg2: false);
                context.SetPortal(arg1: 500, arg2: false, arg3: true);
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
                context.SetPortal(arg1: 101, arg2: false, arg3: false);
                context.SetPortal(arg1: 102, arg2: false, arg3: false);
                context.SetPortal(arg1: 103, arg2: false, arg3: false);
                context.SetPortal(arg1: 104, arg2: false, arg3: false);
                context.SetPortal(arg1: 115, arg2: false, arg3: false);
                context.SetPortal(arg1: 116, arg2: false, arg3: false);
                context.SetPortal(arg1: 117, arg2: false, arg3: false);
                context.SetPortal(arg1: 118, arg2: false, arg3: false);
            }

            public override TriggerState Execute() {
                return new State게임준비(context);
            }

            public override void OnExit() { }
        }

        private class State게임준비 : TriggerState {
            internal State게임준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "11", arg2: 3);
                context.SetEventUI(arg1: 1, arg2: "$99999931__STARTLEVER__0$", arg3: 4000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11")) {
                    return new State시작레버(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}