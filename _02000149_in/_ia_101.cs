namespace Maple2.Trigger._02000149_in {
    public static class _ia_101 {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000190}, arg2: 1);
                context.SetActor(arg1: 201, arg2: true, arg3: "Sit_Chair_Idle_A");
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
                if (context.ObjectInteracted(arg1: new[] {10000190}, arg2: 0)) {
                    context.State = new StateNPC이동(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetActor(arg1: 201, arg2: false, arg3: "Sit_Chair_Idle_A");
                context.CreateMonster(arg1: new[] {401});
            }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 401, arg2: "MS2PatrolData_501");
                context.SetConversation(arg1: 1, arg2: 401, arg3: "$02000149_IN__IA_101__0$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 401, arg3: "$02000149_IN__IA_101__1$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 601, arg2: new[] {401})) {
                    context.State = new StateNPC소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC소멸 : TriggerState {
            internal StateNPC소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {401});
                context.SetTimer(arg1: "1", arg2: 5);
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