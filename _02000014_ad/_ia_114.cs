namespace Maple2.Trigger._02000014_ad {
    public static class _ia_114 {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000114}, arg2: 1);
                context.SetActor(arg1: 114, arg2: true, arg3: "Dead_A");
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
                if (context.ObjectInteracted(arg1: new[] {10000114}, arg2: 0)) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetActor(arg1: 114, arg2: false, arg3: "Dead_A");
                context.CreateMonster(arg1: new[] {92}, arg2: false);
            }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 92, arg2: "MS2PatrolData402");
                context.SetConversation(arg1: 1, arg2: 92, arg3: "$02000014_AD__IA_114__0$", arg4: 4, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 292, arg2: new[] {92})) {
                    return new StateNPC소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC소멸 : TriggerState {
            internal StateNPC소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {92});
                context.SetTimer(arg1: "302", arg2: 10);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "302")) {
                    return new State시작대기중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}