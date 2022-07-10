namespace Maple2.Trigger._64000001_gd {
    public static class _enter {
        public class StatePvP : TriggerState {
            internal StatePvP(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{701, 702}, visible: false);
            }

            public override TriggerState? Execute() {
                context.SetPvpZone(boxId: 101, arg2: 30, duration: 120, additionalEffectId: 90001002, arg5: 4, boxIds: new []{102, 103, 112, 113, 10, 11, 1, 3});
                    return new StatePvP종료(context);
            }

            public override void OnExit() { }
        }

        private class StatePvP종료 : TriggerState {
            internal StatePvP종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.PvpZoneEnded(boxId: 101)) {
                    return new State게임종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임종료 : TriggerState {
            internal State게임종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "999", seconds: 4, clearAtZero: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "999")) {
                    return new State완료(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "999");
            }
        }

        private class State완료 : TriggerState {
            internal State완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 60);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    context.MoveUser(mapId: 0, portalId: 0);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
