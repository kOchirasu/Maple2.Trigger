namespace Maple2.Trigger._52000044_qd {
    public static class _10003040 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000390}, state: 0);
                context.SetEffect(triggerIds: new []{601, 602}, visible: false);
                context.CreateMonster(spawnIds: new []{1001}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{10003042}, questStates: new byte[]{1})) {
                    context.DestroyMonster(spawnIds: new []{1001});
                    context.CreateMonster(spawnIds: new []{1003}, arg2: false);
                    return new StateInteractObjectWait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{10003041}, questStates: new byte[]{3})) {
                    context.DestroyMonster(spawnIds: new []{1001});
                    context.CreateMonster(spawnIds: new []{1003}, arg2: false);
                    return new StateInteractObject조건(context);
                }

                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{10003041}, questStates: new byte[]{2})) {
                    context.DestroyMonster(spawnIds: new []{1001});
                    context.CreateMonster(spawnIds: new []{1003}, arg2: false);
                    return new StateInteractObject조건(context);
                }

                if (context.QuestUserDetected(boxIds: new []{103}, questIds: new []{10003041}, questStates: new byte[]{1})) {
                    return new StateStartCinematic02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{10003041}, questStates: new byte[]{1})) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 301, enabled: true);
                context.DestroyMonster(spawnIds: new []{1001});
                context.CreateMonster(spawnIds: new []{1002}, arg2: false);
                context.SetEffect(triggerIds: new []{602}, visible: true);
                context.CreateMonster(spawnIds: new []{2001, 2002, 2003, 2004, 2005}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State말풍선Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic02 : TriggerState {
            internal StateStartCinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1001});
                context.CreateMonster(spawnIds: new []{1002}, arg2: false);
                context.SetEffect(triggerIds: new []{602}, visible: true);
                context.CreateMonster(spawnIds: new []{2001, 2002, 2003, 2004, 2005}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State1차전투시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State말풍선Script01 : TriggerState {
            internal State말풍선Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 2001, script: "$52000044_QD__10003040__0$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State말풍선Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State말풍선Script02 : TriggerState {
            internal State말풍선Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 2001, patrolName: "MS2PatrolData_2001");
                context.MoveNpc(spawnId: 2002, patrolName: "MS2PatrolData_2002");
                context.MoveNpc(spawnId: 2003, patrolName: "MS2PatrolData_2003");
                context.MoveNpc(spawnId: 2004, patrolName: "MS2PatrolData_2004");
                context.MoveNpc(spawnId: 2005, patrolName: "MS2PatrolData_2005");
                context.SetConversation(type: 1, spawnId: 2003, script: "$52000044_QD__10003040__1$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State제이시Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제이시Script01 : TriggerState {
            internal State제이시Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000515, script: "$52000044_QD__10003040__2$", arg4: 2);
                context.SetSkip(state: new State제이시Script01스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State제이시Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제이시Script01스킵 : TriggerState {
            internal State제이시Script01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State제이시Script02(context);
            }

            public override void OnExit() { }
        }

        private class State제이시Script02 : TriggerState {
            internal State제이시Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 302, enabled: true);
                context.SetEffect(triggerIds: new []{601}, visible: true);
                context.SetConversation(type: 2, spawnId: 11000515, script: "$52000044_QD__10003040__3$", arg4: 4);
                context.SetSkip(state: new State제이시Script02스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제이시Script02스킵 : TriggerState {
            internal State제이시Script02스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateStopCinematic(context);
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 302, enabled: false);
                context.SetEffect(triggerIds: new []{601}, visible: false);
                context.MoveNpc(spawnId: 1002, patrolName: "MS2PatrolData_1002A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State1차전투시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차전투시작 : TriggerState {
            internal State1차전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25200441, textId: 25200441, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2001, 2002, 2003, 2004, 2005})) {
                    context.MoveNpc(spawnId: 1002, patrolName: "MS2PatrolData_1002B");
                    return new State2차전투시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차전투시작 : TriggerState {
            internal State2차전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2006}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2006})) {
                    context.MoveNpc(spawnId: 1002, patrolName: "MS2PatrolData_1002C");
                    return new StateNPC감지Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC감지Wait : TriggerState {
            internal StateNPC감지Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 102, spawnIds: new []{1002})) {
                    context.SetAchievement(triggerId: 199, type: "trigger", code: "EscapewithJacy");
                    context.DestroyMonster(spawnIds: new []{1002});
                    context.CreateMonster(spawnIds: new []{1003}, arg2: false);
                    return new StateInteractObject조건(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateInteractObject조건 : TriggerState {
            internal StateInteractObject조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{10003042}, questStates: new byte[]{1})) {
                    return new StateInteractObjectWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateInteractObjectWait : TriggerState {
            internal StateInteractObjectWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000390}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000390}, arg2: 0)) {
                    context.MoveUser(mapId: 52000045, portalId: 1);
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
