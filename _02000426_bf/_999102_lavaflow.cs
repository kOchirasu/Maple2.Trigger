using System;

namespace Maple2.Trigger._02000426_bf {
    public static class _999102_lavaflow {
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
                if (context.UserValue(key: "LavaflowHigh", value: 1)) {
                    context.SetUserValue(triggerID: 999102, key: "LavaflowHigh", value: 0);
                    context.State = new State3칸이동(context);
                    return;
                }

                if (context.UserValue(key: "LavaflowLow", value: 1)) {
                    context.SetUserValue(triggerID: 999102, key: "LavaflowLow", value: 0);
                    context.State = new State2칸이동(context);
                    return;
                }

                if (context.UserValue(key: "BattleEnd2", value: 1)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3칸이동 : TriggerState {
            internal State3칸이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {600}, arg2: true);
                context.CreateMonster(arg1: new int[] {1001}, arg2: false);
                context.MoveNpc(arg1: 1001, arg2: "MS2PatrolData_1001A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 28000)) {
                    context.State = new State리턴(context);
                    return;
                }

                if (context.UserValue(key: "BattleEnd2", value: 1)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2칸이동 : TriggerState {
            internal State2칸이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {600}, arg2: true);
                context.CreateMonster(arg1: new int[] {1001}, arg2: false);
                context.MoveNpc(arg1: 1001, arg2: "MS2PatrolData_1001B");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 25000)) {
                    context.State = new State리턴(context);
                    return;
                }

                if (context.UserValue(key: "BattleEnd2", value: 1)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State리턴 : TriggerState {
            internal State리턴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1001, arg2: "MS2PatrolData_1001C");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.DestroyMonster(arg1: new int[] {1001});
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {1001});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}