namespace Maple2.Trigger._03000145_bf {
    public static class _save_04 {
        public class State트리거초기화 : TriggerState {
            internal State트리거초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 1);
                context.SetMesh(arg1: new[] {4001}, arg2: false, arg5: 1f);
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
                context.SetInteractObject(arg1: new[] {10000470}, arg2: 1);
                context.CreateMonster(arg1: new[] {401, 402}, arg2: false);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000470}, arg2: 0)) {
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
                context.SetMesh(arg1: new[] {4001}, arg2: true, arg5: 1f);
                context.DestroyMonster(arg1: new[] {401, 402});
                context.CreateMonster(arg1: new[] {411, 412}, arg2: false);
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
                context.SetConversation(arg1: 1, arg2: 411, arg3: "$03000145_BF__SAVE_04__0$", arg4: 2, arg5: 0);
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
                context.SetConversation(arg1: 1, arg2: 412, arg3: "$03000145_BF__SAVE_04__1$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State도망시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망시작 : TriggerState {
            internal State도망시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 411, arg2: "MS2PatrolData_411");
                context.MoveNpc(arg1: 412, arg2: "MS2PatrolData_412");
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
                context.SetConversation(arg1: 1, arg2: 411, arg3: "$03000145_BF__SAVE_04__2$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 412, arg3: "$03000145_BF__SAVE_04__3$", arg4: 2, arg5: 1);
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
                context.DestroyMonster(arg1: new[] {411, 412});
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