namespace Maple2.Trigger._02010040_bf {
    public static class _battlezone01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetEffect(arg1: new[] {4101, 4102}, arg2: false);
                context.SetMesh(arg1: new[] {1100, 1101}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 2100, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 2101, arg2: true, arg3: "Closed");
                context.SetAgent(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9100})) {
                    return new State전투시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투시작 : TriggerState {
            internal State전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 109, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 109, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210})) {
                    return new State문열기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열기 : TriggerState {
            internal State문열기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1100, 1101}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {4101, 4102}, arg2: true);
                context.SetActor(arg1: 2100, arg2: true, arg3: "Opened");
                context.SetActor(arg1: 2101, arg2: true, arg3: "Opened");
                context.SetAgent(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109}, arg2: false);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}