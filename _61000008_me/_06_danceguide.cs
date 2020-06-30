using System;

namespace Maple2.Trigger._61000008_me {
    public static class _06_danceguide {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "DanceGuide", value: 1)) {
                    context.State = new StateDanceGuideP1_Random(context);
                    return;
                }

                if (context.UserValue(key: "DanceGuide", value: 2)) {
                    context.State = new StateDanceGuideP2_Random(context);
                    return;
                }

                if (context.UserValue(key: "DanceGuide", value: 3)) {
                    context.State = new StateDanceGuideP3_01(context);
                    return;
                }

                if (context.UserValue(key: "DanceGuide", value: 41)) {
                    context.State = new StateDanceGuideP41_01(context);
                    return;
                }

                if (context.UserValue(key: "DanceGuide", value: 42)) {
                    context.State = new StateDanceGuideP42_01(context);
                    return;
                }

                if (context.UserValue(key: "DanceGuide", value: 51)) {
                    context.State = new StateDanceGuideP51_01(context);
                    return;
                }

                if (context.UserValue(key: "DanceGuide", value: 52)) {
                    context.State = new StateDanceGuideP52_01(context);
                    return;
                }

                if (context.UserValue(key: "DanceGuide", value: 61)) {
                    context.State = new StateDanceGuideP61_01(context);
                    return;
                }

                if (context.UserValue(key: "DanceGuide", value: 62)) {
                    context.State = new StateDanceGuideP62_01(context);
                    return;
                }

                if (context.UserValue(key: "DanceGuide", value: 71)) {
                    context.State = new StateDanceGuideP71_01(context);
                    return;
                }

                if (context.UserValue(key: "DanceGuide", value: 72)) {
                    context.State = new StateDanceGuideP72_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP1_Random : TriggerState {
            internal StateDanceGuideP1_Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateDanceGuideP11_01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateDanceGuideP12_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP2_Random : TriggerState {
            internal StateDanceGuideP2_Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateDanceGuideP21_01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateDanceGuideP22_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP11_01 : TriggerState {
            internal StateDanceGuideP11_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26100801, textID: 26100801, duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateDanceGuideP11_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP11_02 : TriggerState {
            internal StateDanceGuideP11_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26100802, textID: 26100802, duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP12_01 : TriggerState {
            internal StateDanceGuideP12_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26100801, textID: 26100801, duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateDanceGuideP12_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP12_02 : TriggerState {
            internal StateDanceGuideP12_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26100803, textID: 26100803, duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP21_01 : TriggerState {
            internal StateDanceGuideP21_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26100801, textID: 26100801, duration: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateDanceGuideP21_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP21_02 : TriggerState {
            internal StateDanceGuideP21_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26100802, textID: 26100802, duration: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP22_01 : TriggerState {
            internal StateDanceGuideP22_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26100801, textID: 26100801, duration: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateDanceGuideP22_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP22_02 : TriggerState {
            internal StateDanceGuideP22_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26100803, textID: 26100803, duration: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP3_01 : TriggerState {
            internal StateDanceGuideP3_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26100801, textID: 26100801, duration: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateDanceGuideP3_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP3_02 : TriggerState {
            internal StateDanceGuideP3_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26100802, textID: 26100802, duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateDanceGuideP3_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP3_03 : TriggerState {
            internal StateDanceGuideP3_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26100803, textID: 26100803, duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP41_01 : TriggerState {
            internal StateDanceGuideP41_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26100801, textID: 26100801, duration: 6000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP42_01 : TriggerState {
            internal StateDanceGuideP42_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26100802, textID: 26100802, duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateDanceGuideP42_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP42_02 : TriggerState {
            internal StateDanceGuideP42_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26100803, textID: 26100803, duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP51_01 : TriggerState {
            internal StateDanceGuideP51_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26100801, textID: 26100801, duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateDanceGuideP51_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP51_02 : TriggerState {
            internal StateDanceGuideP51_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26100803, textID: 26100803, duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP52_01 : TriggerState {
            internal StateDanceGuideP52_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26100802, textID: 26100802, duration: 6000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP61_01 : TriggerState {
            internal StateDanceGuideP61_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26100801, textID: 26100801, duration: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateDanceGuideP61_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP61_02 : TriggerState {
            internal StateDanceGuideP61_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26100802, textID: 26100802, duration: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP62_01 : TriggerState {
            internal StateDanceGuideP62_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26100803, textID: 26100803, duration: 6000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP71_01 : TriggerState {
            internal StateDanceGuideP71_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26100801, textID: 26100801, duration: 6000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP72_01 : TriggerState {
            internal StateDanceGuideP72_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26100803, textID: 26100803, duration: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateDanceGuideP72_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDanceGuideP72_02 : TriggerState {
            internal StateDanceGuideP72_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26100802, textID: 26100802, duration: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "DanceGuide", value: 0);
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