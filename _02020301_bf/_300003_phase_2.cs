namespace Maple2.Trigger._02020301_bf {
    public static class _300003_phase_2 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "AI_Phase") == 2) {
                    return new State패이즈_2_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State패이즈_2_시작 : TriggerState {
            internal State패이즈_2_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "AI_Phase", value: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State아르케온_탈것_생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르케온_탈것_생성 : TriggerState {
            internal State아르케온_탈것_생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3000031, key: "Phase_2_Interect_01", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new State쫄몹등장(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쫄몹등장 : TriggerState {
            internal State쫄몹등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3000032, key: "Phase_2_Interect_02", value: 1);
                context.SetUserValue(triggerId: 3000033, key: "Phase_2_Interect_03", value: 1);
                context.SetUserValue(triggerId: 3000034, key: "Phase_2_Interect_04", value: 1);
                context.SetUserValue(triggerId: 3000035, key: "Phase_2_Interect_05", value: 1);
                context.SetUserValue(triggerId: 3000036, key: "Phase_2_Interect_06", value: 1);
                context.SetUserValue(triggerId: 3000037, key: "Phase_2_Interect_07", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) { }

                return null;
            }

            public override void OnExit() { }
        }
    }
}