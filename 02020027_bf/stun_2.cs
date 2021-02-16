namespace Maple2.Trigger._02020027_bf {
    public static class _stun_2 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {1001})) {
                    return new StateBattleStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart : TriggerState {
            internal StateBattleStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "summon_3_2") == 1) {
                    return new StateBuff(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff : TriggerState {
            internal StateBuff(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    return new StateBuff_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff_2 : TriggerState {
            internal StateBuff_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 301, script: "$02020027_BF__stun_1__0$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 302, script: "$02020027_BF__stun_1__1$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateBuff_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff_4 : TriggerState {
            internal StateBuff_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 303, script: "$02020027_BF__stun_1__2$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 304, script: "$02020027_BF__stun_1__3$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateBuff_5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff_5 : TriggerState {
            internal StateBuff_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 305, script: "$02020027_BF__stun_1__4$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 306, script: "$02020027_BF__stun_1__5$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                return new StateBuff_Remove(context);
            }

            public override void OnExit() { }
        }

        private class StateBuff_Remove : TriggerState {
            internal StateBuff_Remove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {201}, arg2: 62000002, arg3: 1, arg4: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}