namespace Maple2.Trigger._02000049_bf {
    public static class _10001582_eagle_503 {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000331}, arg2: 1);
                context.SetActor(arg1: 503, arg2: true, arg3: "Idle_A");
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000331}, arg2: 0)) {
                    context.State = new State오브젝트반응(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오브젝트반응 : TriggerState {
            internal State오브젝트반응(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (true) {
                    context.State = new StateNPC이동(context);
                    return;
                }
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
                context.DestroyMonster(arg1: new[] {5003});
                context.SetTimer(arg1: "2", arg2: 50);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}