namespace Maple2.Trigger._03009023_in {
    public static class _01 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000219}, arg2: 1);
                context.CreateMonster(arg1: new[] {101}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000219}, arg2: 0)) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 8);
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {201}, arg2: true);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_201");
                context.SetConversation(arg1: 1, arg2: 201, script: "$03009023_IN__01__0$", arg4: 4, arg5: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy : TriggerState {
            internal StateNPCDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {201});
                context.SetTimer(id: "1", arg2: 10);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}