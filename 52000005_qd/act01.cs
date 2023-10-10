using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000005_qd {
    public static class _act01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{103, 202}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{10002781}, questStates: new byte[]{1})) {
                    return new StateDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay01 : TriggerState {
            internal StateDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.DestroyMonster(spawnIds: new []{103, 202});
                context.SetTimer(timerId: "1", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State영감대화Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영감대화Prepare : TriggerState {
            internal State영감대화Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                return new State영감대화01(context);
            }

            public override void OnExit() { }
        }

        private class State영감대화01 : TriggerState {
            internal State영감대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 3);
                context.SetConversation(type: 2, spawnId: 11000031, script: "$52000005_QD__ACT01__0$", arg4: 3);
                context.SetSkip(state: new State영감대화02Wait(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State영감대화02Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영감대화02Wait : TriggerState {
            internal State영감대화02Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new State영감대화02(context);
            }

            public override void OnExit() { }
        }

        private class State영감대화02 : TriggerState {
            internal State영감대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
                context.SetConversation(type: 2, spawnId: 11000001, script: "$52000005_QD__ACT01__1$", arg4: 3);
                context.CreateMonster(spawnIds: new []{101, 201}, arg2: true);
                context.SetSkip(state: new State여제입장01(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State여제입장01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State여제입장01 : TriggerState {
            internal State여제입장01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetTimer(timerId: "10", seconds: 1);
                context.CameraSelect(triggerId: 601, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "10")) {
                    return new StateDelay03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay03 : TriggerState {
            internal StateDelay03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "12", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "12")) {
                    return new State여제대화01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State여제대화01 : TriggerState {
            internal State여제대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "20", seconds: 3);
                context.SetConversation(type: 2, spawnId: 11000075, script: "$52000005_QD__ACT01__2$", arg4: 3);
                context.SetSkip(state: new State영상Prepare(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "20")) {
                    return new State영상Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상Prepare : TriggerState {
            internal State영상Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetTimer(timerId: "21", seconds: 3);
                context.CameraSelectPath(pathIds: new []{601, 602}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "21")) {
                    return new State영상재생(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상재생 : TriggerState {
            internal State영상재생(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(type: WidgetType.SceneMovie);
                context.WidgetAction(type: WidgetType.SceneMovie, name: "Clear");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.PlaySceneMovie(fileName: "lumieragonhistory.swf", movieId: 1);
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, condition: "IsStop", value: "1")) {
                    return new State영상종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상종료 : TriggerState {
            internal State영상종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "31", seconds: 4);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(type: 2, spawnId: 11000075, script: "$52000005_QD__ACT01__3$", arg4: 4);
                context.SetSkip(state: new StateStopCinematic(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "31")) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateAchievement(context);
            }

            public override void OnExit() { }
        }

        private class StateAchievement : TriggerState {
            internal StateAchievement(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 9001, type: "trigger", code: "Lumieragon_History");
                context.CameraSelect(triggerId: 601, enabled: false);
                context.CameraSelect(triggerId: 602, enabled: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
