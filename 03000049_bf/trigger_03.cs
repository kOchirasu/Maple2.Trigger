namespace Maple2.Trigger._03000049_bf {
    public static class _trigger_03 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {202});
                context.SetInteractObject(arg1: new[] {10000288}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000288}, arg2: 0)) {
                    return new State반항(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반항 : TriggerState {
            internal State반항(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {202}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 202, script: "$03000049_BF__TRIGGER_03__0$", arg4: 2);
            }

            public override TriggerState Execute() {
                return new State반항2(context);
            }

            public override void OnExit() { }
        }

        private class State반항2 : TriggerState {
            internal State반항2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "2", arg2: 30, arg3: false);
                context.SetInteractObject(arg1: new[] {10000288}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}