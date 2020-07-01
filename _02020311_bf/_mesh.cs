namespace Maple2.Trigger._02020311_bf {
    public static class _mesh {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {701})) {
                    context.State = new State첫번째길막(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State첫번째길막 : TriggerState {
            internal State첫번째길막(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "Mesh") == 2) {
                    context.SetMesh(arg1: new[] {4002}, arg2: true);
                    context.State = new State이페이즈(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이페이즈 : TriggerState {
            internal State이페이즈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {111}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Mesh") == 3) {
                    context.SetAiExtraData(key: "Thunder", value: 2);
                    context.SetMesh(arg1: new[] {4003}, arg2: true);
                    context.State = new State삼페이즈(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼페이즈 : TriggerState {
            internal State삼페이즈(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "Mesh") == 4) {
                    context.SetMesh(arg1: new[] {4004}, arg2: true);
                    context.DestroyMonster(arg1: new[] {111});
                    context.State = new State진짜마지막(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진짜마지막 : TriggerState {
            internal State진짜마지막(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}