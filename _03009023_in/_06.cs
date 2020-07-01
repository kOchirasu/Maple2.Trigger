namespace Maple2.Trigger._03009023_in {
    public static class _06 {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000238}, arg2: 1);
                context.CreateMonster(arg1: new[] {106}, arg2: true);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000238}, arg2: 0)) {
                    context.State = new StateNPC이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 8);
                context.DestroyMonster(arg1: new[] {106});
                context.CreateMonster(arg1: new[] {206}, arg2: true);
                context.MoveNpc(arg1: 206, arg2: "MS2PatrolData_206");
                context.SetConversation(arg1: 1, arg2: 206, arg3: "$03009023_IN__06__0$", arg4: 4, arg5: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateNPC소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC소멸 : TriggerState {
            internal StateNPC소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {206});
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