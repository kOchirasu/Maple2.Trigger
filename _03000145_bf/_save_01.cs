using System;

namespace Maple2.Trigger._03000145_bf {
    public static class _save_01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State트리거초기화(context);

        private class State트리거초기화 : TriggerState {
            internal State트리거초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 1);
                context.SetMesh(arg1: new int[] {1001}, arg2: false, arg5: 1f);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000467}, arg2: 1);
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
                context.CreateMonster(arg1: new int[] {103}, arg2: false);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000467}, arg2: 0)) {
                    context.State = new State문열림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문열림 : TriggerState {
            internal State문열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetMesh(arg1: new int[] {1001}, arg2: true, arg5: 1f);
                context.DestroyMonster(arg1: new int[] {101});
                context.DestroyMonster(arg1: new int[] {102});
                context.DestroyMonster(arg1: new int[] {103});
                context.CreateMonster(arg1: new int[] {111}, arg2: false);
                context.CreateMonster(arg1: new int[] {112}, arg2: false);
                context.CreateMonster(arg1: new int[] {113}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State도망갈준비1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망갈준비1 : TriggerState {
            internal State도망갈준비1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
                context.SetConversation(arg1: 1, arg2: 111, arg3: "$03000145_BF__SAVE_01__0$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State도망갈준비2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망갈준비2 : TriggerState {
            internal State도망갈준비2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetConversation(arg1: 1, arg2: 112, arg3: "$03000145_BF__SAVE_01__1$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State도망갈준비3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망갈준비3 : TriggerState {
            internal State도망갈준비3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "4", arg2: 1);
                context.SetConversation(arg1: 1, arg2: 113, arg3: "$03000145_BF__SAVE_01__2$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new State도망시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망시작 : TriggerState {
            internal State도망시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 111, arg2: "MS2PatrolData_111");
                context.MoveNpc(arg1: 112, arg2: "MS2PatrolData_112");
                context.MoveNpc(arg1: 113, arg2: "MS2PatrolData_113");
            }

            public override void Execute() {
                if (true) {
                    context.State = new State도망중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망중 : TriggerState {
            internal State도망중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "6", arg2: 3);
                context.SetConversation(arg1: 1, arg2: 111, arg3: "$03000145_BF__SAVE_01__3$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 112, arg3: "$03000145_BF__SAVE_01__4$", arg4: 2, arg5: 1);
                context.SetConversation(arg1: 1, arg2: 113, arg3: "$03000145_BF__SAVE_01__5$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    context.State = new State도망끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망끝 : TriggerState {
            internal State도망끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "7", arg2: 10);
                context.DestroyMonster(arg1: new int[] {111});
                context.DestroyMonster(arg1: new int[] {112});
                context.DestroyMonster(arg1: new int[] {113});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "7")) {
                    context.State = new State트리거초기화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}