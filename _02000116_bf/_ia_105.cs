namespace Maple2.Trigger._02000116_bf {
    public static class _ia_105 {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000004}, arg2: 1);
                context.SetActor(arg1: 1051, arg2: true, arg3: "SOS_B");
            }

            public override void Execute() {
                if (true) {
                    context.State = new State오브젝트반응(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new[] {301});
            }
        }

        private class State오브젝트반응 : TriggerState {
            internal State오브젝트반응(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000004}, arg2: 0)) {
                    context.State = new StateNPC이동(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetActor(arg1: 1051, arg2: false, arg3: "SOS_B");
                context.DestroyMonster(arg1: new[] {301});
                context.CreateMonster(arg1: new[] {105});
            }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 105, arg2: "MS2PatrolData105");
                context.SetConversation(arg1: 1, arg2: 105, arg3: "$02000116_BF__IA_105__0$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 105, arg3: "$02000116_BF__IA_105__1$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 105, arg2: new[] {105})) {
                    context.State = new StateNPC소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC소멸 : TriggerState {
            internal StateNPC소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {105});
                context.SetTimer(arg1: "105", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "105")) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}