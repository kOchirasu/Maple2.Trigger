namespace Maple2.Trigger._02000046_ad {
    public static class _eagle_03 {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000295}, arg2: 1);
                context.SetActor(arg1: 203, arg2: true, arg3: "Dead_A");
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000295}, arg2: 0)) {
                    context.State = new State오브젝트반응(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오브젝트반응 : TriggerState {
            internal State오브젝트반응(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 203, arg2: false, arg3: "Dead_A");
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNPC이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {303}, arg2: false);
                context.MoveNpc(arg1: 303, arg2: "MS2PatrolData_203");
                context.SetConversation(arg1: 1, arg2: 303, arg3: "$02000046_AD__EAGLE_03__0$", arg4: 2);
                context.SetTimer(arg1: "1", arg2: 20);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateNPC소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC소멸 : TriggerState {
            internal StateNPC소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {303});
            }

            public override void Execute() {
                if (true) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}