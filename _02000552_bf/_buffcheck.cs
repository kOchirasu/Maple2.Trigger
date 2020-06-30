using System;

namespace Maple2.Trigger._02000552_bf {
    public static class _buffcheck {
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
                context.SetUserValue(key: "MonsterMany", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State트리거작동시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거작동시작 : TriggerState {
            internal State트리거작동시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "MonsterMany", value: 1, @operator: "GreaterEqual")) {
                    context.State = new State블랙빈에게버프부여(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State블랙빈에게버프부여 : TriggerState {
            internal State블랙빈에게버프부여(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {101}, arg2: 50003307, arg3: 2, arg4: true);
                context.AddBuff(arg1: new int[] {102}, arg2: 50003307, arg3: 2, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State블랙빈에게버프삭제체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State블랙빈에게버프삭제체크 : TriggerState {
            internal State블랙빈에게버프삭제체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "MonsterMany", value: 0)) {
                    context.State = new State블랙빈에게버프삭제대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State블랙빈에게버프삭제대기 : TriggerState {
            internal State블랙빈에게버프삭제대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 900)) {
                    context.State = new State블랙빈에게버프삭제실시(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State블랙빈에게버프삭제실시 : TriggerState {
            internal State블랙빈에게버프삭제실시(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {101}, arg2: 50003309, arg3: 1, arg4: true);
                context.AddBuff(arg1: new int[] {102}, arg2: 50003309, arg3: 1, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State트리거작동시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}