namespace Maple2.Trigger._65000002_bd {
    public static class _pvp {
        public class State시간표확인 : TriggerState {
            internal State시간표확인(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetTimer(timerId: "60", seconds: 60, autoRemove: false, display: true);
                context.SetEffect(triggerIds: new []{601, 602}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 102) == 10) {
                    return new State어나운스0(context);
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

            public override void OnEnter() { }

            public override TriggerState? Execute() {
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
                context.SetTimer(timerId: "6", seconds: 6, autoRemove: false);
                context.PlaySystemSoundInBox(sound: "BD_PVP_00");
                context.SetEventUI(arg1: 1, script: "$65000002_BD__PVP__0$", duration: 6000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "6")) {
                    return new State어나운스1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어나운스1 : TriggerState {
            internal State어나운스1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "6", seconds: 6, autoRemove: false);
                context.PlaySystemSoundInBox(sound: "BD_PVP_01");
                context.SetEventUI(arg1: 1, script: "$65000002_BD__PVP__1$", duration: 6000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "6")) {
                    return new State어나운스2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어나운스2 : TriggerState {
            internal State어나운스2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "6", seconds: 6, autoRemove: false);
                context.PlaySystemSoundInBox(sound: "BD_PVP_02");
                context.SetEventUI(arg1: 1, script: "$65000002_BD__PVP__2$", duration: 6000, boxId: 101);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "6")) {
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
                context.PlaySystemSoundInBox(sound: "BD_PVP_03");
                context.SetEventUI(arg1: 1, script: "$65000002_BD__PVP__3$", duration: 3000);
                context.SetEffect(triggerIds: new []{601}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StatePvP(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePvP : TriggerState {
            internal StatePvP(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 101, type: "trigger", code: "dailyquest_start");
                context.GiveGuildExp(boxId: 0, type: 2);
                context.AddBuff(boxIds: new []{101}, skillId: 70000088, level: 1, arg4: false, arg5: false);
                context.AddBuff(boxIds: new []{101}, skillId: 70000089, level: 1, arg4: false, arg5: false);
                context.SetTimer(timerId: "1", seconds: 1, autoRemove: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    context.SetPvpZone(boxId: 101, arg2: 5, duration: 300, additionalEffectId: 90001002, arg5: 2);
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
                if (context.PvpZoneEnded(boxId: 101)) {
                    return new State경기종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State경기종료 : TriggerState {
            internal State경기종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "4", seconds: 4, autoRemove: false);
                context.PlaySystemSoundInBox(sound: "BD_PVP_04");
                context.SetEventUI(arg1: 1, script: "$65000002_BD__PVP__4$", duration: 3000, boxId: 101);
                context.SetEffect(triggerIds: new []{602}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    return new State완료(context);
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
