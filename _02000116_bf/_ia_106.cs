namespace Maple2.Trigger._02000116_bf {
    public static class _ia_106 {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000005}, arg2: 1);
                context.SetActor(arg1: 1061, arg2: true, arg3: "SOS_B");
            }

            public override void Execute() {
                if (true) {
                    context.State = new State오브젝트반응(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new[] {302});
            }
        }

        private class State오브젝트반응 : TriggerState {
            internal State오브젝트반응(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000005}, arg2: 0)) {
                    context.State = new StateNPC이동(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetActor(arg1: 1061, arg2: false, arg3: "SOS_B");
                context.DestroyMonster(arg1: new[] {302});
                context.CreateMonster(arg1: new[] {106});
            }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 106, arg2: "MS2PatrolData106");
                context.SetConversation(arg1: 1, arg2: 106, arg3: "$02000116_BF__IA_106__0$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 106, arg3: "$02000116_BF__IA_106__1$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 106, arg2: new[] {106})) {
                    context.State = new StateNPC소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC소멸 : TriggerState {
            internal StateNPC소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {106});
                context.SetTimer(arg1: "106", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "106")) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}