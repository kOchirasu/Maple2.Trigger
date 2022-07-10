namespace Maple2.Trigger._52010013_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 102, 103});
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10002797}, questStates: new byte[]{1})) {
                    return new StateEvent_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_01 : TriggerState {
            internal StateEvent_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 8001, enable: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CreateMonster(spawnIds: new []{104});
                context.SetTimer(timerId: "3", seconds: 3);
                context.SetConversation(type: 2, spawnId: 11001217, script: "$52010013_QD__MAIN__0$", arg4: 3);
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_1001");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateEvent_02_IdLE(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateEvent_02_IdLE : TriggerState {
            internal StateEvent_02_IdLE(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return new StateEvent_02(context);
            }

            public override void OnExit() { }
        }

        private class StateEvent_02 : TriggerState {
            internal StateEvent_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 8002, enable: true);
                context.SetConversation(type: 2, spawnId: 11001292, script: "$52010013_QD__MAIN__1$", arg4: 5);
                context.SetSkip(state: new StateEvent_03_IdLE(context));
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateEvent_03_IdLE(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateEvent_03_IdLE : TriggerState {
            internal StateEvent_03_IdLE(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return new StateEvent_03(context);
            }

            public override void OnExit() { }
        }

        private class StateEvent_03 : TriggerState {
            internal StateEvent_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001285, script: "$52010013_QD__MAIN__2$", arg4: 4);
                context.SetSkip(state: new StateEvent_04_IdLE(context));
                context.SetTimer(timerId: "4", seconds: 4);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    return new StateEvent_04_IdLE(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateEvent_04_IdLE : TriggerState {
            internal StateEvent_04_IdLE(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return new StateEvent_04(context);
            }

            public override void OnExit() { }
        }

        private class StateEvent_04 : TriggerState {
            internal StateEvent_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001292, script: "$52010013_QD__MAIN__3$", arg4: 4);
                context.SetTimer(timerId: "4", seconds: 4);
                context.SetSkip(state: new StateEvent_05_IdLE(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    return new StateEvent_05_IdLE(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateEvent_05_IdLE : TriggerState {
            internal StateEvent_05_IdLE(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return new StateEvent_05(context);
            }

            public override void OnExit() { }
        }

        private class StateEvent_05 : TriggerState {
            internal StateEvent_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001292, script: "$52010013_QD__MAIN__4$", arg4: 4);
                context.SetTimer(timerId: "4", seconds: 4);
                context.SetSkip(state: new StateEvent_06_IdLE(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    return new StateEvent_06_IdLE(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateEvent_06_IdLE : TriggerState {
            internal StateEvent_06_IdLE(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return new StateEvent_06(context);
            }

            public override void OnExit() { }
        }

        private class StateEvent_06 : TriggerState {
            internal StateEvent_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001285, script: "$52010013_QD__MAIN__5$", arg4: 5);
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetSkip(state: new StateEvent_07_IdLE(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateEvent_07_IdLE(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateEvent_07_IdLE : TriggerState {
            internal StateEvent_07_IdLE(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return new StateEvent_07(context);
            }

            public override void OnExit() { }
        }

        private class StateEvent_07 : TriggerState {
            internal StateEvent_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001292, script: "$52010013_QD__MAIN__6$", arg4: 4);
                context.SetTimer(timerId: "3", seconds: 3);
                context.SetSkip(state: new StateEvent_08_IdLE(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateEvent_08_IdLE(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateEvent_08_IdLE : TriggerState {
            internal StateEvent_08_IdLE(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return new StateEvent_08(context);
            }

            public override void OnExit() { }
        }

        private class StateEvent_08 : TriggerState {
            internal StateEvent_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001285, script: "$52010013_QD__MAIN__7$", arg4: 4);
                context.SetTimer(timerId: "4", seconds: 4);
                context.SetSkip(state: new StateEvent_09_IdLE(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    return new StateEvent_09_IdLE(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateEvent_09_IdLE : TriggerState {
            internal StateEvent_09_IdLE(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return new StateEvent_09(context);
            }

            public override void OnExit() { }
        }

        private class StateEvent_09 : TriggerState {
            internal StateEvent_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001292, script: "$52010013_QD__MAIN__8$", arg4: 3);
                context.SetTimer(timerId: "3", seconds: 3);
                context.SetSkip(state: new StateEvent_10(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateEvent_10(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateEvent_10 : TriggerState {
            internal StateEvent_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001292, script: "$52010013_QD__MAIN__9$", arg4: 4);
                context.SetTimer(timerId: "4", seconds: 4);
                context.SetSkip(state: new StateEnd(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 7);
                context.CameraSelect(triggerId: 8001, enable: false);
                context.CameraSelect(triggerId: 8002, enable: false);
            }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 701, type: "trigger", code: "DragonMika");
                context.MoveUser(mapId: 02010002, portalId: 13, boxId: 701);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
