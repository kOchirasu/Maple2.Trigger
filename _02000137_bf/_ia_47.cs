namespace Maple2.Trigger._02000137_bf {
    public static class _ia_47 {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000047}, arg2: 1);
                context.CreateMonster(arg1: new[] {147});
            }

            public override void Execute() {
                if (true) {
                    context.State = new State오브젝트반응(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오브젝트반응 : TriggerState {
            internal State오브젝트반응(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000047}, arg2: 0)) {
                    context.State = new StateNPC탈출(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {147});
            }
        }

        private class StateNPC탈출 : TriggerState {
            internal StateNPC탈출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {148});
                context.SetConversation(arg1: 1, arg2: 148, arg3: "$02000137_BF__IA_47__0$", arg4: 2);
                context.SetTimer(arg1: "1", arg2: 5);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.DestroyMonster(arg1: new[] {148});
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기시간 : TriggerState {
            internal State대기시간(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 10);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}