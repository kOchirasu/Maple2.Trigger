using System;

namespace Maple2.Trigger._99999841 {
    public static class _team2_box3 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varID: 913, value: false);
                context.SetInteractObject(arg1: new int[] {10002181}, arg2: 0, arg3: false);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 901, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 902, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 903, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.UserValue(key: "Start", value: 1)) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10002179}, arg2: 1, arg3: false);
                context.SetInteractObject(arg1: new int[] {10002180}, arg2: 1, arg3: false);
                context.SetInteractObject(arg1: new int[] {10002181}, arg2: 1, arg3: false);
                context.SetInteractObject(arg1: new int[] {10002182}, arg2: 1, arg3: false);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 901, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 902, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 903, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002181}, arg2: 0)) {
                    context.State = new State애디셔널_중첩1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State애디셔널_중첩1 : TriggerState {
            internal State애디셔널_중첩1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varID: 913, value: true);
                context.AddBuff(arg1: new int[] {9001}, arg2: 70002531, arg3: 1, arg5: false);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 901, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 902, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 903, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State애디셔널_중첩2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State애디셔널_중첩2 : TriggerState {
            internal State애디셔널_중첩2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {9001}, arg2: 70002531, arg3: 1, arg5: false);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 901, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 902, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 903, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State애디셔널_중첩3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State애디셔널_중첩3 : TriggerState {
            internal State애디셔널_중첩3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {9001}, arg2: 70002531, arg3: 1, arg5: false);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 901, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 902, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 903, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State애디셔널_중첩4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State애디셔널_중첩4 : TriggerState {
            internal State애디셔널_중첩4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {9001}, arg2: 70002531, arg3: 1, arg5: false);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 901, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 902, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 903, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State애디셔널_중첩5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State애디셔널_중첩5 : TriggerState {
            internal State애디셔널_중첩5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {9001}, arg2: 70002531, arg3: 1, arg5: false);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 901, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 902, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 903, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State애디셔널_중첩6(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State애디셔널_중첩6 : TriggerState {
            internal State애디셔널_중첩6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {9001}, arg2: 70002531, arg3: 1, arg5: false);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 901, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 902, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 903, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State애디셔널_중첩7(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State애디셔널_중첩7 : TriggerState {
            internal State애디셔널_중첩7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {9001}, arg2: 70002531, arg3: 1, arg5: false);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 901, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 902, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 903, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State애디셔널_중첩8(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State애디셔널_중첩8 : TriggerState {
            internal State애디셔널_중첩8(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {9001}, arg2: 70002531, arg3: 1, arg5: false);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 901, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 902, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 903, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State애디셔널_중첩9(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State애디셔널_중첩9 : TriggerState {
            internal State애디셔널_중첩9(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {9001}, arg2: 70002531, arg3: 1, arg5: false);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 901, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 902, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 903, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10002181}, arg2: 0, arg3: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "BadMob", value: 1)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}