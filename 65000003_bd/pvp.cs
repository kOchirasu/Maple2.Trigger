namespace Maple2.Trigger._65000003_bd {
    public static class _pvp {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "60", seconds: 60, autoRemove: false, display: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 104) == 20) {
                    return new StatePvP(context);
                }

                if (context.TimeExpired(timerId: "60")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "60");
            }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(timerId: "1");
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 104) == 2) {
                    return new StatePvP(context);
                }

                if (context.GetUserCount(boxId: 104) != 2) {
                    return new State비김(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePvP : TriggerState {
            internal StatePvP(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1, autoRemove: false);
                context.SetAchievement(triggerId: 104, type: "trigger", code: "dailyquest_start");
                context.GiveGuildExp(boxId: 0, type: 2);
                context.SetPvpZone(boxId: 104, arg2: 3, duration: 600, additionalEffectId: 90001002, arg5: 3, boxIds: new []{1, 2, 101, 102, 103});
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State문열림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열림 : TriggerState {
            internal State문열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{105})) {
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
                if (context.PvpZoneEnded(boxId: 104)) {
                    return new State게임종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임종료 : TriggerState {
            internal State게임종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "10", seconds: 10);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "10")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비김 : TriggerState {
            internal State비김(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3, autoRemove: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    context.SetEventUI(arg1: 5, script: "$65000002_BD__PVP__5$", duration: 3000, boxId: 0);
                    return new State완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State완료 : TriggerState {
            internal State완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
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
