namespace Maple2.Trigger._02000282_bf {
    public static class _heal06 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {706}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000249}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000249}, arg2: 0)) {
                    return new StateSkill작동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill작동 : TriggerState {
            internal StateSkill작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {706}, arg2: true);
                context.SetTimer(id: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.SetSkill(arg1: new[] {706}, arg2: false);
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "29", arg2: 29);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "29")) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}