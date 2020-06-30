using System;

namespace Maple2.Trigger._52020039_qd {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateReady(context);

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {91000590},
                    arg3: new byte[] {3})) {
                    context.State = new StateNPC소환(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {91000600},
                    arg3: new byte[] {1})) {
                    context.State = new StateNPC소환(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {91000600},
                    arg3: new byte[] {2})) {
                    context.State = new StateNPC소환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC소환 : TriggerState {
            internal StateNPC소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
                context.CreateMonster(arg1: new int[] {103}, arg2: false);
                context.CreateMonster(arg1: new int[] {104}, arg2: false);
                context.CreateMonster(arg1: new int[] {105}, arg2: false);
                context.CreateMonster(arg1: new int[] {106}, arg2: false);
                context.CreateMonster(arg1: new int[] {107}, arg2: false);
                context.CreateMonster(arg1: new int[] {108}, arg2: false);
                context.CreateMonster(arg1: new int[] {109}, arg2: false);
                context.CreateMonster(arg1: new int[] {110}, arg2: false);
                context.CreateMonster(arg1: new int[] {111}, arg2: false);
                context.CreateMonster(arg1: new int[] {112}, arg2: false);
                context.CreateMonster(arg1: new int[] {113}, arg2: false);
                context.CreateMonster(arg1: new int[] {114}, arg2: false);
                context.CreateMonster(arg1: new int[] {115}, arg2: false);
                context.CreateMonster(arg1: new int[] {116}, arg2: false);
                context.CreateMonster(arg1: new int[] {117}, arg2: false);
                context.CreateMonster(arg1: new int[] {118}, arg2: false);
                context.CreateMonster(arg1: new int[] {119}, arg2: false);
                context.CreateMonster(arg1: new int[] {120}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}