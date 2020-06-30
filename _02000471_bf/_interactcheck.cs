using System;

namespace Maple2.Trigger._02000471_bf {
    public static class _interactcheck {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Statecheck(context);

        private class Statecheck : TriggerState {
            internal Statecheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 2040314, key: "InteractClear", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "10002019clear", value: 1)
                    && context.UserValue(key: "10002020clear", value: 1)
                    && context.UserValue(key: "10002021clear", value: 1)
                    && context.UserValue(key: "10002022clear", value: 1)
                    && context.UserValue(key: "10002023clear", value: 1)
                    && context.UserValue(key: "10002024clear", value: 1)) {
                    context.State = new Stateclear(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateclear : TriggerState {
            internal Stateclear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 2040314, key: "InteractClear", value: 1);
                context.SetUserValue(triggerID: 2040322, key: "InteractClear", value: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}