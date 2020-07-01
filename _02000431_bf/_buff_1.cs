namespace Maple2.Trigger._02000431_bf {
    public static class _buff_1 {
        public class State전투시작 : TriggerState {
            internal State전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterInCombat(arg1: new[] {2199})) {
                    context.State = new State버프(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State버프 : TriggerState {
            internal State버프(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {2199}, arg2: 40501006, arg3: 1, arg4: true, arg5: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) { }
            }

            public override void OnExit() { }
        }
    }
}