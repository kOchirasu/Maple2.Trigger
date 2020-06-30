using System;

namespace Maple2.Trigger._02000471_bf {
    public static class _timer {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 2040301, key: "TimerEnd", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "TimerStart", value: 1)) {
                    context.State = new Statestart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "Timer", arg2: 420, arg3: true, arg4: true, arg5: 0);
                context.SetEventUI(arg1: 1, arg2: "$02000471_BF__TIMER__0$", arg3: new int[] {5000}, arg4: "0");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "Timer")) {
                    context.State = new Stateend_fail(context);
                    return;
                }

                if (context.UserValue(key: "InteractClear", value: 1)) {
                    context.State = new Stateend_clear(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateend_fail : TriggerState {
            internal Stateend_fail(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 2040301, key: "TimerEnd", value: 1);
                context.ResetTimer(arg1: "Timer");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class Stateend_clear : TriggerState {
            internal Stateend_clear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 2040301, key: "InteractClear", value: 1);
                context.ResetTimer(arg1: "Timer");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}