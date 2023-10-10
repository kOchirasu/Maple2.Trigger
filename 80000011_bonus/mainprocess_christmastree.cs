namespace Maple2.Trigger._80000011_bonus {
    public static class _mainprocess_christmastree {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    return new State이벤트Waiting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이벤트Waiting : TriggerState {
            internal State이벤트Waiting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 201, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 202, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 203, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 204, visible: false, animationEffect: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    return new StateLadder나타남(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadder나타남 : TriggerState {
            internal StateLadder나타남(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 201, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 202, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 203, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 204, visible: true, animationEffect: true);
                context.SetTimer(timerId: "2", seconds: 30, autoRemove: true, display: true, vOffset: -90);
                context.ShowGuideSummary(entityId: 26300385, textId: 26300385);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State유저이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저이동 : TriggerState {
            internal State유저이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1)) {
                    context.MoveUser(mapId: 0, portalId: 0);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 26300385);
            }
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
