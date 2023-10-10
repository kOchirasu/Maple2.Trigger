namespace Maple2.Trigger._02000066_bf {
    public static class _alon {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "randomTalk") == 1) {
                    context.CreateMonster(spawnIds: new []{5001}, arg2: false);
                    return new StateWaitCombat(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitCombat : TriggerState {
            internal StateWaitCombat(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterInCombat(spawnIds: new []{5001})) {
                    return new State말풍선Random(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State말풍선Random : TriggerState {
            internal State말풍선Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 25)) {
                    return new StateNPCScript01(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new StateNPCScript02(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new StateNPCScript03(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new StateNPCScript04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCScript01 : TriggerState {
            internal StateNPCScript01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 5001, script: "$02000066_BF__ALON__0$", arg4: 3);
            }

            public override TriggerState? Execute() {
                return new StateWaitTime(context);
            }

            public override void OnExit() { }
        }

        private class StateNPCScript02 : TriggerState {
            internal StateNPCScript02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 5001, script: "$02000066_BF__ALON__1$", arg4: 3);
            }

            public override TriggerState? Execute() {
                return new StateWaitTime(context);
            }

            public override void OnExit() { }
        }

        private class StateNPCScript03 : TriggerState {
            internal StateNPCScript03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 5001, script: "$02000066_BF__ALON__2$", arg4: 3);
            }

            public override TriggerState? Execute() {
                return new StateWaitTime(context);
            }

            public override void OnExit() { }
        }

        private class StateNPCScript04 : TriggerState {
            internal StateNPCScript04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 5001, script: "$02000066_BF__ALON__3$", arg4: 3);
            }

            public override TriggerState? Execute() {
                return new StateWaitTime(context);
            }

            public override void OnExit() { }
        }

        private class StateWaitTime : TriggerState {
            internal StateWaitTime(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWaitCombat(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
