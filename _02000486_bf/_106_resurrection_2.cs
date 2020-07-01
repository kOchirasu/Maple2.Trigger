namespace Maple2.Trigger._02000486_bf {
    public static class _106_resurrection_2 {
        public class State전투시작 : TriggerState {
            internal State전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterInCombat(arg1: new[] {901})) {
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
                if (context.WaitTick(waitTick: 240000)) {
                    context.State = new State버프(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State버프 : TriggerState {
            internal State버프(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "RageBuff_3", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State버프_종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State버프_종료 : TriggerState {
            internal State버프_종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "RageBuff_3", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) { }
            }

            public override void OnExit() { }
        }
    }
}