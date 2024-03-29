using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000200_qd {
    public static class _52000200 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{2001})) {
                    return new StateCameraEffect01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect01 : TriggerState {
            internal StateCameraEffect01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCameraEffect02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect02 : TriggerState {
            internal StateCameraEffect02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetQuestAccept(questId: 10003419);
                context.CameraSelectPath(pathIds: new []{4001}, returnView: false);
                context.VisibleMyPc(visible: false);
                context.SetCinematicUI(type: 1);
                context.CreateMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{102});
                context.CreateMonster(spawnIds: new []{103});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraEffect02_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect02_02 : TriggerState {
            internal StateCameraEffect02_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52000200_QD__52000200__0$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCameraEffect03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03 : TriggerState {
            internal StateCameraEffect03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 1);
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraEffect03_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03_3 : TriggerState {
            internal StateCameraEffect03_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4002, 4003}, returnView: false);
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_3001");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State여제알현(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State여제알현 : TriggerState {
            internal State여제알현(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 11004785, script: "$52000200_QD__52000200__1$", illustId: "Ereb_normal", align: Align.Left, duration: 4000);
                context.AddCinematicTalk(npcId: 11004778, script: "$52000200_QD__52000200__2$", align: Align.Right, illustId: "Karl_normal", duration: 4000);
                context.AddCinematicTalk(npcId: 11004785, script: "$52000200_QD__52000200__3$", illustId: "Ereb_normal", align: Align.Left, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new State여제알현_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State여제알현_02 : TriggerState {
            internal State여제알현_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4004, 4005}, returnView: false);
                context.AddCinematicTalk(npcId: 11004778, script: "$52000200_QD__52000200__4$", align: Align.Right, illustId: "Karl_normal", duration: 4000);
                context.AddCinematicTalk(npcId: 11004785, script: "$52000200_QD__52000200__5$", illustId: "Ereb_normal", align: Align.Left, duration: 4500);
                context.AddCinematicTalk(npcId: 11004785, script: "$52000200_QD__52000200__6$", illustId: "Ereb_normal", align: Align.Left, duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 11500)) {
                    return new State여제알현_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State여제알현_03 : TriggerState {
            internal State여제알현_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004778, script: "$52000200_QD__52000200__7$", align: Align.Right, illustId: "Karl_normal", duration: 4000);
                context.AddCinematicTalk(npcId: 11004778, script: "$52000200_QD__52000200__8$", align: Align.Right, illustId: "Karl_normal", duration: 4000);
                context.AddCinematicTalk(npcId: 11004785, script: "$52000200_QD__52000200__9$", illustId: "Ereb_surprise", align: Align.Left, duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    return new State여제알현_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State여제알현_04 : TriggerState {
            internal State여제알현_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4006}, returnView: false);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_3002");
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_3003");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State여제알현_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State여제알현_05 : TriggerState {
            internal State여제알현_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004782, script: "$52000200_QD__52000200__10$", align: Align.Left, illustId: "Ruana_normal", duration: 4000);
                context.AddCinematicTalk(npcId: 11004785, script: "$52000200_QD__52000200__11$", align: Align.Left, illustId: "Ereb_surprise", duration: 4000);
                context.AddCinematicTalk(npcId: 11004778, script: "$52000200_QD__52000200__12$", align: Align.Right, illustId: "Karl_normal", duration: 4500);
                context.AddCinematicTalk(npcId: 11004778, script: "$52000200_QD__52000200__13$", align: Align.Right, illustId: "Karl_normal", duration: 4500);
                context.AddCinematicTalk(npcId: 11004785, script: "$52000200_QD__52000200__14$", align: Align.Left, illustId: "Ereb_surprise", duration: 3000);
                context.AddCinematicTalk(npcId: 11004778, script: "$52000200_QD__52000200__15$", align: Align.Right, illustId: "Karl_normal", duration: 4500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 25000)) {
                    return new State여제알현_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State여제알현_06 : TriggerState {
            internal State여제알현_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4007, 4008}, returnView: false);
                context.AddCinematicTalk(npcId: 11004785, script: "$52000200_QD__52000200__16$", align: Align.Left, illustId: "Ereb_surprise", duration: 4500);
                context.AddCinematicTalk(npcId: 11004778, script: "$52000200_QD__52000200__17$", align: Align.Right, illustId: "Karl_normal", duration: 2800);
                context.AddCinematicTalk(npcId: 11004778, script: "$52000200_QD__52000200__18$", align: Align.Right, illustId: "Karl_normal", duration: 4500);
                context.AddCinematicTalk(npcId: 11004785, script: "$52000200_QD__52000200__19$", align: Align.Left, illustId: "Ereb_surprise", duration: 4000);
                context.AddCinematicTalk(npcId: 11004785, script: "$52000200_QD__52000200__20$", align: Align.Left, illustId: "Ereb_closeEye", duration: 4000);
                context.AddCinematicTalk(npcId: 11004785, script: "$52000200_QD__52000200__21$", align: Align.Left, illustId: "Ereb_closeEye", duration: 4000);
                context.AddCinematicTalk(npcId: 11004778, script: "$52000200_QD__52000200__22$", align: Align.Right, illustId: "Karl_normal", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 27800)) {
                    return new State음모(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State음모 : TriggerState {
            internal State음모(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4009}, returnView: false);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State음모_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State음모_02 : TriggerState {
            internal State음모_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52000200_QD__52000200__23$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State음모_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State음모_03 : TriggerState {
            internal State음모_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 11001975, script: "$52000200_QD__52000200__24$", align: Align.Left, duration: 4500);
                context.AddCinematicTalk(npcId: 11004778, script: "$52000200_QD__52000200__25$", align: Align.Right, illustId: "Karl_normal", duration: 2800);
                context.AddCinematicTalk(npcId: 11004778, script: "$52000200_QD__52000200__26$", align: Align.Right, illustId: "Karl_normal", duration: 4000);
                context.AddCinematicTalk(npcId: 11004778, script: "$52000200_QD__52000200__27$", align: Align.Right, illustId: "Karl_normal", duration: 3000);
                context.AddCinematicTalk(npcId: 11000264, script: "$52000200_QD__52000200__28$", align: Align.Left, illustId: "Radin_normal", duration: 4500);
                context.AddCinematicTalk(npcId: 11000264, script: "$52000200_QD__52000200__29$", align: Align.Left, illustId: "Radin_normal", duration: 4000);
                context.AddCinematicTalk(npcId: 11004778, script: "$52000200_QD__52000200__30$", align: Align.Right, illustId: "Karl_normal", duration: 4000);
                context.AddCinematicTalk(npcId: 11000264, script: "$52000200_QD__52000200__31$", align: Align.Left, illustId: "Radin_normal", duration: 4000);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 29000)) {
                    return new State이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동 : TriggerState {
            internal State이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(visible: true);
                context.MoveUser(mapId: 52000190, portalId: 5001);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
