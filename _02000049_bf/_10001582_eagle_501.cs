namespace Maple2.Trigger._02000049_bf {
    public static class _10001582_eagle_501 {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000052}, arg2: 1);
                context.SetActor(arg1: 501, arg2: true, arg3: "Idle_A");
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000052}, arg2: 0)) {
                    return new State오브젝트반응(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오브젝트반응 : TriggerState {
            internal State오브젝트반응(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return new StateNPC이동(context);
            }

            public override void OnExit() {
                context.SetActor(arg1: 501, arg2: false, arg3: "Idle_A");
                context.CreateMonster(arg1: new[] {5001}, arg2: false);
            }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 5001, arg2: "MS2PatrolData_501");
                context.SetTimer(arg1: "1", arg2: 10);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateNPC소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC소멸 : TriggerState {
            internal StateNPC소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {5001});
                context.SetTimer(arg1: "2", arg2: 50);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State시작대기중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}