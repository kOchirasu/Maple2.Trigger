namespace Maple2.Trigger._80000011_bonus {
    public static class _mainprocess_christmastree {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    return new State이벤트Waiting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이벤트Waiting : TriggerState {
            internal State이벤트Waiting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 201, arg2: false, arg3: false);
                context.SetLadder(arg1: 202, arg2: false, arg3: false);
                context.SetLadder(arg1: 203, arg2: false, arg3: false);
                context.SetLadder(arg1: 204, arg2: false, arg3: false);
            }

            public override TriggerState Execute() {
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
                context.SetLadder(arg1: 201, arg2: true, arg3: true);
                context.SetLadder(arg1: 202, arg2: true, arg3: true);
                context.SetLadder(arg1: 203, arg2: true, arg3: true);
                context.SetLadder(arg1: 204, arg2: true, arg3: true);
                context.SetTimer(arg1: "2", arg2: 30, arg3: true, arg4: true, arg5: -90);
                context.ShowGuideSummary(entityId: 26300385, textId: 26300385);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State유저이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저이동 : TriggerState {
            internal State유저이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1)) {
                    context.MoveUser(arg1: 0, arg2: 0);
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

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}