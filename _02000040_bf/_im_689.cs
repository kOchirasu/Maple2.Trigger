namespace Maple2.Trigger._02000040_bf {
    public static class _im_689 {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000689}, arg2: 1);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State오브젝트반응(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new[] {104});
            }
        }

        private class State오브젝트반응 : TriggerState {
            internal State오브젝트반응(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000689}, arg2: 0)) {
                    context.State = new State시간텀(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {104});
                context.CreateMonster(arg1: new[] {1104});
            }
        }

        private class State시간텀 : TriggerState {
            internal State시간텀(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateNPC이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1104, arg2: "MS2PatrolData_1104");
                context.SetConversation(arg1: 1, arg2: 1104, arg3: "$02000040_BF__IM_689__0$", arg4: 2);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 1104, arg2: new[] {1104})) {
                    context.State = new StateNPC소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC소멸 : TriggerState {
            internal StateNPC소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1104});
                context.SetTimer(arg1: "1104", arg2: 60);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1104")) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}