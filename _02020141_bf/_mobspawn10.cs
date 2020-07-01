using System;

namespace Maple2.Trigger._02020141_bf {
    public static class _mobspawn10 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckUser()) {
                    context.State = new State보스등장때까지잠시대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스등장때까지잠시대기 : TriggerState {
            internal State보스등장때까지잠시대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State트리거영역체크시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거영역체크시작 : TriggerState {
            internal State트리거영역체크시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "MobSpawnStop", value: 4)) {
                    context.State = new State졸몬스터제거작업(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {99})) {
                    context.State = new State졸몬스터제거작업(context);
                    return;
                }

                if (context.UserDetected(arg1: new int[] {11000})) {
                    context.State = new State졸몬스터등장대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State졸몬스터등장대기중 : TriggerState {
            internal State졸몬스터등장대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State트리거영역안플레이어최종체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거영역안플레이어최종체크 : TriggerState {
            internal State트리거영역안플레이어최종체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "MobSpawnStop", value: 4)) {
                    context.State = new State졸몬스터제거작업(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {99})) {
                    context.State = new State졸몬스터제거작업(context);
                    return;
                }

                if (context.UserDetected(arg1: new int[] {11000})) {
                    context.State = new State졸몬스터등장하기(context);
                    return;
                }

                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State트리거영역체크시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State졸몬스터등장하기 : TriggerState {
            internal State졸몬스터등장하기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {11001, 11002, 11003, 11004}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State트리거영역에계속있는지체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거영역에계속있는지체크 : TriggerState {
            internal State트리거영역에계속있는지체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "MobSpawnStop", value: 4)) {
                    context.State = new State졸몬스터제거작업(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {99})) {
                    context.State = new State졸몬스터제거작업(context);
                    return;
                }

                if (context.UserDetected(arg1: new int[] {11000})) {
                    context.State = new State졸몬스터리젠단계시작(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {11000})) {
                    context.State = new State졸몬스터제거작동대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State졸몬스터리젠단계시작 : TriggerState {
            internal State졸몬스터리젠단계시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {11000})) {
                    context.State = new State졸몬스터리젠대기중(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {11000})) {
                    context.State = new State졸몬스터제거작동대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State졸몬스터리젠대기중 : TriggerState {
            internal State졸몬스터리젠대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "MobSpawnStop", value: 4)) {
                    context.State = new State졸몬스터제거작업(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {99})) {
                    context.State = new State졸몬스터제거작업(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {11000})) {
                    context.State = new State졸몬스터제거작동대기(context);
                    return;
                }

                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new State졸몬스터리젠YesNo(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State졸몬스터리젠YesNo : TriggerState {
            internal State졸몬스터리젠YesNo(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "MobSpawnStop", value: 4)) {
                    context.State = new State졸몬스터제거작업(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {99})) {
                    context.State = new State졸몬스터제거작업(context);
                    return;
                }

                if (context.UserDetected(arg1: new int[] {11000})) {
                    context.State = new State졸몬스터등장하기(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {11000})) {
                    context.State = new State졸몬스터제거작동대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State졸몬스터제거작동대기 : TriggerState {
            internal State졸몬스터제거작동대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {11000})) {
                    context.State = new State트리거영역에계속있는지체크(context);
                    return;
                }

                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State졸몬스터제거작업(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State졸몬스터제거작업 : TriggerState {
            internal State졸몬스터제거작업(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {11001, 11002, 11003, 11004});
            }

            public override void Execute() {
                if (context.UserValue(key: "MobSpawnStop", value: 4)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {99})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State트리거영역체크시작(context);
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