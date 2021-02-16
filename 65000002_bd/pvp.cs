namespace Maple2.Trigger._65000002_bd {
    public static class _pvp {
        public class State시간표확인 : TriggerState {
            internal State시간표확인(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetTimer(id: "60", arg2: 60, arg3: false, arg4: true);
                context.SetEffect(arg1: new[] {601, 602}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 102) == 10) {
                    return new State어나운스0(context);
                }

                if (context.TimeExpired(arg1: "60")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "60");
            }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 102) == 2) {
                    return new State어나운스0(context);
                }

                if (context.GetUserCount(boxId: 102) != 2) {
                    return new State비김(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어나운스0 : TriggerState {
            internal State어나운스0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "6", arg2: 6, arg3: false);
                context.PlaySystemSoundInBox(arg2: "BD_PVP_00");
                context.SetEventUI(arg1: 1, script: "$65000002_BD__PVP__0$", arg3: 6000);
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
                context.SetTimer(id: "6", arg2: 6, arg3: false);
                context.PlaySystemSoundInBox(arg2: "BD_PVP_01");
                context.SetEventUI(arg1: 1, script: "$65000002_BD__PVP__1$", arg3: 6000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    return new State어나운스2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어나운스2 : TriggerState {
            internal State어나운스2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "6", arg2: 6, arg3: false);
                context.PlaySystemSoundInBox(arg2: "BD_PVP_02");
                context.SetEventUI(arg1: 1, script: "$65000002_BD__PVP__2$", arg3: 6000, arg4: "101");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    return new State어나운스3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어나운스3 : TriggerState {
            internal State어나운스3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "3", arg2: 3, arg3: false);
                context.PlaySystemSoundInBox(arg2: "BD_PVP_03");
                context.SetEventUI(arg1: 1, script: "$65000002_BD__PVP__3$", arg3: 3000);
                context.SetEffect(arg1: new[] {601}, arg2: true);
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
                context.SetAchievement(arg1: 101, arg2: "trigger", arg3: "dailyquest_start");
                context.GiveGuildExp(boxId: false, type: 2);
                context.AddBuff(arg1: new[] {101}, arg2: 70000088, arg3: 1, arg4: false, arg5: false);
                context.AddBuff(arg1: new[] {101}, arg2: 70000089, arg3: 1, arg4: false, arg5: false);
                context.SetTimer(id: "1", arg2: 1, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.SetPvpZone(arg1: 101, arg2: 5, arg3: 300, arg4: 90001002, arg5: 2);
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
                if (context.PvpZoneEnded(arg1: 101)) {
                    return new State경기종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State경기종료 : TriggerState {
            internal State경기종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "4", arg2: 4, arg3: false);
                context.PlaySystemSoundInBox(arg2: "BD_PVP_04");
                context.SetEventUI(arg1: 1, script: "$65000002_BD__PVP__4$", arg3: 3000, arg4: "101");
                context.SetEffect(arg1: new[] {602}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    return new State완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비김 : TriggerState {
            internal State비김(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "3", arg2: 3, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.SetEventUI(arg1: 5, script: "$65000002_BD__PVP__5$", arg3: 3000, arg4: "0");
                    return new State완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State완료 : TriggerState {
            internal State완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 5);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.MoveUser(arg1: 0, arg2: 0);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}