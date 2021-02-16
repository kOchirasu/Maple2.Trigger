namespace Maple2.Trigger._63000014_cs {
    public static class _checkstone01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetInteractObject(arg1: new[] {10001004}, arg2: 2);
                context.SetMesh(arg1: new[] {3000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {5000, 5001, 5002, 5100, 5101, 5102, 5103, 5200, 5201, 5202, 5203, 5204, 5205, 5206, 5207, 5208, 5209, 5210, 5300, 5301, 5302, 5303, 5304, 5305, 5306, 5307, 5308, 5309, 5310, 5311, 5312, 5313, 5400}, arg2: false);
                context.CreateMonster(arg1: new[] {101}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    return new StateLodingDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLodingDelay01 : TriggerState {
            internal StateLodingDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000450}, arg3: new byte[] {1})) {
                    return new StateQuestOnGoing30(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000449}, arg3: new byte[] {3})) {
                    return new StateQuestOnGoing22(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000449}, arg3: new byte[] {2})) {
                    return new StateQuestOnGoing21(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000449}, arg3: new byte[] {1})) {
                    return new StateQuestOnGoing20(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000448}, arg3: new byte[] {3})) {
                    return new StateQuestOnGoing10(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000448}, arg3: new byte[] {2})) {
                    return new StateFirstQuestEnd01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing10 : TriggerState {
            internal StateQuestOnGoing10(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateSecondQuestStart01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing20 : TriggerState {
            internal StateQuestOnGoing20(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateMoveToFindStone01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing21 : TriggerState {
            internal StateQuestOnGoing21(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateSecondQuestEnd01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing22 : TriggerState {
            internal StateQuestOnGoing22(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateThirdQuestStart01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing30 : TriggerState {
            internal StateQuestOnGoing30(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateMoveToNextMap01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFirstQuestEnd01 : TriggerState {
            internal StateFirstQuestEnd01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: false);
                context.ShowGuideSummary(entityId: 10030100, textId: 10030100);
                context.SetEffect(arg1: new[] {5100, 5101, 5102, 5103}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9003})) {
                    return new StateFirstQuestEnd02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFirstQuestEnd02 : TriggerState {
            internal StateFirstQuestEnd02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5002}, arg2: true);
                context.SetEffect(arg1: new[] {5100, 5101, 5102, 5103}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000448}, arg3: new byte[] {3})) {
                    return new StateSecondQuestStart01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10030100);
            }
        }

        private class StateSecondQuestStart01 : TriggerState {
            internal StateSecondQuestStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 10030160, textId: 10030160);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000449}, arg3: new byte[] {1})) {
                    return new StateMoveToFindStone01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMoveToFindStone01 : TriggerState {
            internal StateMoveToFindStone01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001004}, arg2: 1);
                context.SetMesh(arg1: new[] {3000}, arg2: false, arg3: 50, arg4: 0, arg5: 0f);
                context.HideGuideSummary(entityId: 10030160);
                context.SetEffect(arg1: new[] {5000}, arg2: false);
                context.ShowGuideSummary(entityId: 10032010, textId: 10032010);
                context.SetEffect(arg1: new[] {5400, 5200, 5201, 5202, 5203, 5204, 5205, 5206, 5207, 5208, 5209, 5210}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9001})) {
                    return new StateMoveToFindStone02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMoveToFindStone02 : TriggerState {
            internal StateMoveToFindStone02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5002, 5001}, arg2: true);
                context.HideGuideSummary(entityId: 10032010);
                context.ShowGuideSummary(entityId: 10032020, textId: 10032020);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000449}, arg3: new byte[] {2})) {
                    return new StateSecondQuestEnd01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10032020);
                context.SetEffect(arg1: new[] {5400, 5001}, arg2: false);
            }
        }

        private class StateSecondQuestEnd01 : TriggerState {
            internal StateSecondQuestEnd01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 10030100, textId: 10030100);
                context.SetEffect(arg1: new[] {5000}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9003})) {
                    return new StateSecondQuestEnd02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSecondQuestEnd02 : TriggerState {
            internal StateSecondQuestEnd02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5200, 5201, 5202, 5203, 5204, 5205, 5206, 5207, 5208, 5209, 5210}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000449}, arg3: new byte[] {3})) {
                    return new StateThirdQuestStart01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10030100);
            }
        }

        private class StateThirdQuestStart01 : TriggerState {
            internal StateThirdQuestStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 10030160, textId: 10030160);
                context.SetEffect(arg1: new[] {5000}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000450}, arg3: new byte[] {1})) {
                    return new StateMoveToNextMap01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10030160);
            }
        }

        private class StateMoveToNextMap01 : TriggerState {
            internal StateMoveToNextMap01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: true, enabled: false, minimapVisible: true);
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.ShowGuideSummary(entityId: 10032030, textId: 10032030);
                context.SetEffect(arg1: new[] {5300, 5301, 5302, 5303, 5304, 5305, 5306, 5307, 5308, 5309, 5310, 5311, 5312, 5313}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9002})) {
                    return new StateMoveToNextMap02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMoveToNextMap02 : TriggerState {
            internal StateMoveToNextMap02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 10032030);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                context.SetEffect(arg1: new[] {5002, 5000}, arg2: true);
                context.ShowGuideSummary(entityId: 1060, textId: 1060);
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {9900})) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 1060);
                context.DestroyMonster(arg1: new[] {101});
                context.SetEffect(arg1: new[] {5300, 5301, 5302, 5303, 5304, 5305, 5306, 5307, 5308, 5309, 5310, 5311, 5312, 5313}, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}