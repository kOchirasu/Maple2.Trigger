namespace Maple2.Trigger._02020051_bf {
    public static class _103_potion {
        public class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "Main") == 1) {
                    context.State = new State포션사용_준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포션사용_준비 : TriggerState {
            internal State포션사용_준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002131}, arg2: 2);
                context.SetUserValue(triggerId: 101, key: "Potion", value: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 720000)) {
                    context.State = new State포션사용(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포션사용 : TriggerState {
            internal State포션사용(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002131}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10002131}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 101, key: "Potion", value: 1);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Main") == 2) {
                    context.State = new State준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}