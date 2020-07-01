namespace Maple2.Trigger._02000471_bf {
    public static class _interactcheck {
        public class Statecheck : TriggerState {
            internal Statecheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2040314, key: "InteractClear", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "10002019clear") == 1
                    && context.GetUserValue(key: "10002020clear") == 1
                    && context.GetUserValue(key: "10002021clear") == 1
                    && context.GetUserValue(key: "10002022clear") == 1
                    && context.GetUserValue(key: "10002023clear") == 1
                    && context.GetUserValue(key: "10002024clear") == 1) {
                    context.State = new Stateclear(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateclear : TriggerState {
            internal Stateclear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2040314, key: "InteractClear", value: 1);
                context.SetUserValue(triggerId: 2040322, key: "InteractClear", value: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}