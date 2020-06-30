using System;

namespace Maple2.Trigger._02000401_bf {
    public static class _faction_04 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.RemoveBuff(arg1: 199, arg2: 99910160);
                context.SetInteractObject(arg1: new int[] {12000029}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000040}, arg2: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "faction04", value: 1)) {
                    context.State = new State인원수체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인원수체크 : TriggerState {
            internal State인원수체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(arg1: "반응대기");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.DestroyMonster(arg1: new int[] {2902});
                context.AddBuff(arg1: new int[] {199}, arg2: 70000107, arg3: 1, arg4: false, arg5: false);
                context.CameraSelect(arg1: 303, arg2: true);
                context.CreateMonster(arg1: new int[] {1300}, arg2: true);
                context.CreateMonster(arg1: new int[] {1301, 1302, 1303, 1304, 1305}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 1301, arg3: "$02000401_BF__FACTION_04__0$", arg4: 5, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State반응대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State반응대기 : TriggerState {
            internal State반응대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.ShowGuideSummary(entityID: 20040104, textID: 20040104, duration: 2500);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.RemoveBuff(arg1: 199, arg2: 70000107);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override void Execute() {
                if (context.UserValue(key: "NPClanding", value: 1)) {
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
                context.SetInteractObject(arg1: new int[] {12000029}, arg2: 1);
                context.SetEffect(arg1: new int[] {601}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State보스소환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트 : TriggerState {
            internal State퀘스트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {12000040}, arg2: 1);
                context.SetEffect(arg1: new int[] {601}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State보스소환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스소환 : TriggerState {
            internal State보스소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 20040107, textID: 20040107, duration: 3000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.CreateMonster(arg1: new int[] {2099}, arg2: false);
                context.SetUserValue(triggerID: 99999100, key: "bossSpawn", value: 1);
                context.DestroyMonster(arg1: new int[] {1300}, arg2: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "DungeonClear", value: 1)) {
                    context.DestroyMonster(arg1: new int[] {1300, 1301, 1302, 1303, 1304, 1305}, arg2: false);
                    context.SetInteractObject(arg1: new int[] {12000029}, arg2: 0);
                    context.SetInteractObject(arg1: new int[] {12000040}, arg2: 0);
                    context.RemoveBuff(arg1: 199, arg2: 99910160);
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