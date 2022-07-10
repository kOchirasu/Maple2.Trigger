using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000028_qd {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601, 602, 603, 604}, visible: false);
                context.CreateMonster(spawnIds: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014}, arg2: false);
                context.SetMesh(triggerIds: new []{3001}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3002}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{101}, questIds: new []{20002250}, questStates: new byte[]{1}, jobCode: 90)) {
                    return new StateStartCinematic(context);
                }

                if (context.QuestUserDetected(boxIds: new []{101}, questIds: new []{20002251}, questStates: new byte[]{1}, jobCode: 90)) {
                    return new StateNPC이동01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{101}, questIds: new []{10002931}, questStates: new byte[]{1})) {
                    return new StateStartCinematic(context);
                }

                if (context.QuestUserDetected(boxIds: new []{101}, questIds: new []{10002932}, questStates: new byte[]{1})) {
                    return new StateNPC이동01(context);
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
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State아시모프이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아시모프이동 : TriggerState {
            internal State아시모프이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 1001, patrolName: "MS2PatrolData_1001_A");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 102, spawnIds: new []{1001})) {
                    return new State책장변경(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State책장변경 : TriggerState {
            internal State책장변경(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3001}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3002}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State동영상재상(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State동영상재상 : TriggerState {
            internal State동영상재상(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(type: WidgetType.SceneMovie);
                context.WidgetAction(type: WidgetType.SceneMovie, name: "Clear");
                context.PlaySceneMovie(fileName: "Starlight_expedition.swf", movieId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, condition: "IsStop", value: "1")) {
                    return new StateIshuraScript01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshuraScript01 : TriggerState {
            internal StateIshuraScript01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 302, enable: true);
                context.SetEffect(triggerIds: new []{601}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001244, script: "$52000028_QD__MAIN__0$", arg4: 5, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5500)) {
                    return new StateIshuraScript02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshuraScript02 : TriggerState {
            internal StateIshuraScript02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{602}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001244, script: "$52000028_QD__MAIN__1$", arg4: 6, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State아시모프Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아시모프Script01 : TriggerState {
            internal State아시모프Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 1001, patrolName: "MS2PatrolData_1001_B");
                context.SetEffect(triggerIds: new []{603}, visible: true);
                context.SetConversation(type: 2, spawnId: 11000031, script: "$52000028_QD__MAIN__2$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아시모프Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아시모프Script02 : TriggerState {
            internal State아시모프Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{604}, visible: true);
                context.SetConversation(type: 2, spawnId: 11000031, script: "$52000028_QD__MAIN__3$", arg4: 6, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateQuest수락Wait(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetAchievement(triggerId: 101, type: "trigger", code: "BackstoryOfRune");
                context.CameraSelect(triggerId: 301, enable: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class StateQuest수락Wait : TriggerState {
            internal StateQuest수락Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{101}, questIds: new []{20002251}, questStates: new byte[]{1}, jobCode: 90)) {
                    return new StateNPC이동01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{101}, questIds: new []{10002932}, questStates: new byte[]{1})) {
                    return new StateNPC이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동01 : TriggerState {
            internal StateNPC이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 1002, patrolName: "MS2PatrolData_1002_A");
                context.MoveNpc(spawnId: 1003, patrolName: "MS2PatrolData_1003_A");
                context.MoveNpc(spawnId: 1005, patrolName: "MS2PatrolData_1005_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateNPC이동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동02 : TriggerState {
            internal StateNPC이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 1008, patrolName: "MS2PatrolData_1008_A");
                context.MoveNpc(spawnId: 1013, patrolName: "MS2PatrolData_1013_A");
                context.MoveNpc(spawnId: 1014, patrolName: "MS2PatrolData_1014_A");
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
