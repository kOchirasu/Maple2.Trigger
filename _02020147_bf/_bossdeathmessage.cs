namespace Maple2.Trigger._02020147_bf {
    public static class _bossdeathmessage {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 601) == 1) {
                    return new State변수초기화(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State변수초기화 : TriggerState {
            internal State변수초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "DeathIshuraRbladerDark", value: 0);
                context.SetUserValue(key: "DeathRenduebianRbladerDark", value: 0);
                context.SetUserValue(key: "DeathYuperiaRbladerDark", value: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State신호받기대기중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State신호받기대기중 : TriggerState {
            internal State신호받기대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "DeathIshuraRbladerDark") == 1) {
                    return new State이슈라죽음알림(context);
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

        private class State이슈라죽음알림 : TriggerState {
            internal State이슈라죽음알림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20051002, textId: 20051002);
                context.SetUserValue(key: "DeathIshuraRbladerDark", value: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3200)) {
                    return new State신호받기대기중(context);
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

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3200)) {
                    return new State신호받기대기중(context);
                }

                if (context.GetUserValue(key: "DeathIshuraRbladerDark") == 1) {
                    return new State이슈라죽음알림(context);
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

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3200)) {
                    return new State신호받기대기중(context);
                }

                if (context.GetUserValue(key: "DeathIshuraRbladerDark") == 1) {
                    return new State이슈라죽음알림(context);
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
    }
}