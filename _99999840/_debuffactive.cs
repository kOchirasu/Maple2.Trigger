using System;

namespace Maple2.Trigger._99999840 {
    public static class _debuffactive {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DungeonVariable(varID: 811, value: true)) {
                    context.State = new State이동속도감소(context);
                    return;
                }

                if (context.DungeonVariable(varID: 812, value: true)) {
                    context.State = new State공격력감소(context);
                    return;
                }

                if (context.DungeonVariable(varID: 813, value: true)) {
                    context.State = new State체력감소(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동속도감소 : TriggerState {
            internal State이동속도감소(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varID: 811, value: false);
                context.SetEventUI(arg1: 1, arg2: "이동속도 감소 디버프에 걸립니다.", arg3: new int[] {5000});
                context.AddBuff(arg1: new int[] {9001}, arg2: 70002581, arg3: 1, arg5: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State공격력감소 : TriggerState {
            internal State공격력감소(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varID: 812, value: false);
                context.SetEventUI(arg1: 1, arg2: "공격력 감소 디버프에 걸립니다.", arg3: new int[] {5000});
                context.AddBuff(arg1: new int[] {9001}, arg2: 70002591, arg3: 1, arg5: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State체력감소 : TriggerState {
            internal State체력감소(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varID: 813, value: false);
                context.SetEventUI(arg1: 1, arg2: "체력 감소 디버프에 걸립니다.", arg3: new int[] {5000});
                context.AddBuff(arg1: new int[] {9001}, arg2: 70002601, arg3: 1, arg5: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}