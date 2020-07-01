using System;
using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000241_bf {
    public static class _timer {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {2001}, arg2: false);
                context.SetEffect(arg1: new int[] {2002}, arg2: false);
                context.SetEffect(arg1: new int[] {2003}, arg2: false);
                context.SetMesh(arg1: new int[] {709, 710}, arg2: true);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 205, arg2: 1)) {
                    context.State =
                        new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {205})) {
                    context.State = new State어나운스0(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어나운스0 : TriggerState {
            internal State어나운스0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "88", arg2: 5, arg3: false);
                context.SetEffect(arg1: new int[] {2001}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$02000241_BF__TIMER__0$", arg3: new int[] {5000}, arg4: "0");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "88")) {
                    context.State = new State어나운스1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어나운스1 : TriggerState {
            internal State어나운스1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "88", arg2: 5, arg3: false);
                context.SetEffect(arg1: new int[] {2002}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$02000241_BF__TIMER__1$", arg3: new int[] {5000}, arg4: "0");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "88")) {
                    context.State = new State초재기0(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State초재기0 : TriggerState {
            internal State초재기0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "98", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "98")) {
                    context.State = new State시작0(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작0 : TriggerState {
            internal State시작0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetTimer(arg1: "98", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "98")) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetEventUI(arg1: 1, arg2: "$02000241_BF__TIMER__4$", arg3: new int[] {5000}, arg4: "0");
                context.SetMesh(arg1: new int[] {709, 710}, arg2: false);
                context.SetTimer(arg1: "44", arg2: 6);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "44")) {
                    context.State = new State초재기2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State초재기2 : TriggerState {
            internal State초재기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.TimeExpired(arg1: "99")) {
                    context.State = new State유저이동음성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저이동음성 : TriggerState {
            internal State유저이동음성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State유저이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저이동 : TriggerState {
            internal State유저이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (true) {
                    context.State = new State끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State끝 : TriggerState {
            internal State끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}