namespace Maple2.Trigger._02000300_bf {
    public static class _mobspawn {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterInCombat(spawnIds: new []{1099})) {
                    return new StateRandomCreation조건(context);
                }

                if (context.MonsterDead(spawnIds: new []{1099})) {
                    return new State소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandomCreation조건 : TriggerState {
            internal StateRandomCreation조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 25f)) {
                    return new State40초(context);
                }

                if (context.RandomCondition(rate: 25f)) {
                    return new State35초(context);
                }

                if (context.RandomCondition(rate: 25f)) {
                    return new State30초(context);
                }

                if (context.RandomCondition(rate: 25f)) {
                    return new State45초(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State40초 : TriggerState {
            internal State40초(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "45", seconds: 45);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "45")) {
                    return new StateCreation(context);
                }

                if (context.MonsterDead(spawnIds: new []{1099})) {
                    return new State소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State35초 : TriggerState {
            internal State35초(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "50", seconds: 50);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "50")) {
                    return new StateCreation(context);
                }

                if (context.MonsterDead(spawnIds: new []{1099})) {
                    return new State소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State30초 : TriggerState {
            internal State30초(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "55", seconds: 55);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "55")) {
                    return new StateCreation(context);
                }

                if (context.MonsterDead(spawnIds: new []{1099})) {
                    return new State소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State45초 : TriggerState {
            internal State45초(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "60", seconds: 60);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "60")) {
                    return new StateCreation(context);
                }

                if (context.MonsterDead(spawnIds: new []{1099})) {
                    return new State소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation : TriggerState {
            internal StateCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 1099, script: "$02000300_BF__MOBSPAWN__0$", arg4: 2);
                context.SetConversation(type: 1, spawnId: 1001, script: "$02000300_BF__MOBSPAWN__1$", arg4: 3);
                context.CreateMonster(spawnIds: new []{1097, 1098}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1097, 1098})) {
                    return new StateRandomCreation조건(context);
                }

                if (context.MonsterDead(spawnIds: new []{1099})) {
                    return new State소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소멸 : TriggerState {
            internal State소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1098, 1097});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
