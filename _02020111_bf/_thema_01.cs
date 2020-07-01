namespace Maple2.Trigger._02020111_bf {
    public static class _thema_01 {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {1002})) {
                    context.State = new State소환준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소환준비 : TriggerState {
            internal State소환준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State몬스터등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터등장 : TriggerState {
            internal State몬스터등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {141, 142, 143, 144, 145, 146});
            }

            public override void Execute() {
                if (context.GetUserValue(key: "monster_die") == 1) {
                    context.State = new State몬스터소멸(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {141, 142, 143, 144, 145, 146})) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "monster_die") == 1) {
                    context.State = new State몬스터소멸(context);
                    return;
                }

                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State몬스터등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터소멸 : TriggerState {
            internal State몬스터소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {141, 142, 143, 144, 145, 146});
            }

            public override void Execute() {
                if (context.GetUserValue(key: "SkillBreakFail") == 1) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}