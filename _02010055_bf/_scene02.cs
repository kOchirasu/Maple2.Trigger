namespace Maple2.Trigger._02010055_bf {
    public static class _scene02 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    return new StateRoomCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRoomCheck : TriggerState {
            internal StateRoomCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.IsDungeonRoom()) {
                    return new State난이도체크(context);
                }

                if (!context.IsDungeonRoom()) {
                    return new StateQuest던전대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State난이도체크 : TriggerState {
            internal State난이도체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetDungeonLevel() == 2) {
                    return new State레이드대기(context);
                }

                if (context.GetDungeonLevel() == 3) {
                    // return new State카오스레이드(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest던전대기 : TriggerState {
            internal StateQuest던전대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2299})) {
                    return new State영상준비(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레이드대기 : TriggerState {
            internal State레이드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2099})) {
                    return new State영상준비(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카오스레이드대기 : TriggerState {
            internal State카오스레이드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2199})) {
                    return new State영상준비(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematicDelay : TriggerState {
            internal StateStartCinematicDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
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
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 302, arg2: true);
                context.CreateMonster(arg1: new[] {1002, 1003, 1004}, arg2: false);
                context.SetSkip(arg1: "NPC이동");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State스타츠대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스타츠대사01 : TriggerState {
            internal State스타츠대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(arg1: "NPC이동");
                context.SetConversation(arg1: 2, arg2: 11001292, arg3: "$02010055_BF__SCENE02__0$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State타라대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State타라대사01 : TriggerState {
            internal State타라대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(arg1: "NPC이동");
                context.SetConversation(arg1: 2, arg2: 11001218, arg3: "$02010055_BF__SCENE02__1$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State스타츠대사02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스타츠대사02 : TriggerState {
            internal State스타츠대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(arg1: "NPC이동");
                context.SetConversation(arg1: 2, arg2: 11001292, arg3: "$02010055_BF__SCENE02__2$", arg4: 3);
            }

            public override TriggerState Execute() {
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
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 302, arg2: false);
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_A");
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_A");
                context.MoveNpc(arg1: 1004, arg2: "MS2PatrolData_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.DestroyMonster(arg1: new[] {1002, 1003, 1004});
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상준비 : TriggerState {
            internal State영상준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetTimer(arg1: "21", arg2: 10);
                context.CameraSelectPath(arg1: new[] {601, 602}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "21")) {
                    return new State영상재생(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상재생 : TriggerState {
            internal State영상재생(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.PlaySceneMovie(fileName: @"common\KarKarBossEvent.usm", movieId: 1);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
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

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}