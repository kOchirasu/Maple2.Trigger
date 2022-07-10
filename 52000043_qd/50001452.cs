namespace Maple2.Trigger._52000043_qd {
    public static class _50001452 {
        public class State선행Quest체크 : TriggerState {
            internal State선행Quest체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001017, 10001018, 10001019, 10001020, 10001021}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{50001451}, questStates: new byte[]{3})) {
                    context.DestroyMonster(spawnIds: new []{1001, 2001});
                    return new StateStart조건(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart조건 : TriggerState {
            internal StateStart조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1001, 2001}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{50001452}, questStates: new byte[]{1})) {
                    return new StateStartCinematic(context);
                }

                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{50001452}, questStates: new byte[]{2})) {
                    context.DestroyMonster(spawnIds: new []{1003, 2003});
                    return new StateNPC만배치(context);
                }

                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{50001452}, questStates: new byte[]{3})) {
                    context.DestroyMonster(spawnIds: new []{1003, 2003});
                    return new StateNPC만배치(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC만배치 : TriggerState {
            internal StateNPC만배치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1001, 2001});
                context.CreateMonster(spawnIds: new []{1003, 2003}, arg2: false);
                context.SetMesh(triggerIds: new []{3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{50001454}, questStates: new byte[]{2})) {
                    context.DestroyMonster(spawnIds: new []{1003, 2003});
                    return new StateEnd(context);
                }

                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{50001454}, questStates: new byte[]{3})) {
                    context.DestroyMonster(spawnIds: new []{1003, 2003});
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1001, 2001});
                context.CreateMonster(spawnIds: new []{1002, 2002}, arg2: false);
                context.SetMesh(triggerIds: new []{3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.CameraSelect(triggerId: 304, enable: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateNPC이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동01 : TriggerState {
            internal StateNPC이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 1002, patrolName: "MS2PatrolData_1002A");
                context.MoveNpc(spawnId: 2002, patrolName: "MS2PatrolData_2002A");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 101, spawnIds: new []{2002})) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 304, enable: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.MoveNpc(spawnId: 1002, patrolName: "MS2PatrolData_1002B");
                context.MoveNpc(spawnId: 2002, patrolName: "MS2PatrolData_2002B");
                context.SetInteractObject(interactIds: new []{10001017, 10001018, 10001019}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001019}, arg2: 0)) {
                    return new State부서짐Cinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부서짐Cinematic : TriggerState {
            internal State부서짐Cinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001017, 10001018}, state: 2);
                context.SetInteractObject(interactIds: new []{10001020}, state: 1);
                context.SetMesh(triggerIds: new []{3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017}, visible: false, arg3: 0, arg4: 200, arg5: 2f);
                context.CameraSelect(triggerId: 306, enable: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetSkip(state: new State향로반응Wait(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State향로반응Wait(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CameraSelect(triggerId: 306, enable: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class State향로반응Wait : TriggerState {
            internal State향로반응Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{50001452}, questStates: new byte[]{2})) {
                    return new StateNPC이동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동02 : TriggerState {
            internal StateNPC이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 1002, patrolName: "MS2PatrolData_1002C");
                context.MoveNpc(spawnId: 2002, patrolName: "MS2PatrolData_2002C");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 102, spawnIds: new []{1002})) {
                    return new StateNPC교체01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC교체01 : TriggerState {
            internal StateNPC교체01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1002});
                context.CreateMonster(spawnIds: new []{1003}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 103, spawnIds: new []{2002})) {
                    return new StateNPC교체02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC교체02 : TriggerState {
            internal StateNPC교체02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{2002});
                context.CreateMonster(spawnIds: new []{2003}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
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
