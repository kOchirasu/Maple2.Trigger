namespace Maple2.Trigger._02000421_bf {
    public static class _eventnpcappearance {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return new State보스등장대기(context);
            }

            public override void OnExit() { }
        }

        private class State보스등장대기 : TriggerState {
            internal State보스등장대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {111, 121, 131}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "EventNpcAppearance") == 1) {
                    return new State우호적NPC등장(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State우호적NPC등장 : TriggerState {
            internal State우호적NPC등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {111}, arg2: true);
                context.DestroyMonster(arg1: new[] {121}, arg2: true);
                context.DestroyMonster(arg1: new[] {131}, arg2: true);
                context.CreateMonster(arg1: new[] {11, 21, 31}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "EventNpcAppearance") == 2) {
                    return new State시작대기중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}