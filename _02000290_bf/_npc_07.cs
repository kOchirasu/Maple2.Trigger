namespace Maple2.Trigger._02000290_bf {
    public static class _npc_07 {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6001, 6002}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000464}, arg2: 1);
                context.SetActor(arg1: 9007, arg2: true, arg3: "Down_Idle_A");
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000464}, arg2: 0)) {
                    context.State = new StateNPC대사(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetActor(arg1: 9007, arg2: false, arg3: "Down_Idle_A");
                context.SetUserValue(triggerId: 9999995, key: "dungeonclear", value: 1);
            }
        }

        private class StateNPC대사 : TriggerState {
            internal StateNPC대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {907});
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.SetEffect(arg1: new[] {6001}, arg2: true);
                    context.SetConversation(arg1: 1, arg2: 907, arg3: "$02000290_BF__NPC_07__0$", arg4: 3);
                    context.State = new StateNPC이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "4", arg2: 4);
                context.MoveNpc(arg1: 907, arg2: "MS2PatrolData907");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.SetEffect(arg1: new[] {6002}, arg2: true);
                    context.SetConversation(arg1: 1, arg2: 907, arg3: "$02000290_BF__NPC_07__1$", arg4: 3);
                    context.State = new StateNPC소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC소멸 : TriggerState {
            internal StateNPC소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}