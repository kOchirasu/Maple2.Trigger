using System;

namespace Maple2.Trigger._65000002_bd {
    public static class _pvp {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시간표확인(context);

        private class State시간표확인 : TriggerState {
            internal State시간표확인(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetTimer(arg1: "60", arg2: 60, arg3: false, arg4: true);
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.SetEffect(arg1: new int[] {602}, arg2: false);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 102, arg2: 10)) {
                    context.State = new State어나운스0(context);
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

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CountUsers(arg1: 102, arg2: 2)) {
                    context.State = new State어나운스0(context);
                    return;
                }

                if (!context.CountUsers(arg1: 102, arg2: 2)) {
                    context.State = new State비김(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어나운스0 : TriggerState {
            internal State어나운스0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "6", arg2: 6, arg3: false);
                context.PlaySystemSoundInBox(arg2: "BD_PVP_00");
                context.SetEventUI(arg1: 1, arg2: "$65000002_BD__PVP__0$", arg3: new int[] {6000});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    context.State = new State어나운스1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어나운스1 : TriggerState {
            internal State어나운스1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "6", arg2: 6, arg3: false);
                context.PlaySystemSoundInBox(arg2: "BD_PVP_01");
                context.SetEventUI(arg1: 1, arg2: "$65000002_BD__PVP__1$", arg3: new int[] {6000});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    context.State = new State어나운스2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어나운스2 : TriggerState {
            internal State어나운스2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "6", arg2: 6, arg3: false);
                context.PlaySystemSoundInBox(arg2: "BD_PVP_02");
                context.SetEventUI(arg1: 1, arg2: "$65000002_BD__PVP__2$", arg3: new int[] {6000}, arg4: "101");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "6")) {
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
                context.PlaySystemSoundInBox(arg2: "BD_PVP_03");
                context.SetEventUI(arg1: 1, arg2: "$65000002_BD__PVP__3$", arg3: new int[] {3000});
                context.SetEffect(arg1: new int[] {601}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new StatePvP(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePvP : TriggerState {
            internal StatePvP(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 101, arg2: "trigger", arg3: "dailyquest_start");
                context.GiveGuildExp(boxID: false, type: 2);
                context.AddBuff(arg1: new int[] {101}, arg2: 70000088, arg3: 1, arg4: false, arg5: false);
                context.AddBuff(arg1: new int[] {101}, arg2: 70000089, arg3: 1, arg4: false, arg5: false);
                context.SetTimer(arg1: "1", arg2: 1, arg3: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.SetPvpZone(arg1: 101, arg2: 5, arg3: 300, arg4: 90001002, arg5: 2);
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
                if (context.PvpZoneEnded(arg1: 101)) {
                    context.State = new State경기종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State경기종료 : TriggerState {
            internal State경기종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "4", arg2: 4, arg3: false);
                context.PlaySystemSoundInBox(arg2: "BD_PVP_04");
                context.SetEventUI(arg1: 1, arg2: "$65000002_BD__PVP__4$", arg3: new int[] {3000}, arg4: "101");
                context.SetEffect(arg1: new int[] {602}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new State완료(context);
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