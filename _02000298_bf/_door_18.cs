namespace Maple2.Trigger._02000298_bf {
    public static class _door_18 {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 218, arg2: true, arg3: "Closed");
                context.SetMesh(arg1: new[] {3181, 3182}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetAgent(arg1: new[] {9181, 9182, 9183}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {118})) {
                    context.State = new State문열림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문열림 : TriggerState {
            internal State문열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 218, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new[] {3181}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetMesh(arg1: new[] {3182}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetAgent(arg1: new[] {9181, 9182, 9183}, arg2: false);
                context.CreateMonster(arg1: new[] {1019}, arg2: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}