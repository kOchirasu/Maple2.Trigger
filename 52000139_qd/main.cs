using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000139_qd {
    public static class _main {
        public class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CreateMonster(spawnIds: new []{109, 110, 101, 102, 104, 105, 106, 107}, arg2: true);
                context.SetEffect(triggerIds: new []{5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012, 5013, 5014}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002700}, questStates: new byte[]{3})) {
                    return new State다시검은화면_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002700}, questStates: new byte[]{2})) {
                    return new StateQuest진행_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002700}, questStates: new byte[]{1})) {
                    return new StateQuest수락_02(context);
                }

                if (context.UserDetected(boxIds: new []{701})) {
                    return new State영상Prepare_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상Prepare_01 : TriggerState {
            internal State영상Prepare_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State영상재생_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상재생_01 : TriggerState {
            internal State영상재생_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(type: WidgetType.SceneMovie);
                context.WidgetAction(type: WidgetType.SceneMovie, name: "Clear");
                context.PlaySceneMovie(fileName: @"common\JobIntro_Priest.usm", movieId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, condition: "IsStop", value: "1")) {
                    return new State영상마무리_01(context);
                }

                if (context.WaitTick(waitTick: 53000)) {
                    return new State영상마무리_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상마무리_01 : TriggerState {
            internal State영상마무리_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraCinematic_01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class StateCameraCinematic_01 : TriggerState {
            internal StateCameraCinematic_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8001}, returnView: false);
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCameraCinematic_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraCinematic_02 : TriggerState {
            internal StateCameraCinematic_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8001, 8002}, returnView: false);
                context.SetPcEmotionLoop(sequenceName: "Emotion_Disappoint_Idle_A", duration: 14000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateCameraCinematic_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraCinematic_03 : TriggerState {
            internal StateCameraCinematic_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: CaptionType.Vertical, title: "$52000139_QD__MAIN__22$", script: "$52000139_QD__MAIN__23$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 4000, scale: 2.5f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State검은화면전환_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검은화면전환_01 : TriggerState {
            internal State검은화면전환_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State검은화면전환_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검은화면전환_02 : TriggerState {
            internal State검은화면전환_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{8003}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State밝은화면전환_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State밝은화면전환_01 : TriggerState {
            internal State밝은화면전환_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetPcEmotionLoop(sequenceName: "Emotion_Disappoint_Idle_A", duration: 2000f);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2001");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State기사와대화_00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State기사와대화_00 : TriggerState {
            internal State기사와대화_00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateQuest수락_01(context), arg2: "nextState");
                context.AddCinematicTalk(npcId: 11003320, script: "$52000139_QD__MAIN__0$", duration: 2500, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State기사와대화_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State기사와대화_01 : TriggerState {
            internal State기사와대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000139_QD__MAIN__1$", duration: 2500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State기사와대화_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State기사와대화_02 : TriggerState {
            internal State기사와대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003320, script: "$52000139_QD__MAIN__2$", duration: 2500, align: Align.Left);
                context.AddCinematicTalk(npcId: 11003320, script: "$52000139_QD__MAIN__3$", duration: 2500, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5500)) {
                    return new State기사와대화_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State기사와대화_03 : TriggerState {
            internal State기사와대화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000139_QD__MAIN__4$", duration: 2500);
                context.AddCinematicTalk(npcId: 0, script: "$52000139_QD__MAIN__5$", duration: 2500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5500)) {
                    return new State기사와대화_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State기사와대화_04 : TriggerState {
            internal State기사와대화_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003320, script: "$52000139_QD__MAIN__6$", duration: 3000, align: Align.Left);
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_2002");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State기사와대화_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State기사와대화_05 : TriggerState {
            internal State기사와대화_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000139_QD__MAIN__7$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State기사와대화_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State기사와대화_06 : TriggerState {
            internal State기사와대화_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2003");
                context.MoveUserPath(patrolName: "MS2PatrolData_2004");
                context.AddCinematicTalk(npcId: 11003321, script: "$52000139_QD__MAIN__8$", duration: 3000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State기사와대화_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State기사와대화_07 : TriggerState {
            internal State기사와대화_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003320, script: "$52000139_QD__MAIN__9$", duration: 2500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateQuest수락_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest수락_01 : TriggerState {
            internal StateQuest수락_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.CameraReset(interpolationTime: 2.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.DestroyMonster(spawnIds: new []{102});
                context.CreateMonster(spawnIds: new []{103}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuest수락_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest수락_02 : TriggerState {
            internal StateQuest수락_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25201394, textId: 25201394);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002700}, questStates: new byte[]{1})) {
                    return new State기지로이동_01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 25201394);
            }
        }

        private class State기지로이동_01 : TriggerState {
            internal State기지로이동_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012, 5013, 5014}, visible: true);
                context.ShowGuideSummary(entityId: 25201391, textId: 25201391);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{702}, questIds: new []{40002700}, questStates: new byte[]{1})) {
                    return new StateQuest진행_01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 25201391);
            }
        }

        private class StateQuest진행_01 : TriggerState {
            internal StateQuest진행_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012, 5013, 5014}, visible: false);
                context.ShowGuideSummary(entityId: 25201392, textId: 25201392);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701, 702}, questIds: new []{40002700}, questStates: new byte[]{2})) {
                    return new StateQuest완료가능_01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{107});
                context.CreateMonster(spawnIds: new []{108}, arg2: false);
            }
        }

        private class StateQuest완료가능_01 : TriggerState {
            internal StateQuest완료가능_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 25201392);
                context.ShowGuideSummary(entityId: 25201393, textId: 25201393);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{702}, questIds: new []{40002700}, questStates: new byte[]{3})) {
                    return new State다시검은화면_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시검은화면_01 : TriggerState {
            internal State다시검은화면_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUser(mapId: 52000139, portalId: 99);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State다시검은화면_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시검은화면_02 : TriggerState {
            internal State다시검은화면_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(pathIds: new []{8004}, returnView: false);
                context.MoveUserPath(patrolName: "MS2PatrolData_2005");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State부상병과대화_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부상병과대화_01 : TriggerState {
            internal State부상병과대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 25201393);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcId: 11003327, script: "$52000139_QD__MAIN__13$", duration: 3000);
                context.SetSceneSkip(state: new State마무리(context), arg2: "exit");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State부상병과대화_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부상병과대화_02 : TriggerState {
            internal State부상병과대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000139_QD__MAIN__14$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State부상병과대화_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부상병과대화_03 : TriggerState {
            internal State부상병과대화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003327, script: "$52000139_QD__MAIN__15$", duration: 2500);
                context.AddCinematicTalk(npcId: 11003327, script: "$52000139_QD__MAIN__16$", duration: 2500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5300)) {
                    return new State부상병과대화_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부상병과대화_04 : TriggerState {
            internal State부상병과대화_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000139_QD__MAIN__17$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State부상병과대화_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부상병과대화_05 : TriggerState {
            internal State부상병과대화_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003327, script: "$52000139_QD__MAIN__18$", duration: 2500);
                context.AddCinematicTalk(npcId: 11003327, script: "$52000139_QD__MAIN__19$", duration: 2500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5300)) {
                    return new State부상병과대화_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부상병과대화_06 : TriggerState {
            internal State부상병과대화_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000139_QD__MAIN__20$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State부상병과대화_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부상병과대화_07 : TriggerState {
            internal State부상병과대화_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8004, 8005}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2300)) {
                    return new State부상병과대화_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부상병과대화_08 : TriggerState {
            internal State부상병과대화_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000139_QD__MAIN__21$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State마무리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마무리 : TriggerState {
            internal State마무리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State강제이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State강제이동 : TriggerState {
            internal State강제이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000140, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
