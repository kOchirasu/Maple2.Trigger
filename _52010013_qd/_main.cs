namespace Maple2.Trigger._52010013_qd {
    public static class _main {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 102, 103});
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10002797},
                    arg3: new byte[] {1})) {
                    context.State = new StateEvent_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_01 : TriggerState {
            internal StateEvent_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 8001, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CreateMonster(arg1: new[] {104});
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetConversation(arg1: 2, arg2: 11001217, arg3: "$52010013_QD__MAIN__0$", arg4: 3);
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_1001");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new StateEvent_02_IdLE(context);
                    return;
                }
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateEvent_02_IdLE : TriggerState {
            internal StateEvent_02_IdLE(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (true) {
                    context.State = new StateEvent_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_02 : TriggerState {
            internal StateEvent_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 8002, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001292, arg3: "$52010013_QD__MAIN__1$", arg4: 5);
                context.SetSkip(arg1: "Event_03_IdLE");
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new StateEvent_03_IdLE(context);
                    return;
                }
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateEvent_03_IdLE : TriggerState {
            internal StateEvent_03_IdLE(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (true) {
                    context.State = new StateEvent_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_03 : TriggerState {
            internal StateEvent_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001285, arg3: "$52010013_QD__MAIN__2$", arg4: 4);
                context.SetSkip(arg1: "Event_04_IdLE");
                context.SetTimer(arg1: "4", arg2: 4);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new StateEvent_04_IdLE(context);
                    return;
                }
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateEvent_04_IdLE : TriggerState {
            internal StateEvent_04_IdLE(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (true) {
                    context.State = new StateEvent_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_04 : TriggerState {
            internal StateEvent_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001292, arg3: "$52010013_QD__MAIN__3$", arg4: 4);
                context.SetTimer(arg1: "4", arg2: 4);
                context.SetSkip(arg1: "Event_05_IdLE");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new StateEvent_05_IdLE(context);
                    return;
                }
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateEvent_05_IdLE : TriggerState {
            internal StateEvent_05_IdLE(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (true) {
                    context.State = new StateEvent_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_05 : TriggerState {
            internal StateEvent_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001292, arg3: "$52010013_QD__MAIN__4$", arg4: 4);
                context.SetTimer(arg1: "4", arg2: 4);
                context.SetSkip(arg1: "Event_06_IdLE");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new StateEvent_06_IdLE(context);
                    return;
                }
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateEvent_06_IdLE : TriggerState {
            internal StateEvent_06_IdLE(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (true) {
                    context.State = new StateEvent_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_06 : TriggerState {
            internal StateEvent_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001285, arg3: "$52010013_QD__MAIN__5$", arg4: 5);
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetSkip(arg1: "Event_07_IdLE");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new StateEvent_07_IdLE(context);
                    return;
                }
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateEvent_07_IdLE : TriggerState {
            internal StateEvent_07_IdLE(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (true) {
                    context.State = new StateEvent_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_07 : TriggerState {
            internal StateEvent_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001292, arg3: "$52010013_QD__MAIN__6$", arg4: 4);
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetSkip(arg1: "Event_08_IdLE");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new StateEvent_08_IdLE(context);
                    return;
                }
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateEvent_08_IdLE : TriggerState {
            internal StateEvent_08_IdLE(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (true) {
                    context.State = new StateEvent_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_08 : TriggerState {
            internal StateEvent_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001285, arg3: "$52010013_QD__MAIN__7$", arg4: 4);
                context.SetTimer(arg1: "4", arg2: 4);
                context.SetSkip(arg1: "Event_09_IdLE");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new StateEvent_09_IdLE(context);
                    return;
                }
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateEvent_09_IdLE : TriggerState {
            internal StateEvent_09_IdLE(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (true) {
                    context.State = new StateEvent_09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_09 : TriggerState {
            internal StateEvent_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001292, arg3: "$52010013_QD__MAIN__8$", arg4: 3);
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetSkip(arg1: "Event_10");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new StateEvent_10(context);
                    return;
                }
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateEvent_10 : TriggerState {
            internal StateEvent_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001292, arg3: "$52010013_QD__MAIN__9$", arg4: 4);
                context.SetTimer(arg1: "4", arg2: 4);
                context.SetSkip(arg1: "End");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 7);
                context.CameraSelect(arg1: 8001, arg2: false);
                context.CameraSelect(arg1: 8002, arg2: false);
            }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "DragonMika");
                context.MoveUser(arg1: 02010002, arg2: 13, arg3: 701);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}