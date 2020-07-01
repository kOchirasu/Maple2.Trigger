namespace Maple2.Trigger._02000432_bf {
    public static class _buff_2 {
        public class State전투시작 : TriggerState {
            internal State전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterInCombat(arg1: new[] {2002})) {
                    context.State = new State버프(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State버프 : TriggerState {
            internal State버프(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {2002}, arg2: 40501003, arg3: 1, arg4: true, arg5: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State사망(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State사망 : TriggerState {
            internal State사망(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2002})) {
                    context.State = new State사망_버프제거(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State사망_버프제거 : TriggerState {
            internal State사망_버프제거(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {2001}, arg2: 40501005, arg3: 1, arg4: true, arg5: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) { }
            }

            public override void OnExit() { }
        }
    }
}