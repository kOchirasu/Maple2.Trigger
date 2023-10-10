namespace Maple2.Trigger._52000021_qd {
    public static class _main01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6000, 6100, 6200, 6201, 6202, 6300, 6301, 6400, 6401, 6500, 6600, 6700}, visible: false);
                context.SetMesh(triggerIds: new []{5000, 5001, 5002, 4000, 4001, 4002, 4003}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10000831}, state: 0);
                context.SetInteractObject(interactIds: new []{10000832}, state: 2);
                context.CreateMonster(spawnIds: new []{111, 311}, arg2: true);
                context.MoveNpc(spawnId: 311, patrolName: "MS2PatrolData_311");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{60001030}, questStates: new byte[]{1})) {
                    return new StateSetupCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupCinematic : TriggerState {
            internal StateSetupCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{111, 311});
                context.SetTimer(timerId: "1", seconds: 2);
                context.SetMesh(triggerIds: new []{5000, 5001, 5002}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{6100}, visible: true);
                context.CameraSelect(triggerId: 600, enabled: true);
                context.CreateMonster(spawnIds: new []{101, 201, 301}, arg2: true);
                context.SetEffect(triggerIds: new []{6200, 6300, 6201, 6301}, visible: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateDelay(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class StateDelay : TriggerState {
            internal StateDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 1);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new StateCameraStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraStartCinematic : TriggerState {
            internal StateCameraStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 6);
                context.CameraSelectPath(pathIds: new []{600, 601, 602}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateIshura대화01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshura대화01 : TriggerState {
            internal StateIshura대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "4", seconds: 5);
                context.SetConversation(type: 2, spawnId: 11001244, script: "$52000021_QD__MAIN01__0$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    return new StateIshura대화02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshura대화02 : TriggerState {
            internal StateIshura대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetConversation(type: 2, spawnId: 11001244, script: "$52000021_QD__MAIN01__1$", arg4: 5);
                context.SetInteractObject(interactIds: new []{10000831}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State주문석반응Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State주문석반응Wait : TriggerState {
            internal State주문석반응Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 602, enabled: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000831}, arg2: 0)) {
                    return new State보호막설정01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetInteractObject(interactIds: new []{10000831}, state: 2);
                context.SetInteractObject(interactIds: new []{10000832}, state: 0);
                context.SetEffect(triggerIds: new []{6000}, visible: true);
                context.SetMesh(triggerIds: new []{4000, 4001, 4002, 4003}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }
        }

        private class State보호막설정01 : TriggerState {
            internal State보호막설정01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "10", seconds: 1);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 603, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "10")) {
                    return new State목표전달01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State목표전달01 : TriggerState {
            internal State목표전달01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "11", seconds: 4);
                context.SetConversation(type: 2, spawnId: 11001244, script: "$52000021_QD__MAIN01__2$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11")) {
                    return new State목표전달02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State목표전달02 : TriggerState {
            internal State목표전달02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "12", seconds: 2);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 603, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "12")) {
                    return new StateUserDetection01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateUserDetection01 : TriggerState {
            internal StateUserDetection01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9001})) {
                    return new State탈출경고01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈출경고01 : TriggerState {
            internal State탈출경고01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "20", seconds: 4);
                context.SetConversation(type: 1, spawnId: 101, script: "$52000021_QD__MAIN01__3$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 301, script: "$52000021_QD__MAIN01__4$", arg4: 3, arg5: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "20")) {
                    return new State탈출경고02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈출경고02 : TriggerState {
            internal State탈출경고02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "21", seconds: 4);
                context.SetEffect(triggerIds: new []{6400}, visible: true);
                context.SetConversation(type: 1, spawnId: 301, script: "$52000021_QD__MAIN01__5$", arg4: 3, arg5: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "21")) {
                    return new State탈출경고03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈출경고03 : TriggerState {
            internal State탈출경고03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "22", seconds: 4);
                context.SetConversation(type: 1, spawnId: 301, script: "$52000021_QD__MAIN01__6$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "22")) {
                    return new State탈출경고04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈출경고04 : TriggerState {
            internal State탈출경고04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "25", seconds: 3);
                context.SetEffect(triggerIds: new []{6401}, visible: true);
                context.SetConversation(type: 1, spawnId: 101, script: "$52000021_QD__MAIN01__7$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "25")) {
                    return new State탈출경고05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈출경고05 : TriggerState {
            internal State탈출경고05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "26", seconds: 3);
                context.SetEffect(triggerIds: new []{6401}, visible: true);
                context.SetConversation(type: 1, spawnId: 101, script: "$52000021_QD__MAIN01__8$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "26")) {
                    return new State탈출경고06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈출경고06 : TriggerState {
            internal State탈출경고06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "26", seconds: 3);
                context.SetConversation(type: 1, spawnId: 101, script: "$52000021_QD__MAIN01__9$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "26")) {
                    return new State탈출가능01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈출가능01 : TriggerState {
            internal State탈출가능01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000832}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000832}, arg2: 0)) {
                    return new State보호막해제01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetInteractObject(interactIds: new []{10000832}, state: 2);
            }
        }

        private class State보호막해제01 : TriggerState {
            internal State보호막해제01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "30", seconds: 1);
                context.SetEffect(triggerIds: new []{6000, 6400, 6401}, visible: false);
                context.SetEffect(triggerIds: new []{6202}, visible: true);
                context.SetMesh(triggerIds: new []{4000, 4001, 4002, 4003}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 610, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "30")) {
                    return new State홀슈타트Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{6200, 6201, 6300, 6301, 6100}, visible: false);
            }
        }

        private class State홀슈타트Cinematic01 : TriggerState {
            internal State홀슈타트Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "31", seconds: 2);
                context.SetEffect(triggerIds: new []{6202}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001244, script: "$52000021_QD__MAIN01__10$", arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "31")) {
                    return new State홀슈타트Cinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State홀슈타트Cinematic02 : TriggerState {
            internal State홀슈타트Cinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "32", seconds: 3);
                context.CameraSelect(triggerId: 611, enabled: true);
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_201");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9010, spawnIds: new []{201})) {
                    return new State홀슈타트Cinematic03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State홀슈타트Cinematic03 : TriggerState {
            internal State홀슈타트Cinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "33", seconds: 1);
                context.SetEffect(triggerIds: new []{6700, 6600, 6500}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001244, script: "$52000021_QD__MAIN01__11$", arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "33")) {
                    return new State홀슈타트Cinematic04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State홀슈타트Cinematic04 : TriggerState {
            internal State홀슈타트Cinematic04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "35", seconds: 1);
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_202");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "35")) {
                    return new StateStopCinematicPrepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematicPrepare : TriggerState {
            internal StateStopCinematicPrepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "34", seconds: 2);
                context.SetCinematicUI(type: 4);
                context.DestroyMonster(spawnIds: new []{201, 101, 301});
                context.CreateMonster(spawnIds: new []{111, 311}, arg2: true);
                context.MoveNpc(spawnId: 311, patrolName: "MS2PatrolData_311");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "34")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 4);
            }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 611, enabled: false);
                context.SetAchievement(triggerId: 9900, type: "trigger", code: "EscapeHallstatt");
                context.SetMesh(triggerIds: new []{5000, 5001, 5002}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
