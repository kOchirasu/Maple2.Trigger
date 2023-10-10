using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000241_bf {
    public static class _timer {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{2001, 2002, 2003}, visible: false);
                context.SetMesh(triggerIds: new []{709, 710}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 205) == 1) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{205})) {
                    return new State어나운스0(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어나운스0 : TriggerState {
            internal State어나운스0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "88", seconds: 5, autoRemove: false);
                context.SetEffect(triggerIds: new []{2001}, visible: true);
                context.SetEventUI(arg1: 1, script: "$02000241_BF__TIMER__0$", duration: 5000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "88")) {
                    return new State어나운스1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어나운스1 : TriggerState {
            internal State어나운스1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "88", seconds: 5, autoRemove: false);
                context.SetEffect(triggerIds: new []{2002}, visible: true);
                context.SetEventUI(arg1: 1, script: "$02000241_BF__TIMER__1$", duration: 5000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "88")) {
                    return new State초재기0(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State초재기0 : TriggerState {
            internal State초재기0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new StateStart0(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart0 : TriggerState {
            internal StateStart0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetTimer(timerId: "98", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetEventUI(arg1: 1, script: "$02000241_BF__TIMER__4$", duration: 5000, boxId: 0);
                context.SetMesh(triggerIds: new []{709, 710}, visible: false);
                context.SetTimer(timerId: "44", seconds: 6);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "44")) {
                    return new State초재기2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State초재기2 : TriggerState {
            internal State초재기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State유저이동음성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저이동음성 : TriggerState {
            internal State유저이동음성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
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
                return new State끝(context);
            }

            public override void OnExit() { }
        }

        private class State끝 : TriggerState {
            internal State끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
