using System;

namespace Maple2.Trigger._99999840 {
    public static class _badmob_message {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DungeonVariable(varID: 2, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 3, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 911, value: true)) {
                    context.State = new State쫄몹1(context);
                    return;
                }

                if (context.DungeonVariable(varID: 912, value: true)) {
                    context.State = new State쫄몹2(context);
                    return;
                }

                if (context.DungeonVariable(varID: 913, value: true)) {
                    context.State = new State쫄몹3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State쫄몹1 : TriggerState {
            internal State쫄몹1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: @"방해쫄몹1이 생성되었습니다.\n모두 처치하기 전까지는 자원을 넣을 수 없습니다.",
                    arg3: new int[] {5000});
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 2, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 3, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State쫄몹2 : TriggerState {
            internal State쫄몹2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: @"방해쫄몹2가 생성되었습니다.\n모두 처치하기 전까지는 자원을 넣을 수 없습니다.",
                    arg3: new int[] {5000});
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 2, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 3, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State쫄몹3 : TriggerState {
            internal State쫄몹3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: @"방해쫄몹3이 생성되었습니다.\n모두 처치하기 전까지는 자원을 넣을 수 없습니다.",
                    arg3: new int[] {5000});
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 2, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 3, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State대기(context);
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