namespace Maple2.Trigger._02000090_bf {
    public static class _apply_01 {
        public class StateWait0 : TriggerState {
            internal StateWait0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{1000, 1001}, visible: false);
                context.SetInteractObject(interactIds: new []{10000360}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 33)) {
                    return new StateWait1(context);
                }

                if (context.RandomCondition(rate: 33)) {
                    return new StateWait2(context);
                }

                if (context.RandomCondition(rate: 34)) {
                    return new StateWait3(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000360}, arg2: 0)) {
                    return new State이펙트1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait1 : TriggerState {
            internal StateWait1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 3);
                context.SetEffect(triggerIds: new []{1000}, visible: true);
                context.SetInteractObject(interactIds: new []{10000360}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateWait0(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000360}, arg2: 0)) {
                    return new State이펙트1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait2 : TriggerState {
            internal StateWait2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 7);
                context.SetEffect(triggerIds: new []{1000, 1001}, visible: true);
                context.SetInteractObject(interactIds: new []{10000360}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new StateWait0(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000360}, arg2: 0)) {
                    return new State이펙트1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait3 : TriggerState {
            internal StateWait3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 1);
                context.SetEffect(triggerIds: new []{1000, 1001}, visible: true);
                context.SetInteractObject(interactIds: new []{10000360}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateWait0(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000360}, arg2: 0)) {
                    return new State이펙트1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이펙트1 : TriggerState {
            internal State이펙트1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "10", seconds: 1);
                context.SetEffect(triggerIds: new []{1000, 1001, 2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007}, visible: true);
                context.SetEffect(triggerIds: new []{1000, 1001}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "10")) {
                    return new StateTriggerReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTriggerReset : TriggerState {
            internal StateTriggerReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{1000, 1001, 2000, 2001, 2002, 2003, 2004}, visible: false);
                context.SetTimer(timerId: "20", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "20")) {
                    return new StateWait0(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
