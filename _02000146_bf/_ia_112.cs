namespace Maple2.Trigger._02000146_bf {
    public static class _ia_112 {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000187}, arg2: 1);
                context.SetActor(arg1: 212, arg2: true, arg3: "Attack_Idle_A");
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
                if (context.ObjectInteracted(arg1: new[] {10000187}, arg2: 0)) {
                    return new StateNPC등장(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetActor(arg1: 212, arg2: false, arg3: "Attack_Idle_A");
                context.CreateMonster(arg1: new[] {412});
            }
        }

        private class StateNPC등장 : TriggerState {
            internal StateNPC등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 412, arg3: "$02000146_BF__IA_112__0$", arg4: 2);
                context.SetTimer(arg1: "1", arg2: 15);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {412})) {
                    return new State딜레이(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State딜레이 : TriggerState {
            internal State딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 8);
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