using System;

namespace Maple2.Trigger._02000294_bf {
    public static class _main2 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {10001});
                context.DestroyMonster(arg1: new int[] {10002});
                context.DestroyMonster(arg1: new int[] {10003});
                context.DestroyMonster(arg1: new int[] {10004});
            }

            public override void Execute() {
                if (context.UserValue(key: "Battle_01", value: 1)) {
                    context.State = new State트리거01진행(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거01진행 : TriggerState {
            internal State트리거01진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {10001}, arg2: false);
                context.CreateMonster(arg1: new int[] {10002}, arg2: false);
                context.CreateMonster(arg1: new int[] {10003}, arg2: false);
                context.CreateMonster(arg1: new int[] {10004}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State트리거02시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거02시작 : TriggerState {
            internal State트리거02시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 10001, arg2: "MS2PatrolData0");
                context.MoveNpc(arg1: 10002, arg2: "MS2PatrolData1");
                context.MoveNpc(arg1: 10003, arg2: "MS2PatrolData2");
                context.MoveNpc(arg1: 10004, arg2: "MS2PatrolData3");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}