namespace Maple2.Trigger._99999985_plantest_08 {
    public static class _ia_111 {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000010}, arg2: 1);
                context.SetActor(arg1: 1111, arg2: true, arg3: "SOS_B");
            }

            public override TriggerState Execute() {
                return new State오브젝트반응(context);
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new[] {307});
            }
        }

        private class State오브젝트반응 : TriggerState {
            internal State오브젝트반응(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000010}, arg2: 0)) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetActor(arg1: 1111, arg2: false, arg3: "SOS_B");
                context.DestroyMonster(arg1: new[] {307});
                context.CreateMonster(arg1: new[] {111});
            }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 111, arg2: "MS2PatrolData111");
                context.SetConversation(arg1: 1, arg2: 111, arg3: "$02000116_BF__IA_111__0$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 111, arg3: "$02000116_BF__IA_111__1$", arg4: 2, arg5: 2);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 111, arg2: new[] {111})) {
                    return new StateNPC소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC소멸 : TriggerState {
            internal StateNPC소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {111});
                context.SetTimer(arg1: "111", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "111")) {
                    return new State시작대기중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}