namespace Maple2.Trigger._02000014_ad {
    public static class _01_ladder {
        public class StateUserDetection : TriggerState {
            internal StateUserDetection(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000066}, state: 1);
                context.SetEffect(triggerIds: new []{201, 202, 211, 212, 221, 222, 231, 232, 241, 242}, visible: false);
                context.SetLadder(triggerId: 101, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 102, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 111, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 112, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 121, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 122, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 131, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 132, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 141, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 142, visible: false, animationEffect: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000066}, arg2: 0)) {
                    return new StateLadderCreation101(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation101 : TriggerState {
            internal StateLadderCreation101(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{201, 202}, visible: true);
                context.SetLadder(triggerId: 101, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 102, visible: true, animationEffect: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateLadderCreation102(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation102 : TriggerState {
            internal StateLadderCreation102(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{211, 212}, visible: true);
                context.SetLadder(triggerId: 111, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 112, visible: true, animationEffect: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateLadderCreation111(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation111 : TriggerState {
            internal StateLadderCreation111(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{221, 222}, visible: true);
                context.SetLadder(triggerId: 121, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 122, visible: true, animationEffect: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateLadderCreation112(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation112 : TriggerState {
            internal StateLadderCreation112(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{231, 232}, visible: true);
                context.SetLadder(triggerId: 131, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 132, visible: true, animationEffect: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateLadderCreation121(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation121 : TriggerState {
            internal StateLadderCreation121(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{241, 242}, visible: true);
                context.SetLadder(triggerId: 141, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 142, visible: true, animationEffect: true);
                context.SetTimer(timerId: "1", seconds: 60);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateUserDetection(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation122 : TriggerState {
            internal StateLadderCreation122(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 122, visible: true, animationEffect: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateLadderCreation131(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation131 : TriggerState {
            internal StateLadderCreation131(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 131, visible: true, animationEffect: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateLadderCreation132(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation132 : TriggerState {
            internal StateLadderCreation132(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 132, visible: true, animationEffect: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateLadderCreation141(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation141 : TriggerState {
            internal StateLadderCreation141(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 141, visible: true, animationEffect: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateLadderCreation142(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation142 : TriggerState {
            internal StateLadderCreation142(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 142, visible: true, animationEffect: true);
                context.SetTimer(timerId: "1", seconds: 120);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateUserDetection(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
