namespace Maple2.Trigger._02000116_bf {
    public static class _ia_111 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000010}, arg2: 1);
                context.SetActor(arg1: 1111, arg2: true, arg3: "SOS_B");
            }

            public override TriggerState Execute() {
                return new StateInteractObject(context);
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new[] {307});
            }
        }

        private class StateInteractObject : TriggerState {
            internal StateInteractObject(ITriggerContext context) : base(context) { }

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
                context.SetConversation(arg1: 1, arg2: 111, script: "$02000116_BF__IA_111__0$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 111, script: "$02000116_BF__IA_111__1$", arg4: 2, arg5: 2);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 111, arg2: new[] {111})) {
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy : TriggerState {
            internal StateNPCDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {111});
                context.SetTimer(id: "111", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "111")) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}