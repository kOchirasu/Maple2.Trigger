namespace Maple2.Trigger._03000014_ad {
    public static class _ia_115 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000115}, arg2: 1);
                context.SetActor(arg1: 115, arg2: true, arg3: "Dead_A");
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
                if (context.ObjectInteracted(arg1: new[] {10000115}, arg2: 0)) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetActor(arg1: 115, arg2: false, arg3: "Dead_A");
                context.CreateMonster(arg1: new[] {93}, arg2: false);
            }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 93, arg2: "MS2PatrolData403");
                context.SetConversation(arg1: 1, arg2: 93, script: "$03000014_AD__IA_115__0$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 293, arg2: new[] {93})) {
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy : TriggerState {
            internal StateNPCDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {93});
                context.SetTimer(id: "303", arg2: 10);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "303")) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}