using System;

namespace Maple2.Trigger._02000076_tw_henesysvillage {
    public static class _01_npcbackup08 {
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
                context.CreateMonster(arg1: new int[] {108}, arg2: false);
                context.MoveNpc(arg1: 108, arg2: "MS2PatrolData_18");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 3008, arg2: new int[] {108})) {
                    context.State = new State지원군이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State지원군이동 : TriggerState {
            internal State지원군이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 108, arg2: "MS2PatrolData_108");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 2001, arg2: new int[] {108})) {
                    context.State = new State지원군소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State지원군소멸 : TriggerState {
            internal State지원군소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {108});
                context.SetTimer(arg1: "3", arg2: 120);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}