namespace Maple2.Trigger._02000292_bf {
    public static class _npc7 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000626}, arg2: 1);
                context.DestroyMonster(arg1: new[] {1106});
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000626}, arg2: 0)) {
                    return new StateNPC대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC대사 : TriggerState {
            internal StateNPC대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000626}, arg2: 2);
                context.CreateMonster(arg1: new[] {1106});
                context.SetConversation(arg1: 1, arg2: 1106, arg3: "$02000292_BF__NPC7__0$", arg4: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1106, arg3: "$02000292_BF__NPC7__1$", arg4: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy : TriggerState {
            internal StateNPCDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1106});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}