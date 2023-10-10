namespace Maple2.Trigger._52000043_qd {
    public static class _50001453 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1003, 2003});
                context.SetAgent(triggerIds: new []{9000, 9001, 9002, 9003, 9004, 9005, 9006, 9007}, visible: false);
                context.SetEffect(triggerIds: new []{603, 604, 605}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{50001453}, questStates: new byte[]{1})) {
                    context.DestroyMonster(spawnIds: new []{1003, 2003});
                    return new StateStart조건(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart조건 : TriggerState {
            internal StateStart조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1003, 2003}, arg2: false);
                context.SetMesh(triggerIds: new []{3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10001020}, state: 2);
                context.SetInteractObject(interactIds: new []{10001021}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001021}, arg2: 0)) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{9000, 9001, 9002, 9003, 9004, 9005, 9006, 9007}, visible: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CreateMonster(spawnIds: new []{2100, 2101}, arg2: false);
                context.CameraSelect(triggerId: 303, enabled: true);
                context.MoveNpc(spawnId: 1003, patrolName: "MS2PatrolData_1004A");
                context.MoveNpc(spawnId: 2003, patrolName: "MS2PatrolData_2004A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateNPCScript01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCScript01 : TriggerState {
            internal StateNPCScript01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{603}, visible: true);
                context.SetConversation(type: 2, spawnId: 29000121, script: "$52000043_QD__50001453__0$", arg4: 3);
                context.SetSkip(state: new StateNPCScript01스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State준타Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCScript01스킵 : TriggerState {
            internal StateNPCScript01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{603}, visible: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State준타Script01(context);
            }

            public override void OnExit() { }
        }

        private class State준타Script01 : TriggerState {
            internal State준타Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{604}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001557, script: "$52000043_QD__50001453__1$", arg4: 3);
                context.SetSkip(state: new State준타Script01스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State준타Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타Script01스킵 : TriggerState {
            internal State준타Script01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{604}, visible: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State준타Script02(context);
            }

            public override void OnExit() { }
        }

        private class State준타Script02 : TriggerState {
            internal State준타Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001557, script: "$52000043_QD__50001453__2$", arg4: 2);
                context.SetSkip(state: new State준타Script02스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State틴차이Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타Script02스킵 : TriggerState {
            internal State준타Script02스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State틴차이Script01(context);
            }

            public override void OnExit() { }
        }

        private class State틴차이Script01 : TriggerState {
            internal State틴차이Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{605}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001708, script: "$52000043_QD__50001453__3$", arg4: 4);
                context.SetSkip(state: new State틴차이Script01스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State틴차이Script01스킵 : TriggerState {
            internal State틴차이Script01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{605}, visible: false);
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
                context.DestroyMonster(spawnIds: new []{1003, 2003});
                context.CreateMonster(spawnIds: new []{1004, 2004}, arg2: false);
                context.SetAgent(triggerIds: new []{9000, 9001, 9002, 9003, 9004, 9005, 9006, 9007}, visible: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 303, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2100, 2101})) {
                    return new StateCinematic02시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic02시작 : TriggerState {
            internal StateCinematic02시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetInteractObject(interactIds: new []{10001021}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 1004, patrolName: "MS2PatrolData_1002C");
                context.MoveNpc(spawnId: 2004, patrolName: "MS2PatrolData_2002C");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 102, spawnIds: new []{1004})) {
                    return new StateNPC교체01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC교체01 : TriggerState {
            internal StateNPC교체01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1004});
                context.CreateMonster(spawnIds: new []{1003}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 103, spawnIds: new []{2004})) {
                    return new StateNPC교체02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC교체02 : TriggerState {
            internal StateNPC교체02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{2004});
                context.CreateMonster(spawnIds: new []{2003}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateStopCinematic2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic2 : TriggerState {
            internal StateStopCinematic2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
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
