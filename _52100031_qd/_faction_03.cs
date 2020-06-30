using System;

namespace Maple2.Trigger._52100031_qd {
    public static class _faction_03 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 199, arg2: 99910130);
                context.SetInteractObject(arg1: new int[] {10002064}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10002065}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10002069}, arg2: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "faction03", value: 1)) {
                    context.State = new State탱크준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State탱크준비 : TriggerState {
            internal State탱크준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(arg1: "퀘스트");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.DestroyMonster(arg1: new int[] {2903});
                context.AddBuff(arg1: new int[] {199}, arg2: 70000107, arg3: 1, arg4: false, arg5: false);
                context.ShowGuideSummary(entityID: 20040103, textID: 20040103, duration: 3500);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.CameraSelect(arg1: 302, arg2: true);
                context.CreateMonster(arg1: new int[] {1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 1201, arg3: "$52100031_QD__FACTION_03__0$", arg4: 5, arg5: 0);
                context.SetInteractObject(arg1: new int[] {10002069}, arg2: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State퀘스트(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트 : TriggerState {
            internal State퀘스트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetSkip();
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

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 20040106, textID: 20040106, duration: 3500);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.RemoveBuff(arg1: 199, arg2: 70000107);
            }

            public override void Execute() {
                if (context.UserValue(key: "DungeonClear", value: 1)) {
                    context.DestroyMonster(arg1: new int[] {1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208},
                        arg2: false);
                    context.SetInteractObject(arg1: new int[] {10002064}, arg2: 0);
                    context.SetInteractObject(arg1: new int[] {10002065}, arg2: 0);
                    context.SetInteractObject(arg1: new int[] {10002069}, arg2: 0);
                    context.RemoveBuff(arg1: 199, arg2: 99910130);
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