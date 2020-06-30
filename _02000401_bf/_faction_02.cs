using System;

namespace Maple2.Trigger._02000401_bf {
    public static class _faction_02 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 199, arg2: 99910140);
                context.SetInteractObject(arg1: new int[] {12000023}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000024}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000025}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000026}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000038}, arg2: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "faction02", value: 1)) {
                    context.State = new State말준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State말준비 : TriggerState {
            internal State말준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {199}, arg2: 70000107, arg3: 1, arg4: false, arg5: false);
                context.CameraSelect(arg1: 301, arg2: true);
                context.CreateMonster(arg1: new int[] {1101, 1102, 1103, 1104, 1104}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 1101, arg3: "$02000401_BF__FACTION_02__0$", arg4: 5, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State룸체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State룸체크 : TriggerState {
            internal State룸체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.IsDungeonRoom()) {
                    context.State = new State던전(context);
                    return;
                }

                if (!context.IsDungeonRoom()) {
                    context.State = new State퀘스트(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전 : TriggerState {
            internal State던전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(arg1: "종료체크");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetInteractObject(arg1: new int[] {12000023}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {12000024}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {12000025}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {12000026}, arg2: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State종료체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트 : TriggerState {
            internal State퀘스트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {12000038}, arg2: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State종료체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료체크 : TriggerState {
            internal State종료체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.ShowGuideSummary(entityID: 20040102, textID: 20040102, duration: 3000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.RemoveBuff(arg1: 199, arg2: 70000107);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State2차안내(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차안내 : TriggerState {
            internal State2차안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 20040105, textID: 20040105, duration: 3500);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.RemoveBuff(arg1: 199, arg2: 70000107);
            }

            public override void Execute() {
                if (context.UserValue(key: "DungeonClear", value: 1)) {
                    context.DestroyMonster(arg1: new int[] {1101, 1102, 1103, 1104, 1104}, arg2: false);
                    context.SetInteractObject(arg1: new int[] {12000023}, arg2: 0);
                    context.SetInteractObject(arg1: new int[] {12000024}, arg2: 0);
                    context.SetInteractObject(arg1: new int[] {12000025}, arg2: 0);
                    context.SetInteractObject(arg1: new int[] {12000026}, arg2: 0);
                    context.SetInteractObject(arg1: new int[] {12000038}, arg2: 0);
                    context.RemoveBuff(arg1: 199, arg2: 99910140);
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