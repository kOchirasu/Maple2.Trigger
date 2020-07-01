using System;

namespace Maple2.Trigger._02010055_bf {
    public static class _scene02 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {101})) {
                    context.State = new State룸체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State룸체크 : TriggerState {
            internal State룸체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.IsDungeonRoom()) {
                    context.State = new State난이도체크(context);
                    return;
                }

                if (!context.IsDungeonRoom()) {
                    context.State = new State퀘스트던전대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State난이도체크 : TriggerState {
            internal State난이도체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DungeonLevel(level: 2)) {
                    context.State = new State레이드대기(context);
                    return;
                }

                if (context.DungeonLevel(level: 3)) {
                    // context.State = new State카오스레이드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트던전대기 : TriggerState {
            internal State퀘스트던전대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2299})) {
                    context.State = new State영상준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레이드대기 : TriggerState {
            internal State레이드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2099})) {
                    context.State = new State영상준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카오스레이드대기 : TriggerState {
            internal State카오스레이드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2199})) {
                    context.State = new State영상준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작딜레이 : TriggerState {
            internal State연출시작딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작 : TriggerState {
            internal State연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 302, arg2: true);
                context.CreateMonster(arg1: new int[] {1002, 1003, 1004}, arg2: false);
                context.SetSkip(arg1: "NPC이동");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State스타츠대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스타츠대사01 : TriggerState {
            internal State스타츠대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(arg1: "NPC이동");
                context.SetConversation(arg1: 2, arg2: 11001292, arg3: "$02010055_BF__SCENE02__0$", arg4: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State타라대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State타라대사01 : TriggerState {
            internal State타라대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(arg1: "NPC이동");
                context.SetConversation(arg1: 2, arg2: 11001218, arg3: "$02010055_BF__SCENE02__1$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State스타츠대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스타츠대사02 : TriggerState {
            internal State스타츠대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(arg1: "NPC이동");
                context.SetConversation(arg1: 2, arg2: 11001292, arg3: "$02010055_BF__SCENE02__2$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateNPC이동(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.DestroyMonster(arg1: new int[] {1002, 1003, 1004});
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State영상준비 : TriggerState {
            internal State영상준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetTimer(arg1: "21", arg2: 10);
                context.CameraSelectPath(arg1: new int[] {601, 602}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "21")) {
                    context.State = new State영상재생(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State영상재생 : TriggerState {
            internal State영상재생(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.PlaySceneMovie(fileName: @"common\KarKarBossEvent.usm", movieID: 1);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}