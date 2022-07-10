namespace Maple2.Trigger._52000063_qd {
    public static class _90000640 {
        public class StateBeginWait : TriggerState {
            internal StateBeginWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3100}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3101, 3000, 3001, 3002, 3003, 3004}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.CreateMonster(spawnIds: new []{1001, 1002, 1101, 1102, 1103, 1104, 1105}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{199})) {
                    return new StateQuest분기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest분기 : TriggerState {
            internal StateQuest분기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{90000640}, questStates: new byte[]{2})) {
                    return new State90000640완료가능(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{199}, questIds: new []{90000640}, questStates: new byte[]{2})) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State90000640완료가능 : TriggerState {
            internal State90000640완료가능(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1001, 1002});
                context.CreateMonster(spawnIds: new []{1003, 1004}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{90000640}, questStates: new byte[]{3})) {
                    context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 301, enable: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 302, enable: true);
                context.SetConversation(type: 2, spawnId: 11000168, script: "$52000063_QD__90000640__0$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateKScript02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKScript02 : TriggerState {
            internal StateKScript02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 1104, patrolName: "MS2PatrolData_1104A");
                context.SetConversation(type: 2, spawnId: 11000168, script: "$52000063_QD__90000640__1$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State마칸Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마칸Script01 : TriggerState {
            internal State마칸Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 1101, patrolName: "MS2PatrolData_1101A");
                context.MoveNpc(spawnId: 1102, patrolName: "MS2PatrolData_1102A");
                context.MoveNpc(spawnId: 1103, patrolName: "MS2PatrolData_1103A");
                context.MoveNpc(spawnId: 1105, patrolName: "MS2PatrolData_1105A");
                context.SetConversation(type: 2, spawnId: 11001872, script: "$52000063_QD__90000640__2$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State마칸Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마칸Script02 : TriggerState {
            internal State마칸Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001872, script: "$52000063_QD__90000640__3$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
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
                context.CameraSelect(triggerId: 302, enable: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State90000640진행중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State90000640진행중 : TriggerState {
            internal State90000640진행중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{101}, questIds: new []{90000640}, questStates: new byte[]{1})) {
                    context.MoveUser(mapId: 52000063, portalId: 1);
                    return new State2차StartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차StartCinematic : TriggerState {
            internal State2차StartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 303, enable: true);
                context.SetConversation(type: 2, spawnId: 11000168, script: "$52000063_QD__90000640__4$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateKScript03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKScript03 : TriggerState {
            internal StateKScript03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 304, enable: true);
                context.SetConversation(type: 2, spawnId: 11000168, script: "$52000063_QD__90000640__5$", arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StateCount(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCount : TriggerState {
            internal StateCount(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3100}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3000, 3001, 3002, 3003, 3004, 3101}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.DestroyMonster(spawnIds: new []{1001, 1002});
                context.CameraSelect(triggerId: 304, enable: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.ShowCountUI(text: "$52000063_QD__90000640__6$", stage: 1, count: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State경기시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State경기시작 : TriggerState {
            internal State경기시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99999102, key: "gameStart", value: 1);
                context.SetUserValue(triggerId: 99999103, key: "gameStart", value: 1);
                context.SetUserValue(triggerId: 99999104, key: "gameStart", value: 1);
                context.CreateItem(spawnIds: new []{9000, 9001, 9002, 9003, 9004, 9005, 9006, 9007, 9008, 9009, 9010, 9011, 9012, 9013, 9014, 9015, 9016, 9017, 9018, 9019, 9020, 9021, 9022, 9023, 9024, 9025});
                context.MoveNpc(spawnId: 1101, patrolName: "MS2PatrolData_1101R");
                context.MoveNpc(spawnId: 1102, patrolName: "MS2PatrolData_1102R");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateNPC2차이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC2차이동 : TriggerState {
            internal StateNPC2차이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 1103, patrolName: "MS2PatrolData_1103R");
                context.MoveNpc(spawnId: 1104, patrolName: "MS2PatrolData_1104R");
                context.MoveNpc(spawnId: 1105, patrolName: "MS2PatrolData_1105R");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{102})) {
                    return new State완료Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State완료Wait : TriggerState {
            internal State완료Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateItem(spawnIds: new []{9026, 9027, 9028, 9029});
                context.SetMesh(triggerIds: new []{3000, 3001, 3002, 3003, 3004, 3101}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(spawnIds: new []{1003, 1004}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{103})) {
                    return new State완료알림케이대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State완료알림케이대사 : TriggerState {
            internal State완료알림케이대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(type: 2, spawnId: 11000168, script: "$52000063_QD__90000640__7$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State완료 : TriggerState {
            internal State완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateItem(spawnIds: new []{9030, 9031, 9032, 9033, 9034, 9035});
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetAchievement(triggerId: 199, type: "trigger", code: "ArrivedSupercar");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{90000640}, questStates: new byte[]{3})) {
                    context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
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
