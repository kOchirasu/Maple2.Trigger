namespace Maple2.Trigger._02000046_ad {
    public static class _eagle_03 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000295}, arg2: 1);
                context.SetActor(arg1: 203, arg2: true, arg3: "Dead_A");
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000295}, arg2: 0)) {
                    return new StateInteractObject(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateInteractObject : TriggerState {
            internal StateInteractObject(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 203, arg2: false, arg3: "Dead_A");
            }

            public override TriggerState Execute() {
                return new StateNPC이동(context);
            }

            public override void OnExit() { }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {303}, arg2: false);
                context.MoveNpc(arg1: 303, arg2: "MS2PatrolData_203");
                context.SetConversation(arg1: 1, arg2: 303, script: "$02000046_AD__EAGLE_03__0$", arg4: 2);
                context.SetTimer(id: "1", arg2: 20);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy : TriggerState {
            internal StateNPCDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {303});
            }

            public override TriggerState Execute() {
                return new StateWaitStart(context);
            }

            public override void OnExit() { }
        }
    }
}