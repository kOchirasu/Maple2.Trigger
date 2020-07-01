namespace Maple2.Trigger._02000066_bf {
    public static class _alon {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "randomTalk") == 1) {
                    context.CreateMonster(arg1: new[] {5001}, arg2: false);
                    return new State전투대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투대기 : TriggerState {
            internal State전투대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterInCombat(arg1: new[] {5001})) {
                    return new State말풍선랜덤(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State말풍선랜덤 : TriggerState {
            internal State말풍선랜덤(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 25f)) {
                    return new StateNPC대사01(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StateNPC대사02(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StateNPC대사03(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StateNPC대사04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC대사01 : TriggerState {
            internal StateNPC대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 5001, arg3: "$02000066_BF__ALON__0$", arg4: 3);
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }

        private class StateNPC대사02 : TriggerState {
            internal StateNPC대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 5001, arg3: "$02000066_BF__ALON__1$", arg4: 3);
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }

        private class StateNPC대사03 : TriggerState {
            internal StateNPC대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 5001, arg3: "$02000066_BF__ALON__2$", arg4: 3);
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }

        private class StateNPC대사04 : TriggerState {
            internal StateNPC대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 5001, arg3: "$02000066_BF__ALON__3$", arg4: 3);
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }

        private class State대기시간 : TriggerState {
            internal State대기시간(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new State전투대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}