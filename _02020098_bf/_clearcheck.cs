using System;

namespace Maple2.Trigger._02020098_bf {
    public static class _clearcheck {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {10})) {
                    context.State = new State클리어성공유무체크시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State클리어성공유무체크시작 : TriggerState {
            internal State클리어성공유무체크시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "BossDead", value: 1)) {
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

        private class State연출딜레이 : TriggerState {
            internal State연출딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg3: "BalrogMagicBursterKritiasClear");
                context.DungeonSetEndTime();
                context.DungeonCloseTimer();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
                context.SetMesh(arg1: new int[] {301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311}, arg2: false,
                    arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State종료(context);
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
                context.SetMesh(arg1: new int[] {301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311}, arg2: false,
                    arg3: 0, arg4: 0, arg5: 0f);
                context.DestroyMonster(arg1: new int[] {-1});
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 4, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 5, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 6, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 7, arg2: true, arg3: true, arg4: true);
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
    }
}