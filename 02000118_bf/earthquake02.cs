namespace Maple2.Trigger._02000118_bf {
    public static class _earthquake02 {
        public class State레버당기기 : TriggerState {
            internal State레버당기기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000291}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000291}, arg2: 0)) {
                    return new StateSkill동작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill동작 : TriggerState {
            internal StateSkill동작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {2005, 2006, 2007, 2008}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 10);
                context.SetSkill(arg1: new[] {2005, 2006, 2007, 2008}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State레버당기기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}