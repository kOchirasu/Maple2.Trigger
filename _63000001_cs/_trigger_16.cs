namespace Maple2.Trigger._63000001_cs {
    public static class _trigger_16 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {316}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {116})) {
                    return new State발판16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State발판16 : TriggerState {
            internal State발판16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {316}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {116})) {
                    return new State발판16끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State발판16끝 : TriggerState {
            internal State발판16끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "416", arg2: 2, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "416")) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}