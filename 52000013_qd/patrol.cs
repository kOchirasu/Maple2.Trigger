namespace Maple2.Trigger._52000013_qd {
    public static class _patrol {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetActor(triggerId: 6000, visible: false, initialSequence: "Idle_A");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new State어린벨라Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어린벨라Spawn : TriggerState {
            internal State어린벨라Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "10", seconds: 1);
                context.CreateMonster(spawnIds: new []{5000}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "10")) {
                    return new State어린벨라패트롤01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어린벨라패트롤01 : TriggerState {
            internal State어린벨라패트롤01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 5000, patrolName: "MS2PatrolData_1001");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9001, spawnIds: new []{5000})) {
                    return new State어린벨라대화01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어린벨라대화01 : TriggerState {
            internal State어린벨라대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "11", seconds: 3);
                context.SetConversation(type: 1, spawnId: 5000, script: "$52000013_QD__MAIN__1$", arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11")) {
                    return new State어린벨라패트롤02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어린벨라패트롤02 : TriggerState {
            internal State어린벨라패트롤02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 5000, patrolName: "MS2PatrolData_1002");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9002, spawnIds: new []{5000})) {
                    return new State어린벨라대화02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어린벨라대화02 : TriggerState {
            internal State어린벨라대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "12", seconds: 3);
                context.SetConversation(type: 1, spawnId: 5000, script: "$52000013_QD__MAIN__2$", arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "12")) {
                    return new State어린벨라패트롤03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어린벨라패트롤03 : TriggerState {
            internal State어린벨라패트롤03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 5000, patrolName: "MS2PatrolData_1003");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9003, spawnIds: new []{5000})) {
                    return new StateCameraCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraCinematic01 : TriggerState {
            internal StateCameraCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetTimer(timerId: "12", seconds: 6);
                context.CameraSelectPath(pathIds: new []{901}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9004, spawnIds: new []{5000})) {
                    return new StateCameraCinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraCinematic02 : TriggerState {
            internal StateCameraCinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "13", seconds: 12);
                context.SetActor(triggerId: 6000, visible: true, initialSequence: "Idle_A");
                context.CameraSelectPath(pathIds: new []{902, 903}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "13")) {
                    return new State화면끄기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State화면끄기 : TriggerState {
            internal State화면끄기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "14", seconds: 2);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "14")) {
                    return new State어린벨라소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어린벨라소멸 : TriggerState {
            internal State어린벨라소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "15", seconds: 1);
                context.DestroyMonster(spawnIds: new []{5000});
                context.SetActor(triggerId: 6000, visible: false, initialSequence: "Idle_A");
                context.CreateMonster(spawnIds: new []{6001}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "15")) {
                    return new State벨라Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라Cinematic01 : TriggerState {
            internal State벨라Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "16", seconds: 8);
                context.SetCinematicUI(type: 4);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveNpc(spawnId: 6001, patrolName: "MS2PatrolData_2001");
                context.CameraSelectPath(pathIds: new []{904, 905}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "16")) {
                    return new State벨라StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라StopCinematic : TriggerState {
            internal State벨라StopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "17", seconds: 8);
                context.CameraSelect(triggerId: 905, enable: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "17")) {
                    return new State이동Delay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동Delay : TriggerState {
            internal State이동Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10000}, questIds: new []{10002611}, questStates: new byte[]{3})) {
                    return new State강제이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State강제이동 : TriggerState {
            internal State강제이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "19", seconds: 10);
                context.MoveUser(mapId: 03009017, portalId: 50);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "19")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "20", seconds: 10);
                context.DestroyMonster(spawnIds: new []{6001});
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "20")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
