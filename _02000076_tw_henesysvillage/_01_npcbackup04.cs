using System;

namespace Maple2.Trigger._02000076_tw_henesysvillage {
    public static class _01_npcbackup04 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {1001}, arg2: new int[] {10002041},
                    arg3: new byte[] {1})) {
                    context.State = new State지원군생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State지원군생성 : TriggerState {
            internal State지원군생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {104}, arg2: false);
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_14");
                context.SetConversation(arg1: 1, arg2: 104, arg3: "$02000076_TW_HenesysVillage__01_NPCBACKUP04__0$",
                    arg4: 1);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 3004, arg2: new int[] {104})) {
                    context.State = new State지원군이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State지원군이동 : TriggerState {
            internal State지원군이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_104");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 2001, arg2: new int[] {104})) {
                    context.State = new State지원군소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State지원군소멸 : TriggerState {
            internal State지원군소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {104});
                context.SetTimer(arg1: "4", arg2: 120);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}