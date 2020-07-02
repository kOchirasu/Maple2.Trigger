namespace Maple2.Trigger._02000146_bf {
    public static class _ia_108 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000183}, arg2: 1);
                context.SetActor(arg1: 208, arg2: true, arg3: "Attack_Idle_A");
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
                if (context.ObjectInteracted(arg1: new[] {10000183}, arg2: 0)) {
                    return new StateNPCAppear(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetActor(arg1: 208, arg2: false, arg3: "Attack_Idle_A");
                context.CreateMonster(arg1: new[] {408});
            }
        }

        private class StateNPCAppear : TriggerState {
            internal StateNPCAppear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 408, arg3: "$02000146_BF__IA_108__0$", arg4: 2);
                context.SetTimer(arg1: "1", arg2: 15);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {408})) {
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