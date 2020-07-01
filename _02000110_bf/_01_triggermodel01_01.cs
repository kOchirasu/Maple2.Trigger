namespace Maple2.Trigger._02000110_bf {
    public static class _01_triggermodel01_01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000063}, arg2: 1);
                context.SetActor(arg1: 10, arg2: true, arg3: "Closed");
                context.SetEffect(arg1: new[] {201}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000063}, arg2: 0)) {
                    return new State몬스터생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몬스터생성 : TriggerState {
            internal State몬스터생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 10, arg2: true, arg3: "Opened");
                context.CreateMonster(arg1: new[] {101}, arg2: true);
                context.SetEffect(arg1: new[] {201}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State몬스터전투(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몬스터전투 : TriggerState {
            internal State몬스터전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State트리거초기화(context);
                }

                if (!context.MonsterInCombat(arg1: new[] {101})) {
                    return new State몬스터소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몬스터소멸 : TriggerState {
            internal State몬스터소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 30);
            }

            public override TriggerState Execute() {
                if (context.MonsterInCombat(arg1: new[] {101})) {
                    context.ResetTimer(arg1: "1");
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State소멸대기(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new State소멸대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소멸대기 : TriggerState {
            internal State소멸대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State트리거초기화(context);
                }

                if (context.MonsterInCombat(arg1: new[] {101})) {
                    return new State몬스터소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리거초기화 : TriggerState {
            internal State트리거초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101});
                context.SetTimer(arg1: "2", arg2: 20);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "2");
            }
        }
    }
}