namespace Maple2.Trigger._02000242_bf {
    public static class _trigger_04_01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {707, 708}, arg2: true);
                context.DestroyMonster(arg1: new[] {607, 608});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State1차웨이브 : TriggerState {
            internal State1차웨이브(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {607, 608}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {607, 608})) {
                    context.State = new State1차딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1차딜레이 : TriggerState {
            internal State1차딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 10);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State2차웨이브(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차웨이브 : TriggerState {
            internal State2차웨이브(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {607, 608}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {607, 608})) {
                    context.State = new State2차딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차딜레이 : TriggerState {
            internal State2차딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 10);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State3차웨이브(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3차웨이브 : TriggerState {
            internal State3차웨이브(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {607, 608}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {607, 608})) {
                    context.State = new State3차딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3차딜레이 : TriggerState {
            internal State3차딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 180);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}