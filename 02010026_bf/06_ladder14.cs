namespace Maple2.Trigger._02010026_bf {
    public static class _06_ladder14 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000909}, state: 1);
                context.SetLadder(triggerId: 201, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 202, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 203, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 204, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 205, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 206, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 207, visible: false, animationEffect: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000909}, arg2: 0)) {
                    return new StateLadderCreation01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation01 : TriggerState {
            internal StateLadderCreation01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 201, visible: true, animationEffect: true, animationDelay: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StateLadderCreation02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation02 : TriggerState {
            internal StateLadderCreation02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 202, visible: true, animationEffect: true, animationDelay: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StateLadderCreation03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation03 : TriggerState {
            internal StateLadderCreation03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 203, visible: true, animationEffect: true, animationDelay: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StateLadderCreation04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation04 : TriggerState {
            internal StateLadderCreation04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 204, visible: true, animationEffect: true, animationDelay: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StateLadderCreation05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation05 : TriggerState {
            internal StateLadderCreation05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 205, visible: true, animationEffect: true, animationDelay: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StateLadderCreation06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation06 : TriggerState {
            internal StateLadderCreation06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 206, visible: true, animationEffect: true, animationDelay: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StateLadderCreation07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation07 : TriggerState {
            internal StateLadderCreation07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 207, visible: true, animationEffect: true, animationDelay: 5);
                context.SetTimer(timerId: "1", seconds: 10, clearAtZero: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
