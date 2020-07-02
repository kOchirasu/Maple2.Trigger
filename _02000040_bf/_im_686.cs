namespace Maple2.Trigger._02000040_bf {
    public static class _im_686 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000686}, arg2: 1);
            }

            public override TriggerState Execute() {
                return new StateInteractObject(context);
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new[] {101});
            }
        }

        private class StateInteractObject : TriggerState {
            internal StateInteractObject(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000686}, arg2: 0)) {
                    return new State시간텀(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {1101});
            }
        }

        private class State시간텀 : TriggerState {
            internal State시간텀(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1101, arg2: "MS2PatrolData_1101");
                context.SetConversation(arg1: 1, arg2: 1101, arg3: "$02000040_BF__IM_686__0$", arg4: 2);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 1101, arg2: new[] {1101})) {
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy : TriggerState {
            internal StateNPCDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1101});
                context.SetTimer(arg1: "1101", arg2: 60);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1101")) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}