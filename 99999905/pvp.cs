namespace Maple2.Trigger._99999905 {
    public static class _pvp {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "30", seconds: 30, autoRemove: false);
                context.SetMesh(triggerIds: new []{3001, 3002, 3003, 4001, 4002, 4003}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 104) == 1) {
                    return new StatePvP(context);
                }

                if (context.TimeExpired(timerId: "30")) {
                    return new StatePvP(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePvP : TriggerState {
            internal StatePvP(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1, autoRemove: false);
                context.SetPvpZone(boxId: 104, arg2: 3, duration: 600, additionalEffectId: 90001002, arg5: 3, boxIds: new []{1, 2, 101, 102, 103});
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State어나운스0(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어나운스0 : TriggerState {
            internal State어나운스0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 2, autoRemove: false);
                context.SetEventUI(arg1: 1, script: "$99999905__PVP__0$", duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State어나운스1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어나운스1 : TriggerState {
            internal State어나운스1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "4", seconds: 4, autoRemove: false);
                context.SetEventUI(arg1: 1, script: "$99999905__PVP__1$", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    return new State어나운스2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어나운스2 : TriggerState {
            internal State어나운스2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 2, autoRemove: false);
                context.SetEventUI(arg1: 1, script: "$99999905__PVP__2$", duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State어나운스3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어나운스3 : TriggerState {
            internal State어나운스3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3, autoRemove: false);
                context.ShowCountUI(text: "$99999905__PVP__3$", stage: 1, count: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
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
                    context.SetMesh(triggerIds: new []{3001, 3002, 3003, 4001, 4002, 4003}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
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
                    // return new State보상(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
