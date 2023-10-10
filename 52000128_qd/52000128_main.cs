using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000128_qd {
    public static class _52000128_main {
        public class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CreateMonster(spawnIds: new []{101, 102, 103}, arg2: false);
                context.SetSkill(triggerIds: new []{7001}, enabled: false);
                context.SetEffect(triggerIds: new []{5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009}, visible: false);
                context.SetMesh(triggerIds: new []{4001}, visible: true);
            }

            public override TriggerState? Execute() {
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
                context.PlaySceneMovie(fileName: @"common\JobIntro_Thief.usm", movieId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, condition: "IsStop", value: "1")) {
                    return new StateStart_01(context);
                }

                if (context.WaitTick(waitTick: 33000)) {
                    return new StateStart_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_01 : TriggerState {
            internal StateStart_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State금고폭파_01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 2);
            }
        }

        private class State금고폭파_01 : TriggerState {
            internal State금고폭파_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{8001}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State금고폭파_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State금고폭파_02 : TriggerState {
            internal State금고폭파_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State금고폭파_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State금고폭파_03 : TriggerState {
            internal State금고폭파_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7001}, enabled: true);
                context.SetEffect(triggerIds: new []{5001}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State폭파확인_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭파확인_01 : TriggerState {
            internal State폭파확인_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2001");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_2002");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State빅스소개_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State빅스소개_01 : TriggerState {
            internal State빅스소개_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8001, 8002}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State빅스소개_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State빅스소개_02 : TriggerState {
            internal State빅스소개_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003272, script: "$52000128_QD__52000128_MAIN__0$", duration: 2000, align: Align.Left);
                context.SetSceneSkip(state: new State제시소개_01(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State빅스소개_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State빅스소개_03 : TriggerState {
            internal State빅스소개_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: CaptionType.Vertical, title: "$52000128_QD__52000128_MAIN__1$", script: "$52000128_QD__52000128_MAIN__2$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2.5f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State제시소개_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제시소개_01 : TriggerState {
            internal State제시소개_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.CameraSelectPath(pathIds: new []{8002, 8003}, returnView: false);
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_2003");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State제시소개_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제시소개_02 : TriggerState {
            internal State제시소개_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003273, script: "$52000128_QD__52000128_MAIN__3$", duration: 2000, align: Align.Left);
                context.SetSceneSkip(state: new State카일소개_01(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State제시소개_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제시소개_03 : TriggerState {
            internal State제시소개_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: CaptionType.Vertical, title: "$52000128_QD__52000128_MAIN__4$", script: "$52000128_QD__52000128_MAIN__5$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2.5f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State카일소개_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카일소개_01 : TriggerState {
            internal State카일소개_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.CameraSelectPath(pathIds: new []{8003, 8004}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State카일소개_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카일소개_02 : TriggerState {
            internal State카일소개_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_2004");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State카일소개_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카일소개_03 : TriggerState {
            internal State카일소개_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003280, script: "$52000128_QD__52000128_MAIN__6$", duration: 2351, align: Align.Left);
                context.SetNpcEmotionSequence(spawnId: 103, sequenceName: "Bore_B");
                context.SetSceneSkip(state: new StateQuest시작_01(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State카일소개_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카일소개_04 : TriggerState {
            internal State카일소개_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: CaptionType.Vertical, title: "$52000128_QD__52000128_MAIN__7$", script: "$52000128_QD__52000128_MAIN__8$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2.5f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateQuest시작_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest시작_01 : TriggerState {
            internal StateQuest시작_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 2.0f);
                context.ShowGuideSummary(entityId: 25201281, textId: 25201281);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002690}, questStates: new byte[]{1})) {
                    return new StateQuest진행_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002690}, questStates: new byte[]{2})) {
                    return new StateQuest완료가능_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002690}, questStates: new byte[]{3})) {
                    return new State암전_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest진행_01 : TriggerState {
            internal StateQuest진행_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 25201281);
                context.ShowGuideSummary(entityId: 25201282, textId: 25201282);
                context.SetEffect(triggerIds: new []{5003, 5004, 5005, 5006, 5007, 5008, 5009}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{702})) {
                    return new StateQuest진행_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest진행_02 : TriggerState {
            internal StateQuest진행_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5003, 5004, 5005, 5006, 5007, 5008, 5009}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002690}, questStates: new byte[]{2})) {
                    return new StateQuest완료가능_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest완료가능_01 : TriggerState {
            internal StateQuest완료가능_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 25201281);
                context.HideGuideSummary(entityId: 25201282);
                context.ShowGuideSummary(entityId: 25201283, textId: 25201283);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002690}, questStates: new byte[]{3})) {
                    return new State암전_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State암전_01 : TriggerState {
            internal State암전_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 25201281);
                context.HideGuideSummary(entityId: 25201282);
                context.HideGuideSummary(entityId: 25201283);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State암전_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State암전_02 : TriggerState {
            internal State암전_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8005}, returnView: false);
                context.DestroyMonster(spawnIds: new []{103});
                context.CreateMonster(spawnIds: new []{104}, arg2: false);
                context.MoveUserPath(patrolName: "MS2PatrolData_2005");
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2006");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_2007");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State밝은화면_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State밝은화면_01 : TriggerState {
            internal State밝은화면_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State잡담_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State잡담_01 : TriggerState {
            internal State잡담_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$52000128_QD__52000128_MAIN__9$", arg4: 2, arg5: 0);
                context.SetSceneSkip(state: new State교도관Spawn_06(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State잡담_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State잡담_02 : TriggerState {
            internal State잡담_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{107, 109, 111, 113, 115}, arg2: false);
                context.SetConversation(type: 1, spawnId: 104, script: "$52000128_QD__52000128_MAIN__10$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State교도관Spawn_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State교도관Spawn_01 : TriggerState {
            internal State교도관Spawn_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_2010");
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2008");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_2009");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State교도관Spawn_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State교도관Spawn_02 : TriggerState {
            internal State교도관Spawn_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8006}, returnView: false);
                context.SetConversation(type: 1, spawnId: 111, script: "$52000128_QD__52000128_MAIN__21$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State교도관Spawn_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State교도관Spawn_03 : TriggerState {
            internal State교도관Spawn_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8005}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State교도관Spawn_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State교도관Spawn_04 : TriggerState {
            internal State교도관Spawn_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_2012");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State교도관Spawn_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State교도관Spawn_05 : TriggerState {
            internal State교도관Spawn_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$52000128_QD__52000128_MAIN__11$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3300)) {
                    return new State교도관Spawn_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State교도관Spawn_06 : TriggerState {
            internal State교도관Spawn_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.MoveUserPath(patrolName: "MS2PatrolData_2013");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State교도관Spawn_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State교도관Spawn_07 : TriggerState {
            internal State교도관Spawn_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2014");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_2014");
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_2014");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State교도관Spawn_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State교도관Spawn_08 : TriggerState {
            internal State교도관Spawn_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State교도관전투_01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{101, 102, 104});
            }
        }

        private class State교도관전투_01 : TriggerState {
            internal State교도관전투_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.ShowGuideSummary(entityId: 25201284, textId: 25201284);
                context.DestroyMonster(spawnIds: new []{107, 109, 111, 113, 115});
                context.CreateMonster(spawnIds: new []{108, 110, 112, 114, 116}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{108, 110, 112, 114, 116})) {
                    return new State교도관전투끝_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State교도관전투끝_01 : TriggerState {
            internal State교도관전투끝_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.HideGuideSummary(entityId: 25201284);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State교도관전투끝_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State교도관전투끝_02 : TriggerState {
            internal State교도관전투끝_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000128, portalId: 99);
                context.CreateMonster(spawnIds: new []{117, 118, 119, 120, 121});
                context.CreateMonster(spawnIds: new []{105}, arg2: true);
                context.MoveNpc(spawnId: 105, patrolName: "MS2PatrolData_2011");
                context.CameraSelectPath(pathIds: new []{8009}, returnView: false);
                context.SetNpcEmotionLoop(spawnId: 117, sequenceName: "Dead_Idle_A", duration: 3600000f);
                context.SetNpcEmotionLoop(spawnId: 118, sequenceName: "Dead_Idle_B", duration: 3600000f);
                context.SetNpcEmotionLoop(spawnId: 119, sequenceName: "Dead_Idle_B", duration: 3600000f);
                context.SetNpcEmotionLoop(spawnId: 120, sequenceName: "Dead_Idle_B", duration: 3600000f);
                context.SetNpcEmotionLoop(spawnId: 121, sequenceName: "Dead_Idle_A", duration: 3600000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State교도관전투끝_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State교도관전투끝_03 : TriggerState {
            internal State교도관전투끝_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State전투끝_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투끝_04 : TriggerState {
            internal State전투끝_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new State벨마Spawn_06(context), arg2: "nextState");
                context.AddCinematicTalk(npcId: 0, script: "$52000128_QD__52000128_MAIN__12$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3300)) {
                    return new State전투끝_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투끝_05 : TriggerState {
            internal State전투끝_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(sequenceNames: new []{"Emotion_Suprise_A"});
                context.AddCinematicTalk(npcId: 0, script: "$52000128_QD__52000128_MAIN__13$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3300)) {
                    return new State벨마Spawn_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨마Spawn_01 : TriggerState {
            internal State벨마Spawn_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8006}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State벨마Spawn_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨마Spawn_02 : TriggerState {
            internal State벨마Spawn_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003274, script: "$52000128_QD__52000128_MAIN__14$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3300)) {
                    return new State벨마Spawn_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨마Spawn_03 : TriggerState {
            internal State벨마Spawn_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8007}, returnView: false);
                context.AddCinematicTalk(npcId: 0, script: "$52000128_QD__52000128_MAIN__15$", duration: 4000, align: Align.Right);
                context.SetPcEmotionSequence(sequenceNames: new []{"Talk_A"});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State벨마Spawn_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨마Spawn_04 : TriggerState {
            internal State벨마Spawn_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8008}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State벨마Spawn_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨마Spawn_05 : TriggerState {
            internal State벨마Spawn_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 105, sequenceName: "Attack_01_B");
                context.AddCinematicTalk(npcId: 11003274, script: "$52000128_QD__52000128_MAIN__16$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State벨마Spawn_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨마Spawn_06 : TriggerState {
            internal State벨마Spawn_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
                context.CameraReset(interpolationTime: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State벨마전투_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨마전투_01 : TriggerState {
            internal State벨마전투_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.ShowGuideSummary(entityId: 25201285, textId: 25201285);
                context.DestroyMonster(spawnIds: new []{105});
                context.CreateMonster(spawnIds: new []{106}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "battleStop") == 1) {
                    return new State벨마전투끝_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨마전투끝_01 : TriggerState {
            internal State벨마전투끝_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.HideGuideSummary(entityId: 25201285);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State벨마전투끝_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨마전투끝_02 : TriggerState {
            internal State벨마전투끝_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000128, portalId: 99);
                context.DestroyMonster(spawnIds: new []{106});
                context.CreateMonster(spawnIds: new []{105}, arg2: true);
                context.MoveNpc(spawnId: 105, patrolName: "MS2PatrolData_2011");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State벨마전투끝_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨마전투끝_03 : TriggerState {
            internal State벨마전투끝_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State전투후대화_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후대화_01 : TriggerState {
            internal State전투후대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new State마무리(context), arg2: "exit");
                context.CameraSelectPath(pathIds: new []{8010}, returnView: false);
                context.FaceEmotion(spawnId: 0);
                context.SetPcEmotionSequence(sequenceNames: new []{"Talk_A"});
                context.AddCinematicTalk(npcId: 0, script: "$52000128_QD__52000128_MAIN__17$", duration: 3000, align: Align.Right);
                context.AddCinematicTalk(npcId: 0, script: "$52000128_QD__52000128_MAIN__18$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    return new State전투후대화_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후대화_02 : TriggerState {
            internal State전투후대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8006}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State불길_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State불길_01 : TriggerState {
            internal State불길_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5002}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State탈출_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈출_01 : TriggerState {
            internal State탈출_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8011}, returnView: false);
                context.SetConversation(type: 1, spawnId: 0, script: "$52000128_QD__52000128_MAIN__19$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State탈출_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈출_02 : TriggerState {
            internal State탈출_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_2014");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State탈출_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈출_03 : TriggerState {
            internal State탈출_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8008}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 105, sequenceName: "Attack_01_B");
                context.AddCinematicTalk(npcId: 11003274, script: "$52000128_QD__52000128_MAIN__20$", duration: 2000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
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
                context.RemoveCinematicTalk();
                context.SetOnetimeEffect(id: 5, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
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
                context.MoveUser(mapId: 52000129, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
