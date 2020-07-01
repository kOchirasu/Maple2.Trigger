namespace Maple2.Trigger._02000087_bf {
    public static class _candle3 {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000135}, arg2: 1);
            }

            public override TriggerState Execute() {
                return new State오브젝트반응(context);
            }

            public override void OnExit() { }
        }

        private class State오브젝트반응 : TriggerState {
            internal State오브젝트반응(ITriggerContext context) : base(context) { }

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
                context.CreateMonster(arg1: new[] {103}, arg2: false);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_203");
                context.SetConversation(arg1: 1, arg2: 103, arg3: "$02000087_BF__CANDLE3__0$", arg4: 2);
                context.SetTimer(arg1: "3", arg2: 6);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateNPC소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC소멸 : TriggerState {
            internal StateNPC소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {103});
                context.SetTimer(arg1: "3", arg2: 10);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State시작대기중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}