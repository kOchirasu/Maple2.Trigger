using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52010018_qd {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{100}, questIds: new []{10002852}, questStates: new byte[]{1})) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 301, enable: true);
                context.CreateMonster(spawnIds: new []{1002, 1003, 1004, 1006}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 1002, patrolName: "MS2PatrolData_1002_A");
                context.MoveNpc(spawnId: 1003, patrolName: "MS2PatrolData_1003_A");
                context.MoveNpc(spawnId: 1004, patrolName: "MS2PatrolData_1004_A");
                context.MoveNpc(spawnId: 1006, patrolName: "MS2PatrolData_1006_A");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 102, spawnIds: new []{1002})) {
                    return new State둔바Script01(context);
                }

                if (context.NpcDetected(boxId: 102, spawnIds: new []{1003})) {
                    return new State둔바Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State둔바Script01 : TriggerState {
            internal State둔바Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001217, script: "$52010018_QD__MAIN__0$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State에레브Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에레브Script01 : TriggerState {
            internal State에레브Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000075, script: "$52010018_QD__MAIN__1$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State미카Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미카Script01 : TriggerState {
            internal State미카Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001285, script: "$52010018_QD__MAIN__2$", arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State미카이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미카이동01 : TriggerState {
            internal State미카이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 301, enable: false);
                context.MoveNpc(spawnId: 1006, patrolName: "MS2PatrolData_1006_B");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 103, spawnIds: new []{1006})) {
                    return new State동영상재생Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State동영상재생Wait : TriggerState {
            internal State동영상재생Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State동영상재생(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State동영상재생 : TriggerState {
            internal State동영상재생(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(type: WidgetType.SceneMovie);
                context.WidgetAction(type: WidgetType.SceneMovie, name: "Clear");
                context.PlaySceneMovie(fileName: "awaken.swf", movieId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, condition: "IsStop", value: "1")) {
                    return new State동영상종료Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State동영상종료Wait : TriggerState {
            internal State동영상종료Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateAchievement(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAchievement : TriggerState {
            internal StateAchievement(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 100, type: "trigger", code: "ChangeMika");
                context.DestroyMonster(spawnIds: new []{1006});
                context.CreateMonster(spawnIds: new []{1005}, arg2: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
