namespace Maple2.Trigger._02020130_bf {
    public static class _skillbreakwarningmessage {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 601) == 1) {
                    return new State신호받기Waiting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State신호받기Waiting : TriggerState {
            internal State신호받기Waiting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "WarningMessage", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "WarningMessage") == 1) {
                    return new StateSkill브레이크DisplayGuide(context);
                }

                if (context.GetUserValue(key: "DeathIshuraRbladerDark") == 1) {
                    return new StateIshura죽음알림(context);
                }

                if (context.GetUserValue(key: "DeathRenduebianRbladerDark") == 1) {
                    return new State렌듀비앙죽음알림(context);
                }

                if (context.GetUserValue(key: "DeathYuperiaRbladerDark") == 1) {
                    return new State유페리아죽음알림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill브레이크DisplayGuide : TriggerState {
            internal StateSkill브레이크DisplayGuide(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20051001, textId: 20051001);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State천천히다시처음으로돌아가기직전(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20051001);
            }
        }

        private class StateIshura죽음알림 : TriggerState {
            internal StateIshura죽음알림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20051002, textId: 20051002);
                context.SetUserValue(key: "DeathIshuraRbladerDark", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3200)) {
                    return new State신호받기Waiting(context);
                }

                if (context.GetUserValue(key: "DeathRenduebianRbladerDark") == 1) {
                    return new State렌듀비앙죽음알림(context);
                }

                if (context.GetUserValue(key: "DeathYuperiaRbladerDark") == 1) {
                    return new State유페리아죽음알림(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20051002);
            }
        }

        private class State렌듀비앙죽음알림 : TriggerState {
            internal State렌듀비앙죽음알림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20051003, textId: 20051003);
                context.SetUserValue(key: "DeathRenduebianRbladerDark", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3200)) {
                    return new State신호받기Waiting(context);
                }

                if (context.GetUserValue(key: "DeathIshuraRbladerDark") == 1) {
                    return new StateIshura죽음알림(context);
                }

                if (context.GetUserValue(key: "DeathYuperiaRbladerDark") == 1) {
                    return new State유페리아죽음알림(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20051003);
            }
        }

        private class State유페리아죽음알림 : TriggerState {
            internal State유페리아죽음알림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20051004, textId: 20051004);
                context.SetUserValue(key: "DeathYuperiaRbladerDark", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3200)) {
                    return new State신호받기Waiting(context);
                }

                if (context.GetUserValue(key: "DeathIshuraRbladerDark") == 1) {
                    return new StateIshura죽음알림(context);
                }

                if (context.GetUserValue(key: "DeathRenduebianRbladerDark") == 1) {
                    return new State렌듀비앙죽음알림(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20051004);
            }
        }

        private class State천천히다시처음으로돌아가기직전 : TriggerState {
            internal State천천히다시처음으로돌아가기직전(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new State신호받기Waiting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
