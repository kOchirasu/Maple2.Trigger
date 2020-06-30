using System;

namespace Maple2.Trigger._51000003_dg {
    public static class _buff {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "Tutorial", value: 1)) {
                    context.State = new StateTutorial_buff(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTutorial_buff : TriggerState {
            internal StateTutorial_buff(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "Tutorial", value: 0)) {
                    context.State = new Stateidle(context);
                    return;
                }

                if (context.UserDetected(arg1: "701")) {
                    context.State = new Statebuff(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statebuff : TriggerState {
            internal Statebuff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {701}, arg2: 70000085, arg3: 1, arg5: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "Tutorial", value: 0)) {
                    context.State = new Stateidle(context);
                    return;
                }

                if (true) {
                    context.State = new StateTutorial_buff(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}