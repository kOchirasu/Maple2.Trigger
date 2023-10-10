namespace Maple2.Trigger._52000149_qd {
    public static class _main {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 102, 111, 112});
                context.SetEffect(triggerIds: new []{6001, 6002}, visible: true);
                context.SetNpcEmotionLoop(spawnId: 111, sequenceName: "Sit_Down_A", duration: 99999999f);
                context.SetNpcEmotionLoop(spawnId: 112, sequenceName: "Event_02_Idle", duration: 99999999f);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new StateQuestConditionCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestConditionCheck : TriggerState {
            internal StateQuestConditionCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001633}, questStates: new byte[]{2})) {
                    return new State빈집(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001633}, questStates: new byte[]{1})) {
                    return new StateBasic(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001632}, questStates: new byte[]{3})) {
                    return new StateBasic(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001632}, questStates: new byte[]{2})) {
                    return new StateBasic(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001632}, questStates: new byte[]{1})) {
                    return new State전경_SetupCinematic(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001631}, questStates: new byte[]{3})) {
                    return new StateBasic(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001631}, questStates: new byte[]{2})) {
                    return new StateBasic(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001631}, questStates: new byte[]{1})) {
                    return new StateBasic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBasic : TriggerState {
            internal StateBasic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001632}, questStates: new byte[]{1})) {
                    return new State전경_SetupCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전경_SetupCinematic : TriggerState {
            internal State전경_SetupCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUser(mapId: 52000149, portalId: 10);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State전경_StartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전경_StartCinematic : TriggerState {
            internal State전경_StartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8000, 8010}, returnView: false);
                context.MoveUserPath(patrolName: "MS2PatrolData_pc");
                context.SetSceneSkip(state: new State아노스아파_스킵완료(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCamera_아노스줌인(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_아노스줌인 : TriggerState {
            internal StateCamera_아노스줌인(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8001}, returnView: false);
                context.AddCinematicTalk(npcId: 11003436, script: "$52000149_QD__MAIN__0$", duration: 3000);
                context.SetSkip(state: new State아노스아파_스킵완료(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCamera_아노스줌인01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_아노스줌인01 : TriggerState {
            internal StateCamera_아노스줌인01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCamera_케이틀린01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_케이틀린01 : TriggerState {
            internal StateCamera_케이틀린01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8002, 8004}, returnView: false);
                context.AddCinematicTalk(npcId: 11003436, script: "$52000149_QD__MAIN__1$", duration: 3000);
                context.SetSkip(state: new State아노스아파_스킵완료(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCamera_케이틀린0102(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_케이틀린0102 : TriggerState {
            internal StateCamera_케이틀린0102(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCamera_케이틀린02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_케이틀린02 : TriggerState {
            internal StateCamera_케이틀린02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8003}, returnView: false);
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Idle_A", duration: 3000f);
                context.AddCinematicTalk(npcId: 11003436, script: "$52000149_QD__MAIN__2$", duration: 3000);
                context.AddBalloonTalk(spawnId: 102, msg: "$52000149_QD__MAIN__3$", duration: 3000, delayTick: 0);
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_katelyn");
                context.SetSkip(state: new State아노스아파_스킵완료(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State호르헤이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State호르헤이동 : TriggerState {
            internal State호르헤이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8003}, returnView: false);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_Jorge");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State빈집 : TriggerState {
            internal State빈집(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{111, 112});
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스아파_스킵완료 : TriggerState {
            internal State아노스아파_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
                context.MoveUser(mapId: 52000149, portalId: 11);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_Jorge");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 3.0f);
                context.SetAchievement(triggerId: 9000, type: "trigger", code: "AnosReturns");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
