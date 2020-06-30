using System;

namespace Maple2.Trigger._02000461_bf {
    public static class _cannon_03 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {693}, arg2: false);
                context.SetEffect(arg1: new int[] {793}, arg2: false);
                context.SetMesh(arg1: new int[] {3903}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserValue(key: "cannon03", value: 1)) {
                    context.State = new State생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State생성 : TriggerState {
            internal State생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2903}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2903})) {
                    context.SetEffect(arg1: new int[] {693}, arg2: true);
                    context.SetMesh(arg1: new int[] {3903}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                    context.State = new State보스전_대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스전_대기 : TriggerState {
            internal State보스전_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "Bosscannon03", value: 1)) {
                    context.State = new State보스전용_생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스전용_생성 : TriggerState {
            internal State보스전용_생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {693}, arg2: false);
                context.SetEffect(arg1: new int[] {793}, arg2: true);
                context.SetMesh(arg1: new int[] {3903}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new int[] {2903}, arg2: true);
                context.AddBuff(arg1: new int[] {2099}, arg2: 70002081, arg3: 1, arg4: true, arg5: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2903})) {
                    context.SetEffect(arg1: new int[] {693}, arg2: true);
                    context.SetEffect(arg1: new int[] {793}, arg2: false);
                    context.SetMesh(arg1: new int[] {3903}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                    context.AddBuff(arg1: new int[] {2099}, arg2: 70002082, arg3: 1, arg4: true, arg5: false);
                    context.AddBuff(arg1: new int[] {2903}, arg2: 40444001, arg3: 1, arg4: true, arg5: false);
                    context.State = new State보스전용_재생성대기(context);
                    return;
                }

                if (context.UserValue(key: "DungeonClear", value: 1)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스전용_재생성대기 : TriggerState {
            internal State보스전용_재생성대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 90000)) {
                    context.State = new State보스전용_생성(context);
                    return;
                }

                if (context.UserValue(key: "DungeonClear", value: 1)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {693}, arg2: false);
                context.SetEffect(arg1: new int[] {793}, arg2: false);
                context.SetMesh(arg1: new int[] {3903}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.DestroyMonster(arg1: new int[] {2903});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}