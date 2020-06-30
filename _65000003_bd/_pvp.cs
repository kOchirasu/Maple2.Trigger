using System;

namespace Maple2.Trigger._65000003_bd {
    public static class _pvp {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "60", arg2: 60, arg3: false, arg4: true);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 104, arg2: 20)) {
                    context.State = new StatePvP(context);
                    return;
                }

                if (context.TimeExpired(arg1: "60")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "60");
            }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(arg1: "1");
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 104, arg2: 2)) {
                    context.State = new StatePvP(context);
                    return;
                }

                if (!context.CountUsers(arg1: 104, arg2: 2)) {
                    context.State = new State비김(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePvP : TriggerState {
            internal StatePvP(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1, arg3: false);
                context.SetAchievement(arg1: 104, arg2: "trigger", arg3: "dailyquest_start");
                context.GiveGuildExp(boxID: false, type: 2);
                context.SetPvpZone(arg1: 104, arg2: 3, arg3: 600, arg4: 90001002, arg5: 3,
                    arg6: new byte[] {1, 2, 101, 102, 103});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
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
                if (context.UserDetected(arg1: "105")) {
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
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State비김 : TriggerState {
            internal State비김(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3, arg3: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.SetEventUI(arg1: 5, arg2: "$65000002_BD__PVP__5$", arg3: new int[] {3000}, arg4: "0");
                    context.State = new State완료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State완료 : TriggerState {
            internal State완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.MoveUser(arg1: 0, arg2: 0);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}