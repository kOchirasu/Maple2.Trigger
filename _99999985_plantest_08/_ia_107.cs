namespace Maple2.Trigger._99999985_plantest_08 {
    public static class _ia_107 {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000006}, arg2: 1);
                context.SetActor(arg1: 1071, arg2: true, arg3: "SOS_B");
            }

            public override void Execute() {
                if (true) {
                    context.State = new State오브젝트반응(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new[] {303});
            }
        }

        private class State오브젝트반응 : TriggerState {
            internal State오브젝트반응(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000006}, arg2: 0)) {
                    context.State = new StateNPC이동(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetActor(arg1: 1071, arg2: false, arg3: "SOS_B");
                context.DestroyMonster(arg1: new[] {303});
                context.CreateMonster(arg1: new[] {107});
            }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 107, arg2: "MS2PatrolData107");
                context.SetConversation(arg1: 1, arg2: 107, arg3: "$02000116_BF__IA_107__0$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 107, arg3: "$02000116_BF__IA_107__1$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 107, arg2: new[] {107})) {
                    context.State = new StateNPC소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC소멸 : TriggerState {
            internal StateNPC소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {107});
                context.SetTimer(arg1: "107", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "107")) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}