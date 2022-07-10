namespace Maple2.Trigger._63000039_cs {
    public static class _40002641 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 201, visible: true, initialSequence: "sf_fi_funct_darkdoor_A01_off");
                context.SetMesh(triggerIds: new []{3000, 3001, 3002}, visible: true);
                context.SetMesh(triggerIds: new []{3003, 3004, 3005}, visible: false);
                context.SetInteractObject(interactIds: new []{10001025}, state: 0);
                context.CreateMonster(spawnIds: new []{1001, 1002, 1003, 1004, 1005}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{40002641}, questStates: new byte[]{1})) {
                    return new StateNPC말풍선(context);
                }

                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{40002641}, questStates: new byte[]{2})) {
                    return new State유저이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC말풍선 : TriggerState {
            internal StateNPC말풍선(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetConversation(type: 1, spawnId: 1002, script: "$63000039_CS__40002641__0$", arg4: 4, arg5: 0);
                    context.SetConversation(type: 1, spawnId: 1005, script: "$63000039_CS__40002641__1$", arg4: 4, arg5: 2);
                    return new StateInteractObjectWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateInteractObjectWait : TriggerState {
            internal StateInteractObjectWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001025}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001025}, arg2: 0)) {
                    context.SetMesh(triggerIds: new []{3000, 3001, 3002}, visible: false);
                    context.SetMesh(triggerIds: new []{3003, 3004, 3005}, visible: true);
                    return new StateNPC를이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC를이동 : TriggerState {
            internal StateNPC를이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 301, enable: true);
                context.MoveNpc(spawnId: 1001, patrolName: "MS2PatrolData_1001");
                context.MoveNpc(spawnId: 1002, patrolName: "MS2PatrolData_1002");
                context.MoveNpc(spawnId: 1003, patrolName: "MS2PatrolData_1003");
                context.MoveNpc(spawnId: 1004, patrolName: "MS2PatrolData_1004");
                context.MoveNpc(spawnId: 1005, patrolName: "MS2PatrolData_1005");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StatePC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC이동 : TriggerState {
            internal StatePC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 201, visible: true, initialSequence: "sf_fi_funct_darkdoor_A01_on");
                context.MoveUserPath(patrolName: "MS2PatrolData_PC");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new StatePC말풍선(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선 : TriggerState {
            internal StatePC말풍선(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 302, enable: true);
                context.SetConversation(type: 1, spawnId: 0, script: "$63000039_CS__40002641__2$", arg4: 4, arg5: 0);
                context.SetAchievement(triggerId: 199, type: "trigger", code: "SaveBackstreetPeople");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State유저이동조건(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저이동조건 : TriggerState {
            internal State유저이동조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{40002641}, questStates: new byte[]{2})) {
                    return new State유저이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저이동 : TriggerState {
            internal State유저이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 302, enable: false);
                context.MoveUser(mapId: 02000275, portalId: 30);
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
