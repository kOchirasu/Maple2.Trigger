using System;

namespace Maple2.Trigger._02020141_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckUser()) {
                    context.State = new State기본셋팅(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State기본셋팅 : TriggerState {
            internal State기본셋팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {102})) {
                    context.State = new State보스등장준비(context);
                    return;
                }

                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State보스등장준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스등장준비 : TriggerState {
            internal State보스등장준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {301}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State보스등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스등장 : TriggerState {
            internal State보스등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {99}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1100)) {
                    context.State = new State클리어성공유무체크시작(context);
                    return;
                }

                if (context.DungeonTimeOut()) {
                    context.State = new State던전실패(context);
                    return;
                }

                if (context.DungeonCheckState(checkState: "Fail")) {
                    context.State = new State던전실패(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State클리어성공유무체크시작 : TriggerState {
            internal State클리어성공유무체크시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {99})) {
                    context.State = new State연출딜레이(context);
                    return;
                }

                if (context.DungeonTimeOut()) {
                    context.State = new State던전실패(context);
                    return;
                }

                if (context.DungeonCheckState(checkState: "Fail")) {
                    context.State = new State던전실패(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전실패 : TriggerState {
            internal State던전실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonSetEndTime();
                context.DungeonCloseTimer();
                context.DestroyMonster(arg1: new int[] {-1});
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.DungeonFail();
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonEnableGiveUp(isEnable: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State연출딜레이 : TriggerState {
            internal State연출딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionID: 23090000);
                context.SetAchievement(arg2: "trigger", arg3: "TurkaDungeonClear");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonSetEndTime();
                context.DungeonCloseTimer();
                context.DungeonClear();
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}