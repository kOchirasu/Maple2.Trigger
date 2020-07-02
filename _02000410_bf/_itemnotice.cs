namespace Maple2.Trigger._02000410_bf {
    public static class _itemnotice {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 750) == 1) {
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
                if (context.GetUserValue(key: "ItemNotice01") == 1) {
                    return new State필수아이템01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State필수아이템01 : TriggerState {
            internal State필수아이템01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20041008, textId: 20041008);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State다음대기(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20041008);
            }
        }

        private class State다음대기 : TriggerState {
            internal State다음대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "ItemNotice02") == 1) {
                    return new State필수아이템02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State필수아이템02 : TriggerState {
            internal State필수아이템02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20041009, textId: 20041009);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20041009);
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