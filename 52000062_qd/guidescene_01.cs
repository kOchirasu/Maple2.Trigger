namespace Maple2.Trigger._52000062_qd {
    public static class _guidescene_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1001, 1002, 1003, 1004, 1007}, arg2: false);
                context.SetEffect(triggerIds: new []{601}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateUserDetection(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateUserDetection : TriggerState {
            internal StateUserDetection(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{90000561}, questStates: new byte[]{3})) {
                    return new StateEnd(context);
                }

                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{90000561}, questStates: new byte[]{2})) {
                    return new State연퀘감지2(context);
                }

                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{90000560, 90000561}, questStates: new byte[]{1})) {
                    return new State연퀘감지(context);
                }

                if (context.UserDetected(boxIds: new []{199})) {
                    return new State페르시카Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State페르시카Script01 : TriggerState {
            internal State페르시카Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 301, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State페르시카Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State페르시카Script02 : TriggerState {
            internal State페르시카Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001176, script: "$52000062_QD__GUIdESCENE_01__0$", arg4: 3, arg5: 0);
                context.SetConversation(type: 2, spawnId: 11001176, script: "$52000062_QD__GUIdESCENE_01__1$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 301, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State연퀘감지(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연퀘감지 : TriggerState {
            internal State연퀘감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 1001, patrolName: "MS2PatrolData_Fercika");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{90000561}, questStates: new byte[]{2})) {
                    return new StatePC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연퀘감지2 : TriggerState {
            internal State연퀘감지2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 1001, patrolName: "MS2PatrolData_Fercika");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC이동 : TriggerState {
            internal StatePC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 301, enabled: true);
                context.MoveUserPath(patrolName: "MS2PatrolData_PC");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{198})) {
                    return new State찬양NPC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State찬양NPC이동 : TriggerState {
            internal State찬양NPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601}, visible: true);
                context.MoveNpc(spawnId: 1001, patrolName: "MS2PatrolData_Fercika2");
                context.CreateMonster(spawnIds: new []{1005}, arg2: false);
                context.DestroyMonster(spawnIds: new []{1002}, arg2: false);
                context.CreateMonster(spawnIds: new []{1006}, arg2: false);
                context.DestroyMonster(spawnIds: new []{1004}, arg2: false);
                context.CreateMonster(spawnIds: new []{1008}, arg2: false);
                context.DestroyMonster(spawnIds: new []{1007}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 197, spawnIds: new []{1001})) {
                    return new State찬양Cinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State찬양Cinematic : TriggerState {
            internal State찬양Cinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 1008, script: "$52000062_QD__GUIdESCENE_01__2$", arg4: 2, arg5: 1);
                context.SetConversation(type: 1, spawnId: 1005, script: "$52000062_QD__GUIdESCENE_01__3$", arg4: 2, arg5: 3);
                context.SetConversation(type: 1, spawnId: 1006, script: "$52000062_QD__GUIdESCENE_01__4$", arg4: 2, arg5: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
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
                context.CameraSelect(triggerId: 301, enabled: false);
                context.SetEffect(triggerIds: new []{601}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
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
