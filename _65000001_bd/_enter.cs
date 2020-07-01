namespace Maple2.Trigger._65000001_bd {
    public static class _enter {
        public class State시간표확인 : TriggerState {
            internal State시간표확인(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetTimer(arg1: "60", arg2: 60, arg3: false, arg4: true);
                context.SetEffect(arg1: new[] {601}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 101) == 10) {
                    return new State어나운스0(context);
                }

                if (context.TimeExpired(arg1: "60")) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "60");
            }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 101) == 2) {
                    return new State어나운스0(context);
                }

                if (context.GetUserCount(boxId: 101) != 2) {
                    return new State비김(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어나운스0 : TriggerState {
            internal State어나운스0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "6", arg2: 6, arg3: false);
                context.PlaySystemSoundInBox(arg2: "BD_Enter_00");
                context.SetEventUI(arg1: 1, arg2: "$65000001_BD__ENTER__0$", arg3: 6000, arg4: "101");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    return new State어나운스1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어나운스1 : TriggerState {
            internal State어나운스1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3, arg3: false);
                context.PlaySystemSoundInBox(arg2: "BD_Enter_01");
                context.SetEventUI(arg1: 1, arg2: "$65000001_BD__ENTER__1$", arg3: 3000, arg4: "101");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StatePvP(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePvP : TriggerState {
            internal StatePvP(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.SetAchievement(arg1: 105, arg2: "trigger", arg3: "dailyquest_start");
                    context.GiveGuildExp(boxId: false, type: 2);
                    context.SetPvpZone(arg1: 102, arg2: 1, arg3: 120, arg4: 90001002, arg5: 1);
                    return new StatePvP종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePvP종료 : TriggerState {
            internal StatePvP종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.PvpZoneEnded(arg1: 102)) {
                    return new State게임종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비김 : TriggerState {
            internal State비김(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.SetEventUI(arg1: 5, arg2: "$65000001_BD__ENTER__2$", arg3: 3000, arg4: "0");
                    return new State완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임종료 : TriggerState {
            internal State게임종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "6", arg2: 6);
                context.SetEventUI(arg1: 0, arg2: "0,0");
                context.SetEventUI(arg1: 3, arg2: "$65000001_BD__ENTER__3$", arg3: 5000, arg4: "102");
                context.AddBuff(arg1: new[] {102}, arg2: 70000063, arg3: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    return new State보상(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보상 : TriggerState {
            internal State보상(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "15", arg2: 15);
                context.PlaySystemSoundInBox(arg1: new[] {102}, arg2: "BD_Enter_04");
                context.PlaySystemSoundInBox(arg1: new[] {103}, arg2: "BD_Enter_05");
                context.SetEventUI(arg1: 3, arg2: "$65000001_BD__ENTER__4$", arg3: 5000, arg4: "102");
                context.SetEventUI(arg1: 6, arg2: "$65000001_BD__ENTER__5$", arg3: 5000, arg4: "!102");
                context.CreateItem(arg1: new[] {9001, 9002, 9003});
                context.CreateItem(arg1: new[] {9004}, arg2: 104);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "15")) {
                    return new State완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State완료 : TriggerState {
            internal State완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.MoveUser(arg1: 0, arg2: 0);
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}