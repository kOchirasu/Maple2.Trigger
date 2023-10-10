using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000097_qd {
    public static class _main {
        public class StateMain : TriggerState {
            internal StateMain(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000097, portalId: 1);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CreateMonster(spawnIds: new []{101, 102, 201}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{701})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(pathIds: new []{8001, 8002}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateScene_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_01 : TriggerState {
            internal StateScene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_02 : TriggerState {
            internal StateScene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8003, 8004}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11003084, script: "$52000097_QD__MAIN__0$", arg4: 5);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateScene_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_03 : TriggerState {
            internal StateScene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8006}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11003085, script: "$52000097_QD__MAIN__1$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateScene_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_04 : TriggerState {
            internal StateScene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11003086, script: "$52000097_QD__MAIN__2$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_05 : TriggerState {
            internal StateScene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11003086, script: "$52000097_QD__MAIN__3$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_06 : TriggerState {
            internal StateScene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8007}, returnView: false);
                context.SetPcEmotionSequence(sequenceNames: new []{"Talk_A"});
                context.SetConversation(type: 1, spawnId: 0, script: "$52000097_QD__MAIN__4$", arg4: 3, arg5: 0);
                context.SetConversation(type: 1, spawnId: 0, script: "$52000097_QD__MAIN__5$", arg4: 3, arg5: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateScene_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_07 : TriggerState {
            internal StateScene_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8008}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11003086, script: "$52000097_QD__MAIN__6$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateScene_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_08 : TriggerState {
            internal StateScene_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11003086, script: "$52000097_QD__MAIN__7$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateScene_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_09 : TriggerState {
            internal StateScene_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$52000097_QD__MAIN__8$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_10 : TriggerState {
            internal StateScene_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11003086, script: "$52000097_QD__MAIN__9$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateScene_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_11 : TriggerState {
            internal StateScene_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 201, sequenceName: "Attack_01_E");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene_12_ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_12_ready : TriggerState {
            internal StateScene_12_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8009}, returnView: false);
                context.SetPcEmotionSequence(sequenceNames: new []{"Emotion_Failure_Idle_A"});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_12 : TriggerState {
            internal StateScene_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(type: WidgetType.SceneMovie);
                context.WidgetAction(type: WidgetType.SceneMovie, name: "Clear");
                context.PlaySceneMovie(fileName: "ProphecyofFall.swf", movieId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, condition: "IsStop", value: "1")) {
                    return new StateScene_13(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }
        }

        private class StateScene_13 : TriggerState {
            internal StateScene_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2002");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_2001");
                context.SetConversation(type: 1, spawnId: 102, script: "$52000097_QD__MAIN__10$", arg4: 2, arg5: 1);
                context.SetConversation(type: 1, spawnId: 101, script: "$52000097_QD__MAIN__11$", arg4: 2, arg5: 0);
                context.CameraSelectPath(pathIds: new []{8008}, returnView: false);
                context.SetPcEmotionSequence(sequenceNames: new []{"Emotion_Failure_Idle_A"});
                context.SetConversation(type: 2, spawnId: 11003086, script: "$52000097_QD__MAIN__12$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateScene_14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_14 : TriggerState {
            internal StateScene_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8010}, returnView: false);
                context.SetConversation(type: 1, spawnId: 0, script: "$52000097_QD__MAIN__13$", arg4: 3, arg5: 1);
                context.MoveUserPath(patrolName: "MS2PatrolData_2003");
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_2004");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_15 : TriggerState {
            internal StateScene_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(sequenceNames: new []{"Talk_A"});
                context.SetConversation(type: 1, spawnId: 0, script: "$52000097_QD__MAIN__14$", arg4: 4, arg5: 0);
                context.SetConversation(type: 1, spawnId: 0, script: "$52000097_QD__MAIN__15$", arg4: 4, arg5: 4);
                context.SetConversation(type: 1, spawnId: 0, script: "$52000097_QD__MAIN__16$", arg4: 4, arg5: 8);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new StateScene_16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_16 : TriggerState {
            internal StateScene_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11003086, script: "$52000097_QD__MAIN__17$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene_17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_17 : TriggerState {
            internal StateScene_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11003086, script: "$52000097_QD__MAIN__18$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene_18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_18 : TriggerState {
            internal StateScene_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11003086, script: "$52000097_QD__MAIN__19$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene_19(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_19 : TriggerState {
            internal StateScene_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_2005");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene_20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_20 : TriggerState {
            internal StateScene_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8011}, returnView: false);
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_2006");
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2007");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_21(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_21 : TriggerState {
            internal StateScene_21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{201});
                context.SetConversation(type: 2, spawnId: 11003085, script: "$52000097_QD__MAIN__20$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateScene_22(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_22 : TriggerState {
            internal StateScene_22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11003084, script: "$52000097_QD__MAIN__21$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateScene_23(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_23 : TriggerState {
            internal StateScene_23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2008");
                context.MoveUserPath(patrolName: "MS2PatrolData_2009");
                context.SetConversation(type: 2, spawnId: 11003084, script: "$52000097_QD__MAIN__22$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateScene_24(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_24 : TriggerState {
            internal StateScene_24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11003085, script: "$52000097_QD__MAIN__23$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateScene_25(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_25 : TriggerState {
            internal StateScene_25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$52000097_QD__MAIN__24$", arg4: 4, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateScene_26(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_26 : TriggerState {
            internal StateScene_26(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
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

            public override void OnEnter() {
                context.MoveUser(mapId: 02000068, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
