namespace Maple2.Trigger._52010056_qd {
    public static class _eventsection {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {9005}, arg2: true);
                context.SetMeshAnimation(arg1: new[] {9005}, arg2: true, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {9006}, arg2: false);
                context.SetMeshAnimation(arg1: new[] {9006}, arg2: false, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new[] {5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012, 5013, 5014, 5101, 5102, 5103, 5104, 5105, 5106, 5107, 5108, 5109, 5110, 5111, 5112, 5113, 5114, 5115, 5116, 5117, 5118, 5201, 5202, 5203, 5204, 5205, 5206, 5207, 5208, 5209, 5210, 5211, 5212, 5213, 5214, 5215, 5216, 5218, 5218, 5301, 5302, 5303, 5304}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 5, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 6, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOut.xml");
            }

            public override TriggerState Execute() {
                return new StateReady(context);
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(isVisible: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.CreateMonster(arg1: new[] {111, 112, 121, 122, 123, 124, 125, 126, 191}, arg2: false);
                context.MoveUser(arg1: 52010056, arg2: 6001);
            }

            public override TriggerState Execute() {
                return new State인트로_준비(context);
            }

            public override void OnExit() { }
        }

        private class State인트로_준비 : TriggerState {
            internal State인트로_준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52010056_QD__EventSection__52$", arg3: false);
                context.CameraSelectPath(arg1: new[] {4001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {91000054}, arg3: new byte[] {2})) {
                    return new StateStopCinematic(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {91000054}, arg3: new byte[] {1})) {
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
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.ShowCaption(type: "VerticalCaption", title: "$52010056_QD__EventSection__54$", desc: "$52010056_QD__EventSection__0$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f, duration: 3500, scale: 1f);
                context.SetSceneSkip(arg1: "시작연출_준비", arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State크림슨스피어_대사_A(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨스피어_대사_A : TriggerState {
            internal State크림슨스피어_대사_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 126, arg2: "MS2PatrolData_3001");
                context.AddCinematicTalk(npcId: 11003816, msg: "$52010056_QD__EventSection__1$", duration: 2800);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State크림슨발록_대사_A(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록_대사_A : TriggerState {
            internal State크림슨발록_대사_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 121, arg2: "Stun_A");
                context.AddCinematicTalk(npcId: 11003817, msg: "$52010056_QD__EventSection__2$", duration: 2800);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State크림슨발록_대사_B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록_대사_B : TriggerState {
            internal State크림슨발록_대사_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003817, msg: "$52010056_QD__EventSection__3$", duration: 2800);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State크림슨발록_대사_C(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록_대사_C : TriggerState {
            internal State크림슨발록_대사_C(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003817, msg: "$52010056_QD__EventSection__4$", duration: 2800);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State크림슨발록_대사_D(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록_대사_D : TriggerState {
            internal State크림슨발록_대사_D(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003817, msg: "$52010056_QD__EventSection__5$", duration: 2800);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State크림슨발록_대사_E(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록_대사_E : TriggerState {
            internal State크림슨발록_대사_E(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003817, msg: "$52010056_QD__EventSection__6$", duration: 2800);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State크림슨발록_대사_F(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록_대사_F : TriggerState {
            internal State크림슨발록_대사_F(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003817, msg: "$52010056_QD__EventSection__7$", duration: 2800);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State크림슨스피어_대사_B(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetNpcEmotionSequence(arg1: 121, arg2: "Attack_01_C");
            }
        }

        private class State크림슨스피어_대사_B : TriggerState {
            internal State크림슨스피어_대사_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 125, arg2: "MS2PatrolData_3002");
                context.MoveNpc(arg1: 124, arg2: "MS2PatrolData_3003");
                context.MoveNpc(arg1: 123, arg2: "MS2PatrolData_3004");
                context.AddBalloonTalk(spawnPointId: 123, msg: "$52010056_QD__EventSection__8$", duration: 2800, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 124, msg: "$52010056_QD__EventSection__8$", duration: 2800, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 125, msg: "$52010056_QD__EventSection__8$", duration: 2800, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 126, msg: "$52010056_QD__EventSection__8$", duration: 2800, delayTick: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State인트로_종료(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }
        }

        private class State인트로_종료 : TriggerState {
            internal State인트로_종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateStart연출_준비(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart연출_준비 : TriggerState {
            internal StateStart연출_준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52010056_QD__EventSection__53$", arg3: false);
                context.CameraSelectPath(arg1: new[] {4002}, arg2: false);
                context.CreateMonster(arg1: new[] {101}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StateStart연출_지역소개(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart연출_지역소개 : TriggerState {
            internal StateStart연출_지역소개(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.ShowCaption(type: "VerticalCaption", title: "$52010056_QD__EventSection__12$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f, duration: 3500, scale: 1f);
            }

            public override TriggerState Execute() {
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
                context.MoveNpc(arg1: 111, arg2: "MS2PatrolData_3005");
                context.MoveNpc(arg1: 112, arg2: "MS2PatrolData_3006");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_3007");
                context.AddBalloonTalk(spawnPointId: 111, msg: "$52010056_QD__EventSection__13$", duration: 2800, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 112, msg: "$52010056_QD__EventSection__14$", duration: 2800, delayTick: 0);
            }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {5001, 5002, 5003}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {4003}, arg2: false);
                context.SetEffect(arg1: new[] {5004}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionLoop(arg1: 111, arg2: "Dead_B", arg3: 999999999f);
                context.SetNpcEmotionLoop(arg1: 112, arg2: "Dead_B", arg3: 999999999f);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 11003812, msg: "$52010056_QD__EventSection__15$", duration: 2800);
            }

            public override TriggerState Execute() {
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
                context.AddCinematicTalk(npcId: 11003812, msg: "$52010056_QD__EventSection__16$", duration: 2800, illustId: "Tristan_normal", align: "Center");
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State조작_준비(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조작_준비 : TriggerState {
            internal State조작_준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 111, 112, 121, 122, 123, 124, 125, 126});
                context.CameraReset(interpolationTime: 1.0f);
                context.VisibleMyPc(isVisible: true);
            }

            public override TriggerState Execute() {
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
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetEventUI(arg1: 1, arg2: "$52010056_QD__EventSection__17$", arg3: 3000, arg4: "0");
                context.SetQuestAccept(questId: 91000053);
                context.SetVisibleUI(uiName: "UpperHudDialog,MessengerBrowser,ExpBar,GroupMessengerBrowser,QuestGuideDialog,MinimapDialog,AdPushDialog,SnowmanEventDialog", visible: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2010}, arg2: new[] {91000054}, arg3: new byte[] {2})) {
                    return new State의외의효능_화면끔(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2010}, arg2: new[] {91000054}, arg3: new byte[] {1})) {
                    return new State의외의효능_화면끔(context);
                }

                return null;
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetSound(arg1: 7001, arg2: false);
            }
        }

        private class State의외의효능_화면끔 : TriggerState {
            internal State의외의효능_화면끔(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State의외의효능_준비(context);
                }

                return null;
            }

            public override void OnExit() {
                context.VisibleMyPc(isVisible: false);
                context.CreateMonster(arg1: new[] {102}, arg2: false);
                context.DestroyMonster(arg1: new[] {111, 112, 121, 122, 123, 124, 125, 126});
            }
        }

        private class State의외의효능_준비 : TriggerState {
            internal State의외의효능_준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 2001, arg2: 99910300);
                context.CameraSelectPath(arg1: new[] {4008}, arg2: false);
                context.MoveUser(arg1: 52010056, arg2: 6002);
            }

            public override TriggerState Execute() {
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
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcId: 11003817, msg: "$52010056_QD__EventSection__18$", duration: 4569);
            }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {5005, 5008}, arg2: true);
                context.CreateMonster(arg1: new[] {801}, arg2: false);
                context.CameraSelectPath(arg1: new[] {4009, 4010}, arg2: false);
                context.AddCinematicTalk(npcId: 11003812, msg: "$52010056_QD__EventSection__19$", duration: 2800);
                context.SetSceneSkip(arg1: "각성_전투준비", arg2: "nextState");
            }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {5005, 5008}, arg2: false);
                context.AddCinematicTalk(npcId: 11003812, msg: "$52010056_QD__EventSection__20$", duration: 2800);
            }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {5006, 5007, 5009, 5010, 5012, 5013}, arg2: true);
                context.CreateMonster(arg1: new[] {802, 803, 804, 805, 806, 807}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {5006, 5007, 5009, 5010, 5012, 5013}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 801, arg2: "Stun_A");
                context.MoveNpc(arg1: 802, arg2: "MS2PatrolData_3009");
                context.MoveNpc(arg1: 803, arg2: "MS2PatrolData_3010");
                context.MoveNpc(arg1: 804, arg2: "MS2PatrolData_3011");
                context.MoveNpc(arg1: 805, arg2: "MS2PatrolData_3012");
                context.MoveNpc(arg1: 806, arg2: "MS2PatrolData_3013");
                context.MoveNpc(arg1: 807, arg2: "MS2PatrolData_3014");
                context.AddCinematicTalk(npcId: 11003817, msg: "$52010056_QD__EventSection__21$", duration: 2800);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 801, arg2: "Attack_01_B");
                context.AddCinematicTalk(npcId: 11003817, msg: "$52010056_QD__EventSection__22$", duration: 2800);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State트리스탄대사_A(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }
        }

        private class State트리스탄대사_A : TriggerState {
            internal State트리스탄대사_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003812, msg: "$52010056_QD__EventSection__23$", duration: 2800, illustId: "Tristan_normal", align: "Center");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State트리스탄대사_B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리스탄대사_B : TriggerState {
            internal State트리스탄대사_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003812, msg: "$52010056_QD__EventSection__24$", duration: 2800, illustId: "Tristan_normal", align: "Center");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State크림슨발록대사_A(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록대사_A : TriggerState {
            internal State크림슨발록대사_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4011}, arg2: false);
                context.AddCinematicTalk(npcId: 11003817, msg: "$52010056_QD__EventSection__25$", duration: 2800, illustId: "balrog_normal", align: "Center");
                context.SetEffect(arg1: new[] {5011}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State인페르녹의혼_흡수연출_A(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }
        }

        private class State인페르녹의혼_흡수연출_A : TriggerState {
            internal State인페르녹의혼_흡수연출_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Attack_02_B", arg3: 999999999f);
                context.AddCinematicTalk(npcId: 11003812, msg: "$52010056_QD__EventSection__26$", duration: 2800);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State인페르녹의혼_흡수연출_B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹의혼_흡수연출_B : TriggerState {
            internal State인페르녹의혼_흡수연출_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4012}, arg2: false);
                context.AddCinematicTalk(npcId: 11003812, msg: "$52010056_QD__EventSection__27$", duration: 2800);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State인페르녹의혼_흡수연출_C(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹의혼_흡수연출_C : TriggerState {
            internal State인페르녹의혼_흡수연출_C(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5012, 5013}, arg2: true);
                context.AddCinematicTalk(npcId: 11003812, msg: "$52010056_QD__EventSection__28$", duration: 2800);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State인페르녹의혼_흡수연출_D(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹의혼_흡수연출_D : TriggerState {
            internal State인페르녹의혼_흡수연출_D(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State인페르녹의혼_흡수연출_E(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹의혼_흡수연출_E : TriggerState {
            internal State인페르녹의혼_흡수연출_E(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003821, msg: "$52010056_QD__EventSection__29$", duration: 2800);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State인페르녹의혼_흡수연출_F(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹의혼_흡수연출_F : TriggerState {
            internal State인페르녹의혼_흡수연출_F(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003812, msg: "$52010056_QD__EventSection__30$", duration: 2800, illustId: "Tristan_normal", align: "Center");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State인페르녹의혼_흡수연출_G(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹의혼_흡수연출_G : TriggerState {
            internal State인페르녹의혼_흡수연출_G(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003821, msg: "$52010056_QD__EventSection__31$", duration: 2800, align: "Center");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State인페르녹의혼_흡수연출_H(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹의혼_흡수연출_H : TriggerState {
            internal State인페르녹의혼_흡수연출_H(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003821, msg: "$52010056_QD__EventSection__32$", duration: 2800, align: "Center");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State인페르녹의혼_흡수연출_I(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹의혼_흡수연출_I : TriggerState {
            internal State인페르녹의혼_흡수연출_I(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003812, msg: "$52010056_QD__EventSection__33$", duration: 2800, illustId: "Tristan_normal", align: "Center");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State인페르녹의혼_흡수연출_J(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹의혼_흡수연출_J : TriggerState {
            internal State인페르녹의혼_흡수연출_J(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003821, msg: "$52010056_QD__EventSection__34$", duration: 2800);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State인페르녹의혼_흡수연출_K(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹의혼_흡수연출_K : TriggerState {
            internal State인페르녹의혼_흡수연출_K(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003812, msg: "$52010056_QD__EventSection__35$", duration: 2800, illustId: "Tristan_normal", align: "Center");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State인페르녹의혼_흡수연출_L(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹의혼_흡수연출_L : TriggerState {
            internal State인페르녹의혼_흡수연출_L(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003821, msg: "$52010056_QD__EventSection__36$", duration: 2800);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State인페르녹의혼_흡수연출_M(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹의혼_흡수연출_M : TriggerState {
            internal State인페르녹의혼_흡수연출_M(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003821, msg: "$52010056_QD__EventSection__37$", duration: 2800);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State인페르녹의혼_흡수연출_N(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹의혼_흡수연출_N : TriggerState {
            internal State인페르녹의혼_흡수연출_N(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4013}, arg2: false);
                context.AddCinematicTalk(npcId: 11003821, msg: "$52010056_QD__EventSection__38$", duration: 2800);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State각성_전투준비(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State각성_전투준비 : TriggerState {
            internal State각성_전투준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.SetMesh(arg1: new[] {9005}, arg2: false);
                context.SetMeshAnimation(arg1: new[] {9005}, arg2: false, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {9006}, arg2: true);
                context.SetMeshAnimation(arg1: new[] {9006}, arg2: true, arg3: 0, arg4: 0);
                context.DestroyMonster(arg1: new[] {102, 802, 803, 804, 805, 806, 807});
                context.SetEffect(arg1: new[] {5005, 5006, 5007, 5008, 5009, 5010, 5009, 5010, 5011, 5012, 5013}, arg2: false);
                context.VisibleMyPc(isVisible: true);
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
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
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcId: 11003812, msg: "$52010056_QD__EventSection__39$", duration: 2800);
            }

            public override TriggerState Execute() {
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
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {701, 702, 703, 704, 705, 706, 707, 708, 709, 710, 711, 712, 713, 714, 715, 716, 717, 718, 719, 720, 721, 722, 723, 724}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$52010056_QD__EventSection__40$", arg3: 3000, arg4: "0");
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {701, 702, 703, 704, 705, 706, 707, 708, 709, 710, 711, 712, 713, 714, 715, 716, 717, 718, 719, 720, 721, 722, 723, 724}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {701, 702, 703, 704, 705, 706, 707, 708, 709, 710, 711, 712, 713, 714, 715, 716, 717, 718, 719, 720, 721, 722, 723, 724}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {701, 702, 703, 704, 705, 706, 707, 708, 709, 710, 711, 712, 713, 714, 715, 716, 717, 718, 719, 720, 721, 722, 723, 724}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$52010056_QD__EventSection__41$", arg3: 3000, arg4: "0");
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {701, 702, 703, 704, 705, 706, 707, 708, 709, 710, 711, 712, 713, 714, 715, 716, 717, 718, 719, 720, 721, 722, 723, 724}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {701, 702, 703, 704, 705, 706, 707, 708, 709, 710, 711, 712, 713, 714, 715, 716, 717, 718, 719, 720, 721, 722, 723, 724}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {701, 702, 703, 704, 705, 706, 707, 708, 709, 710, 711, 712, 713, 714, 715, 716, 717, 718, 719, 720, 721, 722, 723, 724})) {
                    return new State필살기연출_암전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State필살기연출_암전 : TriggerState {
            internal State필살기연출_암전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(isVisible: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.SetOnetimeEffect(id: 5, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(arg1: 52010056, arg2: 6003);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State필살기연출_준비A(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State필살기연출_준비A : TriggerState {
            internal State필살기연출_준비A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {701, 702, 703, 704, 705, 706, 707, 708, 709, 710, 711, 712, 713, 714, 715, 716, 717, 718, 719, 720, 721, 722, 723, 724});
                context.CreateMonster(arg1: new[] {103, 808, 809, 810, 811, 812, 813, 814, 815, 816, 817, 818, 819, 820, 821, 822, 823, 824, 825, 826}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State필살기연출_준비B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State필살기연출_준비B : TriggerState {
            internal State필살기연출_준비B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 103, arg2: "Attack_Idle_A", arg3: 9999999f);
                context.SetNpcEmotionLoop(arg1: 808, arg2: "Attack_Idle_A", arg3: 9999999f);
                context.SetNpcEmotionLoop(arg1: 809, arg2: "Attack_Idle_A", arg3: 9999999f);
                context.SetNpcEmotionLoop(arg1: 810, arg2: "Attack_Idle_A", arg3: 9999999f);
                context.SetNpcEmotionLoop(arg1: 811, arg2: "Attack_Idle_A", arg3: 9999999f);
                context.SetNpcEmotionLoop(arg1: 812, arg2: "Attack_Idle_A", arg3: 9999999f);
                context.SetNpcEmotionLoop(arg1: 813, arg2: "Attack_Idle_A", arg3: 9999999f);
                context.SetNpcEmotionLoop(arg1: 814, arg2: "Attack_Idle_A", arg3: 9999999f);
                context.SetNpcEmotionLoop(arg1: 815, arg2: "Attack_Idle_A", arg3: 9999999f);
                context.SetNpcEmotionLoop(arg1: 816, arg2: "Attack_Idle_A", arg3: 9999999f);
                context.SetNpcEmotionLoop(arg1: 817, arg2: "Attack_Idle_A", arg3: 9999999f);
                context.SetNpcEmotionLoop(arg1: 818, arg2: "Attack_Idle_A", arg3: 9999999f);
                context.SetNpcEmotionLoop(arg1: 819, arg2: "Attack_Idle_A", arg3: 9999999f);
                context.SetNpcEmotionLoop(arg1: 820, arg2: "Attack_Idle_A", arg3: 9999999f);
                context.SetNpcEmotionLoop(arg1: 821, arg2: "Attack_Idle_A", arg3: 9999999f);
                context.SetNpcEmotionLoop(arg1: 822, arg2: "Attack_Idle_A", arg3: 9999999f);
                context.SetNpcEmotionLoop(arg1: 823, arg2: "Attack_Idle_A", arg3: 9999999f);
                context.SetNpcEmotionLoop(arg1: 824, arg2: "Attack_Idle_A", arg3: 9999999f);
                context.SetNpcEmotionLoop(arg1: 825, arg2: "Attack_Idle_A", arg3: 9999999f);
                context.SetNpcEmotionLoop(arg1: 826, arg2: "Attack_Idle_A", arg3: 9999999f);
            }

            public override TriggerState Execute() {
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
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 5, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(arg1: new[] {4014}, arg2: false);
                context.SetSceneSkip(arg1: "트리거업적", arg2: "nextState");
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {4015}, arg2: false);
                context.AddCinematicTalk(npcId: 11003817, msg: "$52010056_QD__EventSection__42$", duration: 2800);
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {4016}, arg2: false);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State크림슨발록_대사_G(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록_대사_G : TriggerState {
            internal State크림슨발록_대사_G(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 801, arg2: "Attack_01_B");
                context.AddCinematicTalk(npcId: 11003817, msg: "$52010056_QD__EventSection__43$", duration: 2800);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State트리스탄_대사_H(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리스탄_대사_H : TriggerState {
            internal State트리스탄_대사_H(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003812, msg: "$52010056_QD__EventSection__44$", duration: 2800, illustId: "Tristan_normal", align: "Center");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State크림슨발록_대사_I(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록_대사_I : TriggerState {
            internal State크림슨발록_대사_I(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003817, msg: "$52010056_QD__EventSection__45$", duration: 2800);
            }

            public override TriggerState Execute() {
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
                context.AddCinematicTalk(npcId: 11003812, msg: "$52010056_QD__EventSection__46$", duration: 2800, illustId: "Tristan_normal", align: "Center");
            }

            public override TriggerState Execute() {
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
                context.AddCinematicTalk(npcId: 11003812, msg: "$52010056_QD__EventSection__47$", duration: 2800, illustId: "Tristan_normal", align: "Center");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State필살기연출_모션A(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State필살기연출_모션A : TriggerState {
            internal State필살기연출_모션A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 103, arg2: "Attack_02_B", arg3: 9999999f);
                context.SetEffect(arg1: new[] {5014}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State필살기연출_모션B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State필살기연출_모션B : TriggerState {
            internal State필살기연출_모션B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 103, arg2: "Attack_01_B", arg3: 9999999f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State크림슨발록_대사_J(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록_대사_J : TriggerState {
            internal State크림슨발록_대사_J(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003817, msg: "$52010056_QD__EventSection__48$", duration: 1800);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1800)) {
                    return new State크림슨발록_대사_K(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록_대사_K : TriggerState {
            internal State크림슨발록_대사_K(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5101}, arg2: true);
                context.AddCinematicTalk(npcId: 11003817, msg: "$52010056_QD__EventSection__55$", duration: 1800);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionLoop(arg1: 808, arg2: "Damg_A", arg3: 9999999f);
                context.SetEffect(arg1: new[] {5102, 5202}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionLoop(arg1: 809, arg2: "Damg_A", arg3: 9999999f);
                context.SetEffect(arg1: new[] {5103, 5203}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionLoop(arg1: 810, arg2: "Damg_A", arg3: 9999999f);
                context.SetEffect(arg1: new[] {5104, 5204, 5302}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionLoop(arg1: 811, arg2: "Damg_A", arg3: 9999999f);
                context.SetEffect(arg1: new[] {5105, 5205}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionLoop(arg1: 812, arg2: "Damg_A", arg3: 9999999f);
                context.SetEffect(arg1: new[] {5106, 5206}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionLoop(arg1: 813, arg2: "Damg_A", arg3: 9999999f);
                context.SetEffect(arg1: new[] {5107, 5207}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionLoop(arg1: 814, arg2: "Damg_A", arg3: 9999999f);
                context.SetEffect(arg1: new[] {5108, 5208}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionLoop(arg1: 815, arg2: "Damg_A", arg3: 9999999f);
                context.SetEffect(arg1: new[] {5109, 5209, 5303}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionLoop(arg1: 816, arg2: "Damg_A", arg3: 9999999f);
                context.SetEffect(arg1: new[] {5110, 5210}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionLoop(arg1: 817, arg2: "Damg_A", arg3: 9999999f);
                context.SetEffect(arg1: new[] {5111, 5211}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionLoop(arg1: 818, arg2: "Damg_A", arg3: 9999999f);
                context.SetEffect(arg1: new[] {5112, 5212}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionLoop(arg1: 819, arg2: "Damg_A", arg3: 9999999f);
                context.SetEffect(arg1: new[] {5113, 5213}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionLoop(arg1: 820, arg2: "Damg_A", arg3: 9999999f);
                context.SetEffect(arg1: new[] {5114, 5214, 5304}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionLoop(arg1: 821, arg2: "Damg_A", arg3: 9999999f);
                context.SetEffect(arg1: new[] {5115, 5215}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionLoop(arg1: 822, arg2: "Damg_A", arg3: 9999999f);
                context.SetEffect(arg1: new[] {5116, 5216}, arg2: true);
                context.SetOnetimeEffect(id: 6, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOut.xml");
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionLoop(arg1: 823, arg2: "Damg_A", arg3: 9999999f);
                context.SetEffect(arg1: new[] {5117, 5217}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionLoop(arg1: 824, arg2: "Damg_A", arg3: 9999999f);
                context.SetEffect(arg1: new[] {5118, 5218}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionLoop(arg1: 825, arg2: "Damg_A", arg3: 9999999f);
                context.SetEffect(arg1: new[] {5202, 5301}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State크림슨발록_대사_L(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록_대사_L : TriggerState {
            internal State크림슨발록_대사_L(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003817, msg: "$52010056_QD__EventSection__50$", duration: 2800, illustId: "balrog_normal", align: "Center");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State마지막연출_세팅(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {103});
                context.CreateMonster(arg1: new[] {104}, arg2: true);
            }
        }

        private class State마지막연출_세팅 : TriggerState {
            internal State마지막연출_세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5101, 5102, 5103, 5104, 5105, 5106, 5107, 5108, 5109, 5110, 5111, 5112, 5113, 5114, 5115, 5116, 5117, 5118, 5201, 5202, 5203, 5204, 5205, 5206, 5207, 5208, 5209, 5210, 5211, 5212, 5213, 5214, 5215, 5216, 5218, 5218, 5301, 5302, 5303, 5304}, arg2: false);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetNpcEmotionLoop(arg1: 104, arg2: "Attack_Idle_A", arg3: 9999999f);
                context.SetNpcEmotionLoop(arg1: 801, arg2: "Dead_01_A", arg3: 9999999f);
                context.SetNpcEmotionLoop(arg1: 808, arg2: "Dead_A", arg3: 9999999f);
                context.SetNpcEmotionLoop(arg1: 809, arg2: "Dead_A", arg3: 9999999f);
                context.SetNpcEmotionLoop(arg1: 810, arg2: "Dead_A", arg3: 9999999f);
                context.SetNpcEmotionLoop(arg1: 811, arg2: "Dead_A", arg3: 9999999f);
                context.SetNpcEmotionLoop(arg1: 812, arg2: "Dead_A", arg3: 9999999f);
                context.SetNpcEmotionLoop(arg1: 813, arg2: "Dead_A", arg3: 9999999f);
                context.SetNpcEmotionLoop(arg1: 814, arg2: "Dead_A", arg3: 9999999f);
                context.SetNpcEmotionLoop(arg1: 815, arg2: "Dead_A", arg3: 9999999f);
                context.SetNpcEmotionLoop(arg1: 816, arg2: "Dead_A", arg3: 9999999f);
                context.SetNpcEmotionLoop(arg1: 817, arg2: "Dead_A", arg3: 9999999f);
                context.SetNpcEmotionLoop(arg1: 818, arg2: "Dead_A", arg3: 9999999f);
                context.SetNpcEmotionLoop(arg1: 819, arg2: "Dead_A", arg3: 9999999f);
                context.SetNpcEmotionLoop(arg1: 820, arg2: "Dead_A", arg3: 9999999f);
                context.SetNpcEmotionLoop(arg1: 821, arg2: "Dead_A", arg3: 9999999f);
                context.SetNpcEmotionLoop(arg1: 822, arg2: "Dead_A", arg3: 9999999f);
                context.SetNpcEmotionLoop(arg1: 823, arg2: "Dead_A", arg3: 9999999f);
                context.SetNpcEmotionLoop(arg1: 824, arg2: "Dead_A", arg3: 9999999f);
                context.SetNpcEmotionLoop(arg1: 825, arg2: "Dead_A", arg3: 9999999f);
                context.SetNpcEmotionLoop(arg1: 826, arg2: "Dead_A", arg3: 9999999f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State마지막연출_온(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마지막연출_온 : TriggerState {
            internal State마지막연출_온(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 6, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOut.xml");
            }

            public override TriggerState Execute() {
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
                context.AddCinematicTalk(npcId: 11003812, msg: "$52010056_QD__EventSection__51$", duration: 2800, illustId: "Tristan_normal", align: "Center");
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTrigger업적(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger업적 : TriggerState {
            internal StateTrigger업적(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 2009, arg2: "trigger", arg3: "tristanarousal");
            }

            public override TriggerState Execute() {
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
                context.MoveUser(arg1: 52010052, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {91000054}, arg3: new byte[] {2})) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}