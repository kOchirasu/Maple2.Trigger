namespace Maple2.Trigger._02000047_bf {
    public static class _04_rarebox_03 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {403}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {203})) {
                    context.State = new State발판03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판03 : TriggerState {
            internal State발판03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {403}, arg2: true);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: new[] {203})) {
                    context.State = new State발판03끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판03끝 : TriggerState {
            internal State발판03끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "503", arg2: 2, arg3: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "503")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}