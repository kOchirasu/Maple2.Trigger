using System;

namespace Maple2.Trigger._99999905 {
    public static class _pvp {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "30", arg2: 30, arg3: false);
                context.SetMesh(arg1: new int[] {3001, 3002, 3003, 4001, 4002, 4003}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 104, arg2: 1)) {
                    context.State = new StatePvP(context);
                    return;
                }

                if (context.TimeExpired(arg1: "30")) {
                    context.State = new StatePvP(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePvP : TriggerState {
            internal StatePvP(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1, arg3: false);
                context.SetPvpZone(arg1: 104, arg2: 3, arg3: 600, arg4: 90001002, arg5: 3,
                    arg6: new byte[] {1, 2, 101, 102, 103});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State어나운스0(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어나운스0 : TriggerState {
            internal State어나운스0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2, arg3: false);
                context.SetEventUI(arg1: 1, arg2: "$99999905__PVP__0$", arg3: new int[] {2000});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State어나운스1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어나운스1 : TriggerState {
            internal State어나운스1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "4", arg2: 4, arg3: false);
                context.SetEventUI(arg1: 1, arg2: "$99999905__PVP__1$", arg3: new int[] {4000});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new State어나운스2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어나운스2 : TriggerState {
            internal State어나운스2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2, arg3: false);
                context.SetEventUI(arg1: 1, arg2: "$99999905__PVP__2$", arg3: new int[] {2000});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State어나운스3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어나운스3 : TriggerState {
            internal State어나운스3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3, arg3: false);
                context.ShowCountUI(text: "$99999905__PVP__3$", stage: 1, count: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State문열림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문열림 : TriggerState {
            internal State문열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {105})) {
                    context.SetMesh(arg1: new int[] {3001, 3002, 3003, 4001, 4002, 4003}, arg2: false, arg3: 0, arg4: 0,
                        arg5: 0f);
                    context.State = new StatePvP종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePvP종료 : TriggerState {
            internal StatePvP종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.PvpZoneEnded(arg1: 104)) {
                    context.State = new State게임종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State게임종료 : TriggerState {
            internal State게임종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 10);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    // context.State = new State보상(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}