namespace Maple2.Trigger._02020062_bf {
    public static class _movepanel1 {
        public class State발판초기화 : TriggerState {
            internal State발판초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new[] {2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008}, arg2: false);
                context.SetUserValue(triggerId: 99990024, key: "MovePanel01", value: 0);
                context.SetInteractObject(arg1: new[] {12000115}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "MovePanel01") == 1) {
                    context.State = new State레버생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레버생성 : TriggerState {
            internal State레버생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {12000115}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000115}, arg2: 0)) {
                    context.State = new State발판이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판이동 : TriggerState {
            internal State발판이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetVisibleBreakableObject(arg1: new[] {2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008}, arg2: true);
                context.SetInteractObject(arg1: new[] {12000115}, arg2: 2);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9200})) {
                    context.SetBreakable(arg1: new[] {2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008}, arg2: true);
                    context.State = new State대기(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {9204})) {
                    context.SetBreakable(arg1: new[] {2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008}, arg2: true);
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.UserDetected(arg1: new[] {9204})) {
                    context.SetBreakable(arg1: new[] {2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008}, arg2: false);
                    context.State = new State발판이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}