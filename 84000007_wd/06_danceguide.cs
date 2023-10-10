namespace Maple2.Trigger._84000007_wd {
    public static class _06_danceguide {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "DanceGuide") == 1) {
                    return new StateDanceGuideP1_Random(context);
                }

                if (context.GetUserValue(key: "DanceGuide") == 2) {
                    return new StateDanceGuideP2_Random(context);
                }

                if (context.GetUserValue(key: "DanceGuide") == 3) {
                    return new StateDanceGuideP3_01(context);
                }

                if (context.GetUserValue(key: "DanceGuide") == 41) {
                    return new StateDanceGuideP41_01(context);
                }

                if (context.GetUserValue(key: "DanceGuide") == 42) {
                    return new StateDanceGuideP42_01(context);
                }

                if (context.GetUserValue(key: "DanceGuide") == 51) {
                    return new StateDanceGuideP51_01(context);
                }

                if (context.GetUserValue(key: "DanceGuide") == 52) {
                    return new StateDanceGuideP52_01(context);
                }

                if (context.GetUserValue(key: "DanceGuide") == 61) {
                    return new StateDanceGuideP61_01(context);
                }

                if (context.GetUserValue(key: "DanceGuide") == 62) {
                    return new StateDanceGuideP62_01(context);
                }

                if (context.GetUserValue(key: "DanceGuide") == 71) {
                    return new StateDanceGuideP71_01(context);
                }

                if (context.GetUserValue(key: "DanceGuide") == 72) {
                    return new StateDanceGuideP72_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP1_Random : TriggerState {
            internal StateDanceGuideP1_Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 50)) {
                    return new StateDanceGuideP11_01(context);
                }

                if (context.RandomCondition(rate: 50)) {
                    return new StateDanceGuideP12_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP2_Random : TriggerState {
            internal StateDanceGuideP2_Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 50)) {
                    return new StateDanceGuideP21_01(context);
                }

                if (context.RandomCondition(rate: 50)) {
                    return new StateDanceGuideP22_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP11_01 : TriggerState {
            internal StateDanceGuideP11_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26100801, textId: 26100801, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateDanceGuideP11_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP11_02 : TriggerState {
            internal StateDanceGuideP11_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26100802, textId: 26100802, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP12_01 : TriggerState {
            internal StateDanceGuideP12_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26100801, textId: 26100801, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateDanceGuideP12_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP12_02 : TriggerState {
            internal StateDanceGuideP12_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 28400703, textId: 28400703, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP21_01 : TriggerState {
            internal StateDanceGuideP21_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26100801, textId: 26100801, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateDanceGuideP21_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP21_02 : TriggerState {
            internal StateDanceGuideP21_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26100802, textId: 26100802, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP22_01 : TriggerState {
            internal StateDanceGuideP22_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26100801, textId: 26100801, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateDanceGuideP22_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP22_02 : TriggerState {
            internal StateDanceGuideP22_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 28400703, textId: 28400703, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP3_01 : TriggerState {
            internal StateDanceGuideP3_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26100801, textId: 26100801, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateDanceGuideP3_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP3_02 : TriggerState {
            internal StateDanceGuideP3_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26100802, textId: 26100802, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateDanceGuideP3_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP3_03 : TriggerState {
            internal StateDanceGuideP3_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 28400703, textId: 28400703, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP41_01 : TriggerState {
            internal StateDanceGuideP41_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26100801, textId: 26100801, duration: 6000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP42_01 : TriggerState {
            internal StateDanceGuideP42_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26100802, textId: 26100802, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateDanceGuideP42_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP42_02 : TriggerState {
            internal StateDanceGuideP42_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 28400703, textId: 28400703, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP51_01 : TriggerState {
            internal StateDanceGuideP51_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26100801, textId: 26100801, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateDanceGuideP51_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP51_02 : TriggerState {
            internal StateDanceGuideP51_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 28400703, textId: 28400703, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP52_01 : TriggerState {
            internal StateDanceGuideP52_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26100802, textId: 26100802, duration: 6000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP61_01 : TriggerState {
            internal StateDanceGuideP61_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26100801, textId: 26100801, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateDanceGuideP61_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP61_02 : TriggerState {
            internal StateDanceGuideP61_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26100802, textId: 26100802, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP62_01 : TriggerState {
            internal StateDanceGuideP62_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 28400703, textId: 28400703, duration: 6000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP71_01 : TriggerState {
            internal StateDanceGuideP71_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26100801, textId: 26100801, duration: 6000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP72_01 : TriggerState {
            internal StateDanceGuideP72_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 28400703, textId: 28400703, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateDanceGuideP72_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP72_02 : TriggerState {
            internal StateDanceGuideP72_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26100802, textId: 26100802, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "DanceGuide", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
