namespace Maple2.Trigger._02000046_ad {
    public static class _eagle_04 {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000296}, arg2: 1);
                context.SetActor(arg1: 204, arg2: true, arg3: "Dead_A");
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000296}, arg2: 0)) {
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
                context.SetActor(arg1: 204, arg2: false, arg3: "Dead_A");
                context.CreateMonster(arg1: new[] {304}, arg2: false);
            }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 304, arg2: "MS2PatrolData_204");
                context.SetConversation(arg1: 1, arg2: 304, arg3: "$02000046_AD__EAGLE_04__0$", arg4: 2);
                context.SetTimer(arg1: "1", arg2: 20);
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
                context.DestroyMonster(arg1: new[] {304});
            }

            public override TriggerState Execute() {
                return new State시작대기중(context);
            }

            public override void OnExit() { }
        }
    }
}