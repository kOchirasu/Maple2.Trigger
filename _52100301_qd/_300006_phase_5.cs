using System;

namespace Maple2.Trigger._52100301_qd {
    public static class _300006_phase_5 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "AI_Phase", value: 5)) {
                    context.State = new State패이즈_5_시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패이즈_5_시작 : TriggerState {
            internal State패이즈_5_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcID: 11004205, illust: "ArcaneBlader_unfair",
                    script: "$52100301_QD__300006_PHASE_5__0$", duration: 3176);
                context.SetEffect(arg1: new int[] {200021, 200022, 200023, 200024, 200025, 200026, 200027, 200028},
                    arg2: false);
                context.SetUserValue(key: "AI_Phase", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 3000051, key: "Phase_4_Interect_01", value: 0);
                context.SetUserValue(triggerID: 3000052, key: "Phase_4_Interect_02", value: 0);
                context.SetUserValue(triggerID: 3000053, key: "Phase_4_Interect_03", value: 0);
                context.SetUserValue(triggerID: 3000054, key: "Phase_4_Interect_04", value: 0);
                context.SetEffect(arg1: new int[] {200001, 200002, 200003, 200004, 200005, 200006, 200007, 200008},
                    arg2: false);
                context.SideNpcTalk(type: "talk", npcID: 11004205, illust: "ArcaneBlader_unfair",
                    script: "$52100301_QD__300006_PHASE_5__1$", duration: 3176);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State아르케온_등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아르케온_등장 : TriggerState {
            internal State아르케온_등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "AI_Phase", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State아르케온_탈것_생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아르케온_탈것_생성 : TriggerState {
            internal State아르케온_탈것_생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 3000061, key: "Phase_5_Interect_01", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    // context.State = new State게임종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}