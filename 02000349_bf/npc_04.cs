namespace Maple2.Trigger._02000349_bf {
    public static class _npc_04 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {904});
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000809}, arg2: 0)) {
                    return new StateNPCScript(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCScript : TriggerState {
            internal StateNPCScript(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "2", arg2: 2);
                context.SetConversation(arg1: 1, arg2: 904, script: "$02000349_BF__NPC_04__0$", arg4: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "3", arg2: 3);
                context.MoveNpc(arg1: 904, arg2: "MS2PatrolData904");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy : TriggerState {
            internal StateNPCDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {904});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}