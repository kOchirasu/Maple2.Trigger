using System;

namespace Maple2.Trigger._84000007_wd {
    public static class _07_gameguide {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "GameGuide", value: 1)) {
                    context.State = new StateGameGuideR1_30(context);
                    return;
                }

                if (context.UserValue(key: "GameGuide", value: 2)) {
                    context.State = new StateGameGuideR2_20(context);
                    return;
                }

                if (context.UserValue(key: "GameGuide", value: 3)) {
                    context.State = new StateGameGuideR3_15(context);
                    return;
                }

                if (context.UserValue(key: "GameGuide", value: 4)) {
                    context.State = new StateGameGuideR4_10(context);
                    return;
                }

                if (context.UserValue(key: "GameGuide", value: 5)) {
                    context.State = new StateGameGuideR5_10(context);
                    return;
                }

                if (context.UserValue(key: "GameGuide", value: 6)) {
                    context.State = new StateGambleGuideR4_15(context);
                    return;
                }

                if (context.UserValue(key: "GameGuide", value: 7)) {
                    context.State = new StateJackpotGuideR4_20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGameGuideR1_30 : TriggerState {
            internal StateGameGuideR1_30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 29, arg3: true, arg4: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNormalGameGuide_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGameGuideR2_20 : TriggerState {
            internal StateGameGuideR2_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 19, arg3: true, arg4: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNormalGameGuide_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGameGuideR3_15 : TriggerState {
            internal StateGameGuideR3_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14, arg3: true, arg4: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNormalGameGuide_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGameGuideR4_10 : TriggerState {
            internal StateGameGuideR4_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 9, arg3: true, arg4: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNormalGameGuide_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGameGuideR5_10 : TriggerState {
            internal StateGameGuideR5_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 9, arg3: true, arg4: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNormalGameGuide_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNormalGameGuide_01 : TriggerState {
            internal StateNormalGameGuide_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26100804, textID: 26100804, durationTime: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateNormalGameGuide_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNormalGameGuide_02 : TriggerState {
            internal StateNormalGameGuide_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26100805, textID: 26100805, durationTime: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateNormalGameGuide_03(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNormalGameGuide_03 : TriggerState {
            internal StateNormalGameGuide_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26100808, textID: 26100808, durationTime: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateNormalGameGuide_04(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNormalGameGuide_04 : TriggerState {
            internal StateNormalGameGuide_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26100804, textID: 26100804, durationTime: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateNormalGameGuide_05(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNormalGameGuide_05 : TriggerState {
            internal StateNormalGameGuide_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26100805, textID: 26100805, durationTime: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateNormalGameGuide_06(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNormalGameGuide_06 : TriggerState {
            internal StateNormalGameGuide_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26100808, textID: 26100808, durationTime: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGambleGuideR4_15 : TriggerState {
            internal StateGambleGuideR4_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14, arg3: true, arg4: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateGambleGameGuide_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJackpotGuideR4_20 : TriggerState {
            internal StateJackpotGuideR4_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 19, arg3: true, arg4: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateGambleGameGuide_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGambleGameGuide_01 : TriggerState {
            internal StateGambleGameGuide_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26100806, textID: 26100806, durationTime: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateGambleGameGuide_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGambleGameGuide_02 : TriggerState {
            internal StateGambleGameGuide_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26100807, textID: 26100807, durationTime: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateGambleGameGuide_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGambleGameGuide_03 : TriggerState {
            internal StateGambleGameGuide_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26100808, textID: 26100808, durationTime: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateGambleGameGuide_04(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGambleGameGuide_04 : TriggerState {
            internal StateGambleGameGuide_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26100806, textID: 26100806, durationTime: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "GameGuide", value: 0);
                context.ResetTimer(arg1: "1");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}