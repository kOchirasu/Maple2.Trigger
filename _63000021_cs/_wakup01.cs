using System;

namespace Maple2.Trigger._63000021_cs {
    public static class _wakup01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new int[] {3000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {5000}, arg2: false);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
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
                context.SetEffect(arg1: new int[] {5211}, arg2: false);
                context.SetEffect(arg1: new int[] {5212}, arg2: false);
                context.SetEffect(arg1: new int[] {5213}, arg2: false);
                context.SetEffect(arg1: new int[] {5214}, arg2: false);
                context.SetEffect(arg1: new int[] {5215}, arg2: false);
                context.SetEffect(arg1: new int[] {5216}, arg2: false);
                context.SetEffect(arg1: new int[] {5217}, arg2: false);
                context.SetEffect(arg1: new int[] {7000}, arg2: false);
                context.SetEffect(arg1: new int[] {7001}, arg2: false);
                context.SetEffect(arg1: new int[] {7002}, arg2: false);
                context.SetEffect(arg1: new int[] {7003}, arg2: false);
                context.SetEffect(arg1: new int[] {7004}, arg2: false);
                context.SetEffect(arg1: new int[] {7100}, arg2: false);
                context.SetEffect(arg1: new int[] {7101}, arg2: false);
                context.SetEffect(arg1: new int[] {7102}, arg2: false);
                context.SetEffect(arg1: new int[] {7103}, arg2: false);
                context.SetEffect(arg1: new int[] {7104}, arg2: false);
                context.SetEffect(arg1: new int[] {6000}, arg2: false);
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
                context.CameraSelect(arg1: 500, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateLodingDelay02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLodingDelay02 : TriggerState {
            internal StateLodingDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Down_Idle_D", arg2: 6600f);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {90000439},
                    arg3: new byte[] {1})) {
                    context.State = new StateQuestOngoing01(context);
                    return;
                }

                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateWakeUp01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestOngoing01 : TriggerState {
            internal StateQuestOngoing01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 500, arg2: false);
                context.CreateMonster(arg1: new int[] {103}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateQuestOngoing02(context);
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
                context.MoveUser(arg1: 63000021, arg2: 10, arg3: 9002);
                context.SetPcEmotionLoop(arg1: "Idle_A", arg2: 2000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateCallNextRoom01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWakeUp01 : TriggerState {
            internal StateWakeUp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateWakeUp02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWakeUp02 : TriggerState {
            internal StateWakeUp02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateWakeUp03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWakeUp03 : TriggerState {
            internal StateWakeUp03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Sit_Ground_Idle_A", arg2: 60000f);
                context.CreateMonster(arg1: new int[] {101, 201, 301}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateWakeUp04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWakeUp04 : TriggerState {
            internal StateWakeUp04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 599, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateWakeUp05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWakeUp05 : TriggerState {
            internal StateWakeUp05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 600, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDialogue01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue01 : TriggerState {
            internal StateDialogue01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 301, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001546, arg3: "$63000021_CS__WAKUP01__0$", arg4: 4);
                context.SetEffect(arg1: new int[] {7000}, arg2: true);
                context.SetSkip(arg1: "Dialogue02");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateDialogue02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue02 : TriggerState {
            internal StateDialogue02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 301, arg2: "Idle_A");
                context.SetEffect(arg1: new int[] {7000}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateDialogue03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue03 : TriggerState {
            internal StateDialogue03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_200");
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$63000021_CS__WAKUP01__1$", arg4: 4);
                context.SetEffect(arg1: new int[] {7100}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDialogue04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue04 : TriggerState {
            internal StateDialogue04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 301, arg2: "MS2PatrolData_300");
                context.SetSkip(arg1: "Dialogue05");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateDialogue05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue05 : TriggerState {
            internal StateDialogue05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7100}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateDialogue06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue06 : TriggerState {
            internal StateDialogue06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001546, arg3: "$63000021_CS__WAKUP01__2$", arg4: 4);
                context.SetEffect(arg1: new int[] {7001}, arg2: true);
                context.SetSkip(arg1: "Dialogue07");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateDialogue07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue07 : TriggerState {
            internal StateDialogue07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7001}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateJaceyWalkIn01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJaceyWalkIn01 : TriggerState {
            internal StateJaceyWalkIn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 601, arg2: true);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_101");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateJaceyWalkIn02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJaceyWalkIn02 : TriggerState {
            internal StateJaceyWalkIn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateTrialogue01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTrialogue01 : TriggerState {
            internal StateTrialogue01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001620, arg3: "$63000021_CS__WAKUP01__3$", arg4: 4);
                context.SetSkip(arg1: "Trialogue02");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateTrialogue02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTrialogue02 : TriggerState {
            internal StateTrialogue02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.CameraSelect(arg1: 602, arg2: true);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_201");
                context.MoveNpc(arg1: 301, arg2: "MS2PatrolData_301");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateTrialogue03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTrialogue03 : TriggerState {
            internal StateTrialogue03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$63000021_CS__WAKUP01__4$", arg4: 4);
                context.SetEffect(arg1: new int[] {7101}, arg2: true);
                context.SetSkip(arg1: "Trialogue04");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateTrialogue04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTrialogue04 : TriggerState {
            internal StateTrialogue04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7101}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateTrialogue05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTrialogue05 : TriggerState {
            internal StateTrialogue05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 301, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001546, arg3: "$63000021_CS__WAKUP01__5$", arg4: 4);
                context.SetEffect(arg1: new int[] {7002}, arg2: true);
                context.SetSkip(arg1: "Trialogue06");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateTrialogue06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTrialogue06 : TriggerState {
            internal StateTrialogue06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7002}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 301, arg2: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateTrialogue07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTrialogue07 : TriggerState {
            internal StateTrialogue07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$63000021_CS__WAKUP01__6$", arg4: 4);
                context.SetEffect(arg1: new int[] {7102}, arg2: true);
                context.SetSkip(arg1: "Trialogue08");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateTrialogue08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTrialogue08 : TriggerState {
            internal StateTrialogue08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7102}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateTrialogue09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTrialogue09 : TriggerState {
            internal StateTrialogue09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001620, arg3: "$63000021_CS__WAKUP01__7$", arg4: 4);
                context.SetSkip(arg1: "Trialogue10");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateTrialogue10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTrialogue10 : TriggerState {
            internal StateTrialogue10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateTwoMenWalkOut01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTwoMenWalkOut01 : TriggerState {
            internal StateTwoMenWalkOut01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 700, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateTwoMenWalkOut02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTwoMenWalkOut02 : TriggerState {
            internal StateTwoMenWalkOut02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 201, arg3: "$63000021_CS__WAKUP01__8$", arg4: 3, arg5: 0);
                context.SetEffect(arg1: new int[] {7103}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateTwoMenWalkOut03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTwoMenWalkOut03 : TriggerState {
            internal StateTwoMenWalkOut03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_202");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateTwoMenWalkOut04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTwoMenWalkOut04 : TriggerState {
            internal StateTwoMenWalkOut04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 301, arg2: "MS2PatrolData_302");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateTwoMenWalkOut05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTwoMenWalkOut05 : TriggerState {
            internal StateTwoMenWalkOut05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7103}, arg2: false);
                context.SetEffect(arg1: new int[] {7003}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 301, arg3: "$63000021_CS__WAKUP01__9$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateTwoMenWalkOut06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTwoMenWalkOut06 : TriggerState {
            internal StateTwoMenWalkOut06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7003}, arg2: false);
                context.CameraSelectPath(arg1: new int[] {701, 702}, arg2: 0);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_102");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateTwoMenWalkOut07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTwoMenWalkOut07 : TriggerState {
            internal StateTwoMenWalkOut07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7104}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 201, arg3: "$63000021_CS__WAKUP01__10$", arg4: 4, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateTwoMenWalkOut08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTwoMenWalkOut08 : TriggerState {
            internal StateTwoMenWalkOut08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7104}, arg2: false);
                context.SetEffect(arg1: new int[] {7004}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 301, arg3: "$63000021_CS__WAKUP01__11$", arg4: 4, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateStandUp01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStandUp01 : TriggerState {
            internal StateStandUp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 63000021, arg2: 10, arg3: 9900);
                context.SetPcEmotionLoop(arg1: "Idle_A", arg2: 2000f);
                context.DestroyMonster(arg1: new int[] {101});
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 703, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateJaceyTalk01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJaceyTalk01 : TriggerState {
            internal StateJaceyTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7004}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateJaceyTalk02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJaceyTalk02 : TriggerState {
            internal StateJaceyTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001620, arg3: "$63000021_CS__WAKUP01__12$", arg4: 3);
                context.SetSkip(arg1: "JaceyTalk03");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateJaceyTalk03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJaceyTalk03 : TriggerState {
            internal StateJaceyTalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateJaceyTalk04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJaceyTalk04 : TriggerState {
            internal StateJaceyTalk04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001620, arg3: "$63000021_CS__WAKUP01__13$", arg4: 5);
                context.SetSkip(arg1: "JaceyTalk05");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateJaceyTalk05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJaceyTalk05 : TriggerState {
            internal StateJaceyTalk05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {201, 301});
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 703, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateJaceyQuest01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJaceyQuest01 : TriggerState {
            internal StateJaceyQuest01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.ShowGuideSummary(entityID: 10021030, textID: 10021030);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {90000439},
                    arg3: new byte[] {1})) {
                    context.State = new StateJaceyQuest02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJaceyQuest02 : TriggerState {
            internal StateJaceyQuest02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 10021030);
                context.DestroyMonster(arg1: new int[] {102});
                context.CreateMonster(arg1: new int[] {103}, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateCallNextRoom01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCallNextRoom01 : TriggerState {
            internal StateCallNextRoom01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_103");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateCallNextRoom02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCallNextRoom02 : TriggerState {
            internal StateCallNextRoom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3000}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {6000}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCallNextRoom03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCallNextRoom03 : TriggerState {
            internal StateCallNextRoom03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6000}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001620, arg3: "$63000021_CS__WAKUP01__14$", arg4: 4);
                context.SetSkip(arg1: "CallNextRoom04");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateCallNextRoom04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCallNextRoom04 : TriggerState {
            internal StateCallNextRoom04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateCallNextRoom05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCallNextRoom05 : TriggerState {
            internal StateCallNextRoom05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6000}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001620, arg3: "$63000021_CS__WAKUP01__15$", arg4: 3);
                context.SetSkip(arg1: "CallNextRoom06");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateCallNextRoom06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCallNextRoom06 : TriggerState {
            internal StateCallNextRoom06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateSayGoodBye01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSayGoodBye01 : TriggerState {
            internal StateSayGoodBye01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_104");
                context.SetEffect(arg1: new int[] {6000}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateSayGoodBye02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSayGoodBye02 : TriggerState {
            internal StateSayGoodBye02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001620, arg3: "$63000021_CS__WAKUP01__16$", arg4: 5);
                context.SetSkip(arg1: "SayGoodBye03");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateSayGoodBye03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSayGoodBye03 : TriggerState {
            internal StateSayGoodBye03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.DestroyMonster(arg1: new int[] {103});
                context.CreateMonster(arg1: new int[] {104}, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateGuideNextMap01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGuideNextMap01 : TriggerState {
            internal StateGuideNextMap01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.ShowGuideSummary(entityID: 10026010, textID: 10026010);
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
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
                context.SetEffect(arg1: new int[] {5211}, arg2: true);
                context.SetEffect(arg1: new int[] {5212}, arg2: true);
                context.SetEffect(arg1: new int[] {5213}, arg2: true);
                context.SetEffect(arg1: new int[] {5214}, arg2: true);
                context.SetEffect(arg1: new int[] {5215}, arg2: true);
                context.SetEffect(arg1: new int[] {5216}, arg2: true);
                context.SetEffect(arg1: new int[] {5217}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9001")) {
                    context.State = new StateGuideNextMap02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGuideNextMap02 : TriggerState {
            internal StateGuideNextMap02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetEffect(arg1: new int[] {5002}, arg2: true);
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: "9900")) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 10026010);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
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
                context.SetEffect(arg1: new int[] {5211}, arg2: false);
                context.SetEffect(arg1: new int[] {5212}, arg2: false);
                context.SetEffect(arg1: new int[] {5213}, arg2: false);
                context.SetEffect(arg1: new int[] {5214}, arg2: false);
                context.SetEffect(arg1: new int[] {5215}, arg2: false);
                context.SetEffect(arg1: new int[] {5216}, arg2: false);
                context.SetEffect(arg1: new int[] {5217}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}