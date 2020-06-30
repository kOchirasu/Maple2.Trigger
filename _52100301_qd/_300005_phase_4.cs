using System;

namespace Maple2.Trigger._52100301_qd {
    public static class _300005_phase_4 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {200001, 200002, 200003, 200004, 200005, 200006, 200007, 200008},
                    arg2: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "AI_Phase", value: 4)) {
                    context.State = new State패이즈_4_시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패이즈_4_시작 : TriggerState {
            internal State패이즈_4_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {1003}, arg2: 62100169, arg3: 1);
                context.SetEffect(arg1: new int[] {200011, 200012, 200013, 200014, 200015, 200016, 200017, 200018},
                    arg2: false);
                context.DestroyMonster(arg1: new int[] {512});
                context.DestroyMonster(arg1: new int[] {511});
                context.SetInteractObject(arg1: new int[] {10003122}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10003121}, arg2: 2);
                context.SetUserValue(triggerID: 3000041, key: "Phase_3_Interect_01", value: 0);
                context.SetUserValue(triggerID: 3000042, key: "Phase_3_Interect_02", value: 0);
                context.SideNpcTalk(type: "talk", npcID: 11004205, illust: "ArcaneBlader_unfair",
                    script: "$52100301_QD__300005_PHASE_4__0$", duration: 3176);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State추가대화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State추가대화 : TriggerState {
            internal State추가대화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcID: 29500101, illust: "ArcheonBlack_Angry",
                    script: "$52100301_QD__300005_PHASE_4__1$", duration: 3176);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State추가대화_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State추가대화_2 : TriggerState {
            internal State추가대화_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcID: 11004205, illust: "ArcaneBlader_unfair",
                    script: "$52100301_QD__300005_PHASE_4__2$", duration: 3176);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State엘리베이터_대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엘리베이터_대기 : TriggerState {
            internal State엘리베이터_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcID: 11004205, illust: "ArcaneBlader_unfair",
                    script: "$52100301_QD__300005_PHASE_4__3$", duration: 3176);
                context.SetUserValue(key: "AI_Phase", value: 0);
                context.SetVisibleBreakableObject(
                    arg1: new int[]
                        {5351, 5352, 5353, 5354, 5355, 5356, 5357, 5358, 5359, 5360, 5361, 5362, 5363, 5364},
                    arg2: false);
                context.SetVisibleBreakableObject(
                    arg1: new int[]
                        {5371, 5372, 5373, 5374, 5375, 5376, 5377, 5378, 5379, 5380, 5381, 5382, 5383, 5384},
                    arg2: false);
                context.SetVisibleBreakableObject(
                    arg1: new int[] {5101, 5102, 5103, 5104, 5105, 5106, 5107, 5108, 5109, 5110}, arg2: true);
                context.SetVisibleBreakableObject(
                    arg1: new int[] {5111, 5112, 5113, 5114, 5115, 5116, 5117, 5118, 5119, 5120}, arg2: true);
                context.SetVisibleBreakableObject(
                    arg1: new int[] {5121, 5122, 5123, 5124, 5125, 5126, 5127, 5128, 5129, 5130}, arg2: true);
                context.SetVisibleBreakableObject(
                    arg1: new int[] {5131, 5132, 5133, 5134, 5135, 5136, 5137, 5138, 5139, 5140}, arg2: true);
                context.SetBreakable(arg1: new int[] {5101, 5102, 5103, 5104, 5105, 5106, 5107, 5108, 5109, 5110},
                    arg2: true);
                context.SetBreakable(arg1: new int[] {5111, 5112, 5113, 5114, 5115, 5116, 5117, 5118, 5119, 5120},
                    arg2: true);
                context.SetBreakable(arg1: new int[] {5121, 5122, 5123, 5124, 5125, 5126, 5127, 5128, 5129, 5130},
                    arg2: true);
                context.SetBreakable(arg1: new int[] {5131, 5132, 5133, 5134, 5135, 5136, 5137, 5138, 5139, 5140},
                    arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new State엘리베이터_도착(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엘리베이터_도착 : TriggerState {
            internal State엘리베이터_도착(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "AI_Phase", value: 0);
                context.SetVisibleBreakableObject(
                    arg1: new int[] {
                        5301, 5302, 5303, 5304, 5305, 5306, 5307, 5308, 5309, 5310, 5311, 5312, 5313, 5314, 5315, 5316,
                        5317, 5318, 5319, 5320, 5321, 5322, 5323, 5324, 5325, 5326, 5327, 5328, 5329, 5330, 5331, 5332,
                        5333, 5334, 5335, 5336, 5337, 5338, 5339, 5340
                    }, arg2: true);
                context.SetUserValue(triggerID: 3000051, key: "Phase_4_Interect_01", value: 1);
                context.SetUserValue(triggerID: 3000052, key: "Phase_4_Interect_02", value: 1);
                context.SetUserValue(triggerID: 3000053, key: "Phase_4_Interect_03", value: 1);
                context.SetUserValue(triggerID: 3000054, key: "Phase_4_Interect_04", value: 1);
                context.SetVisibleBreakableObject(
                    arg1: new int[] {5101, 5102, 5103, 5104, 5105, 5106, 5107, 5108, 5109, 5110}, arg2: false);
                context.SetVisibleBreakableObject(
                    arg1: new int[] {5111, 5112, 5113, 5114, 5115, 5116, 5117, 5118, 5119, 5120}, arg2: false);
                context.SetVisibleBreakableObject(
                    arg1: new int[] {5121, 5122, 5123, 5124, 5125, 5126, 5127, 5128, 5129, 5130}, arg2: false);
                context.SetVisibleBreakableObject(
                    arg1: new int[] {5131, 5132, 5133, 5134, 5135, 5136, 5137, 5138, 5139, 5140}, arg2: false);
                context.SetBreakable(arg1: new int[] {5101, 5102, 5103, 5104, 5105, 5106, 5107, 5108, 5109, 5110},
                    arg2: false);
                context.SetBreakable(arg1: new int[] {5111, 5112, 5113, 5114, 5115, 5116, 5117, 5118, 5119, 5120},
                    arg2: false);
                context.SetBreakable(arg1: new int[] {5121, 5122, 5123, 5124, 5125, 5126, 5127, 5128, 5129, 5130},
                    arg2: false);
                context.SetBreakable(arg1: new int[] {5131, 5132, 5133, 5134, 5135, 5136, 5137, 5138, 5139, 5140},
                    arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State폭발물제어장치_생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State폭발물제어장치_생성 : TriggerState {
            internal State폭발물제어장치_생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 13, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 14, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 15, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 16, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State길막열기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State길막열기 : TriggerState {
            internal State길막열기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$52100301_QD__300005_PHASE_4__4$", arg3: new int[] {4000});
                context.SetMesh(arg1: new int[] {5241, 5242, 5243, 5244}, arg2: false);
                context.SetAgent(
                    arg1:
                    "1800000,1800001,1800002,1800003,1800004,1800005,1800006,1800007,1800008,1800009,1800010,1800011",
                    arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    // context.State = new State완료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}