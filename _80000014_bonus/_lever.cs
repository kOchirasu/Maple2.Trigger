namespace Maple2.Trigger._80000014_bonus {
    public static class _lever {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001314}, arg2: 1);
                context.SetMesh(arg1: new[] {3501, 3502, 3503, 3504, 3505, 3506}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {199})) {
                    context.State = new State반응대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State반응대기 : TriggerState {
            internal State반응대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    context.State = new State안내(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10001314}, arg2: 0)) {
                    context.State = new State문열림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State안내 : TriggerState {
            internal State안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$80000014_bonus__lever__0$", arg3: 2000);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001314}, arg2: 0)) {
                    context.State = new State문열림(context);
                    return;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State반응대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문열림 : TriggerState {
            internal State문열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3501, 3502, 3503, 3504, 3505, 3506}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}