using System;

namespace Maple2.Trigger._02000551_bf {
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
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 3, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 4, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 5, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 6, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 7, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 8, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 9, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 21, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 22, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 23, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 24, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 25, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State난이도체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State난이도체크 : TriggerState {
            internal State난이도체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DungeonID(dungeonID: 23050003)) {
                    context.State = new State쉬운난이도보스등장(context);
                    return;
                }

                if (context.DungeonID(dungeonID: 23051003)) {
                    context.State = new State여려움난이도보스등장(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1100)) {
                    context.State = new State여려움난이도보스등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State여려움난이도보스등장 : TriggerState {
            internal State여려움난이도보스등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1800)) {
                    context.State = new State일러스트대화창(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State쉬운난이도보스등장 : TriggerState {
            internal State쉬운난이도보스등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1800)) {
                    context.State = new State일러스트대화창(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State일러스트대화창 : TriggerState {
            internal State일러스트대화창(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcID: 23000101, illust: "BlackBean_Smile",
                    script: "$02000551_BF__BOSSSPAWN__0$", duration: 7000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2100)) {
                    context.State = new State전투진행중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투진행중 : TriggerState {
            internal State전투진행중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "GuideMessage", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "GuideMessage", value: 1)) {
                    context.State = new State메시지출력(context);
                    return;
                }

                if (context.UserValue(key: "NextPortal", value: 1)) {
                    context.State = new State다음진행딜레이(context);
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

        private class State메시지출력 : TriggerState {
            internal State메시지출력(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 29200007, textID: 29200007, durationTime: 7000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    context.State = new State전투진행중(context);
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
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.DungeonFail();
                    context.State = new State게임오버(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State게임오버 : TriggerState {
            internal State게임오버(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonEnableGiveUp(isEnable: false);
                context.SetPortal(arg1: 21, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 22, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 23, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 24, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 25, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 11, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State다음진행딜레이 : TriggerState {
            internal State다음진행딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5800)) {
                    context.State = new State다음맵가는포탈등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다음맵가는포탈등장 : TriggerState {
            internal State다음맵가는포탈등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 4, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 5, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 6, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 7, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 8, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 9, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 11, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}