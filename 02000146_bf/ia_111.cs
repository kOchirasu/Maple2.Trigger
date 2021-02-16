namespace Maple2.Trigger._02000146_bf {
    public static class _ia_111 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000186}, arg2: 1);
                context.SetActor(arg1: 211, arg2: true, arg3: "Attack_Idle_A");
            }

            public override TriggerState Execute() {
                return new StateInteractObject(context);
            }

            public override void OnExit() { }
        }

        private class StateInteractObject : TriggerState {
            internal StateInteractObject(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000186}, arg2: 0)) {
                    return new StateNPCSpawn(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetActor(arg1: 211, arg2: false, arg3: "Attack_Idle_A");
                context.CreateMonster(arg1: new[] {411});
            }
        }

        private class StateNPCSpawn : TriggerState {
            internal StateNPCSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 411, arg3: "$02000146_BF__IA_111__0$", arg4: 3);
                context.SetTimer(arg1: "1", arg2: 15);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {411})) {
                    return new StateDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay : TriggerState {
            internal StateDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 8);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}