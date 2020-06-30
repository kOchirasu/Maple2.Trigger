using System;

namespace Maple2.Trigger._02000296_bf {
    public static class _release13 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {5011, 50111, 50112});
                context.SetInteractObject(arg1: new int[] {10000503}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000503}, arg2: 0)) {
                    context.State = new StateNpcSpawn01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcSpawn01 : TriggerState {
            internal StateNpcSpawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {5011, 50111, 50112});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateNpcMove01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcMove01 : TriggerState {
            internal StateNpcMove01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 5011, arg3: "$02000296_BF__NPC4__0$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 50111, arg3: "$02000296_BF__NPC11__0$", arg4: 2, arg5: 1);
                context.SetConversation(arg1: 1, arg2: 50112, arg3: "$02000296_BF__NPC12__0$", arg4: 2, arg5: 2);
                context.MoveNpc(arg1: 5011, arg2: "MS2PatrolData2");
                context.MoveNpc(arg1: 50111, arg2: "MS2PatrolData2");
                context.MoveNpc(arg1: 50112, arg2: "MS2PatrolData2");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateNpcRemove01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcRemove01 : TriggerState {
            internal StateNpcRemove01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {5011, 50111, 50112});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}