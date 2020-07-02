namespace Maple2.Trigger._02000486_bf {
    public static class _103_timer {
        public class StateBattleStart : TriggerState {
            internal StateBattleStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterInCombat(arg1: new[] {900}) || context.MonsterInCombat(arg1: new[] {901})) {
                    return new State타이머(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State타이머 : TriggerState {
            internal State타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "999", arg2: 240, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State설명(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State설명 : TriggerState {
            internal State설명(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000486_BF__103_TIMER__0$", arg3: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 239000)) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(arg1: new[] {900}) && context.MonsterDead(arg1: new[] {901})) {
                    return new State타이머종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000486_BF__103_TIMER__1$", arg3: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) { }

                return null;
            }

            public override void OnExit() { }
        }

        private class State타이머종료 : TriggerState {
            internal State타이머종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(arg1: "999");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) { }

                return null;
            }

            public override void OnExit() { }
        }
    }
}