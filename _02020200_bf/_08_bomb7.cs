using System;

namespace Maple2.Trigger._02020200_bf {
    public static class _08_bomb7 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "BombOn", value: 1)) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {311}, arg2: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "BombOn", value: 2)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {311})) {
                    context.State = new State폭탄_터짐(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State폭탄_터짐 : TriggerState {
            internal State폭탄_터짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {2007}, arg2: false, arg3: 1500, arg5: 3f);
            }

            public override void Execute() {
                if (context.UserValue(key: "BombOn", value: 2)) {
                    context.State = new State종료(context);
                    return;
                }

                if (true) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기시간 : TriggerState {
            internal State대기시간(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "BombOn", value: 2)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 40000)) {
                    context.SetMesh(arg1: new int[] {2007}, arg2: true, arg5: 3f);
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {311});
                context.SetMesh(arg1: new int[] {2007}, arg2: false, arg3: 1500, arg5: 3f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}