namespace Maple2.Trigger._02000296_bf {
    public static class _release10 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000500}, arg2: 1);
                context.DestroyMonster(arg1: new[] {5008, 50081, 50082});
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000500}, arg2: 0)) {
                    return new StateNpcSpawn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcSpawn01 : TriggerState {
            internal StateNpcSpawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {5008, 50081, 50082});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateNpcMove01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcMove01 : TriggerState {
            internal StateNpcMove01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 5008, script: "$02000296_BF__NPC1__0$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 50081, script: "$02000296_BF__NPC5__0$", arg4: 2, arg5: 1);
                context.SetConversation(arg1: 1, arg2: 50082, script: "$02000296_BF__NPC6__0$", arg4: 2, arg5: 2);
                context.MoveNpc(arg1: 5008, arg2: "MS2PatrolData2");
                context.MoveNpc(arg1: 50081, arg2: "MS2PatrolData2");
                context.MoveNpc(arg1: 50082, arg2: "MS2PatrolData2");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateNpcRemove01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcRemove01 : TriggerState {
            internal StateNpcRemove01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {5008, 50081, 50082});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}