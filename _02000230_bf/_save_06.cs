using System;

namespace Maple2.Trigger._02000230_bf {
    public static class _save_06 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {600}, arg2: false);
                context.SetActor(arg1: 601, arg2: true, arg3: "Emotion_Failure_Idle_A");
                context.SetActor(arg1: 60601, arg2: true, arg3: "Attack_Idle_A");
                context.SetActor(arg1: 60602, arg2: true, arg3: "Attack_02_A");
                context.SetActor(arg1: 60603, arg2: true, arg3: "Attack_02_A");
                context.SetActor(arg1: 60604, arg2: true, arg3: "Attack_Idle_A");
                context.SetActor(arg1: 60605, arg2: true, arg3: "Attack_02_A");
            }

            public override void Execute() {
                if (true) {
                    context.State = new State주민구출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State주민구출 : TriggerState {
            internal State주민구출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000358}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000358}, arg2: 0)) {
                    context.State = new State문열림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문열림 : TriggerState {
            internal State문열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 3);
                context.SetConversation(arg1: 1, arg2: 600, arg3: "$02000230_BF__SAVE_06__0$", arg4: 2, arg5: 0);
                context.SetActor(arg1: 60601, arg2: false, arg3: "Attack_Idle_A");
                context.CreateMonster(arg1: new int[] {60611}, arg2: true);
                context.SetActor(arg1: 60602, arg2: false, arg3: "Attack_02_A");
                context.CreateMonster(arg1: new int[] {60612}, arg2: true);
                context.SetActor(arg1: 60603, arg2: false, arg3: "Attack_02_A");
                context.CreateMonster(arg1: new int[] {60613}, arg2: true);
                context.SetActor(arg1: 60604, arg2: false, arg3: "Attack_Idle_A");
                context.CreateMonster(arg1: new int[] {60614}, arg2: true);
                context.SetActor(arg1: 60605, arg2: false, arg3: "Attack_02_A");
                context.CreateMonster(arg1: new int[] {60615}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 60611, arg3: "$02000230_BF__SAVE_06__1$", arg4: 2, arg5: 1);
                context.SetConversation(arg1: 1, arg2: 60613, arg3: "$02000230_BF__SAVE_06__2$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    context.State = new State도망과공격(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망과공격 : TriggerState {
            internal State도망과공격(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {600});
                context.SetActor(arg1: 601, arg2: false, arg3: "Emotion_Failure_Idle_A");
                context.CreateMonster(arg1: new int[] {611}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 611, arg3: "$02000230_BF__SAVE_06__3$", arg4: 2, arg5: 0);
                context.MoveNpc(arg1: 611, arg2: "MS2PatrolData_611_11000688");
                context.SetConversation(arg1: 1, arg2: 611, arg3: "$02000230_BF__SAVE_06__4$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 90611, arg2: new int[] {611})) {
                    context.State = new State도망완료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망완료 : TriggerState {
            internal State도망완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {611});
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {60611, 60612, 60613, 60614, 60615})) {
                    context.State = new State트리거초기화(context);
                    return;
                }

                if (!context.MonsterInCombat(arg1: new int[] {60611, 60612, 60613, 60614, 60615})) {
                    context.State = new State트리거초기화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거초기화 : TriggerState {
            internal State트리거초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "11", arg2: 10);
                context.DestroyMonster(arg1: new int[] {60611, 60612, 60613, 60614, 60615});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "11")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}