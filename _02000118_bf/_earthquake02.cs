namespace Maple2.Trigger._02000118_bf {
    public static class _earthquake02 {
        public class State레버당기기 : TriggerState {
            internal State레버당기기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000291}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000291}, arg2: 0)) {
                    context.State = new State스킬동작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬동작 : TriggerState {
            internal State스킬동작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {2005}, arg2: true);
                context.SetSkill(arg1: new[] {2006}, arg2: true);
                context.SetSkill(arg1: new[] {2007}, arg2: true);
                context.SetSkill(arg1: new[] {2008}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 10);
                context.SetSkill(arg1: new[] {2005}, arg2: false);
                context.SetSkill(arg1: new[] {2006}, arg2: false);
                context.SetSkill(arg1: new[] {2007}, arg2: false);
                context.SetSkill(arg1: new[] {2008}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State레버당기기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}