namespace Maple2.Trigger._52100303_qd {
    public static class _blackbuff {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {12000607}, arg2: 0);
                context.SetInteractObject(arg1: new[] {12000607}, arg2: 1);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {801})) {
                    context.State = new State오브젝트체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기이 : TriggerState {
            internal State대기이(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {801})) {
                    context.State = new State오브젝트체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오브젝트체크 : TriggerState {
            internal State오브젝트체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000606}, arg2: 0)) {
                    context.State = new State오브젝트재생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오브젝트재생성 : TriggerState {
            internal State오브젝트재생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetInteractObject(arg1: new[] {12000606}, arg2: 1);
                    context.State = new State오브젝트체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}