namespace Maple2.Trigger._02000349_bf {
    public static class _wall_14 {
        public class State벽재생 : TriggerState {
            internal State벽재생(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {31401, 31402, 31403, 31404, 31405, 31406, 31407, 31408, 31409, 31410, 31411, 31412, 31413, 31414, 31415, 31416, 31417, 31418, 31419, 31420, 31421, 31422, 31423, 31424}, arg2: true, arg3: 0, arg4: 10, arg5: 3f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {114})) {
                    return new State벽삭제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벽삭제 : TriggerState {
            internal State벽삭제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {31401, 31402, 31403, 31404, 31405, 31406, 31407, 31408, 31409, 31410, 31411, 31412, 31413, 31414, 31415, 31416, 31417, 31418, 31419, 31420, 31421, 31422, 31423, 31424}, arg2: false, arg3: 0, arg4: 10, arg5: 3f);
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {114})) {
                    return new StateDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay : TriggerState {
            internal StateDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State벽재생(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}