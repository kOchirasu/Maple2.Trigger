using System;

namespace Maple2.Trigger._02000524_bf {
    public static class _bossspawn {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "101")) {
                    context.State = new State난이도별보스등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State난이도별보스등장 : TriggerState {
            internal State난이도별보스등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DungeonID(dungeonID: 23046003)) {
                    context.State = new State일반난이도_보스등장(context);
                    return;
                }

                if (context.DungeonID(dungeonID: 23047003)) {
                    context.State = new State어려움난이도_보스등장(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1100)) {
                    context.State = new State일반난이도_보스등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State일반난이도_보스등장 : TriggerState {
            internal State일반난이도_보스등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.CreateMonster(arg1: new int[] {98}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {98})) {
                    context.State = new State클리어처리(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어려움난이도_보스등장 : TriggerState {
            internal State어려움난이도_보스등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.CreateMonster(arg1: new int[] {99}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {99})) {
                    context.State = new State클리어처리(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State클리어처리 : TriggerState {
            internal State클리어처리(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.DungeonClear();
                    context.State = new State종료처리(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료처리 : TriggerState {
            internal State종료처리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {-1});
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}