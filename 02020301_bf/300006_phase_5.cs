using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02020301_bf {
    public static class _300006_phase_5 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "AI_Phase") == 5) {
                    return new State패이즈_5_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State패이즈_5_시작 : TriggerState {
            internal State패이즈_5_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{111});
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11004205, illust: "ArcaneBlader_unfair", script: "$02020301_BF__300006_PHASE_5__0$", duration: 3176);
                context.SetEffect(triggerIds: new []{200021, 200022, 200023, 200024, 200025, 200026, 200027, 200028}, visible: false);
                context.SetUserValue(key: "AI_Phase", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Portal_On_04") == 1) {
                    return new StatePortal_오픈_Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortal_오픈_Wait : TriggerState {
            internal StatePortal_오픈_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePortal_오픈(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortal_오픈 : TriggerState {
            internal StatePortal_오픈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3000051, key: "Phase_4_Interect_01", value: 0);
                context.SetUserValue(triggerId: 3000052, key: "Phase_4_Interect_02", value: 0);
                context.SetUserValue(triggerId: 3000053, key: "Phase_4_Interect_03", value: 0);
                context.SetUserValue(triggerId: 3000054, key: "Phase_4_Interect_04", value: 0);
                context.SetEffect(triggerIds: new []{200001, 200002, 200003, 200004, 200005, 200006, 200007, 200008}, visible: false);
                context.SetPortal(portalId: 4, visible: true, enabled: true, minimapVisible: true);
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11004205, illust: "ArcaneBlader_unfair", script: "$02020301_BF__300006_PHASE_5__1$", duration: 3176);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{1002})) {
                    return new State엘리베이터_동작_Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엘리베이터_동작_Wait : TriggerState {
            internal State엘리베이터_동작_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "Last_Phase", value: 1, isModify: false);
                context.SetUserValue(triggerId: 3000051, key: "Phase_4_Interect_01", value: 0);
                context.SetUserValue(triggerId: 3000052, key: "Phase_4_Interect_02", value: 0);
                context.SetUserValue(triggerId: 3000053, key: "Phase_4_Interect_03", value: 0);
                context.SetUserValue(triggerId: 3000054, key: "Phase_4_Interect_04", value: 0);
                context.SetEffect(triggerIds: new []{200001, 200002, 200003, 200004, 200005, 200006, 200007, 200008}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new State택스트_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State택스트_1 : TriggerState {
            internal State택스트_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11004205, illust: "ArcaneBlader_unfair", script: "$02020301_BF__300006_PHASE_5__2$", duration: 3176);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State택스트_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State택스트_2 : TriggerState {
            internal State택스트_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11004205, illust: "ArcaneBlader_normal", script: "$02020301_BF__300006_PHASE_5__3$", duration: 3176);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State엘리베이터_동작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엘리베이터_동작 : TriggerState {
            internal State엘리베이터_동작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(triggerIds: new []{5401, 5402, 5403, 5404, 5405, 5406, 5407, 5408, 5409, 5410, 5411, 5412, 5413, 5414, 5415, 5416, 5417, 5418, 5419, 5420, 5421, 5422, 5423, 5424, 5425, 5426, 5427, 5428, 5429, 5430, 5431, 5432, 5433, 5434, 5435, 5436, 5437, 5438, 5439, 5440}, enabled: true);
                context.SetVisibleBreakableObject(triggerIds: new []{5401, 5402, 5403, 5404, 5405, 5406, 5407, 5408, 5409, 5410, 5411, 5412, 5413, 5414, 5415, 5416, 5417, 5418, 5419, 5420, 5421, 5422, 5423, 5424, 5425, 5426, 5427, 5428, 5429, 5430, 5431, 5432, 5433, 5434, 5435, 5436, 5437, 5438, 5439, 5440}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State엘리베이터_도착(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엘리베이터_도착 : TriggerState {
            internal State엘리베이터_도착(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetVisibleBreakableObject(triggerIds: new []{5501, 5502, 5503, 5504, 5505, 5506, 5507, 5508, 5509, 5510, 5511, 5512, 5513, 5514, 5515, 5516, 5517, 5518, 5519, 5520, 5521, 5522, 5523, 5524, 5525, 5526, 5527, 5528, 5529, 5530, 5531, 5532, 5533, 5534, 5535, 5536, 5537, 5538, 5539, 5540}, visible: true);
                context.SetBreakable(triggerIds: new []{5401, 5402, 5403, 5404, 5405, 5406, 5407, 5408, 5409, 5410, 5411, 5412, 5413, 5414, 5415, 5416, 5417, 5418, 5419, 5420, 5421, 5422, 5423, 5424, 5425, 5426, 5427, 5428, 5429, 5430, 5431, 5432, 5433, 5434, 5435, 5436, 5437, 5438, 5439, 5440}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{5401, 5402, 5403, 5404, 5405, 5406, 5407, 5408, 5409, 5410, 5411, 5412, 5413, 5414, 5415, 5416, 5417, 5418, 5419, 5420, 5421, 5422, 5423, 5424, 5425, 5426, 5427, 5428, 5429, 5430, 5431, 5432, 5433, 5434, 5435, 5436, 5437, 5438, 5439, 5440}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State아르케온_탈것_Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르케온_탈것_Creation : TriggerState {
            internal State아르케온_탈것_Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02020301_BF__300006_PHASE_5__4$", duration: 4000);
                context.SetUserValue(triggerId: 3000061, key: "Phase_5_Interect_01", value: 1);
                context.SetUserValue(triggerId: 3000062, key: "Phase_5_Interect_02", value: 1);
                context.SetUserValue(triggerId: 3000063, key: "Phase_5_Interect_03", value: 1);
                context.SetUserValue(triggerId: 3000064, key: "Phase_5_Interect_04", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State길막열기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State길막열기 : TriggerState {
            internal State길막열기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{5641, 5642, 5643, 5644}, visible: false);
                context.SetAgent(triggerIds: new []{1810000, 1810001, 1810002, 1810003, 1810004, 1810005, 1810006, 1810007, 1810008, 1810009, 1810010, 1810011}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new State아르케온_탈것_리셋(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르케온_탈것_리셋 : TriggerState {
            internal State아르케온_탈것_리셋(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3000061, key: "Phase_5_Interect_01", value: 0);
                context.SetUserValue(triggerId: 3000062, key: "Phase_5_Interect_02", value: 0);
                context.SetUserValue(triggerId: 3000063, key: "Phase_5_Interect_03", value: 0);
                context.SetUserValue(triggerId: 3000064, key: "Phase_5_Interect_04", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    // return new State게임_종료(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
