namespace Maple2.Trigger._65010009_bd {
    public static class _camera {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    return new StatePvP종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePvP종료 : TriggerState {
            internal StatePvP종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.PvpZoneEnded(boxId: 101)) {
                    return new State완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State완료 : TriggerState {
            internal State완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    context.MoveUser(mapId: 0, portalId: 0);
                    return new StateEnd(context);
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
