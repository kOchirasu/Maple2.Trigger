using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52010056_qd {
    public static class _eventsection {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{9005}, visible: true);
                context.SetMeshAnimation(triggerIds: new []{9005}, visible: true, arg3: 0, arg4: 0);
                context.SetMesh(triggerIds: new []{9006}, visible: false);
                context.SetMeshAnimation(triggerIds: new []{9006}, visible: false, arg3: 0, arg4: 0);
                context.SetEffect(triggerIds: new []{5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012, 5013, 5014, 5101, 5102, 5103, 5104, 5105, 5106, 5107, 5108, 5109, 5110, 5111, 5112, 5113, 5114, 5115, 5116, 5117, 5118, 5201, 5202, 5203, 5204, 5205, 5206, 5207, 5208, 5209, 5210, 5211, 5212, 5213, 5214, 5215, 5216, 5218, 5218, 5301, 5302, 5303, 5304}, visible: false);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 3, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 4, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 5, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 6, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOut.xml");
            }

            public override TriggerState? Execute() {
                return new StateReady(context);
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(visible: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.CreateMonster(spawnIds: new []{111, 112, 121, 122, 123, 124, 125, 126, 191}, arg2: false);
                context.MoveUser(mapId: 52010056, portalId: 6001);
            }

            public override TriggerState? Execute() {
                return new State인트로_Prepare(context);
            }

            public override void OnExit() { }
        }

        private class State인트로_Prepare : TriggerState {
            internal State인트로_Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52010056_QD__EventSection__52$", arg3: false);
                context.CameraSelectPath(pathIds: new []{4001}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{91000054}, questStates: new byte[]{2})) {
                    return new StateStopCinematic(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{91000054}, questStates: new byte[]{1})) {
                    return new State의외의효능_화면끔(context);
                }

                if (context.WaitTick(waitTick: 4000)) {
                    return new State인트로_지역소개(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인트로_지역소개 : TriggerState {
            internal State인트로_지역소개(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.ShowCaption(type: CaptionType.Vertical, title: "$52010056_QD__EventSection__54$", script: "$52010056_QD__EventSection__0$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 3500, scale: 1f);
                context.SetSceneSkip(state: new StateStartCinematic_Prepare(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State크림슨스피어_Script_A(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨스피어_Script_A : TriggerState {
            internal State크림슨스피어_Script_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 126, patrolName: "MS2PatrolData_3001");
                context.AddCinematicTalk(npcId: 11003816, script: "$52010056_QD__EventSection__1$", duration: 2800);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State크림슨발록_Script_A(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록_Script_A : TriggerState {
            internal State크림슨발록_Script_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 121, sequenceName: "Stun_A");
                context.AddCinematicTalk(npcId: 11003817, script: "$52010056_QD__EventSection__2$", duration: 2800);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State크림슨발록_Script_B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록_Script_B : TriggerState {
            internal State크림슨발록_Script_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003817, script: "$52010056_QD__EventSection__3$", duration: 2800);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State크림슨발록_Script_C(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록_Script_C : TriggerState {
            internal State크림슨발록_Script_C(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003817, script: "$52010056_QD__EventSection__4$", duration: 2800);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State크림슨발록_Script_D(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록_Script_D : TriggerState {
            internal State크림슨발록_Script_D(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003817, script: "$52010056_QD__EventSection__5$", duration: 2800);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State크림슨발록_Script_E(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록_Script_E : TriggerState {
            internal State크림슨발록_Script_E(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003817, script: "$52010056_QD__EventSection__6$", duration: 2800);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State크림슨발록_Script_F(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록_Script_F : TriggerState {
            internal State크림슨발록_Script_F(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003817, script: "$52010056_QD__EventSection__7$", duration: 2800);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State크림슨스피어_Script_B(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetNpcEmotionSequence(spawnId: 121, sequenceName: "Attack_01_C");
            }
        }

        private class State크림슨스피어_Script_B : TriggerState {
            internal State크림슨스피어_Script_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 125, patrolName: "MS2PatrolData_3002");
                context.MoveNpc(spawnId: 124, patrolName: "MS2PatrolData_3003");
                context.MoveNpc(spawnId: 123, patrolName: "MS2PatrolData_3004");
                context.AddBalloonTalk(spawnId: 123, msg: "$52010056_QD__EventSection__8$", duration: 2800, delayTick: 0);
                context.AddBalloonTalk(spawnId: 124, msg: "$52010056_QD__EventSection__8$", duration: 2800, delayTick: 0);
                context.AddBalloonTalk(spawnId: 125, msg: "$52010056_QD__EventSection__8$", duration: 2800, delayTick: 0);
                context.AddBalloonTalk(spawnId: 126, msg: "$52010056_QD__EventSection__8$", duration: 2800, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State인트로_종료(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }
        }

        private class State인트로_종료 : TriggerState {
            internal State인트로_종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateStartCinematic_Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic_Prepare : TriggerState {
            internal StateStartCinematic_Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52010056_QD__EventSection__53$", arg3: false);
                context.CameraSelectPath(pathIds: new []{4002}, returnView: false);
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StateStartCinematic_지역소개(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic_지역소개 : TriggerState {
            internal StateStartCinematic_지역소개(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.ShowCaption(type: CaptionType.Vertical, title: "$52010056_QD__EventSection__12$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 3500, scale: 1f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State트리스탄_침입(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리스탄_침입 : TriggerState {
            internal State트리스탄_침입(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 111, patrolName: "MS2PatrolData_3005");
                context.MoveNpc(spawnId: 112, patrolName: "MS2PatrolData_3006");
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_3007");
                context.AddBalloonTalk(spawnId: 111, msg: "$52010056_QD__EventSection__13$", duration: 2800, delayTick: 0);
                context.AddBalloonTalk(spawnId: 112, msg: "$52010056_QD__EventSection__14$", duration: 2800, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State트리스탄_공격(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리스탄_공격 : TriggerState {
            internal State트리스탄_공격(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001, 5002, 5003}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2100)) {
                    return new State트리스탄_마무리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리스탄_마무리 : TriggerState {
            internal State트리스탄_마무리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4003}, returnView: false);
                context.SetEffect(triggerIds: new []{5004}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State보초_쓰러짐(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보초_쓰러짐 : TriggerState {
            internal State보초_쓰러짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 111, sequenceName: "Dead_B", duration: 999999999f);
                context.SetNpcEmotionLoop(spawnId: 112, sequenceName: "Dead_B", duration: 999999999f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State트리스탄_대사A(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리스탄_대사A : TriggerState {
            internal State트리스탄_대사A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Bore_A");
                context.AddCinematicTalk(npcId: 11003812, script: "$52010056_QD__EventSection__15$", duration: 2800);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State트리스탄_대사B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리스탄_대사B : TriggerState {
            internal State트리스탄_대사B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003812, script: "$52010056_QD__EventSection__16$", duration: 2800, illustId: "Tristan_normal", align: Align.Center);
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State조작_Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조작_Prepare : TriggerState {
            internal State조작_Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 111, 112, 121, 122, 123, 124, 125, 126});
                context.CameraReset(interpolationTime: 1.0f);
                context.VisibleMyPc(visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State조작_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조작_시작 : TriggerState {
            internal State조작_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetEventUI(arg1: 1, script: "$52010056_QD__EventSection__17$", duration: 3000, boxId: 0);
                context.SetQuestAccept(questId: 91000053);
                context.SetVisibleUI(uiNames: new []{"UpperHudDialog", "MessengerBrowser", "ExpBar", "GroupMessengerBrowser", "QuestGuideDialog", "MinimapDialog", "AdPushDialog", "SnowmanEventDialog"}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2010}, questIds: new []{91000054}, questStates: new byte[]{2})) {
                    return new State의외의효능_화면끔(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2010}, questIds: new []{91000054}, questStates: new byte[]{1})) {
                    return new State의외의효능_화면끔(context);
                }

                return null;
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetSound(triggerId: 7001, enabled: false);
            }
        }

        private class State의외의효능_화면끔 : TriggerState {
            internal State의외의효능_화면끔(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.SetOnetimeEffect(id: 3, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State의외의효능_Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.VisibleMyPc(visible: false);
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
                context.DestroyMonster(spawnIds: new []{111, 112, 121, 122, 123, 124, 125, 126});
            }
        }

        private class State의외의효능_Prepare : TriggerState {
            internal State의외의효능_Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(boxId: 2001, skillId: 99910300);
                context.CameraSelectPath(pathIds: new []{4008}, returnView: false);
                context.MoveUser(mapId: 52010056, portalId: 6002);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State의외의효능_CinematicA(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State의외의효능_CinematicA : TriggerState {
            internal State의외의효능_CinematicA(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 11003817, script: "$52010056_QD__EventSection__18$", duration: 4569);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4569)) {
                    return new State의외의효능_CinematicB(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State의외의효능_CinematicB : TriggerState {
            internal State의외의효능_CinematicB(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5005, 5008}, visible: true);
                context.CreateMonster(spawnIds: new []{801}, arg2: false);
                context.CameraSelectPath(pathIds: new []{4009, 4010}, returnView: false);
                context.AddCinematicTalk(npcId: 11003812, script: "$52010056_QD__EventSection__19$", duration: 2800);
                context.SetSceneSkip(state: new State각성_전투Prepare(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePortalCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalCreation : TriggerState {
            internal StatePortalCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5005, 5008}, visible: false);
                context.AddCinematicTalk(npcId: 11003812, script: "$52010056_QD__EventSection__20$", duration: 2800);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State크림슨군단Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨군단Creation : TriggerState {
            internal State크림슨군단Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5006, 5007, 5009, 5010, 5012, 5013}, visible: true);
                context.CreateMonster(spawnIds: new []{802, 803, 804, 805, 806, 807}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State크림슨군단진영(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨군단진영 : TriggerState {
            internal State크림슨군단진영(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5006, 5007, 5009, 5010, 5012, 5013}, visible: false);
                context.SetNpcEmotionSequence(spawnId: 801, sequenceName: "Stun_A");
                context.MoveNpc(spawnId: 802, patrolName: "MS2PatrolData_3009");
                context.MoveNpc(spawnId: 803, patrolName: "MS2PatrolData_3010");
                context.MoveNpc(spawnId: 804, patrolName: "MS2PatrolData_3011");
                context.MoveNpc(spawnId: 805, patrolName: "MS2PatrolData_3012");
                context.MoveNpc(spawnId: 806, patrolName: "MS2PatrolData_3013");
                context.MoveNpc(spawnId: 807, patrolName: "MS2PatrolData_3014");
                context.AddCinematicTalk(npcId: 11003817, script: "$52010056_QD__EventSection__21$", duration: 2800);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State크림슨발록분노(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록분노 : TriggerState {
            internal State크림슨발록분노(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 801, sequenceName: "Attack_01_B");
                context.AddCinematicTalk(npcId: 11003817, script: "$52010056_QD__EventSection__22$", duration: 2800);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State트리스탄Script_A(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetOnetimeEffect(id: 3, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }
        }

        private class State트리스탄Script_A : TriggerState {
            internal State트리스탄Script_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003812, script: "$52010056_QD__EventSection__23$", duration: 2800, illustId: "Tristan_normal", align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State트리스탄Script_B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리스탄Script_B : TriggerState {
            internal State트리스탄Script_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003812, script: "$52010056_QD__EventSection__24$", duration: 2800, illustId: "Tristan_normal", align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State크림슨발록Script_A(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록Script_A : TriggerState {
            internal State크림슨발록Script_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4011}, returnView: false);
                context.AddCinematicTalk(npcId: 11003817, script: "$52010056_QD__EventSection__25$", duration: 2800, illustId: "balrog_normal", align: Align.Center);
                context.SetEffect(triggerIds: new []{5011}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State인페르녹의혼_흡수Cinematic_A(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetOnetimeEffect(id: 3, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }
        }

        private class State인페르녹의혼_흡수Cinematic_A : TriggerState {
            internal State인페르녹의혼_흡수Cinematic_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Attack_02_B", duration: 999999999f);
                context.AddCinematicTalk(npcId: 11003812, script: "$52010056_QD__EventSection__26$", duration: 2800);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State인페르녹의혼_흡수Cinematic_B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹의혼_흡수Cinematic_B : TriggerState {
            internal State인페르녹의혼_흡수Cinematic_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4012}, returnView: false);
                context.AddCinematicTalk(npcId: 11003812, script: "$52010056_QD__EventSection__27$", duration: 2800);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State인페르녹의혼_흡수Cinematic_C(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹의혼_흡수Cinematic_C : TriggerState {
            internal State인페르녹의혼_흡수Cinematic_C(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5012, 5013}, visible: true);
                context.AddCinematicTalk(npcId: 11003812, script: "$52010056_QD__EventSection__28$", duration: 2800);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State인페르녹의혼_흡수Cinematic_D(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹의혼_흡수Cinematic_D : TriggerState {
            internal State인페르녹의혼_흡수Cinematic_D(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State인페르녹의혼_흡수Cinematic_E(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹의혼_흡수Cinematic_E : TriggerState {
            internal State인페르녹의혼_흡수Cinematic_E(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003821, script: "$52010056_QD__EventSection__29$", duration: 2800);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State인페르녹의혼_흡수Cinematic_F(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹의혼_흡수Cinematic_F : TriggerState {
            internal State인페르녹의혼_흡수Cinematic_F(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003812, script: "$52010056_QD__EventSection__30$", duration: 2800, illustId: "Tristan_normal", align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State인페르녹의혼_흡수Cinematic_G(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹의혼_흡수Cinematic_G : TriggerState {
            internal State인페르녹의혼_흡수Cinematic_G(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003821, script: "$52010056_QD__EventSection__31$", duration: 2800, align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State인페르녹의혼_흡수Cinematic_H(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹의혼_흡수Cinematic_H : TriggerState {
            internal State인페르녹의혼_흡수Cinematic_H(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003821, script: "$52010056_QD__EventSection__32$", duration: 2800, align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State인페르녹의혼_흡수Cinematic_I(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹의혼_흡수Cinematic_I : TriggerState {
            internal State인페르녹의혼_흡수Cinematic_I(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003812, script: "$52010056_QD__EventSection__33$", duration: 2800, illustId: "Tristan_normal", align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State인페르녹의혼_흡수Cinematic_J(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹의혼_흡수Cinematic_J : TriggerState {
            internal State인페르녹의혼_흡수Cinematic_J(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003821, script: "$52010056_QD__EventSection__34$", duration: 2800);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State인페르녹의혼_흡수Cinematic_K(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹의혼_흡수Cinematic_K : TriggerState {
            internal State인페르녹의혼_흡수Cinematic_K(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003812, script: "$52010056_QD__EventSection__35$", duration: 2800, illustId: "Tristan_normal", align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State인페르녹의혼_흡수Cinematic_L(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹의혼_흡수Cinematic_L : TriggerState {
            internal State인페르녹의혼_흡수Cinematic_L(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003821, script: "$52010056_QD__EventSection__36$", duration: 2800);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State인페르녹의혼_흡수Cinematic_M(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹의혼_흡수Cinematic_M : TriggerState {
            internal State인페르녹의혼_흡수Cinematic_M(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003821, script: "$52010056_QD__EventSection__37$", duration: 2800);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State인페르녹의혼_흡수Cinematic_N(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹의혼_흡수Cinematic_N : TriggerState {
            internal State인페르녹의혼_흡수Cinematic_N(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4013}, returnView: false);
                context.AddCinematicTalk(npcId: 11003821, script: "$52010056_QD__EventSection__38$", duration: 2800);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State각성_전투Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State각성_전투Prepare : TriggerState {
            internal State각성_전투Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.SetMesh(triggerIds: new []{9005}, visible: false);
                context.SetMeshAnimation(triggerIds: new []{9005}, visible: false, arg3: 0, arg4: 0);
                context.SetMesh(triggerIds: new []{9006}, visible: true);
                context.SetMeshAnimation(triggerIds: new []{9006}, visible: true, arg3: 0, arg4: 0);
                context.DestroyMonster(spawnIds: new []{102, 802, 803, 804, 805, 806, 807});
                context.SetEffect(triggerIds: new []{5005, 5006, 5007, 5008, 5009, 5010, 5009, 5010, 5011, 5012, 5013}, visible: false);
                context.VisibleMyPc(visible: true);
                context.SetOnetimeEffect(id: 3, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 4, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State각성_전투시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State각성_전투시작 : TriggerState {
            internal State각성_전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 11003812, script: "$52010056_QD__EventSection__39$", duration: 2800);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State조작제어_해제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조작제어_해제 : TriggerState {
            internal State조작제어_해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State크림슨발록군단Creation_A(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록군단Creation_A : TriggerState {
            internal State크림슨발록군단Creation_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{701, 702, 703, 704, 705, 706, 707, 708, 709, 710, 711, 712, 713, 714, 715, 716, 717, 718, 719, 720, 721, 722, 723, 724}, arg2: true);
                context.SetEventUI(arg1: 1, script: "$52010056_QD__EventSection__40$", duration: 3000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State크림슨발록군단Creation_B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록군단Creation_B : TriggerState {
            internal State크림슨발록군단Creation_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{701, 702, 703, 704, 705, 706, 707, 708, 709, 710, 711, 712, 713, 714, 715, 716, 717, 718, 719, 720, 721, 722, 723, 724}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State크림슨발록군단Creation_C(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록군단Creation_C : TriggerState {
            internal State크림슨발록군단Creation_C(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{701, 702, 703, 704, 705, 706, 707, 708, 709, 710, 711, 712, 713, 714, 715, 716, 717, 718, 719, 720, 721, 722, 723, 724}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State크림슨발록군단Creation_D(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록군단Creation_D : TriggerState {
            internal State크림슨발록군단Creation_D(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{701, 702, 703, 704, 705, 706, 707, 708, 709, 710, 711, 712, 713, 714, 715, 716, 717, 718, 719, 720, 721, 722, 723, 724}, arg2: true);
                context.SetEventUI(arg1: 1, script: "$52010056_QD__EventSection__41$", duration: 3000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State크림슨발록군단Creation_E(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록군단Creation_E : TriggerState {
            internal State크림슨발록군단Creation_E(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{701, 702, 703, 704, 705, 706, 707, 708, 709, 710, 711, 712, 713, 714, 715, 716, 717, 718, 719, 720, 721, 722, 723, 724}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State크림슨발록군단Creation_F(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록군단Creation_F : TriggerState {
            internal State크림슨발록군단Creation_F(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{701, 702, 703, 704, 705, 706, 707, 708, 709, 710, 711, 712, 713, 714, 715, 716, 717, 718, 719, 720, 721, 722, 723, 724}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{701, 702, 703, 704, 705, 706, 707, 708, 709, 710, 711, 712, 713, 714, 715, 716, 717, 718, 719, 720, 721, 722, 723, 724})) {
                    return new State필살기Cinematic_암전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State필살기Cinematic_암전 : TriggerState {
            internal State필살기Cinematic_암전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(visible: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.SetOnetimeEffect(id: 5, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(mapId: 52010056, portalId: 6003);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State필살기Cinematic_PrepareA(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State필살기Cinematic_PrepareA : TriggerState {
            internal State필살기Cinematic_PrepareA(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{701, 702, 703, 704, 705, 706, 707, 708, 709, 710, 711, 712, 713, 714, 715, 716, 717, 718, 719, 720, 721, 722, 723, 724});
                context.CreateMonster(spawnIds: new []{103, 808, 809, 810, 811, 812, 813, 814, 815, 816, 817, 818, 819, 820, 821, 822, 823, 824, 825, 826}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State필살기Cinematic_PrepareB(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State필살기Cinematic_PrepareB : TriggerState {
            internal State필살기Cinematic_PrepareB(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 103, sequenceName: "Attack_Idle_A", duration: 9999999f);
                context.SetNpcEmotionLoop(spawnId: 808, sequenceName: "Attack_Idle_A", duration: 9999999f);
                context.SetNpcEmotionLoop(spawnId: 809, sequenceName: "Attack_Idle_A", duration: 9999999f);
                context.SetNpcEmotionLoop(spawnId: 810, sequenceName: "Attack_Idle_A", duration: 9999999f);
                context.SetNpcEmotionLoop(spawnId: 811, sequenceName: "Attack_Idle_A", duration: 9999999f);
                context.SetNpcEmotionLoop(spawnId: 812, sequenceName: "Attack_Idle_A", duration: 9999999f);
                context.SetNpcEmotionLoop(spawnId: 813, sequenceName: "Attack_Idle_A", duration: 9999999f);
                context.SetNpcEmotionLoop(spawnId: 814, sequenceName: "Attack_Idle_A", duration: 9999999f);
                context.SetNpcEmotionLoop(spawnId: 815, sequenceName: "Attack_Idle_A", duration: 9999999f);
                context.SetNpcEmotionLoop(spawnId: 816, sequenceName: "Attack_Idle_A", duration: 9999999f);
                context.SetNpcEmotionLoop(spawnId: 817, sequenceName: "Attack_Idle_A", duration: 9999999f);
                context.SetNpcEmotionLoop(spawnId: 818, sequenceName: "Attack_Idle_A", duration: 9999999f);
                context.SetNpcEmotionLoop(spawnId: 819, sequenceName: "Attack_Idle_A", duration: 9999999f);
                context.SetNpcEmotionLoop(spawnId: 820, sequenceName: "Attack_Idle_A", duration: 9999999f);
                context.SetNpcEmotionLoop(spawnId: 821, sequenceName: "Attack_Idle_A", duration: 9999999f);
                context.SetNpcEmotionLoop(spawnId: 822, sequenceName: "Attack_Idle_A", duration: 9999999f);
                context.SetNpcEmotionLoop(spawnId: 823, sequenceName: "Attack_Idle_A", duration: 9999999f);
                context.SetNpcEmotionLoop(spawnId: 824, sequenceName: "Attack_Idle_A", duration: 9999999f);
                context.SetNpcEmotionLoop(spawnId: 825, sequenceName: "Attack_Idle_A", duration: 9999999f);
                context.SetNpcEmotionLoop(spawnId: 826, sequenceName: "Attack_Idle_A", duration: 9999999f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateCamera_온A(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_온A : TriggerState {
            internal StateCamera_온A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 5, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(pathIds: new []{4014}, returnView: false);
                context.SetSceneSkip(state: new StateTriggerAchievement(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateCamera_온B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_온B : TriggerState {
            internal StateCamera_온B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4015}, returnView: false);
                context.AddCinematicTalk(npcId: 11003817, script: "$52010056_QD__EventSection__42$", duration: 2800);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateCamera_온C(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_온C : TriggerState {
            internal StateCamera_온C(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4016}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateCamera_리셋(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_리셋 : TriggerState {
            internal StateCamera_리셋(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State크림슨발록_Script_G(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록_Script_G : TriggerState {
            internal State크림슨발록_Script_G(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 801, sequenceName: "Attack_01_B");
                context.AddCinematicTalk(npcId: 11003817, script: "$52010056_QD__EventSection__43$", duration: 2800);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State트리스탄_Script_H(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리스탄_Script_H : TriggerState {
            internal State트리스탄_Script_H(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003812, script: "$52010056_QD__EventSection__44$", duration: 2800, illustId: "Tristan_normal", align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State크림슨발록_Script_I(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록_Script_I : TriggerState {
            internal State크림슨발록_Script_I(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003817, script: "$52010056_QD__EventSection__45$", duration: 2800);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State트리스탄_대사D(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리스탄_대사D : TriggerState {
            internal State트리스탄_대사D(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003812, script: "$52010056_QD__EventSection__46$", duration: 2800, illustId: "Tristan_normal", align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State트리스탄_대사E(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리스탄_대사E : TriggerState {
            internal State트리스탄_대사E(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003812, script: "$52010056_QD__EventSection__47$", duration: 2800, illustId: "Tristan_normal", align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State필살기Cinematic_모션A(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State필살기Cinematic_모션A : TriggerState {
            internal State필살기Cinematic_모션A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 103, sequenceName: "Attack_02_B", duration: 9999999f);
                context.SetEffect(triggerIds: new []{5014}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State필살기Cinematic_모션B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State필살기Cinematic_모션B : TriggerState {
            internal State필살기Cinematic_모션B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 103, sequenceName: "Attack_01_B", duration: 9999999f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State크림슨발록_Script_J(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록_Script_J : TriggerState {
            internal State크림슨발록_Script_J(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003817, script: "$52010056_QD__EventSection__48$", duration: 1800);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1800)) {
                    return new State크림슨발록_Script_K(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록_Script_K : TriggerState {
            internal State크림슨발록_Script_K(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5101}, visible: true);
                context.AddCinematicTalk(npcId: 11003817, script: "$52010056_QD__EventSection__55$", duration: 1800);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new State바닥이펙트_A(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바닥이펙트_A : TriggerState {
            internal State바닥이펙트_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 808, sequenceName: "Damg_A", duration: 9999999f);
                context.SetEffect(triggerIds: new []{5102, 5202}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new State바닥이펙트_B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바닥이펙트_B : TriggerState {
            internal State바닥이펙트_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 809, sequenceName: "Damg_A", duration: 9999999f);
                context.SetEffect(triggerIds: new []{5103, 5203}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new State바닥이펙트_C(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바닥이펙트_C : TriggerState {
            internal State바닥이펙트_C(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 810, sequenceName: "Damg_A", duration: 9999999f);
                context.SetEffect(triggerIds: new []{5104, 5204, 5302}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new State바닥이펙트_D(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바닥이펙트_D : TriggerState {
            internal State바닥이펙트_D(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 811, sequenceName: "Damg_A", duration: 9999999f);
                context.SetEffect(triggerIds: new []{5105, 5205}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new State바닥이펙트_E(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바닥이펙트_E : TriggerState {
            internal State바닥이펙트_E(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 812, sequenceName: "Damg_A", duration: 9999999f);
                context.SetEffect(triggerIds: new []{5106, 5206}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new State바닥이펙트_F(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바닥이펙트_F : TriggerState {
            internal State바닥이펙트_F(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 813, sequenceName: "Damg_A", duration: 9999999f);
                context.SetEffect(triggerIds: new []{5107, 5207}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new State바닥이펙트_G(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바닥이펙트_G : TriggerState {
            internal State바닥이펙트_G(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 814, sequenceName: "Damg_A", duration: 9999999f);
                context.SetEffect(triggerIds: new []{5108, 5208}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new State바닥이펙트_H(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바닥이펙트_H : TriggerState {
            internal State바닥이펙트_H(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 815, sequenceName: "Damg_A", duration: 9999999f);
                context.SetEffect(triggerIds: new []{5109, 5209, 5303}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new State바닥이펙트_I(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바닥이펙트_I : TriggerState {
            internal State바닥이펙트_I(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 816, sequenceName: "Damg_A", duration: 9999999f);
                context.SetEffect(triggerIds: new []{5110, 5210}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new State바닥이펙트_J(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바닥이펙트_J : TriggerState {
            internal State바닥이펙트_J(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 817, sequenceName: "Damg_A", duration: 9999999f);
                context.SetEffect(triggerIds: new []{5111, 5211}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new State바닥이펙트_K(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바닥이펙트_K : TriggerState {
            internal State바닥이펙트_K(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 818, sequenceName: "Damg_A", duration: 9999999f);
                context.SetEffect(triggerIds: new []{5112, 5212}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new State바닥이펙트_L(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바닥이펙트_L : TriggerState {
            internal State바닥이펙트_L(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 819, sequenceName: "Damg_A", duration: 9999999f);
                context.SetEffect(triggerIds: new []{5113, 5213}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new State바닥이펙트_M(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바닥이펙트_M : TriggerState {
            internal State바닥이펙트_M(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 820, sequenceName: "Damg_A", duration: 9999999f);
                context.SetEffect(triggerIds: new []{5114, 5214, 5304}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new State바닥이펙트_N(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바닥이펙트_N : TriggerState {
            internal State바닥이펙트_N(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 821, sequenceName: "Damg_A", duration: 9999999f);
                context.SetEffect(triggerIds: new []{5115, 5215}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new State바닥이펙트_O(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바닥이펙트_O : TriggerState {
            internal State바닥이펙트_O(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 822, sequenceName: "Damg_A", duration: 9999999f);
                context.SetEffect(triggerIds: new []{5116, 5216}, visible: true);
                context.SetOnetimeEffect(id: 6, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOut.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new State바닥이펙트_P(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바닥이펙트_P : TriggerState {
            internal State바닥이펙트_P(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 823, sequenceName: "Damg_A", duration: 9999999f);
                context.SetEffect(triggerIds: new []{5117, 5217}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new State바닥이펙트_Q(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바닥이펙트_Q : TriggerState {
            internal State바닥이펙트_Q(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 824, sequenceName: "Damg_A", duration: 9999999f);
                context.SetEffect(triggerIds: new []{5118, 5218}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new State바닥이펙트_R(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바닥이펙트_R : TriggerState {
            internal State바닥이펙트_R(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 825, sequenceName: "Damg_A", duration: 9999999f);
                context.SetEffect(triggerIds: new []{5202, 5301}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State크림슨발록_Script_L(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록_Script_L : TriggerState {
            internal State크림슨발록_Script_L(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003817, script: "$52010056_QD__EventSection__50$", duration: 2800, illustId: "balrog_normal", align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State마지막Cinematic_세팅(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{103});
                context.CreateMonster(spawnIds: new []{104}, arg2: true);
            }
        }

        private class State마지막Cinematic_세팅 : TriggerState {
            internal State마지막Cinematic_세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5101, 5102, 5103, 5104, 5105, 5106, 5107, 5108, 5109, 5110, 5111, 5112, 5113, 5114, 5115, 5116, 5117, 5118, 5201, 5202, 5203, 5204, 5205, 5206, 5207, 5208, 5209, 5210, 5211, 5212, 5213, 5214, 5215, 5216, 5218, 5218, 5301, 5302, 5303, 5304}, visible: false);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetNpcEmotionLoop(spawnId: 104, sequenceName: "Attack_Idle_A", duration: 9999999f);
                context.SetNpcEmotionLoop(spawnId: 801, sequenceName: "Dead_01_A", duration: 9999999f);
                context.SetNpcEmotionLoop(spawnId: 808, sequenceName: "Dead_A", duration: 9999999f);
                context.SetNpcEmotionLoop(spawnId: 809, sequenceName: "Dead_A", duration: 9999999f);
                context.SetNpcEmotionLoop(spawnId: 810, sequenceName: "Dead_A", duration: 9999999f);
                context.SetNpcEmotionLoop(spawnId: 811, sequenceName: "Dead_A", duration: 9999999f);
                context.SetNpcEmotionLoop(spawnId: 812, sequenceName: "Dead_A", duration: 9999999f);
                context.SetNpcEmotionLoop(spawnId: 813, sequenceName: "Dead_A", duration: 9999999f);
                context.SetNpcEmotionLoop(spawnId: 814, sequenceName: "Dead_A", duration: 9999999f);
                context.SetNpcEmotionLoop(spawnId: 815, sequenceName: "Dead_A", duration: 9999999f);
                context.SetNpcEmotionLoop(spawnId: 816, sequenceName: "Dead_A", duration: 9999999f);
                context.SetNpcEmotionLoop(spawnId: 817, sequenceName: "Dead_A", duration: 9999999f);
                context.SetNpcEmotionLoop(spawnId: 818, sequenceName: "Dead_A", duration: 9999999f);
                context.SetNpcEmotionLoop(spawnId: 819, sequenceName: "Dead_A", duration: 9999999f);
                context.SetNpcEmotionLoop(spawnId: 820, sequenceName: "Dead_A", duration: 9999999f);
                context.SetNpcEmotionLoop(spawnId: 821, sequenceName: "Dead_A", duration: 9999999f);
                context.SetNpcEmotionLoop(spawnId: 822, sequenceName: "Dead_A", duration: 9999999f);
                context.SetNpcEmotionLoop(spawnId: 823, sequenceName: "Dead_A", duration: 9999999f);
                context.SetNpcEmotionLoop(spawnId: 824, sequenceName: "Dead_A", duration: 9999999f);
                context.SetNpcEmotionLoop(spawnId: 825, sequenceName: "Dead_A", duration: 9999999f);
                context.SetNpcEmotionLoop(spawnId: 826, sequenceName: "Dead_A", duration: 9999999f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State마지막Cinematic_온(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마지막Cinematic_온 : TriggerState {
            internal State마지막Cinematic_온(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 6, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOut.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State트리스탄_대사F(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리스탄_대사F : TriggerState {
            internal State트리스탄_대사F(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003812, script: "$52010056_QD__EventSection__51$", duration: 2800, illustId: "Tristan_normal", align: Align.Center);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTriggerAchievement(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTriggerAchievement : TriggerState {
            internal StateTriggerAchievement(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 2009, type: "trigger", code: "tristanarousal");
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
                context.MoveUser(mapId: 52010052, portalId: 1);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{91000054}, questStates: new byte[]{2})) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
