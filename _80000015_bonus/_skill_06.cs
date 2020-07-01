namespace Maple2.Trigger._80000015_bonus {
    public static class _skill_06 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {103})) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기시간 : TriggerState {
            internal State대기시간(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {706, 707, 708, 709, 710, 711}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1300)) {
                    context.State = new State스킬01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬01 : TriggerState {
            internal State스킬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {706}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State스킬02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬02 : TriggerState {
            internal State스킬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {707}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State스킬03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬03 : TriggerState {
            internal State스킬03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {708}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State스킬04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬04 : TriggerState {
            internal State스킬04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {709}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State스킬05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬05 : TriggerState {
            internal State스킬05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {710}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State스킬06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬06 : TriggerState {
            internal State스킬06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {711}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}