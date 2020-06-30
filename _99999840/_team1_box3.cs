using System;

namespace Maple2.Trigger._99999840 {
    public static class _team1_box3 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varID: 903, value: false);
                context.SetInteractObject(arg1: new int[] {10002177}, arg2: 0, arg3: false);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 911, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 912, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 913, value: true)) {
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
                context.SetInteractObject(arg1: new int[] {10002175}, arg2: 1, arg3: false);
                context.SetInteractObject(arg1: new int[] {10002176}, arg2: 1, arg3: false);
                context.SetInteractObject(arg1: new int[] {10002177}, arg2: 1, arg3: false);
                context.SetInteractObject(arg1: new int[] {10002178}, arg2: 1, arg3: false);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 911, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 912, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 913, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002177}, arg2: 0)) {
                    context.State = new State애디셔널_중첩1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State애디셔널_중첩1 : TriggerState {
            internal State애디셔널_중첩1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varID: 903, value: true);
                context.AddBuff(arg1: new int[] {9001}, arg2: 70002511, arg3: 1, arg5: false);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 911, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 912, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 913, value: true)) {
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
                context.AddBuff(arg1: new int[] {9001}, arg2: 70002511, arg3: 1, arg5: false);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 911, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 912, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 913, value: true)) {
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
                context.AddBuff(arg1: new int[] {9001}, arg2: 70002511, arg3: 1, arg5: false);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 911, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 912, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 913, value: true)) {
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
                context.AddBuff(arg1: new int[] {9001}, arg2: 70002511, arg3: 1, arg5: false);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 911, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 912, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 913, value: true)) {
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
                context.AddBuff(arg1: new int[] {9001}, arg2: 70002511, arg3: 1, arg5: false);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 911, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 912, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 913, value: true)) {
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
                context.AddBuff(arg1: new int[] {9001}, arg2: 70002511, arg3: 1, arg5: false);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 911, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 912, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 913, value: true)) {
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
                context.AddBuff(arg1: new int[] {9001}, arg2: 70002511, arg3: 1, arg5: false);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 911, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 912, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 913, value: true)) {
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
                context.AddBuff(arg1: new int[] {9001}, arg2: 70002511, arg3: 1, arg5: false);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 911, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 912, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 913, value: true)) {
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
                context.AddBuff(arg1: new int[] {9001}, arg2: 70002511, arg3: 1, arg5: false);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 911, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 912, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 913, value: true)) {
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
                context.SetInteractObject(arg1: new int[] {10002177}, arg2: 0, arg3: false);
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