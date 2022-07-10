using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02010055_bf {
    public static class _scene02 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    return new StateRoomCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRoomCheck : TriggerState {
            internal StateRoomCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.IsDungeonRoom()) {
                    return new State난이도체크(context);
                }

                if (!context.IsDungeonRoom()) {
                    return new StateQuestDungeonWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State난이도체크 : TriggerState {
            internal State난이도체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetDungeonLevel() == 2) {
                    return new State레이드Wait(context);
                }

                if (context.GetDungeonLevel() == 3) {
                    // return new State카오스레이드(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestDungeonWait : TriggerState {
            internal StateQuestDungeonWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2299})) {
                    return new State영상Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레이드Wait : TriggerState {
            internal State레이드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2099})) {
                    return new State영상Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카오스레이드Wait : TriggerState {
            internal State카오스레이드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2199})) {
                    return new State영상Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematicDelay : TriggerState {
            internal StateStartCinematicDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
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
                context.CameraSelect(triggerId: 302, enable: true);
                context.CreateMonster(spawnIds: new []{1002, 1003, 1004}, arg2: false);
                context.SetSkip(state: new StateNPC이동(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State스타츠Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스타츠Script01 : TriggerState {
            internal State스타츠Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(state: new StateNPC이동(context));
                context.SetConversation(type: 2, spawnId: 11001292, script: "$02010055_BF__SCENE02__0$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State타라Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State타라Script01 : TriggerState {
            internal State타라Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(state: new StateNPC이동(context));
                context.SetConversation(type: 2, spawnId: 11001218, script: "$02010055_BF__SCENE02__1$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State스타츠Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스타츠Script02 : TriggerState {
            internal State스타츠Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(state: new StateNPC이동(context));
                context.SetConversation(type: 2, spawnId: 11001292, script: "$02010055_BF__SCENE02__2$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 302, enable: false);
                context.MoveNpc(spawnId: 1002, patrolName: "MS2PatrolData_A");
                context.MoveNpc(spawnId: 1003, patrolName: "MS2PatrolData_A");
                context.MoveNpc(spawnId: 1004, patrolName: "MS2PatrolData_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.DestroyMonster(spawnIds: new []{1002, 1003, 1004});
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상Prepare : TriggerState {
            internal State영상Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetTimer(timerId: "21", seconds: 10);
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
                context.PlaySceneMovie(fileName: @"common\KarKarBossEvent.usm", movieId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, condition: "IsStop", value: "1")) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 10000)) {
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
