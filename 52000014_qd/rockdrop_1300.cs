namespace Maple2.Trigger._52000014_qd {
    public static class _rockdrop_1300 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{1300, 1302, 1304}, enabled: false);
                context.SetEffect(triggerIds: new []{1301, 1303, 1305}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new State낙하01시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State낙하01시작 : TriggerState {
            internal State낙하01시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{1301}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1200)) {
                    return new State낙하01완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State낙하01완료 : TriggerState {
            internal State낙하01완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{1300}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new State낙하02시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State낙하02시작 : TriggerState {
            internal State낙하02시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{1303}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1200)) {
                    return new State낙하02완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State낙하02완료 : TriggerState {
            internal State낙하02완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 2);
                context.SetSkill(triggerIds: new []{1302}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State낙하03시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State낙하03시작 : TriggerState {
            internal State낙하03시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{1305}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1200)) {
                    return new State낙하03완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State낙하03완료 : TriggerState {
            internal State낙하03완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "4", seconds: 1);
                context.SetSkill(triggerIds: new []{1304}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 2);
                context.SetSkill(triggerIds: new []{1300, 1302, 1304}, enabled: false);
                context.SetEffect(triggerIds: new []{1301, 1303, 1305}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State낙하01시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
