namespace Maple2.Trigger._02000047_bf {
    public static class _02_mob {
        public class State반응대기 : TriggerState {
            internal State반응대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000078}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000078}, arg2: 0)) {
                    return new State몬스터리젠(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몬스터리젠 : TriggerState {
            internal State몬스터리젠(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {102});
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State우레우스대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State우레우스대사 : TriggerState {
            internal State우레우스대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$02000047_BF__02_MOB__0$", arg4: 3);
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$02000047_BF__02_MOB__1$", arg4: 3);
                context.SetTimer(arg1: "1", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State몬스터와전투(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몬스터와전투 : TriggerState {
            internal State몬스터와전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {102})) {
                    return new State트리거초기화(context);
                }

                if (!context.MonsterInCombat(arg1: new[] {102})) {
                    return new State우레우스소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State우레우스소멸 : TriggerState {
            internal State우레우스소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 30);
            }

            public override TriggerState Execute() {
                if (context.MonsterInCombat(arg1: new[] {102})) {
                    context.ResetTimer(arg1: "1");
                }

                if (context.MonsterDead(arg1: new[] {102})) {
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
                context.SetTimer(arg1: "1", arg2: 10);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State트리거초기화(context);
                }

                if (context.MonsterInCombat(arg1: new[] {102})) {
                    return new State우레우스소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리거초기화 : TriggerState {
            internal State트리거초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterInCombat(arg1: new[] {102})) {
                    return new State우레우스소멸(context);
                }

                if (!context.MonsterInCombat(arg1: new[] {102})) {
                    context.DestroyMonster(arg1: new[] {102});
                    return new State반응대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}