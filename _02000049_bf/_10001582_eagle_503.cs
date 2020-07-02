namespace Maple2.Trigger._02000049_bf {
    public static class _10001582_eagle_503 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000331}, arg2: 1);
                context.SetActor(arg1: 503, arg2: true, arg3: "Idle_A");
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000331}, arg2: 0)) {
                    return new StateInteractObject(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateInteractObject : TriggerState {
            internal StateInteractObject(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return new StateNPC이동(context);
            }

            public override void OnExit() {
                context.SetActor(arg1: 503, arg2: false, arg3: "Idle_A");
                context.CreateMonster(arg1: new[] {5003}, arg2: false);
            }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 5003, arg2: "MS2PatrolData_503");
                context.SetTimer(arg1: "1", arg2: 10);
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
                context.DestroyMonster(arg1: new[] {5003});
                context.SetTimer(arg1: "2", arg2: 50);
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