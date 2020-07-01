namespace Maple2.Trigger._02000207_bf {
    public static class _999990_ground {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {5001, 5002, 5003, 5004, 5005, 5006}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "ZakumBodyAppearance") == 1) {
                    context.State = new State3층지형의숨겨진바닥생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3층지형의숨겨진바닥생성 : TriggerState {
            internal State3층지형의숨겨진바닥생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {5001, 5002, 5003, 5004, 5005, 5006}, arg2: true, arg3: 1, arg4: 120, arg5: 0.5f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}