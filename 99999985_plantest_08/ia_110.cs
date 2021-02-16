namespace Maple2.Trigger._99999985_plantest_08 {
    public static class _ia_110 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000009}, arg2: 1);
                context.SetActor(arg1: 1101, arg2: true, arg3: "SOS_B");
            }

            public override TriggerState Execute() {
                return new StateInteractObject(context);
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new[] {306});
            }
        }

        private class StateInteractObject : TriggerState {
            internal StateInteractObject(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000009}, arg2: 0)) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetActor(arg1: 1101, arg2: false, arg3: "SOS_B");
                context.DestroyMonster(arg1: new[] {306});
                context.CreateMonster(arg1: new[] {110});
            }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 110, arg2: "MS2PatrolData110");
                context.SetConversation(arg1: 1, arg2: 110, script: "$02000116_BF__IA_110__0$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 110, script: "$02000116_BF__IA_110__1$", arg4: 2, arg5: 2);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 110, arg2: new[] {110})) {
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy : TriggerState {
            internal StateNPCDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {110});
                context.SetTimer(id: "110", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "110")) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}