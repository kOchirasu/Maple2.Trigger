namespace Maple2.Trigger._52100303_qd {
    public static class _mesh {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {701})) {
                    return new State첫번째길막(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째길막 : TriggerState {
            internal State첫번째길막(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Mesh") == 2) {
                    context.SetMesh(arg1: new[] {4002}, arg2: true);
                    return new State이Phase(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이Phase : TriggerState {
            internal State이Phase(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {111}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Mesh") == 3) {
                    context.SetAiExtraData(key: "Thunder", value: 2);
                    context.SetMesh(arg1: new[] {4003}, arg2: true);
                    return new State삼Phase(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼Phase : TriggerState {
            internal State삼Phase(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Mesh") == 4) {
                    context.SetMesh(arg1: new[] {4004}, arg2: true);
                    context.DestroyMonster(arg1: new[] {111});
                    return new State진짜마지막(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진짜마지막 : TriggerState {
            internal State진짜마지막(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}