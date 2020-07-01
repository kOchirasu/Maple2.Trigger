namespace Maple2.Trigger._02000486_bf {
    public static class _103_timer {
        public class State전투시작 : TriggerState {
            internal State전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterInCombat(arg1: new[] {900}) || context.MonsterInCombat(arg1: new[] {901})) {
                    context.State = new State타이머(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State타이머 : TriggerState {
            internal State타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "999", arg2: 240, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State설명(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State설명 : TriggerState {
            internal State설명(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000486_BF__103_TIMER__0$", arg3: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 239000)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {900}) && context.MonsterDead(arg1: new[] {901})) {
                    context.State = new State타이머종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000486_BF__103_TIMER__1$", arg3: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) { }
            }

            public override void OnExit() { }
        }

        private class State타이머종료 : TriggerState {
            internal State타이머종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(arg1: "999");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) { }
            }

            public override void OnExit() { }
        }
    }
}