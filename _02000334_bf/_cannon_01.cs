using System;

namespace Maple2.Trigger._02000334_bf {
    public static class _cannon_01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateIdle(context);

        private class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {98010}, arg2: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "cannon_01", value: 1)) {
                    context.State = new State마킹비표시(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마킹비표시 : TriggerState {
            internal State마킹비표시(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {98010}, arg2: false);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 90011, arg2: new int[] {190})) {
                    context.State = new State마킹표시(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마킹표시 : TriggerState {
            internal State마킹표시(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {98010}, arg2: true);
            }

            public override void Execute() {
                if (!context.NpcDetected(arg1: 90011, arg2: new int[] {190})) {
                    context.State = new State마킹비표시(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}