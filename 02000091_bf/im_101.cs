namespace Maple2.Trigger._02000091_bf {
    public static class _im_101 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000532}, arg2: 1);
                context.SetActor(arg1: 2101, arg2: true, arg3: "Idle_A");
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
                if (context.ObjectInteracted(arg1: new[] {10000532}, arg2: 0)) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new[] {101});
                context.SetActor(arg1: 2101, arg2: false, arg3: "Idle_A");
            }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_Gull_101");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 1101, arg2: new[] {101})) {
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy : TriggerState {
            internal StateNPCDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101});
                context.SetTimer(id: "101", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "101")) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}