namespace Maple2.Trigger._61000022_me {
    public static class _07_gameguide {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "GameGuide") == 1) {
                    return new StateGameGuideR1_30(context);
                }

                if (context.GetUserValue(key: "GameGuide") == 2) {
                    return new StateGameGuideR2_20(context);
                }

                if (context.GetUserValue(key: "GameGuide") == 3) {
                    return new StateGameGuideR3_15(context);
                }

                if (context.GetUserValue(key: "GameGuide") == 4) {
                    return new StateGameGuideR4_10(context);
                }

                if (context.GetUserValue(key: "GameGuide") == 5) {
                    return new StateGameGuideR5_10(context);
                }

                if (context.GetUserValue(key: "GameGuide") == 6) {
                    return new StateGambleGuideR4_15(context);
                }

                if (context.GetUserValue(key: "GameGuide") == 7) {
                    return new StateJackpotGuideR4_20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGameGuideR1_30 : TriggerState {
            internal StateGameGuideR1_30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 29, arg3: true, arg4: false);
            }

            public override TriggerState Execute() {
                return new StateNormalGameGuide_01(context);
            }

            public override void OnExit() { }
        }

        private class StateGameGuideR2_20 : TriggerState {
            internal StateGameGuideR2_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 19, arg3: true, arg4: false);
            }

            public override TriggerState Execute() {
                return new StateNormalGameGuide_01(context);
            }

            public override void OnExit() { }
        }

        private class StateGameGuideR3_15 : TriggerState {
            internal StateGameGuideR3_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14, arg3: true, arg4: false);
            }

            public override TriggerState Execute() {
                return new StateNormalGameGuide_01(context);
            }

            public override void OnExit() { }
        }

        private class StateGameGuideR4_10 : TriggerState {
            internal StateGameGuideR4_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 9, arg3: true, arg4: false);
            }

            public override TriggerState Execute() {
                return new StateNormalGameGuide_01(context);
            }

            public override void OnExit() { }
        }

        private class StateGameGuideR5_10 : TriggerState {
            internal StateGameGuideR5_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 9, arg3: true, arg4: false);
            }

            public override TriggerState Execute() {
                return new StateNormalGameGuide_01(context);
            }

            public override void OnExit() { }
        }

        private class StateNormalGameGuide_01 : TriggerState {
            internal StateNormalGameGuide_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26100804, textId: 26100804, duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateNormalGameGuide_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNormalGameGuide_02 : TriggerState {
            internal StateNormalGameGuide_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26100805, textId: 26100805, duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateNormalGameGuide_03(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNormalGameGuide_03 : TriggerState {
            internal StateNormalGameGuide_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26100808, textId: 26100808, duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateNormalGameGuide_04(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNormalGameGuide_04 : TriggerState {
            internal StateNormalGameGuide_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26100804, textId: 26100804, duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateNormalGameGuide_05(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNormalGameGuide_05 : TriggerState {
            internal StateNormalGameGuide_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26100805, textId: 26100805, duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateNormalGameGuide_06(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNormalGameGuide_06 : TriggerState {
            internal StateNormalGameGuide_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26100808, textId: 26100808, duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateReset(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGambleGuideR4_15 : TriggerState {
            internal StateGambleGuideR4_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14, arg3: true, arg4: false);
            }

            public override TriggerState Execute() {
                return new StateGambleGameGuide_01(context);
            }

            public override void OnExit() { }
        }

        private class StateJackpotGuideR4_20 : TriggerState {
            internal StateJackpotGuideR4_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 19, arg3: true, arg4: false);
            }

            public override TriggerState Execute() {
                return new StateGambleGameGuide_01(context);
            }

            public override void OnExit() { }
        }

        private class StateGambleGameGuide_01 : TriggerState {
            internal StateGambleGameGuide_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26100806, textId: 26100806, duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateGambleGameGuide_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGambleGameGuide_02 : TriggerState {
            internal StateGambleGameGuide_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26100807, textId: 26100807, duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateGambleGameGuide_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGambleGameGuide_03 : TriggerState {
            internal StateGambleGameGuide_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26100808, textId: 26100808, duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateGambleGameGuide_04(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGambleGameGuide_04 : TriggerState {
            internal StateGambleGameGuide_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26100806, textId: 26100806, duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateReset(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "GameGuide", value: 0);
                context.ResetTimer(id: "1");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}