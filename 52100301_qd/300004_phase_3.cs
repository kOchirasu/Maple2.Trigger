using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52100301_qd {
    public static class _300004_phase_3 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{200011, 200012, 200013, 200014, 200015, 200016, 200017, 200018}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "AI_Phase") == 3) {
                    return new State패이즈_3_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State패이즈_3_시작 : TriggerState {
            internal State패이즈_3_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{1003}, skillId: 62100168, level: 1);
                context.DestroyMonster(spawnIds: new []{701, 702, 703, 704, 705, 706});
                context.SetUserValue(triggerId: 3000032, key: "Phase_2_Interect_02", value: 0);
                context.SetUserValue(triggerId: 3000033, key: "Phase_2_Interect_03", value: 0);
                context.SetUserValue(triggerId: 3000034, key: "Phase_2_Interect_04", value: 0);
                context.SetUserValue(triggerId: 3000035, key: "Phase_2_Interect_05", value: 0);
                context.SetUserValue(triggerId: 3000036, key: "Phase_2_Interect_06", value: 0);
                context.SetUserValue(triggerId: 3000037, key: "Phase_2_Interect_07", value: 0);
                context.RemoveBuff(boxId: 1001, skillId: 73000004, arg3: true);
                context.SetUserValue(triggerId: 3000031, key: "Phase_2_Interect_01", value: 0);
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11004205, illust: "ArcaneBlader_unfair", script: "$52100301_QD__300004_PHASE_3__0$", duration: 3176);
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11004205, illust: "ArcaneBlader_unfair", script: "$52100301_QD__300004_PHASE_3__1$", duration: 3176);
                context.SetUserValue(key: "AI_Phase", value: 0);
                context.SetVisibleBreakableObject(triggerIds: new []{5171, 5172, 5173, 5174, 5175, 5176, 5177, 5178, 5179, 5180, 5181, 5182, 5183, 5184, 5151, 5152, 5153, 5154, 5155, 5156, 5157, 5158, 5159, 5160, 5161, 5162, 5163, 5164}, arg2: true);
                context.SetBreakable(triggerIds: new []{5171, 5172, 5173, 5174, 5175, 5176, 5177, 5178, 5179, 5180, 5181, 5182, 5183, 5184, 5151, 5152, 5153, 5154, 5155, 5156, 5157, 5158, 5159, 5160, 5161, 5162, 5163, 5164}, enabled: true);
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
                context.SetUserValue(key: "AI_Phase", value: 0);
                context.SetVisibleBreakableObject(triggerIds: new []{5351, 5352, 5353, 5354, 5355, 5356, 5357, 5358, 5359, 5360, 5361, 5362, 5363, 5364, 5371, 5372, 5373, 5374, 5375, 5376, 5377, 5378, 5379, 5380, 5381, 5382, 5383, 5384}, arg2: true);
                context.SetBreakable(triggerIds: new []{5171, 5172, 5173, 5174, 5175, 5176, 5177, 5178, 5179, 5180, 5181, 5182, 5183, 5184, 5151, 5152, 5153, 5154, 5155, 5156, 5157, 5158, 5159, 5160, 5161, 5162, 5163, 5164}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{5171, 5172, 5173, 5174, 5175, 5176, 5177, 5178, 5179, 5180, 5181, 5182, 5183, 5184, 5151, 5152, 5153, 5154, 5155, 5156, 5157, 5158, 5159, 5160, 5161, 5162, 5163, 5164}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State포탑_Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State포탑_Creation : TriggerState {
            internal State포탑_Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{512, 511}, arg2: true);
                context.SetUserValue(triggerId: 3000041, key: "Phase_3_Interect_01", value: 1);
                context.SetUserValue(triggerId: 3000042, key: "Phase_3_Interect_02", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateGuide(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuide : TriggerState {
            internal StateGuide(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$52100301_QD__300004_PHASE_3__2$", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    // return new State엘리베이터_Wait(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
