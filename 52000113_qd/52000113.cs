using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000113_qd {
    public static class _52000113 {
        public class StateSTART : TriggerState {
            internal StateSTART(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{10011})) {
                    return new StateWait01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait01 : TriggerState {
            internal StateWait01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateQuit02(context), arg2: "exit");
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SpawnNpcRange(spawnIds: new []{202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221}, isAutoTargeting: false);
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.SetCinematicUI(type: 1);
                context.MoveNpc(spawnId: 203, patrolName: "MS2PatrolData_203");
                context.MoveNpc(spawnId: 204, patrolName: "MS2PatrolData_204");
                context.MoveNpc(spawnId: 215, patrolName: "MS2PatrolData_215");
                context.MoveNpc(spawnId: 216, patrolName: "MS2PatrolData_216");
                context.MoveNpc(spawnId: 217, patrolName: "MS2PatrolData_217");
                context.MoveNpc(spawnId: 219, patrolName: "MS2PatrolData_219");
                context.MoveNpc(spawnId: 220, patrolName: "MS2PatrolData_220");
                context.MoveNpc(spawnId: 221, patrolName: "MS2PatrolData_221");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCamera01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera01 : TriggerState {
            internal StateCamera01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{1000, 1001}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCamera02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera02 : TriggerState {
            internal StateCamera02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1002, 1003}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCamera03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera03 : TriggerState {
            internal StateCamera03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1004, 1005}, returnView: false);
                context.MoveNpc(spawnId: 208, patrolName: "MS2PatrolData_Rogues_come");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCamera04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera04 : TriggerState {
            internal StateCamera04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1006, 1007}, returnView: false);
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 11003338, illustId: "0", script: "$52000113_QD__52000113__0$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCamera05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera05 : TriggerState {
            internal StateCamera05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1008, 1009}, returnView: false);
                context.AddCinematicTalk(npcId: 11003185, illustId: "0", script: "$52000113_QD__52000113__1$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCamera06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera06 : TriggerState {
            internal StateCamera06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1010}, returnView: false);
                context.AddCinematicTalk(npcId: 11003185, illustId: "0", script: "$52000113_QD__52000113__2$", duration: 4000, align: Align.Right);
                context.MoveNpc(spawnId: 208, patrolName: "MS2PatrolData_Rogues_out");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCamera07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera07 : TriggerState {
            internal StateCamera07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1011, 1012}, returnView: false);
                context.AddCinematicTalk(npcId: 11003185, illustId: "0", script: "$52000113_QD__52000113__3$", duration: 5000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCamera08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera08 : TriggerState {
            internal StateCamera08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003185, illustId: "0", script: "$52000113_QD__52000113__4$", duration: 5000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateQuit01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit01 : TriggerState {
            internal StateQuit01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateQuit01_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit01_1 : TriggerState {
            internal StateQuit01_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit02 : TriggerState {
            internal StateQuit02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.MoveUser(mapId: 02000062, portalId: 13);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
