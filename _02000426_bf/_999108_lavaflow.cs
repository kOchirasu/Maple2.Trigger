using System;

namespace Maple2.Trigger._02000426_bf {
    public static class _999108_lavaflow {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State전투체크(context);

        private class State전투체크 : TriggerState {
            internal State전투체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckUser()) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {600}, arg2: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "LavaflowLeft", value: 1)) {
                    context.State = new State왼쪽용암생성(context);
                    return;
                }

                if (context.UserValue(key: "BattleEnd2", value: 1)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State왼쪽용암생성 : TriggerState {
            internal State왼쪽용암생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 999108, key: "LavaflowLeft", value: 0);
                context.SetUserValue(triggerID: 999108, key: "LavaflowLeftStop", value: 0);
                context.SetEffect(arg1: new int[] {600}, arg2: true);
                context.CreateMonster(arg1: new int[] {1002}, arg2: false);
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002A");
            }

            public override void Execute() {
                if (context.UserValue(key: "LavaflowLeftStop", value: 1)) {
                    context.State = new State왼쪽용암내려가기(context);
                    return;
                }

                if (context.UserValue(key: "BattleEnd2", value: 1)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State왼쪽용암내려가기 : TriggerState {
            internal State왼쪽용암내려가기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 999108, key: "LavaflowLeft", value: 0);
                context.SetUserValue(triggerID: 999108, key: "LavaflowLeftStop", value: 0);
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002C");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.DestroyMonster(arg1: new int[] {1002});
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {1002});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}