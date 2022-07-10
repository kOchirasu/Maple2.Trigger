using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52100301_qd {
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
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11004205, illust: "ArcaneBlader_unfair", script: "$52100301_QD__300006_PHASE_5__0$", duration: 3176);
                context.SetEffect(triggerIds: new []{200021, 200022, 200023, 200024, 200025, 200026, 200027, 200028}, visible: false);
                context.SetUserValue(key: "AI_Phase", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3000051, key: "Phase_4_Interect_01", value: 0);
                context.SetUserValue(triggerId: 3000052, key: "Phase_4_Interect_02", value: 0);
                context.SetUserValue(triggerId: 3000053, key: "Phase_4_Interect_03", value: 0);
                context.SetUserValue(triggerId: 3000054, key: "Phase_4_Interect_04", value: 0);
                context.SetEffect(triggerIds: new []{200001, 200002, 200003, 200004, 200005, 200006, 200007, 200008}, visible: false);
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11004205, illust: "ArcaneBlader_unfair", script: "$52100301_QD__300006_PHASE_5__1$", duration: 3176);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State아르케온_Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르케온_Spawn : TriggerState {
            internal State아르케온_Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "AI_Phase", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State아르케온_탈것_Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르케온_탈것_Creation : TriggerState {
            internal State아르케온_탈것_Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3000061, key: "Phase_5_Interect_01", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    // return new State게임종료(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
