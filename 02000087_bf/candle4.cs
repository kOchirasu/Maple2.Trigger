namespace Maple2.Trigger._02000087_bf {
    public static class _candle4 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000135}, arg2: 1);
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
                if (context.ObjectInteracted(arg1: new[] {10000135}, arg2: 0)) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {104}, arg2: false);
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_204");
                context.SetTimer(id: "4", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    return new State대화(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대화 : TriggerState {
            internal State대화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 104, script: "$02000087_BF__CANDLE4__0$", arg4: 2);
                context.SetTimer(id: "4", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy : TriggerState {
            internal StateNPCDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {104});
                context.SetTimer(id: "4", arg2: 10);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}