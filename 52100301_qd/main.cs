using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52100301_qd {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300002, key: "Phase_1", value: 0);
                context.SetUserValue(triggerId: 300003, key: "Phase_2", value: 0);
                context.SetUserValue(triggerId: 300004, key: "Phase_3", value: 0);
                context.SetUserValue(triggerId: 300005, key: "Phase_4", value: 0);
                context.SetUserValue(triggerId: 300006, key: "Phase_5", value: 0);
                context.SetMesh(arg1: new[] {5241, 5242, 5243, 5244, 5641, 5642, 5643, 5644}, arg2: true);
                context.SetBreakable(arg1: new[] {5171, 5172, 5173, 5174, 5175, 5176, 5177, 5178, 5179, 5180, 5181, 5182, 5183, 5184, 5151, 5152, 5153, 5154, 5155, 5156, 5157, 5158, 5159, 5160, 5161, 5162, 5163, 5164, 5101, 5102, 5103, 5104, 5105, 5106, 5107, 5108, 5109, 5110, 5111, 5112, 5113, 5114, 5115, 5116, 5117, 5118, 5119, 5120, 5121, 5122, 5123, 5124, 5125, 5126, 5127, 5128, 5129, 5130, 5131, 5132, 5133, 5134, 5135, 5136, 5137, 5138, 5139, 5140, 5401, 5402, 5403, 5404, 5405, 5406, 5407, 5408, 5409, 5410, 5411, 5412, 5413, 5414, 5415, 5416, 5417, 5418, 5419, 5420, 5421, 5422, 5423, 5424, 5425, 5426, 5427, 5428, 5429, 5430, 5431, 5432, 5433, 5434, 5435, 5436, 5437, 5438, 5439, 5440}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {5351, 5352, 5353, 5354, 5355, 5356, 5357, 5358, 5359, 5360, 5361, 5362, 5363, 5364, 5371, 5372, 5373, 5374, 5375, 5376, 5377, 5378, 5379, 5380, 5381, 5382, 5383, 5384, 5351, 5352, 5353, 5354, 5355, 5356, 5357, 5358, 5359, 5360, 5361, 5362, 5363, 5364, 5371, 5372, 5373, 5374, 5375, 5376, 5377, 5378, 5379, 5380, 5381, 5382, 5383, 5384, 5301, 5302, 5303, 5304, 5305, 5306, 5307, 5308, 5309, 5310, 5311, 5312, 5313, 5314, 5315, 5316, 5317, 5318, 5319, 5320, 5321, 5322, 5323, 5324, 5325, 5326, 5327, 5328, 5329, 5330, 5331, 5332, 5333, 5334, 5335, 5336, 5337, 5338, 5339, 5340, 5101, 5102, 5103, 5104, 5105, 5106, 5107, 5108, 5109, 5110, 5111, 5112, 5113, 5114, 5115, 5116, 5117, 5118, 5119, 5120, 5121, 5122, 5123, 5124, 5125, 5126, 5127, 5128, 5129, 5130, 5131, 5132, 5133, 5134, 5135, 5136, 5137, 5138, 5139, 5140, 5401, 5402, 5403, 5404, 5405, 5406, 5407, 5408, 5409, 5410, 5411, 5412, 5413, 5414, 5415, 5416, 5417, 5418, 5419, 5420, 5421, 5422, 5423, 5424, 5425, 5426, 5427, 5428, 5429, 5430, 5431, 5432, 5433, 5434, 5435, 5436, 5437, 5438, 5439, 5440, 5501, 5502, 5503, 5504, 5505, 5506, 5507, 5508, 5509, 5510, 5511, 5512, 5513, 5514, 5515, 5516, 5517, 5518, 5519, 5520, 5521, 5522, 5523, 5524, 5525, 5526, 5527, 5528, 5529, 5530, 5531, 5532, 5533, 5534, 5535, 5536, 5537, 5538, 5539, 5540}, arg2: false);
                context.SetInteractObject(arg1: new[] {10003126, 10003121, 10003122, 10003111, 10003112, 10003113, 10003114, 10003101, 10003102, 10003103, 10003104}, arg2: 2);
                context.SetAgent(arg1: new[] {1800000, 1800001, 1800002, 1800003, 1800004, 1800005, 1800006, 1800007, 1800008, 1800009, 1800010, 1800011, 1810000, 1810001, 1810002, 1810003, 1810004, 1810005, 1810006, 1810007, 1810008, 1810009, 1810010, 1810011}, arg2: true);
                context.AddBuff(arg1: new[] {1003}, arg2: 62100168, arg3: 1);
                context.SetPortal(portalId: 7, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 13, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 14, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 15, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 16, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {1001})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {5241, 5242, 5243, 5244}, arg2: true);
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 29500101, illust: "ArcheonBlack_Normal", script: "$52100301_QD__MAIN__0$", duration: 5684);
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.CreateMonster(arg1: new[] {111, 112, 113, 114, 115, 121, 122, 123, 124}, arg2: true);
                context.SetPortal(portalId: 13, visible: false, enabled: true, minimapVisible: false);
                context.SetPortal(portalId: 14, visible: false, enabled: true, minimapVisible: false);
                context.SetPortal(portalId: 15, visible: false, enabled: true, minimapVisible: false);
                context.SetPortal(portalId: 16, visible: false, enabled: true, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State조건추가(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조건추가 : TriggerState {
            internal State조건추가(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateBoss_Success(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_Success : TriggerState {
            internal StateBoss_Success(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10003126}, arg2: 2);
                context.SetUserValue(triggerId: 3000061, key: "Phase_5_Interect_01", value: 0);
                context.AddBuff(arg1: new[] {1003}, arg2: 62100169, arg3: 1);
                context.DungeonMissionComplete(missionId: 23039005);
                context.DungeonSetEndTime();
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 29500101, illust: "ArcheonBlack_Die", script: "$52100301_QD__MAIN__1$", duration: 3176);
                context.SetAchievement(arg2: "trigger", arg3: "KillArcheon");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State추가대화(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State추가대화 : TriggerState {
            internal State추가대화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11004205, illust: "ArcaneBlader_normal", script: "$52100301_QD__MAIN__2$", duration: 3176);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {-1});
                context.DungeonClear();
                context.SetPortal(portalId: 7, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}