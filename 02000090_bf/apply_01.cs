namespace Maple2.Trigger._02000090_bf {
    public static class _apply_01 {
        public class StateWait0 : TriggerState {
            internal StateWait0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {1000, 1001}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000360}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 33f)) {
                    return new StateWait1(context);
                }

                if (context.RandomCondition(arg1: 33f)) {
                    return new StateWait2(context);
                }

                if (context.RandomCondition(arg1: 34f)) {
                    return new StateWait3(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000360}, arg2: 0)) {
                    return new State이펙트1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait1 : TriggerState {
            internal StateWait1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 3);
                context.SetEffect(arg1: new[] {1000}, arg2: true);
                context.SetInteractObject(arg1: new[] {10000360}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateWait0(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000360}, arg2: 0)) {
                    return new State이펙트1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait2 : TriggerState {
            internal StateWait2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "2", arg2: 7);
                context.SetEffect(arg1: new[] {1000, 1001}, arg2: true);
                context.SetInteractObject(arg1: new[] {10000360}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new StateWait0(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000360}, arg2: 0)) {
                    return new State이펙트1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait3 : TriggerState {
            internal StateWait3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "3", arg2: 1);
                context.SetEffect(arg1: new[] {1000, 1001}, arg2: true);
                context.SetInteractObject(arg1: new[] {10000360}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateWait0(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000360}, arg2: 0)) {
                    return new State이펙트1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이펙트1 : TriggerState {
            internal State이펙트1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "10", arg2: 1);
                context.SetEffect(arg1: new[] {1000, 1001, 2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007}, arg2: true);
                context.SetEffect(arg1: new[] {1000, 1001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    return new StateTriggerReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTriggerReset : TriggerState {
            internal StateTriggerReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {1000, 1001, 2000, 2001, 2002, 2003, 2004}, arg2: false);
                context.SetTimer(id: "20", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "20")) {
                    return new StateWait0(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}