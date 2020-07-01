using System;

namespace Maple2.Trigger._63000014_cs {
    public static class _checkstone01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetInteractObject(arg1: new int[] {10001004}, arg2: 2);
                context.SetMesh(arg1: new int[] {3000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {5000}, arg2: false);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
                context.SetEffect(arg1: new int[] {5100}, arg2: false);
                context.SetEffect(arg1: new int[] {5101}, arg2: false);
                context.SetEffect(arg1: new int[] {5102}, arg2: false);
                context.SetEffect(arg1: new int[] {5103}, arg2: false);
                context.SetEffect(arg1: new int[] {5200}, arg2: false);
                context.SetEffect(arg1: new int[] {5201}, arg2: false);
                context.SetEffect(arg1: new int[] {5202}, arg2: false);
                context.SetEffect(arg1: new int[] {5203}, arg2: false);
                context.SetEffect(arg1: new int[] {5204}, arg2: false);
                context.SetEffect(arg1: new int[] {5205}, arg2: false);
                context.SetEffect(arg1: new int[] {5206}, arg2: false);
                context.SetEffect(arg1: new int[] {5207}, arg2: false);
                context.SetEffect(arg1: new int[] {5208}, arg2: false);
                context.SetEffect(arg1: new int[] {5209}, arg2: false);
                context.SetEffect(arg1: new int[] {5210}, arg2: false);
                context.SetEffect(arg1: new int[] {5300}, arg2: false);
                context.SetEffect(arg1: new int[] {5301}, arg2: false);
                context.SetEffect(arg1: new int[] {5302}, arg2: false);
                context.SetEffect(arg1: new int[] {5303}, arg2: false);
                context.SetEffect(arg1: new int[] {5304}, arg2: false);
                context.SetEffect(arg1: new int[] {5305}, arg2: false);
                context.SetEffect(arg1: new int[] {5306}, arg2: false);
                context.SetEffect(arg1: new int[] {5307}, arg2: false);
                context.SetEffect(arg1: new int[] {5308}, arg2: false);
                context.SetEffect(arg1: new int[] {5309}, arg2: false);
                context.SetEffect(arg1: new int[] {5310}, arg2: false);
                context.SetEffect(arg1: new int[] {5311}, arg2: false);
                context.SetEffect(arg1: new int[] {5312}, arg2: false);
                context.SetEffect(arg1: new int[] {5313}, arg2: false);
                context.SetEffect(arg1: new int[] {5400}, arg2: false);
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9000})) {
                    context.State = new StateLodingDelay01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLodingDelay01 : TriggerState {
            internal StateLodingDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {90000450},
                    arg3: new byte[] {1})) {
                    context.State = new StateQuestOnGoing30(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {90000449},
                    arg3: new byte[] {3})) {
                    context.State = new StateQuestOnGoing22(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {90000449},
                    arg3: new byte[] {2})) {
                    context.State = new StateQuestOnGoing21(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {90000449},
                    arg3: new byte[] {1})) {
                    context.State = new StateQuestOnGoing20(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {90000448},
                    arg3: new byte[] {3})) {
                    context.State = new StateQuestOnGoing10(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {90000448},
                    arg3: new byte[] {2})) {
                    context.State = new StateFirstQuestEnd01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing10 : TriggerState {
            internal StateQuestOnGoing10(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new StateSecondQuestStart01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing20 : TriggerState {
            internal StateQuestOnGoing20(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new StateMoveToFindStone01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing21 : TriggerState {
            internal StateQuestOnGoing21(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new StateSecondQuestEnd01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing22 : TriggerState {
            internal StateQuestOnGoing22(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new StateThirdQuestStart01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing30 : TriggerState {
            internal StateQuestOnGoing30(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new StateMoveToNextMap01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFirstQuestEnd01 : TriggerState {
            internal StateFirstQuestEnd01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: false);
                context.ShowGuideSummary(entityID: 10030100, textID: 10030100);
                context.SetEffect(arg1: new int[] {5100}, arg2: true);
                context.SetEffect(arg1: new int[] {5101}, arg2: true);
                context.SetEffect(arg1: new int[] {5102}, arg2: true);
                context.SetEffect(arg1: new int[] {5103}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9003})) {
                    context.State = new StateFirstQuestEnd02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFirstQuestEnd02 : TriggerState {
            internal StateFirstQuestEnd02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5002}, arg2: true);
                context.SetEffect(arg1: new int[] {5100}, arg2: false);
                context.SetEffect(arg1: new int[] {5101}, arg2: false);
                context.SetEffect(arg1: new int[] {5102}, arg2: false);
                context.SetEffect(arg1: new int[] {5103}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {90000448},
                    arg3: new byte[] {3})) {
                    context.State = new StateSecondQuestStart01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 10030100);
            }
        }

        private class StateSecondQuestStart01 : TriggerState {
            internal StateSecondQuestStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 10030160, textID: 10030160);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {90000449},
                    arg3: new byte[] {1})) {
                    context.State = new StateMoveToFindStone01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMoveToFindStone01 : TriggerState {
            internal StateMoveToFindStone01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001004}, arg2: 1);
                context.SetMesh(arg1: new int[] {3000}, arg2: false, arg3: 50, arg4: 0, arg5: 0f);
                context.HideGuideSummary(entityID: 10030160);
                context.SetEffect(arg1: new int[] {5000}, arg2: false);
                context.ShowGuideSummary(entityID: 10032010, textID: 10032010);
                context.SetEffect(arg1: new int[] {5400}, arg2: true);
                context.SetEffect(arg1: new int[] {5200}, arg2: true);
                context.SetEffect(arg1: new int[] {5201}, arg2: true);
                context.SetEffect(arg1: new int[] {5202}, arg2: true);
                context.SetEffect(arg1: new int[] {5203}, arg2: true);
                context.SetEffect(arg1: new int[] {5204}, arg2: true);
                context.SetEffect(arg1: new int[] {5205}, arg2: true);
                context.SetEffect(arg1: new int[] {5206}, arg2: true);
                context.SetEffect(arg1: new int[] {5207}, arg2: true);
                context.SetEffect(arg1: new int[] {5208}, arg2: true);
                context.SetEffect(arg1: new int[] {5209}, arg2: true);
                context.SetEffect(arg1: new int[] {5210}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9001})) {
                    context.State = new StateMoveToFindStone02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMoveToFindStone02 : TriggerState {
            internal StateMoveToFindStone02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5002}, arg2: true);
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
                context.HideGuideSummary(entityID: 10032010);
                context.ShowGuideSummary(entityID: 10032020, textID: 10032020);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {90000449},
                    arg3: new byte[] {2})) {
                    context.State = new StateSecondQuestEnd01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 10032020);
                context.SetEffect(arg1: new int[] {5400}, arg2: false);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
            }
        }

        private class StateSecondQuestEnd01 : TriggerState {
            internal StateSecondQuestEnd01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 10030100, textID: 10030100);
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9003})) {
                    context.State = new StateSecondQuestEnd02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSecondQuestEnd02 : TriggerState {
            internal StateSecondQuestEnd02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5200}, arg2: false);
                context.SetEffect(arg1: new int[] {5201}, arg2: false);
                context.SetEffect(arg1: new int[] {5202}, arg2: false);
                context.SetEffect(arg1: new int[] {5203}, arg2: false);
                context.SetEffect(arg1: new int[] {5204}, arg2: false);
                context.SetEffect(arg1: new int[] {5205}, arg2: false);
                context.SetEffect(arg1: new int[] {5206}, arg2: false);
                context.SetEffect(arg1: new int[] {5207}, arg2: false);
                context.SetEffect(arg1: new int[] {5208}, arg2: false);
                context.SetEffect(arg1: new int[] {5209}, arg2: false);
                context.SetEffect(arg1: new int[] {5210}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {90000449},
                    arg3: new byte[] {3})) {
                    context.State = new StateThirdQuestStart01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 10030100);
            }
        }

        private class StateThirdQuestStart01 : TriggerState {
            internal StateThirdQuestStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 10030160, textID: 10030160);
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {90000450},
                    arg3: new byte[] {1})) {
                    context.State = new StateMoveToNextMap01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 10030160);
            }
        }

        private class StateMoveToNextMap01 : TriggerState {
            internal StateMoveToNextMap01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: false, arg4: true);
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.ShowGuideSummary(entityID: 10032030, textID: 10032030);
                context.SetEffect(arg1: new int[] {5300}, arg2: true);
                context.SetEffect(arg1: new int[] {5301}, arg2: true);
                context.SetEffect(arg1: new int[] {5302}, arg2: true);
                context.SetEffect(arg1: new int[] {5303}, arg2: true);
                context.SetEffect(arg1: new int[] {5304}, arg2: true);
                context.SetEffect(arg1: new int[] {5305}, arg2: true);
                context.SetEffect(arg1: new int[] {5306}, arg2: true);
                context.SetEffect(arg1: new int[] {5307}, arg2: true);
                context.SetEffect(arg1: new int[] {5308}, arg2: true);
                context.SetEffect(arg1: new int[] {5309}, arg2: true);
                context.SetEffect(arg1: new int[] {5310}, arg2: true);
                context.SetEffect(arg1: new int[] {5311}, arg2: true);
                context.SetEffect(arg1: new int[] {5312}, arg2: true);
                context.SetEffect(arg1: new int[] {5313}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9002})) {
                    context.State = new StateMoveToNextMap02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMoveToNextMap02 : TriggerState {
            internal StateMoveToNextMap02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 10032030);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetEffect(arg1: new int[] {5002}, arg2: true);
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.ShowGuideSummary(entityID: 1060, textID: 1060);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: new int[] {9900})) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 1060);
                context.DestroyMonster(arg1: new int[] {101});
                context.SetEffect(arg1: new int[] {5300}, arg2: false);
                context.SetEffect(arg1: new int[] {5301}, arg2: false);
                context.SetEffect(arg1: new int[] {5302}, arg2: false);
                context.SetEffect(arg1: new int[] {5303}, arg2: false);
                context.SetEffect(arg1: new int[] {5304}, arg2: false);
                context.SetEffect(arg1: new int[] {5305}, arg2: false);
                context.SetEffect(arg1: new int[] {5306}, arg2: false);
                context.SetEffect(arg1: new int[] {5307}, arg2: false);
                context.SetEffect(arg1: new int[] {5308}, arg2: false);
                context.SetEffect(arg1: new int[] {5309}, arg2: false);
                context.SetEffect(arg1: new int[] {5310}, arg2: false);
                context.SetEffect(arg1: new int[] {5311}, arg2: false);
                context.SetEffect(arg1: new int[] {5312}, arg2: false);
                context.SetEffect(arg1: new int[] {5313}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}