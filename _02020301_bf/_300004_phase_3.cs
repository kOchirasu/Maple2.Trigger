using System;

namespace Maple2.Trigger._02020301_bf {
    public static class _300004_phase_3 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {200011, 200012, 200013, 200014, 200015, 200016, 200017, 200018},
                    arg2: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "AI_Phase", value: 3)) {
                    context.State = new State패이즈_3_시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패이즈_3_시작 : TriggerState {
            internal State패이즈_3_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {1003}, arg2: 62100168, arg3: 1);
                context.DestroyMonster(arg1: new int[] {701});
                context.DestroyMonster(arg1: new int[] {702});
                context.DestroyMonster(arg1: new int[] {703});
                context.DestroyMonster(arg1: new int[] {704});
                context.DestroyMonster(arg1: new int[] {705});
                context.DestroyMonster(arg1: new int[] {706});
                context.SetUserValue(triggerID: 3000032, key: "Phase_2_Interect_02", value: 0);
                context.SetUserValue(triggerID: 3000033, key: "Phase_2_Interect_03", value: 0);
                context.SetUserValue(triggerID: 3000034, key: "Phase_2_Interect_04", value: 0);
                context.SetUserValue(triggerID: 3000035, key: "Phase_2_Interect_05", value: 0);
                context.SetUserValue(triggerID: 3000036, key: "Phase_2_Interect_06", value: 0);
                context.SetUserValue(triggerID: 3000037, key: "Phase_2_Interect_07", value: 0);
                context.RemoveBuff(arg1: 1001, arg2: 73000004, arg3: "True");
                context.SetUserValue(triggerID: 3000031, key: "Phase_2_Interect_01", value: 0);
                context.SideNpcTalk(type: "talk", npcID: 11004205, illust: "ArcaneBlader_unfair",
                    script: "$02020301_BF__300004_PHASE_3__0$", duration: 3176);
                context.SideNpcTalk(type: "talk", npcID: 11004205, illust: "ArcaneBlader_unfair",
                    script: "$02020301_BF__300004_PHASE_3__1$", duration: 3176);
                context.SetUserValue(key: "AI_Phase", value: 0);
                context.SetVisibleBreakableObject(
                    arg1: new int[]
                        {5171, 5172, 5173, 5174, 5175, 5176, 5177, 5178, 5179, 5180, 5181, 5182, 5183, 5184},
                    arg2: true);
                context.SetVisibleBreakableObject(
                    arg1: new int[]
                        {5151, 5152, 5153, 5154, 5155, 5156, 5157, 5158, 5159, 5160, 5161, 5162, 5163, 5164},
                    arg2: true);
                context.SetBreakable(
                    arg1: new int[]
                        {5171, 5172, 5173, 5174, 5175, 5176, 5177, 5178, 5179, 5180, 5181, 5182, 5183, 5184},
                    arg2: true);
                context.SetBreakable(
                    arg1: new int[]
                        {5151, 5152, 5153, 5154, 5155, 5156, 5157, 5158, 5159, 5160, 5161, 5162, 5163, 5164},
                    arg2: true);
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
                context.SetUserValue(key: "AI_Phase", value: 0);
                context.SetVisibleBreakableObject(
                    arg1: new int[]
                        {5351, 5352, 5353, 5354, 5355, 5356, 5357, 5358, 5359, 5360, 5361, 5362, 5363, 5364},
                    arg2: true);
                context.SetVisibleBreakableObject(
                    arg1: new int[]
                        {5371, 5372, 5373, 5374, 5375, 5376, 5377, 5378, 5379, 5380, 5381, 5382, 5383, 5384},
                    arg2: true);
                context.SetBreakable(
                    arg1: new int[]
                        {5171, 5172, 5173, 5174, 5175, 5176, 5177, 5178, 5179, 5180, 5181, 5182, 5183, 5184},
                    arg2: false);
                context.SetBreakable(
                    arg1: new int[]
                        {5151, 5152, 5153, 5154, 5155, 5156, 5157, 5158, 5159, 5160, 5161, 5162, 5163, 5164},
                    arg2: false);
                context.SetVisibleBreakableObject(
                    arg1: new int[]
                        {5171, 5172, 5173, 5174, 5175, 5176, 5177, 5178, 5179, 5180, 5181, 5182, 5183, 5184},
                    arg2: false);
                context.SetVisibleBreakableObject(
                    arg1: new int[]
                        {5151, 5152, 5153, 5154, 5155, 5156, 5157, 5158, 5159, 5160, 5161, 5162, 5163, 5164},
                    arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State포탑_생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포탑_생성 : TriggerState {
            internal State포탑_생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {512}, arg2: true);
                context.CreateMonster(arg1: new int[] {511}, arg2: true);
                context.SetUserValue(triggerID: 3000041, key: "Phase_3_Interect_01", value: 1);
                context.SetUserValue(triggerID: 3000042, key: "Phase_3_Interect_02", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State가이드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State가이드 : TriggerState {
            internal State가이드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02020301_BF__300004_PHASE_3__2$", arg3: new int[] {4000});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    // context.State = new State엘리베이터_대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}