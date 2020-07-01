using System;

namespace Maple2.Trigger._02020301_bf {
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
                context.DestroyMonster(arg1: new int[] {111});
                context.SideNpcTalk(type: "talk", npcID: 11004205, illust: "ArcaneBlader_unfair",
                    script: "$02020301_BF__300006_PHASE_5__0$", duration: 3176);
                context.SetEffect(arg1: new int[] {200021, 200022, 200023, 200024, 200025, 200026, 200027, 200028},
                    arg2: false);
                context.SetUserValue(key: "AI_Phase", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "Portal_On_04", value: 1)) {
                    context.State = new State포탈_오픈_대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포탈_오픈_대기 : TriggerState {
            internal State포탈_오픈_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State포탈_오픈(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포탈_오픈 : TriggerState {
            internal State포탈_오픈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 3000051, key: "Phase_4_Interect_01", value: 0);
                context.SetUserValue(triggerID: 3000052, key: "Phase_4_Interect_02", value: 0);
                context.SetUserValue(triggerID: 3000053, key: "Phase_4_Interect_03", value: 0);
                context.SetUserValue(triggerID: 3000054, key: "Phase_4_Interect_04", value: 0);
                context.SetEffect(arg1: new int[] {200001, 200002, 200003, 200004, 200005, 200006, 200007, 200008},
                    arg2: false);
                context.SetPortal(arg1: 4, arg2: true, arg3: true, arg4: true);
                context.SideNpcTalk(type: "talk", npcID: 11004205, illust: "ArcaneBlader_unfair",
                    script: "$02020301_BF__300006_PHASE_5__1$", duration: 3176);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {1002})) {
                    context.State = new State엘리베이터_동작_대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엘리베이터_동작_대기 : TriggerState {
            internal State엘리베이터_동작_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "Last_Phase", value: 1, isModify: "false");
                context.SetUserValue(triggerID: 3000051, key: "Phase_4_Interect_01", value: 0);
                context.SetUserValue(triggerID: 3000052, key: "Phase_4_Interect_02", value: 0);
                context.SetUserValue(triggerID: 3000053, key: "Phase_4_Interect_03", value: 0);
                context.SetUserValue(triggerID: 3000054, key: "Phase_4_Interect_04", value: 0);
                context.SetEffect(arg1: new int[] {200001, 200002, 200003, 200004, 200005, 200006, 200007, 200008},
                    arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State택스트_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State택스트_1 : TriggerState {
            internal State택스트_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcID: 11004205, illust: "ArcaneBlader_unfair",
                    script: "$02020301_BF__300006_PHASE_5__2$", duration: 3176);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State택스트_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State택스트_2 : TriggerState {
            internal State택스트_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcID: 11004205, illust: "ArcaneBlader_normal",
                    script: "$02020301_BF__300006_PHASE_5__3$", duration: 3176);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State엘리베이터_동작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엘리베이터_동작 : TriggerState {
            internal State엘리베이터_동작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new int[] {5401, 5402, 5403, 5404, 5405, 5406, 5407, 5408, 5409, 5410},
                    arg2: true);
                context.SetBreakable(arg1: new int[] {5411, 5412, 5413, 5414, 5415, 5416, 5417, 5418, 5419, 5420},
                    arg2: true);
                context.SetBreakable(arg1: new int[] {5421, 5422, 5423, 5424, 5425, 5426, 5427, 5428, 5429, 5430},
                    arg2: true);
                context.SetBreakable(arg1: new int[] {5431, 5432, 5433, 5434, 5435, 5436, 5437, 5438, 5439, 5440},
                    arg2: true);
                context.SetVisibleBreakableObject(
                    arg1: new int[] {5401, 5402, 5403, 5404, 5405, 5406, 5407, 5408, 5409, 5410}, arg2: true);
                context.SetVisibleBreakableObject(
                    arg1: new int[] {5411, 5412, 5413, 5414, 5415, 5416, 5417, 5418, 5419, 5420}, arg2: true);
                context.SetVisibleBreakableObject(
                    arg1: new int[] {5421, 5422, 5423, 5424, 5425, 5426, 5427, 5428, 5429, 5430}, arg2: true);
                context.SetVisibleBreakableObject(
                    arg1: new int[] {5431, 5432, 5433, 5434, 5435, 5436, 5437, 5438, 5439, 5440}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State엘리베이터_도착(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엘리베이터_도착 : TriggerState {
            internal State엘리베이터_도착(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetVisibleBreakableObject(
                    arg1: new int[] {
                        5501, 5502, 5503, 5504, 5505, 5506, 5507, 5508, 5509, 5510, 5511, 5512, 5513, 5514, 5515, 5516,
                        5517, 5518, 5519, 5520, 5521, 5522, 5523, 5524, 5525, 5526, 5527, 5528, 5529, 5530, 5531, 5532,
                        5533, 5534, 5535, 5536, 5537, 5538, 5539, 5540
                    }, arg2: true);
                context.SetBreakable(arg1: new int[] {5401, 5402, 5403, 5404, 5405, 5406, 5407, 5408, 5409, 5410},
                    arg2: false);
                context.SetBreakable(arg1: new int[] {5411, 5412, 5413, 5414, 5415, 5416, 5417, 5418, 5419, 5420},
                    arg2: false);
                context.SetBreakable(arg1: new int[] {5421, 5422, 5423, 5424, 5425, 5426, 5427, 5428, 5429, 5430},
                    arg2: false);
                context.SetBreakable(arg1: new int[] {5431, 5432, 5433, 5434, 5435, 5436, 5437, 5438, 5439, 5440},
                    arg2: false);
                context.SetVisibleBreakableObject(
                    arg1: new int[] {5401, 5402, 5403, 5404, 5405, 5406, 5407, 5408, 5409, 5410}, arg2: false);
                context.SetVisibleBreakableObject(
                    arg1: new int[] {5411, 5412, 5413, 5414, 5415, 5416, 5417, 5418, 5419, 5420}, arg2: false);
                context.SetVisibleBreakableObject(
                    arg1: new int[] {5421, 5422, 5423, 5424, 5425, 5426, 5427, 5428, 5429, 5430}, arg2: false);
                context.SetVisibleBreakableObject(
                    arg1: new int[] {5431, 5432, 5433, 5434, 5435, 5436, 5437, 5438, 5439, 5440}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State아르케온_탈것_생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아르케온_탈것_생성 : TriggerState {
            internal State아르케온_탈것_생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02020301_BF__300006_PHASE_5__4$", arg3: new int[] {4000});
                context.SetUserValue(triggerID: 3000061, key: "Phase_5_Interect_01", value: 1);
                context.SetUserValue(triggerID: 3000062, key: "Phase_5_Interect_02", value: 1);
                context.SetUserValue(triggerID: 3000063, key: "Phase_5_Interect_03", value: 1);
                context.SetUserValue(triggerID: 3000064, key: "Phase_5_Interect_04", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State길막열기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State길막열기 : TriggerState {
            internal State길막열기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {5641, 5642, 5643, 5644}, arg2: false);
                context.SetAgent(
                    arg1:
                    "1810000,1810001,1810002,1810003,1810004,1810005,1810006,1810007,1810008,1810009,1810010,1810011",
                    arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State아르케온_탈것_리셋(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아르케온_탈것_리셋 : TriggerState {
            internal State아르케온_탈것_리셋(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 3000061, key: "Phase_5_Interect_01", value: 0);
                context.SetUserValue(triggerID: 3000062, key: "Phase_5_Interect_02", value: 0);
                context.SetUserValue(triggerID: 3000063, key: "Phase_5_Interect_03", value: 0);
                context.SetUserValue(triggerID: 3000064, key: "Phase_5_Interect_04", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    // context.State = new State게임_종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}