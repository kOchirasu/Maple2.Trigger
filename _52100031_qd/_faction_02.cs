namespace Maple2.Trigger._52100031_qd {
    public static class _faction_02 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 199, arg2: 99910140);
                context.SetInteractObject(arg1: new[] {10002060, 10002061, 10002062, 10002063, 10002068}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "faction02") == 1) {
                    context.State = new State말준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State말준비 : TriggerState {
            internal State말준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(arg1: "퀘스트");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.AddBuff(arg1: new[] {199}, arg2: 70000107, arg3: 1, arg4: false, arg5: false);
                context.CameraSelect(arg1: 301, arg2: true);
                context.CreateMonster(arg1: new[] {1101, 1102, 1103, 1104, 1104}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 1101, arg3: "$52100031_QD__FACTION_02__0$", arg4: 5, arg5: 0);
                context.SetInteractObject(arg1: new[] {10002068}, arg2: 1);
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
                context.CameraReset(interpolationTime: 0.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
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
                context.ShowGuideSummary(entityId: 20040102, textId: 20040102, duration: 3000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.RemoveBuff(arg1: 199, arg2: 70000107);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2차안내(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차안내 : TriggerState {
            internal State2차안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20040105, textId: 20040105, duration: 3500);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.RemoveBuff(arg1: 199, arg2: 70000107);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "DungeonClear") == 1) {
                    context.DestroyMonster(arg1: new[] {1101, 1102, 1103, 1104, 1104}, arg2: false);
                    context.SetInteractObject(arg1: new[] {10002060, 10002061, 10002062, 10002063, 10002068}, arg2: 0);
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