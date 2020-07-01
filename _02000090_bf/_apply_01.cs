namespace Maple2.Trigger._02000090_bf {
    public static class _apply_01 {
        public class State대기0 : TriggerState {
            internal State대기0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {1000}, arg2: false);
                context.SetEffect(arg1: new[] {1001}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000360}, arg2: 1);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new State대기1(context);
                    return;
                }

                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new State대기2(context);
                    return;
                }

                if (context.RandomCondition(arg1: 34f)) {
                    context.State = new State대기3(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000360}, arg2: 0)) {
                    context.State = new State이펙트1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기1 : TriggerState {
            internal State대기1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 3);
                context.SetEffect(arg1: new[] {1000}, arg2: true);
                context.SetInteractObject(arg1: new[] {10000360}, arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State대기0(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000360}, arg2: 0)) {
                    context.State = new State이펙트1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기2 : TriggerState {
            internal State대기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 7);
                context.SetEffect(arg1: new[] {1000}, arg2: true);
                context.SetEffect(arg1: new[] {1001}, arg2: true);
                context.SetInteractObject(arg1: new[] {10000360}, arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State대기0(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000360}, arg2: 0)) {
                    context.State = new State이펙트1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기3 : TriggerState {
            internal State대기3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 1);
                context.SetEffect(arg1: new[] {1000}, arg2: true);
                context.SetEffect(arg1: new[] {1001}, arg2: true);
                context.SetInteractObject(arg1: new[] {10000360}, arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State대기0(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000360}, arg2: 0)) {
                    context.State = new State이펙트1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이펙트1 : TriggerState {
            internal State이펙트1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 1);
                context.SetEffect(arg1: new[] {1000}, arg2: true);
                context.SetEffect(arg1: new[] {1001}, arg2: true);
                context.SetEffect(arg1: new[] {2000}, arg2: true);
                context.SetEffect(arg1: new[] {2001}, arg2: true);
                context.SetEffect(arg1: new[] {2002}, arg2: true);
                context.SetEffect(arg1: new[] {2003}, arg2: true);
                context.SetEffect(arg1: new[] {2004}, arg2: true);
                context.SetEffect(arg1: new[] {2005}, arg2: true);
                context.SetEffect(arg1: new[] {2006}, arg2: true);
                context.SetEffect(arg1: new[] {2007}, arg2: true);
                context.SetEffect(arg1: new[] {1000}, arg2: false);
                context.SetEffect(arg1: new[] {1001}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    context.State = new State트리거초기화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거초기화 : TriggerState {
            internal State트리거초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {1000}, arg2: false);
                context.SetEffect(arg1: new[] {1001}, arg2: false);
                context.SetEffect(arg1: new[] {2000}, arg2: false);
                context.SetEffect(arg1: new[] {2001}, arg2: false);
                context.SetEffect(arg1: new[] {2002}, arg2: false);
                context.SetEffect(arg1: new[] {2003}, arg2: false);
                context.SetEffect(arg1: new[] {2004}, arg2: false);
                context.SetTimer(arg1: "20", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "20")) {
                    context.State = new State대기0(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}