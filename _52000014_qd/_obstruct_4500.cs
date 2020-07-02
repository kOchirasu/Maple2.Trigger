namespace Maple2.Trigger._52000014_qd {
    public static class _obstruct_4500 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {4500}, arg2: false);
                context.SetEffect(arg1: new[] {450}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    return new State발동준비(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State발동준비 : TriggerState {
            internal State발동준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State발동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State발동 : TriggerState {
            internal State발동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 1);
                context.SetSkill(arg1: new[] {4500}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State발동준비(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}