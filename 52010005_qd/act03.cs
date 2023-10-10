using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52010005_qd {
    public static class _act03 {
        public class StateQuest조건03 : TriggerState {
            internal StateQuest조건03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000872}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{10002822}, questStates: new byte[]{1})) {
                    return new StateQ3_Delay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ3_Delay01 : TriggerState {
            internal StateQ3_Delay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "100", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "100")) {
                    return new StateQ3_미카Spawn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ3_미카Spawn01 : TriggerState {
            internal StateQ3_미카Spawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "20", seconds: 1);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CreateMonster(spawnIds: new []{601}, arg2: false);
                context.MoveNpc(spawnId: 601, patrolName: "MS2PatrolData_6010");
                context.DestroyMonster(spawnIds: new []{401, 101});
                context.CreateMonster(spawnIds: new []{501}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "20")) {
                    return new StateQ3_미카Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ3_미카Cinematic01 : TriggerState {
            internal StateQ3_미카Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "21", seconds: 5);
                context.CameraSelectPath(pathIds: new []{2001, 2002}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "21")) {
                    return new StateQ3_미카Cinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ3_미카Cinematic02 : TriggerState {
            internal StateQ3_미카Cinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 8003, spawnIds: new []{601})) {
                    return new StateQ3_미카Cinematic03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ3_미카Cinematic03 : TriggerState {
            internal StateQ3_미카Cinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "22", seconds: 4);
                context.MoveNpc(spawnId: 601, patrolName: "MS2PatrolData_6011");
                context.CameraSelectPath(pathIds: new []{2002, 2001}, returnView: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "22")) {
                    return new StateQ3_미카Cinematic04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ3_미카Cinematic04 : TriggerState {
            internal StateQ3_미카Cinematic04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000872}, state: 1);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000872}, arg2: 0)) {
                    return new StateQ3_영상재생(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ3_영상재생 : TriggerState {
            internal StateQ3_영상재생(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(type: WidgetType.SceneMovie);
                context.WidgetAction(type: WidgetType.SceneMovie, name: "Clear");
                context.PlaySceneMovie(fileName: "MemoryofDragon.swf", movieId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, condition: "IsStop", value: "1")) {
                    return new StateQ3_시네마틱Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ3_시네마틱Cinematic01 : TriggerState {
            internal StateQ3_시네마틱Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "25", seconds: 4);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(type: 2, spawnId: 11001285, script: "$52010005_QD__ACT03__0$", arg4: 4);
                context.SetSkip(state: new StateQ3_시네마틱Cinematic02Wait(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "25")) {
                    return new StateQ3_시네마틱Cinematic02Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ3_시네마틱Cinematic02Wait : TriggerState {
            internal StateQ3_시네마틱Cinematic02Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                return new StateQ3_시네마틱Cinematic02(context);
            }

            public override void OnExit() { }
        }

        private class StateQ3_시네마틱Cinematic02 : TriggerState {
            internal StateQ3_시네마틱Cinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 4001, enabled: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                return new StateQ3_시네마틱Cinematic03(context);
            }

            public override void OnExit() { }
        }

        private class StateQ3_시네마틱Cinematic03 : TriggerState {
            internal StateQ3_시네마틱Cinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "26", seconds: 3);
                context.SetConversation(type: 2, spawnId: 11001316, script: "$52010005_QD__ACT03__1$", arg4: 3);
                context.SetSkip(state: new StateQ3_시네마틱Cinematic04(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "26")) {
                    return new StateQ3_시네마틱Cinematic04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ3_시네마틱Cinematic04 : TriggerState {
            internal StateQ3_시네마틱Cinematic04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateQ3_시네마틱Cinematic05(context);
            }

            public override void OnExit() { }
        }

        private class StateQ3_시네마틱Cinematic05 : TriggerState {
            internal StateQ3_시네마틱Cinematic05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "27", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "27")) {
                    return new StateQ3_미카Exit01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ3_미카Exit01 : TriggerState {
            internal StateQ3_미카Exit01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "30", seconds: 2);
                context.MoveNpc(spawnId: 601, patrolName: "MS2PatrolData_6013");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "30")) {
                    return new StateQ3_미카Exit02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ3_미카Exit02 : TriggerState {
            internal StateQ3_미카Exit02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "31", seconds: 3);
                context.SetConversation(type: 2, spawnId: 11001285, script: "$52010005_QD__ACT03__2$", arg4: 3);
                context.SetSkip(state: new StateQ3_미카Exit03(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "31")) {
                    return new StateQ3_미카Exit03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateQ3_미카Exit03 : TriggerState {
            internal StateQ3_미카Exit03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 601, patrolName: "MS2PatrolData_6014");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 8010, spawnIds: new []{601})) {
                    return new StateQ3_미카Exit04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ3_미카Exit04 : TriggerState {
            internal StateQ3_미카Exit04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{601});
                context.SetTimer(timerId: "40", seconds: 1);
                context.CameraSelect(triggerId: 4001, enabled: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "40")) {
                    return new StateQ3_Achievement(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ3_Achievement : TriggerState {
            internal StateQ3_Achievement(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 9001, type: "trigger", code: "Intothememory");
                context.DestroyMonster(spawnIds: new []{501});
                context.CreateMonster(spawnIds: new []{502}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{10002823}, questStates: new byte[]{2})) {
                    return new StateQ3_UserExit01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ3_UserExit01 : TriggerState {
            internal StateQ3_UserExit01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "41", seconds: 2);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "41")) {
                    return new StateQ3_UserExit02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateQ3_UserExit02 : TriggerState {
            internal StateQ3_UserExit02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "42", seconds: 4);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(type: 2, spawnId: 11001316, script: "$52010005_QD__ACT03__3$", arg4: 4);
                context.SetSkip(state: new StateQ3_UserExit03(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "42")) {
                    return new StateQ3_UserExit03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateQ3_UserExit03 : TriggerState {
            internal StateQ3_UserExit03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.MoveUser(mapId: 02010026, portalId: 3, boxId: 9000);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
