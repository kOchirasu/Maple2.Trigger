using System;

namespace Maple2.Trigger._52000033_qd {
    public static class _audiencewithereb_01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(
                    arg1: new int[] {101, 201, 301, 401, 501, 502, 503, 504, 505, 506, 507, 508, 509, 510},
                    arg2: false);
                context.SetEffect(arg1: new int[] {5000}, arg2: false);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9000")) {
                    context.State = new StateLodingDelay01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLodingDelay01 : TriggerState {
            internal StateLodingDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001301},
                    arg3: new byte[] {3})) {
                    context.State = new StateQuestOngoing02(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001300},
                    arg3: new byte[] {3})) {
                    context.State = new StateQuestOngoing01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001300},
                    arg3: new byte[] {2})) {
                    context.State = new StatePCWalkIn01(context);
                    return;
                }

                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StatePCtoLeave01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestOngoing01 : TriggerState {
            internal StateQuestOngoing01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateSecondQuestCheck02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestOngoing02 : TriggerState {
            internal StateQuestOngoing02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StatePCGoCenter01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCWalkIn01 : TriggerState {
            internal StatePCWalkIn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 600, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StatePCWalkIn02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCWalkIn02 : TriggerState {
            internal StatePCWalkIn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 601, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StatePCWalkIn03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCWalkIn03 : TriggerState {
            internal StatePCWalkIn03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_1000");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePCWalkIn04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCWalkIn04 : TriggerState {
            internal StatePCWalkIn04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 602, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateBowAction01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBowAction01 : TriggerState {
            internal StateBowAction01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 501, arg2: "Bow_A");
                context.SetNpcEmotionSequence(arg1: 502, arg2: "Bow_A");
                context.SetNpcEmotionSequence(arg1: 503, arg2: "Bow_A");
                context.SetNpcEmotionSequence(arg1: 504, arg2: "Bow_A");
                context.SetNpcEmotionSequence(arg1: 505, arg2: "Bow_A");
                context.SetNpcEmotionSequence(arg1: 506, arg2: "Bow_A");
                context.SetNpcEmotionSequence(arg1: 507, arg2: "Bow_A");
                context.SetNpcEmotionSequence(arg1: 508, arg2: "Bow_A");
                context.SetNpcEmotionSequence(arg1: 509, arg2: "Bow_A");
                context.SetNpcEmotionSequence(arg1: 510, arg2: "Bow_A");
                context.SetEffect(arg1: new int[] {5002}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateBowAction02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBowAction02 : TriggerState {
            internal StateBowAction02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 701, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateErebTalk01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateErebTalk01 : TriggerState {
            internal StateErebTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_1001");
                context.CameraSelect(arg1: 700, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateErebTalk02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateErebTalk02 : TriggerState {
            internal StateErebTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000075, arg3: "$52000033_QD__AUDIENCEWITHEREB_01__0$", arg4: 4,
                    arg5: 0);
                context.SetSkip(arg1: "ErebTalk03");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateErebTalk03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateErebTalk03 : TriggerState {
            internal StateErebTalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateErebTalk04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateErebTalk04 : TriggerState {
            internal StateErebTalk04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 700, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSecondQuestCheck01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class StateSecondQuestCheck01 : TriggerState {
            internal StateSecondQuestCheck01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {50001300},
                    arg3: new byte[] {3})) {
                    context.State = new StateSecondQuestCheck02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSecondQuestCheck02 : TriggerState {
            internal StateSecondQuestCheck02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {50001301},
                    arg3: new byte[] {3})) {
                    context.State = new StatePCGoCenter01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCGoCenter01 : TriggerState {
            internal StatePCGoCenter01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePCGoCenter02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCGoCenter02 : TriggerState {
            internal StatePCGoCenter02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StatePCGoCenter03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCGoCenter03 : TriggerState {
            internal StatePCGoCenter03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000033, arg2: 10, arg3: 9900);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StatePCGoCenter04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCGoCenter04 : TriggerState {
            internal StatePCGoCenter04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 800, arg2: true);
                context.MoveUserPath(arg1: "MS2PatrolData_1002");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StatePCGoCenter05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCGoCenter05 : TriggerState {
            internal StatePCGoCenter05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StatePCSpotLighting01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCSpotLighting01 : TriggerState {
            internal StatePCSpotLighting01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StatePCSpotLighting02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCSpotLighting02 : TriggerState {
            internal StatePCSpotLighting02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Emotion_Happy_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StatePCSpotLighting03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCSpotLighting03 : TriggerState {
            internal StatePCSpotLighting03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_1003");
                context.CameraSelect(arg1: 801, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateErebTalk11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateErebTalk11 : TriggerState {
            internal StateErebTalk11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000075, arg3: "$52000033_QD__AUDIENCEWITHEREB_01__1$", arg4: 5,
                    arg5: 0);
                context.SetSkip(arg1: "ErebTalk12");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateErebTalk12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateErebTalk12 : TriggerState {
            internal StateErebTalk12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateErebTalk13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateErebTalk13 : TriggerState {
            internal StateErebTalk13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 801, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePCtoLeave01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new int[] {5000}, arg2: false);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
            }
        }

        private class StatePCtoLeave01 : TriggerState {
            internal StatePCtoLeave01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}