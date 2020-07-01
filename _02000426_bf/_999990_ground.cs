namespace Maple2.Trigger._02000426_bf {
    public static class _999990_ground {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {5001, 5002, 5003, 5004, 5005, 5006}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {199})) {
                    return new State대기중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대기중 : TriggerState {
            internal State대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "ZakumBodyAppearance") == 1) {
                    return new State3층지형의숨겨진바닥생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3층지형의숨겨진바닥생성 : TriggerState {
            internal State3층지형의숨겨진바닥생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {5001, 5002, 5003, 5004, 5005, 5006}, arg2: true, arg3: 1, arg4: 120, arg5: 0.5f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}