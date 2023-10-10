namespace Maple2.Trigger._52000004_qd {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601, 602}, visible: false);
                context.DestroyMonster(spawnIds: new []{2001, 2099, 1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016});
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(triggerIds: new []{3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{199})) {
                    return new StateDungeonInit(context);
                }

                if (!context.UserDetected(boxIds: new []{199})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonInit : TriggerState {
            internal StateDungeonInit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State1차목표(context);
                }

                if (!context.UserDetected(boxIds: new []{199})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차목표 : TriggerState {
            internal State1차목표(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601}, visible: true);
                context.SetTimer(timerId: "2", seconds: 2);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3, script: "$52000004_QD__MAIN__0$");
                context.SetSkip(state: new StateStopCinematic(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new StateCamera이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera이동 : TriggerState {
            internal StateCamera이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
                context.CameraSelect(triggerId: 301, enabled: true);
                context.SetSkip(state: new StateStopCinematic(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{602}, visible: true);
                context.CameraSelectPath(pathIds: new []{301}, returnView: true);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{100})) {
                    return new State피자들기(context);
                }

                if (!context.UserDetected(boxIds: new []{199})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State피자들기 : TriggerState {
            internal State피자들기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
                context.ShowGuideSummary(entityId: 25200401, textId: 25200401);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateEliteSpawnWait(context);
                }

                if (!context.UserDetected(boxIds: new []{199})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 25200401);
            }
        }

        private class StateEliteSpawnWait : TriggerState {
            internal StateEliteSpawnWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016}, arg2: false);
                context.SetEffect(triggerIds: new []{602}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    return new StateEliteSpawn(context);
                }

                if (!context.UserDetected(boxIds: new []{199})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEliteSpawn : TriggerState {
            internal StateEliteSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25200402, textId: 25200402);
                context.SetMesh(triggerIds: new []{3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.CreateMonster(spawnIds: new []{2001}, arg2: false);
                context.SetConversation(type: 1, spawnId: 2001, script: "$52000004_QD__MAIN__3$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2001})) {
                    return new State벽해제(context);
                }

                if (!context.UserDetected(boxIds: new []{199})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 25200402);
            }
        }

        private class State벽해제 : TriggerState {
            internal State벽해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{102})) {
                    return new StateNPCSpawn(context);
                }

                if (!context.UserDetected(boxIds: new []{199})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCSpawn : TriggerState {
            internal StateNPCSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601}, visible: false);
                context.CreateMonster(spawnIds: new []{2099}, arg2: false);
                context.SetConversation(type: 1, spawnId: 2099, script: "$52000004_QD__MAIN__4$", arg4: 3);
                context.MoveNpc(spawnId: 2099, patrolName: "MS2PatrolData_2099");
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{199})) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(timerId: "5")) {
                    return new State미션Success(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미션Success : TriggerState {
            internal State미션Success(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{10001852}, questStates: new byte[]{2})) {
                    context.SetEventUI(arg1: 7, script: "$52000004_QD__MAIN__5$", duration: 3000, boxId: 0);
                    return new StatePortalCreation(context);
                }

                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{10001851}, questStates: new byte[]{2})) {
                    context.SetEventUI(arg1: 7, script: "$52000004_QD__MAIN__6$", duration: 3000, boxId: 0);
                    return new StatePortalCreation(context);
                }

                if (context.TimeExpired(timerId: "3")) {
                    return new StatePortalCreation(context);
                }

                if (!context.UserDetected(boxIds: new []{199})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalCreation : TriggerState {
            internal StatePortalCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                    context.ShowGuideSummary(entityId: 25200403, textId: 25200403);
                    return new StateEndWait(context);
                }

                if (!context.UserDetected(boxIds: new []{199})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndWait : TriggerState {
            internal StateEndWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "30", seconds: 30);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "30")) {
                    context.MoveUser(mapId: 02000166, portalId: 30, boxId: 199);
                    return new StateEnd(context);
                }

                if (!context.UserDetected(boxIds: new []{199})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 25200403);
            }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{2001, 2099, 1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016});
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(triggerIds: new []{3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                return new StateWait(context);
            }

            public override void OnExit() { }
        }
    }
}
