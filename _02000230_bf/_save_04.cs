using System;

namespace Maple2.Trigger._02000230_bf {
    public static class _save_04 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {400}, arg2: false);
                context.SetActor(arg1: 401, arg2: true, arg3: "Emotion_Failure_Idle_A");
                context.SetActor(arg1: 40401, arg2: true, arg3: "Attack_Idle_A");
                context.SetActor(arg1: 40402, arg2: true, arg3: "Attack_02_A");
                context.SetActor(arg1: 40403, arg2: true, arg3: "Attack_02_A");
                context.SetActor(arg1: 40404, arg2: true, arg3: "Attack_Idle_A");
                context.SetActor(arg1: 40405, arg2: true, arg3: "Attack_02_A");
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
                context.SetInteractObject(arg1: new int[] {10000356}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000356}, arg2: 0)) {
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
                context.SetConversation(arg1: 1, arg2: 400, arg3: "$02000230_BF__SAVE_04__0$", arg4: 2, arg5: 0);
                context.SetActor(arg1: 40401, arg2: false, arg3: "Attack_Idle_A");
                context.CreateMonster(arg1: new int[] {40411}, arg2: true);
                context.SetActor(arg1: 40402, arg2: false, arg3: "Attack_02_A");
                context.CreateMonster(arg1: new int[] {40412}, arg2: true);
                context.SetActor(arg1: 40403, arg2: false, arg3: "Attack_02_A");
                context.CreateMonster(arg1: new int[] {40413}, arg2: true);
                context.SetActor(arg1: 40404, arg2: false, arg3: "Attack_Idle_A");
                context.CreateMonster(arg1: new int[] {40414}, arg2: true);
                context.SetActor(arg1: 40405, arg2: false, arg3: "Attack_02_A");
                context.CreateMonster(arg1: new int[] {40415}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 40411, arg3: "$02000230_BF__SAVE_04__1$", arg4: 2, arg5: 1);
                context.SetConversation(arg1: 1, arg2: 40413, arg3: "$02000230_BF__SAVE_04__2$", arg4: 2, arg5: 2);
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
                context.DestroyMonster(arg1: new int[] {400});
                context.SetActor(arg1: 401, arg2: false, arg3: "Emotion_Failure_Idle_A");
                context.CreateMonster(arg1: new int[] {411}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 411, arg3: "$02000230_BF__SAVE_04__3$", arg4: 2, arg5: 0);
                context.MoveNpc(arg1: 411, arg2: "MS2PatrolData_411_11000687");
                context.SetConversation(arg1: 1, arg2: 411, arg3: "$02000230_BF__SAVE_04__4$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 90411, arg2: new int[] {411})) {
                    context.State = new State도망완료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망완료 : TriggerState {
            internal State도망완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {411});
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {40411, 40412, 40413, 40414, 40415})) {
                    context.State = new State트리거초기화(context);
                    return;
                }

                if (!context.MonsterInCombat(arg1: new int[] {40411, 40412, 40413, 40414, 40415})) {
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
                context.DestroyMonster(arg1: new int[] {40411, 40412, 40413, 40414, 40415});
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