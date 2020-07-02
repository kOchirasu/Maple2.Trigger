namespace Maple2.Trigger._02000014_ad {
    public static class _ia_117 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000117}, arg2: 1);
                context.SetActor(arg1: 117, arg2: true, arg3: "Dead_A");
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
                if (context.ObjectInteracted(arg1: new[] {10000117}, arg2: 0)) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetActor(arg1: 117, arg2: false, arg3: "Dead_A");
                context.CreateMonster(arg1: new[] {95}, arg2: false);
            }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 95, arg2: "MS2PatrolData405");
                context.SetConversation(arg1: 1, arg2: 95, arg3: "$02000014_AD__IA_117__0$", arg4: 4, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 295, arg2: new[] {95})) {
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy : TriggerState {
            internal StateNPCDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {95});
                context.SetTimer(arg1: "305", arg2: 10);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "305")) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}