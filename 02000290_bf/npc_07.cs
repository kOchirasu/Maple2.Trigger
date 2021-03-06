namespace Maple2.Trigger._02000290_bf {
    public static class _npc_07 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6001, 6002}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000464}, arg2: 1);
                context.SetActor(arg1: 9007, arg2: true, arg3: "Down_Idle_A");
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000464}, arg2: 0)) {
                    return new StateNPCScript(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetActor(arg1: 9007, arg2: false, arg3: "Down_Idle_A");
                context.SetUserValue(triggerId: 9999995, key: "dungeonclear", value: 1);
            }
        }

        private class StateNPCScript : TriggerState {
            internal StateNPCScript(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {907});
                context.SetTimer(id: "2", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.SetEffect(arg1: new[] {6001}, arg2: true);
                    context.SetConversation(arg1: 1, arg2: 907, script: "$02000290_BF__NPC_07__0$", arg4: 3);
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "4", arg2: 4);
                context.MoveNpc(arg1: 907, arg2: "MS2PatrolData907");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.SetEffect(arg1: new[] {6002}, arg2: true);
                    context.SetConversation(arg1: 1, arg2: 907, script: "$02000290_BF__NPC_07__1$", arg4: 3);
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy : TriggerState {
            internal StateNPCDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}