namespace Maple2.Trigger._02000066_bf {
    public static class _anos {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {103})) {
                    return new StateNPCCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCCreation : TriggerState {
            internal StateNPCCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {98}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitTime : TriggerState {
            internal StateWaitTime(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new State말풍선Random(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State말풍선Random : TriggerState {
            internal State말풍선Random(ITriggerContext context) : base(context) { }

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
                context.SetConversation(arg1: 1, arg2: 98, arg3: "$02000066_BF__ANOS__0$", arg4: 3);
            }

            public override TriggerState Execute() {
                return new StateWaitTime(context);
            }

            public override void OnExit() { }
        }

        private class StateNPC대사02 : TriggerState {
            internal StateNPC대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 98, arg3: "$02000066_BF__ANOS__1$", arg4: 3);
            }

            public override TriggerState Execute() {
                return new StateWaitTime(context);
            }

            public override void OnExit() { }
        }

        private class StateNPC대사03 : TriggerState {
            internal StateNPC대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 98, arg3: "$02000066_BF__ANOS__2$", arg4: 3);
            }

            public override TriggerState Execute() {
                return new StateWaitTime(context);
            }

            public override void OnExit() { }
        }

        private class StateNPC대사04 : TriggerState {
            internal StateNPC대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 98, arg3: "$02000066_BF__ANOS__3$", arg4: 3);
            }

            public override TriggerState Execute() {
                return new StateWaitTime(context);
            }

            public override void OnExit() { }
        }
    }
}