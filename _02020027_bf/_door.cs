namespace Maple2.Trigger._02020027_bf {
    public static class _door {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {9001, 9002, 9003, 9004, 9005, 9006, 9007}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.GetNpcHpRate(spawnPointId: 201) < 0.50f) {
                    return new State문열림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열림 : TriggerState {
            internal State문열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {9001, 9002, 9003, 9004, 9005, 9006, 9007}, arg2: false, arg3: 0, arg4: 0, arg5: 10f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {1002})) {
                    return new State문닫힘(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문닫힘 : TriggerState {
            internal State문닫힘(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {9001, 9002, 9003, 9004, 9005, 9006}, arg2: true, arg3: 0, arg4: 0, arg5: 10f);
                context.SetMesh(arg1: new[] {9007}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}