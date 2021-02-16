namespace Maple2.Trigger._63000021_cs {
    public static class _wakup01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(arg1: new[] {3000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {5000, 5001, 5002, 5200, 5201, 5202, 5203, 5204, 5205, 5206, 5207, 5208, 5209, 5210, 5211, 5212, 5213, 5214, 5215, 5216, 5217, 7000, 7001, 7002, 7003, 7004, 7100, 7101, 7102, 7103, 7104, 6000}, arg2: false);
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

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.CameraSelect(arg1: 500, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateLodingDelay02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLodingDelay02 : TriggerState {
            internal StateLodingDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Down_Idle_D", arg2: 6600f);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000439}, arg3: new byte[] {1})) {
                    return new StateQuestOngoing01(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new StateWakeUp01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestOngoing01 : TriggerState {
            internal StateQuestOngoing01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 500, arg2: false);
                context.CreateMonster(arg1: new[] {103}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateQuestOngoing02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestOngoing02 : TriggerState {
            internal StateQuestOngoing02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.MoveUser(arg1: 63000021, arg2: 10, arg3: 9002);
                context.SetPcEmotionLoop(arg1: "Idle_A", arg2: 2000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCallNextRoom01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWakeUp01 : TriggerState {
            internal StateWakeUp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateWakeUp02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWakeUp02 : TriggerState {
            internal StateWakeUp02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWakeUp03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWakeUp03 : TriggerState {
            internal StateWakeUp03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Sit_Ground_Idle_A", arg2: 60000f);
                context.CreateMonster(arg1: new[] {101, 201, 301}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWakeUp04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWakeUp04 : TriggerState {
            internal StateWakeUp04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 599, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWakeUp05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWakeUp05 : TriggerState {
            internal StateWakeUp05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(arg1: 600, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDialogue01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDialogue01 : TriggerState {
            internal StateDialogue01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 301, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001546, script: "$63000021_CS__WAKUP01__0$", arg4: 4);
                context.SetEffect(arg1: new[] {7000}, arg2: true);
                context.SetSkip(state: new StateDialogue02(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateDialogue02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDialogue02 : TriggerState {
            internal StateDialogue02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 301, arg2: "Idle_A");
                context.SetEffect(arg1: new[] {7000}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateDialogue03(context);
            }

            public override void OnExit() { }
        }

        private class StateDialogue03 : TriggerState {
            internal StateDialogue03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_200");
                context.SetConversation(arg1: 2, arg2: 11001545, script: "$63000021_CS__WAKUP01__1$", arg4: 4);
                context.SetEffect(arg1: new[] {7100}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDialogue04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDialogue04 : TriggerState {
            internal StateDialogue04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 301, arg2: "MS2PatrolData_300");
                context.SetSkip(state: new StateDialogue05(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateDialogue05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDialogue05 : TriggerState {
            internal StateDialogue05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7100}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateDialogue06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDialogue06 : TriggerState {
            internal StateDialogue06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001546, script: "$63000021_CS__WAKUP01__2$", arg4: 4);
                context.SetEffect(arg1: new[] {7001}, arg2: true);
                context.SetSkip(state: new StateDialogue07(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateDialogue07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDialogue07 : TriggerState {
            internal StateDialogue07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7001}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateJaceyWalkIn01(context);
            }

            public override void OnExit() { }
        }

        private class StateJaceyWalkIn01 : TriggerState {
            internal StateJaceyWalkIn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(arg1: 601, arg2: true);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_101");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateJaceyWalkIn02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJaceyWalkIn02 : TriggerState {
            internal StateJaceyWalkIn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateTrialogue01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrialogue01 : TriggerState {
            internal StateTrialogue01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001620, script: "$63000021_CS__WAKUP01__3$", arg4: 4);
                context.SetSkip(state: new StateTrialogue02(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateTrialogue02(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTrialogue03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrialogue03 : TriggerState {
            internal StateTrialogue03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001545, script: "$63000021_CS__WAKUP01__4$", arg4: 4);
                context.SetEffect(arg1: new[] {7101}, arg2: true);
                context.SetSkip(state: new StateTrialogue04(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateTrialogue04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrialogue04 : TriggerState {
            internal StateTrialogue04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7101}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateTrialogue05(context);
            }

            public override void OnExit() { }
        }

        private class StateTrialogue05 : TriggerState {
            internal StateTrialogue05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 301, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001546, script: "$63000021_CS__WAKUP01__5$", arg4: 4);
                context.SetEffect(arg1: new[] {7002}, arg2: true);
                context.SetSkip(state: new StateTrialogue06(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateTrialogue06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrialogue06 : TriggerState {
            internal StateTrialogue06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7002}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 301, arg2: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateTrialogue07(context);
            }

            public override void OnExit() { }
        }

        private class StateTrialogue07 : TriggerState {
            internal StateTrialogue07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001545, script: "$63000021_CS__WAKUP01__6$", arg4: 4);
                context.SetEffect(arg1: new[] {7102}, arg2: true);
                context.SetSkip(state: new StateTrialogue08(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateTrialogue08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrialogue08 : TriggerState {
            internal StateTrialogue08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7102}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateTrialogue09(context);
            }

            public override void OnExit() { }
        }

        private class StateTrialogue09 : TriggerState {
            internal StateTrialogue09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001620, script: "$63000021_CS__WAKUP01__7$", arg4: 4);
                context.SetSkip(state: new StateTrialogue10(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateTrialogue10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrialogue10 : TriggerState {
            internal StateTrialogue10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateTwoMenWalkOut01(context);
            }

            public override void OnExit() { }
        }

        private class StateTwoMenWalkOut01 : TriggerState {
            internal StateTwoMenWalkOut01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(arg1: 700, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateTwoMenWalkOut02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTwoMenWalkOut02 : TriggerState {
            internal StateTwoMenWalkOut02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 201, script: "$63000021_CS__WAKUP01__8$", arg4: 3, arg5: 0);
                context.SetEffect(arg1: new[] {7103}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTwoMenWalkOut03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTwoMenWalkOut03 : TriggerState {
            internal StateTwoMenWalkOut03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_202");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTwoMenWalkOut04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTwoMenWalkOut04 : TriggerState {
            internal StateTwoMenWalkOut04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 301, arg2: "MS2PatrolData_302");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTwoMenWalkOut05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTwoMenWalkOut05 : TriggerState {
            internal StateTwoMenWalkOut05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7103}, arg2: false);
                context.SetEffect(arg1: new[] {7003}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 301, script: "$63000021_CS__WAKUP01__9$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTwoMenWalkOut06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTwoMenWalkOut06 : TriggerState {
            internal StateTwoMenWalkOut06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7003}, arg2: false);
                context.CameraSelectPath(pathIds: new[] {701, 702}, arg2: false);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_102");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateTwoMenWalkOut07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTwoMenWalkOut07 : TriggerState {
            internal StateTwoMenWalkOut07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7104}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 201, script: "$63000021_CS__WAKUP01__10$", arg4: 4, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateTwoMenWalkOut08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTwoMenWalkOut08 : TriggerState {
            internal StateTwoMenWalkOut08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7104}, arg2: false);
                context.SetEffect(arg1: new[] {7004}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 301, script: "$63000021_CS__WAKUP01__11$", arg4: 4, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStandUp01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStandUp01 : TriggerState {
            internal StateStandUp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 63000021, arg2: 10, arg3: 9900);
                context.SetPcEmotionLoop(arg1: "Idle_A", arg2: 2000f);
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {102}, arg2: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(arg1: 703, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateJaceyTalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJaceyTalk01 : TriggerState {
            internal StateJaceyTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateJaceyTalk02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJaceyTalk02 : TriggerState {
            internal StateJaceyTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001620, script: "$63000021_CS__WAKUP01__12$", arg4: 3);
                context.SetSkip(state: new StateJaceyTalk03(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateJaceyTalk03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJaceyTalk03 : TriggerState {
            internal StateJaceyTalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateJaceyTalk04(context);
            }

            public override void OnExit() { }
        }

        private class StateJaceyTalk04 : TriggerState {
            internal StateJaceyTalk04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001620, script: "$63000021_CS__WAKUP01__13$", arg4: 5);
                context.SetSkip(state: new StateJaceyTalk05(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateJaceyTalk05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJaceyTalk05 : TriggerState {
            internal StateJaceyTalk05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {201, 301});
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(arg1: 703, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateJaceyQuest01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJaceyQuest01 : TriggerState {
            internal StateJaceyQuest01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.ShowGuideSummary(entityId: 10021030, textId: 10021030);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000439}, arg3: new byte[] {1})) {
                    return new StateJaceyQuest02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJaceyQuest02 : TriggerState {
            internal StateJaceyQuest02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 10021030);
                context.DestroyMonster(arg1: new[] {102});
                context.CreateMonster(arg1: new[] {103}, arg2: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCallNextRoom01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCallNextRoom01 : TriggerState {
            internal StateCallNextRoom01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_103");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCallNextRoom02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCallNextRoom02 : TriggerState {
            internal StateCallNextRoom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3000}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {6000}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCallNextRoom03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCallNextRoom03 : TriggerState {
            internal StateCallNextRoom03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6000}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001620, script: "$63000021_CS__WAKUP01__14$", arg4: 4);
                context.SetSkip(state: new StateCallNextRoom04(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCallNextRoom04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCallNextRoom04 : TriggerState {
            internal StateCallNextRoom04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateCallNextRoom05(context);
            }

            public override void OnExit() { }
        }

        private class StateCallNextRoom05 : TriggerState {
            internal StateCallNextRoom05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6000}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001620, script: "$63000021_CS__WAKUP01__15$", arg4: 3);
                context.SetSkip(state: new StateCallNextRoom06(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCallNextRoom06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCallNextRoom06 : TriggerState {
            internal StateCallNextRoom06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateSayGoodBye01(context);
            }

            public override void OnExit() { }
        }

        private class StateSayGoodBye01 : TriggerState {
            internal StateSayGoodBye01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_104");
                context.SetEffect(arg1: new[] {6000}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateSayGoodBye02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSayGoodBye02 : TriggerState {
            internal StateSayGoodBye02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001620, script: "$63000021_CS__WAKUP01__16$", arg4: 5);
                context.SetSkip(state: new StateSayGoodBye03(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateSayGoodBye03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSayGoodBye03 : TriggerState {
            internal StateSayGoodBye03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.DestroyMonster(arg1: new[] {103});
                context.CreateMonster(arg1: new[] {104}, arg2: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState Execute() {
                return new StateGuideNextMap01(context);
            }

            public override void OnExit() { }
        }

        private class StateGuideNextMap01 : TriggerState {
            internal StateGuideNextMap01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.ShowGuideSummary(entityId: 10026010, textId: 10026010);
                context.SetEffect(arg1: new[] {5001, 5200, 5201, 5202, 5203, 5204, 5205, 5206, 5207, 5208, 5209, 5210, 5211, 5212, 5213, 5214, 5215, 5216, 5217}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9001})) {
                    return new StateGuideNextMap02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuideNextMap02 : TriggerState {
            internal StateGuideNextMap02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                context.SetEffect(arg1: new[] {5002, 5000}, arg2: true);
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
                context.HideGuideSummary(entityId: 10026010);
                context.SetEffect(arg1: new[] {5001, 5002, 5200, 5201, 5202, 5203, 5204, 5205, 5206, 5207, 5208, 5209, 5210, 5211, 5212, 5213, 5214, 5215, 5216, 5217}, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}