using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000241_bf {
    public static class _timer {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {2001, 2002, 2003}, arg2: false);
                context.SetMesh(arg1: new[] {709, 710}, arg2: true);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {205})) {
                    return new State어나운스0(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어나운스0 : TriggerState {
            internal State어나운스0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "88", arg2: 5, arg3: false);
                context.SetEffect(arg1: new[] {2001}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$02000241_BF__TIMER__0$", arg3: 5000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "88")) {
                    return new State어나운스1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어나운스1 : TriggerState {
            internal State어나운스1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "88", arg2: 5, arg3: false);
                context.SetEffect(arg1: new[] {2002}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$02000241_BF__TIMER__1$", arg3: 5000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "88")) {
                    return new State초재기0(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State초재기0 : TriggerState {
            internal State초재기0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "98", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "98")) {
                    return new StateStart0(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart0 : TriggerState {
            internal StateStart0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetTimer(arg1: "98", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "98")) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetEventUI(arg1: 1, arg2: "$02000241_BF__TIMER__4$", arg3: 5000, arg4: "0");
                context.SetMesh(arg1: new[] {709, 710}, arg2: false);
                context.SetTimer(arg1: "44", arg2: 6);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "44")) {
                    return new State초재기2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State초재기2 : TriggerState {
            internal State초재기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "99")) {
                    return new State유저이동음성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저이동음성 : TriggerState {
            internal State유저이동음성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
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
                return new State끝(context);
            }

            public override void OnExit() { }
        }

        private class State끝 : TriggerState {
            internal State끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}