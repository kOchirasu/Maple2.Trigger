namespace Maple2.Trigger._02000401_bf {
    public static class _faction_03 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 199, arg2: 99910130);
                context.SetInteractObject(arg1: new[] {12000027, 12000028, 12000039}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "faction03") == 1) {
                    context.State = new State탱크준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State탱크준비 : TriggerState {
            internal State탱크준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {2903});
                context.AddBuff(arg1: new[] {199}, arg2: 70000107, arg3: 1, arg4: false, arg5: false);
                context.ShowGuideSummary(entityId: 20040103, textId: 20040103, duration: 3500);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.CameraSelect(arg1: 302, arg2: true);
                context.CreateMonster(arg1: new[] {1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 1201, arg3: "$02000401_BF__FACTION_03__0$", arg4: 5, arg5: 0);
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
                context.SetInteractObject(arg1: new[] {12000027, 12000028}, arg2: 1);
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
                context.SetInteractObject(arg1: new[] {12000039}, arg2: 1);
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
                context.ShowGuideSummary(entityId: 20040106, textId: 20040106, duration: 3500);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.RemoveBuff(arg1: 199, arg2: 70000107);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "DungeonClear") == 1) {
                    context.DestroyMonster(arg1: new[] {1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208}, arg2: false);
                    context.SetInteractObject(arg1: new[] {12000027, 12000028, 12000039}, arg2: 0);
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