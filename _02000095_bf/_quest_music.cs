using System;

namespace Maple2.Trigger._02000095_bf {
    public static class _quest_music {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {101}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000465}, arg2: 1);
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
                if (context.ObjectInteracted(arg1: new int[] {10000465}, arg2: 0)) {
                    context.State = new StateNPC대화(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new int[] {892});
                context.CreateMonster(arg1: new int[] {893});
                context.CreateMonster(arg1: new int[] {894});
            }
        }

        private class StateNPC대화 : TriggerState {
            internal StateNPC대화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 892, arg3: "$02000095_BF__QUEST_MUSIC__0$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 893, arg3: "$02000095_BF__QUEST_MUSIC__1$", arg4: 2, arg5: 2);
                context.SetConversation(arg1: 1, arg2: 894, arg3: "$02000095_BF__QUEST_MUSIC__2$", arg4: 2, arg5: 4);
                context.SetTimer(arg1: "1", arg2: 8);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기시간 : TriggerState {
            internal State대기시간(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {101}, arg2: true);
                context.DestroyMonster(arg1: new int[] {892});
                context.DestroyMonster(arg1: new int[] {893});
                context.DestroyMonster(arg1: new int[] {894});
                context.SetTimer(arg1: "1", arg2: 10);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}