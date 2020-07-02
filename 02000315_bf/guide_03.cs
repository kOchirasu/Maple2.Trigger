namespace Maple2.Trigger._02000315_bf {
    public static class _guide_03 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: false);
                context.SetUserValue(key: "CameraWalkEnd", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateLoadingDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay01 : TriggerState {
            internal StateLoadingDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "CameraWalkEnd") == 1) {
                    return new StateLoadingDelay02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay02 : TriggerState {
            internal StateLoadingDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stBattleGuide(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stBattleGuide : TriggerState {
            internal State1stBattleGuide(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.ShowGuideSummary(entityId: 20031501, textId: 20031501, duration: 8000);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {502})) {
                    return new State1stBridgeGuide(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stBridgeGuide : TriggerState {
            internal State1stBridgeGuide(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.ShowGuideSummary(entityId: 20031502, textId: 20031502, duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {503})) {
                    return new State2ndBattleGuide(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndBattleGuide : TriggerState {
            internal State2ndBattleGuide(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.ShowGuideSummary(entityId: 20031501, textId: 20031501, duration: 8000);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {505})) {
                    return new State2ndBridgeGuide(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndBridgeGuide : TriggerState {
            internal State2ndBridgeGuide(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.ShowGuideSummary(entityId: 20031502, textId: 20031502, duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {506})) {
                    return new State3rdBattleGuide(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdBattleGuide : TriggerState {
            internal State3rdBattleGuide(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.ShowGuideSummary(entityId: 20031501, textId: 20031501, duration: 8000);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {508})) {
                    return new State3rdBridgeGuide(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdBridgeGuide : TriggerState {
            internal State3rdBridgeGuide(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.ShowGuideSummary(entityId: 20031502, textId: 20031502, duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {402})) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20031502);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}