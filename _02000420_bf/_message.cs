namespace Maple2.Trigger._02000420_bf {
    public static class _message {
        public class StateBattleStart : TriggerState {
            internal StateBattleStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Message") == 1) {
                    return new StateDisplayGuide01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDisplayGuide01 : TriggerState {
            internal StateDisplayGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20042001, textId: 20042001);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateDisplayGuide02대기(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20042001);
            }
        }

        private class StateDisplayGuide02대기 : TriggerState {
            internal StateDisplayGuide02대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Message") == 2) {
                    return new StateDisplayGuide02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDisplayGuide02 : TriggerState {
            internal StateDisplayGuide02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20042002, textId: 20042002);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateDisplayGuide03대기(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20042002);
            }
        }

        private class StateDisplayGuide03대기 : TriggerState {
            internal StateDisplayGuide03대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Message") == 3) {
                    return new StateDisplayGuide03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDisplayGuide03 : TriggerState {
            internal StateDisplayGuide03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20042003, textId: 20042003);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20042003);
            }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}