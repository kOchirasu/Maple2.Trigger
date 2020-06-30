using System;

namespace Maple2.Trigger._02000146_bf {
    public static class _ia_108 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000183}, arg2: 1);
                context.SetActor(arg1: 208, arg2: true, arg3: "Attack_Idle_A");
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
                if (context.ObjectInteracted(arg1: new int[] {10000183}, arg2: 0)) {
                    context.State = new StateNPC등장(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetActor(arg1: 208, arg2: false, arg3: "Attack_Idle_A");
                context.CreateMonster(arg1: new int[] {408});
            }
        }

        private class StateNPC등장 : TriggerState {
            internal StateNPC등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 408, arg3: "$02000146_BF__IA_108__0$", arg4: 2);
                context.SetTimer(arg1: "1", arg2: 15);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {408})) {
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