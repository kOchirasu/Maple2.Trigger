namespace Maple2.Trigger._63000022_cs {
    public static class _business01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetEffect(triggerIds: new []{5000, 5001, 5002, 5200, 5201, 5202, 5203, 5204, 5205, 8000, 8001, 8002}, visible: false);
                context.CreateMonster(spawnIds: new []{101, 201, 301, 401}, arg2: false);
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
                context.CameraSelect(triggerId: 500, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{90000439}, questStates: new byte[]{3})) {
                    return new StateQuestOngoing01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{90000440}, questStates: new byte[]{1})) {
                    return new StateQuestOngoing11(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new StateTalkWeiHong01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestOngoing01 : TriggerState {
            internal StateQuestOngoing01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
                context.CameraSelect(triggerId: 500, enabled: false);
            }

            public override TriggerState? Execute() {
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
            }

            public override TriggerState? Execute() {
                return new StateNextQuestStart01(context);
            }

            public override void OnExit() { }
        }

        private class StateQuestOngoing11 : TriggerState {
            internal StateQuestOngoing11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
                context.CameraSelect(triggerId: 500, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateQuestOngoing12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestOngoing12 : TriggerState {
            internal StateQuestOngoing12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                return new StateMoveToNextMap01(context);
            }

            public override void OnExit() { }
        }

        private class StateTalkWeiHong01 : TriggerState {
            internal StateTalkWeiHong01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Bore_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTalkWeiHong02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalkWeiHong02 : TriggerState {
            internal StateTalkWeiHong02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTalkWeiHong03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalkWeiHong03 : TriggerState {
            internal StateTalkWeiHong03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 501, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTalkWeiHong04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalkWeiHong04 : TriggerState {
            internal StateTalkWeiHong04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Talk_A");
                context.SetConversation(type: 2, spawnId: 11000251, script: "$63000022_CS__BUSINESS01__0$", arg4: 6);
                context.SetEffect(triggerIds: new []{8000}, visible: true);
                context.SetSkip(state: new StateTalkWeiHong05(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTalkWeiHong05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalkWeiHong05 : TriggerState {
            internal StateTalkWeiHong05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Idle_A");
                context.MoveUserPath(patrolName: "MS2PatrolData_1000");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateTalkWeiHong06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalkWeiHong06 : TriggerState {
            internal StateTalkWeiHong06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Talk_A");
                context.SetConversation(type: 2, spawnId: 11000251, script: "$63000022_CS__BUSINESS01__1$", arg4: 6);
                context.SetEffect(triggerIds: new []{8001}, visible: true);
                context.SetSkip(state: new StateTalkWeiHong07(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateTalkWeiHong07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalkWeiHong07 : TriggerState {
            internal StateTalkWeiHong07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Idle_A");
            }

            public override TriggerState? Execute() {
                return new StateTalkWeiHong08(context);
            }

            public override void OnExit() { }
        }

        private class StateTalkWeiHong08 : TriggerState {
            internal StateTalkWeiHong08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001547, script: "$63000022_CS__BUSINESS01__3$", arg4: 3);
                context.SetSkip(state: new StateTalkWeiHong09(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTalkWeiHong09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalkWeiHong09 : TriggerState {
            internal StateTalkWeiHong09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateTalkWeiHong10(context);
            }

            public override void OnExit() { }
        }

        private class StateTalkWeiHong10 : TriggerState {
            internal StateTalkWeiHong10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000251, script: "$63000022_CS__BUSINESS01__2$", arg4: 6);
                context.SetEffect(triggerIds: new []{8002}, visible: true);
                context.SetSkip(state: new StateTalkWeiHong11(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateTalkWeiHong11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalkWeiHong11 : TriggerState {
            internal StateTalkWeiHong11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 501, enabled: false);
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateQuestComplete01(context);
            }

            public override void OnExit() { }
        }

        private class StateQuestComplete01 : TriggerState {
            internal StateQuestComplete01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 10024020, textId: 10024020);
                context.SetEffect(triggerIds: new []{5000}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{90000439}, questStates: new byte[]{3})) {
                    return new StateNextQuestStart01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10024020);
            }
        }

        private class StateNextQuestStart01 : TriggerState {
            internal StateNextQuestStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 10024030, textId: 10024030);
                context.SetEffect(triggerIds: new []{5000}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{90000440}, questStates: new byte[]{1})) {
                    return new StateMoveToNextMap01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10024030);
            }
        }

        private class StateMoveToNextMap01 : TriggerState {
            internal StateMoveToNextMap01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 10027010, textId: 10027010);
                context.SetEffect(triggerIds: new []{5000, 5001, 5200, 5201, 5202, 5203, 5204, 5205}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9001})) {
                    return new StateMoveToNextMap02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMoveToNextMap02 : TriggerState {
            internal StateMoveToNextMap02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5002}, visible: true);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{9900})) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 10027010);
                context.SetEffect(triggerIds: new []{5002, 5000, 5001, 5200, 5201, 5202, 5203, 5204, 5205}, visible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
