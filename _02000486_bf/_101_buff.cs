namespace Maple2.Trigger._02000486_bf {
    public static class _101_buff {
        public class State전투시작 : TriggerState {
            internal State전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterInCombat(arg1: new[] {900})) {
                    context.State = new State타임(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State타임 : TriggerState {
            internal State타임(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {900}) || context.MonsterDead(arg1: new[] {901})) {
                    // context.State = new StateMove01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State버프_종료 : TriggerState {
            internal State버프_종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) { }
            }

            public override void OnExit() { }
        }
    }
}