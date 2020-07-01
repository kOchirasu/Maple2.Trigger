namespace Maple2.Trigger._02000091_bf {
    public static class _im_105 {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000536}, arg2: 1);
                context.SetActor(arg1: 2105, arg2: true, arg3: "Idle_A");
            }

            public override void Execute() {
                if (true) {
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
                if (context.ObjectInteracted(arg1: new[] {10000536}, arg2: 0)) {
                    context.State = new StateNPC이동(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new[] {105});
                context.SetActor(arg1: 2105, arg2: false, arg3: "Idle_A");
            }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 105, arg2: "MS2PatrolData_Gull_105");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 1105, arg2: new[] {105})) {
                    context.State = new StateNPC소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC소멸 : TriggerState {
            internal StateNPC소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {105});
                context.SetTimer(arg1: "105", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "105")) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}