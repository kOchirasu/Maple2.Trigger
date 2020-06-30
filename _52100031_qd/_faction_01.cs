using System;

namespace Maple2.Trigger._52100031_qd {
    public static class _faction_01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 199, arg2: 99910150);
                context.SetInteractObject(arg1: new int[] {10002058}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10002059}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10002067}, arg2: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "faction01", value: 1)) {
                    context.State = new State석궁준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State석궁준비 : TriggerState {
            internal State석궁준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1001, arg3: "$52100031_QD__FACTION_01__0$", arg4: 5, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 1001, arg3: "$52100031_QD__FACTION_01__1$", arg4: 5, arg5: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State퀘스트(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트 : TriggerState {
            internal State퀘스트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 20040101, textID: 20040101, durationTime: 3500);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetInteractObject(arg1: new int[] {10002067}, arg2: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State종료체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료체크 : TriggerState {
            internal State종료체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2901})) {
                    context.SetInteractObject(arg1: new int[] {10002058}, arg2: 0);
                    context.SetInteractObject(arg1: new int[] {10002059}, arg2: 0);
                    context.SetInteractObject(arg1: new int[] {10002067}, arg2: 0);
                    context.SetConversation(arg1: 1, arg2: 1001, arg3: "$52100031_QD__FACTION_01__2$", arg4: 5,
                        arg5: 0);
                    context.RemoveBuff(arg1: 199, arg2: 99910150);
                    context.State = new StateNPC삭제대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC삭제대기 : TriggerState {
            internal StateNPC삭제대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "DungeonClear", value: 1)) {
                    context.DestroyMonster(arg1: new int[] {1001, 1002, 1003, 1004, 1005}, arg2: false);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}