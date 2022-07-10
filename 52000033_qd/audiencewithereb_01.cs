namespace Maple2.Trigger._52000033_qd {
    public static class _audiencewithereb_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 201, 301, 401, 501, 502, 503, 504, 505, 506, 507, 508, 509, 510}, arg2: false);
                context.SetEffect(triggerIds: new []{5000, 5001, 5002}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
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
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001301}, questStates: new byte[]{3})) {
                    return new StateQuestOngoing02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001300}, questStates: new byte[]{3})) {
                    return new StateQuestOngoing01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001300}, questStates: new byte[]{2})) {
                    return new StatePCWalkIn01(context);
                }

                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePCtoLeave01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestOngoing01 : TriggerState {
            internal StateQuestOngoing01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateSecondQuestCheck02(context);
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
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePCGoCenter01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCWalkIn01 : TriggerState {
            internal StatePCWalkIn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 600, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StatePCWalkIn02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCWalkIn02 : TriggerState {
            internal StatePCWalkIn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 601, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePCWalkIn03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCWalkIn03 : TriggerState {
            internal StatePCWalkIn03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_1000");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePCWalkIn04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCWalkIn04 : TriggerState {
            internal StatePCWalkIn04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 602, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBowAction01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBowAction01 : TriggerState {
            internal StateBowAction01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 501, sequenceName: "Bow_A");
                context.SetNpcEmotionSequence(spawnId: 502, sequenceName: "Bow_A");
                context.SetNpcEmotionSequence(spawnId: 503, sequenceName: "Bow_A");
                context.SetNpcEmotionSequence(spawnId: 504, sequenceName: "Bow_A");
                context.SetNpcEmotionSequence(spawnId: 505, sequenceName: "Bow_A");
                context.SetNpcEmotionSequence(spawnId: 506, sequenceName: "Bow_A");
                context.SetNpcEmotionSequence(spawnId: 507, sequenceName: "Bow_A");
                context.SetNpcEmotionSequence(spawnId: 508, sequenceName: "Bow_A");
                context.SetNpcEmotionSequence(spawnId: 509, sequenceName: "Bow_A");
                context.SetNpcEmotionSequence(spawnId: 510, sequenceName: "Bow_A");
                context.SetEffect(triggerIds: new []{5002}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBowAction02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBowAction02 : TriggerState {
            internal StateBowAction02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 701, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateErebTalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateErebTalk01 : TriggerState {
            internal StateErebTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_1001");
                context.CameraSelect(triggerId: 700, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateErebTalk02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateErebTalk02 : TriggerState {
            internal StateErebTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000075, script: "$52000033_QD__AUDIENCEWITHEREB_01__0$", arg4: 4, arg5: 0);
                context.SetSkip(state: new StateErebTalk03(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateErebTalk03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateErebTalk03 : TriggerState {
            internal StateErebTalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateErebTalk04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateErebTalk04 : TriggerState {
            internal StateErebTalk04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 700, enable: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSecondQuestCheck01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class StateSecondQuestCheck01 : TriggerState {
            internal StateSecondQuestCheck01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{50001300}, questStates: new byte[]{3})) {
                    return new StateSecondQuestCheck02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSecondQuestCheck02 : TriggerState {
            internal StateSecondQuestCheck02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{50001301}, questStates: new byte[]{3})) {
                    return new StatePCGoCenter01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCGoCenter01 : TriggerState {
            internal StatePCGoCenter01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePCGoCenter02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCGoCenter02 : TriggerState {
            internal StatePCGoCenter02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePCGoCenter03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCGoCenter03 : TriggerState {
            internal StatePCGoCenter03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000033, portalId: 10, boxId: 9900);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePCGoCenter04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCGoCenter04 : TriggerState {
            internal StatePCGoCenter04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 800, enable: true);
                context.MoveUserPath(patrolName: "MS2PatrolData_1002");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePCGoCenter05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCGoCenter05 : TriggerState {
            internal StatePCGoCenter05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePCSpotLighting01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCSpotLighting01 : TriggerState {
            internal StatePCSpotLighting01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000, 5001}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePCSpotLighting02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCSpotLighting02 : TriggerState {
            internal StatePCSpotLighting02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(sequenceNames: new []{"Emotion_Happy_A"});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePCSpotLighting03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCSpotLighting03 : TriggerState {
            internal StatePCSpotLighting03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_1003");
                context.CameraSelect(triggerId: 801, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateErebTalk11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateErebTalk11 : TriggerState {
            internal StateErebTalk11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000075, script: "$52000033_QD__AUDIENCEWITHEREB_01__1$", arg4: 5, arg5: 0);
                context.SetSkip(state: new StateErebTalk12(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateErebTalk12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateErebTalk12 : TriggerState {
            internal StateErebTalk12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateErebTalk13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateErebTalk13 : TriggerState {
            internal StateErebTalk13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 801, enable: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePCtoLeave01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{5000, 5001}, visible: false);
            }
        }

        private class StatePCtoLeave01 : TriggerState {
            internal StatePCtoLeave01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
