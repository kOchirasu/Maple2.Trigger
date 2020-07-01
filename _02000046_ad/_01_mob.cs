namespace Maple2.Trigger._02000046_ad {
    public static class _01_mob {
        public class State반응대기 : TriggerState {
            internal State반응대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000084}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000085}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000086}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000087}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000084, 10000085, 10000086, 10000087}, arg2: 0)) {
                    context.State = new State몬스터리젠(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터리젠 : TriggerState {
            internal State몬스터리젠(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101});
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State카단대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카단대사 : TriggerState {
            internal State카단대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$02000046_AD__01_MOB__0$", arg4: 2);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$02000046_AD__01_MOB__1$", arg4: 2);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$02000046_AD__01_MOB__2$", arg4: 2);
                context.SetTimer(arg1: "1", arg2: 7);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.DestroyMonster(arg1: new[] {101});
                    context.State = new State휴지(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new[] {102}, arg2: true);
            }
        }

        private class State휴지 : TriggerState {
            internal State휴지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State몬스터와전투(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터와전투 : TriggerState {
            internal State몬스터와전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {102})) {
                    context.State = new State소멸대기(context);
                    return;
                }

                if (!context.MonsterInCombat(arg1: new[] {102})) {
                    context.State = new State카단소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카단소멸 : TriggerState {
            internal State카단소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 30);
            }

            public override void Execute() {
                if (context.MonsterInCombat(arg1: new[] {102})) {
                    context.ResetTimer(arg1: "1");
                }

                if (context.MonsterDead(arg1: new[] {102})) {
                    context.State = new State소멸대기(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State소멸대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소멸대기 : TriggerState {
            internal State소멸대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 10);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State트리거초기화(context);
                    return;
                }

                if (context.MonsterInCombat(arg1: new[] {102})) {
                    context.State = new State카단소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거초기화 : TriggerState {
            internal State트리거초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterInCombat(arg1: new[] {102})) {
                    context.State = new State카단소멸(context);
                    return;
                }

                if (!context.MonsterInCombat(arg1: new[] {102})) {
                    context.DestroyMonster(arg1: new[] {102});
                    context.State = new State반응대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}