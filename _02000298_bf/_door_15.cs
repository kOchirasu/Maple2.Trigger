namespace Maple2.Trigger._02000298_bf {
    public static class _door_15 {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 215, arg2: true, arg3: "Closed");
                context.SetMesh(arg1: new[] {3151, 3152}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetAgent(arg1: new[] {9151, 9152, 9153}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {115})) {
                    context.State = new State문열림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문열림 : TriggerState {
            internal State문열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 215, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new[] {3151}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetMesh(arg1: new[] {3152}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetAgent(arg1: new[] {9151, 9152, 9153}, arg2: false);
                context.CreateMonster(arg1: new[] {1016}, arg2: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}