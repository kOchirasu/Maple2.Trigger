namespace Maple2.Trigger._02000146_bf {
    public static class _ia_109 {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000184}, arg2: 1);
                context.SetActor(arg1: 209, arg2: true, arg3: "Attack_Idle_A");
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
                if (context.ObjectInteracted(arg1: new[] {10000184}, arg2: 0)) {
                    context.State = new StateNPC등장(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetActor(arg1: 209, arg2: false, arg3: "Attack_Idle_A");
                context.CreateMonster(arg1: new[] {409});
            }
        }

        private class StateNPC등장 : TriggerState {
            internal StateNPC등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 409, arg3: "$02000146_BF__IA_109__0$", arg4: 3);
                context.SetTimer(arg1: "1", arg2: 15);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {409})) {
                    context.State = new State딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State딜레이 : TriggerState {
            internal State딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 8);
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