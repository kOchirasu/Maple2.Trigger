namespace Maple2.Trigger._65010003_bd {
    public static class _camera {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 101) == 2) {
                    return new StatePvP시작(context);
                }

                if (context.PvpZoneEnded(boxId: 101)) {
                    return new State완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePvP시작 : TriggerState {
            internal StatePvP시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{101}, skillId: 70000088, level: 1, arg4: false, arg5: false);
                context.AddBuff(boxIds: new []{101}, skillId: 70000089, level: 1, arg4: false, arg5: false);
            }

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
