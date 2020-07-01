namespace Maple2.Trigger._52000113_qd {
    public static class _52000113 {
        public class StateSTART : TriggerState {
            internal StateSTART(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {10011})) {
                    return new State대기01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대기01 : TriggerState {
            internal State대기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Quit02", arg2: "exit");
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SpawnNpcRange(rangeId: new[] {202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221}, isAutoTargeting: false);
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.MoveNpc(arg1: 203, arg2: "MS2PatrolData_203");
                context.MoveNpc(arg1: 204, arg2: "MS2PatrolData_204");
                context.MoveNpc(arg1: 215, arg2: "MS2PatrolData_215");
                context.MoveNpc(arg1: 216, arg2: "MS2PatrolData_216");
                context.MoveNpc(arg1: 217, arg2: "MS2PatrolData_217");
                context.MoveNpc(arg1: 219, arg2: "MS2PatrolData_219");
                context.MoveNpc(arg1: 220, arg2: "MS2PatrolData_220");
                context.MoveNpc(arg1: 221, arg2: "MS2PatrolData_221");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new Statecamera01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statecamera01 : TriggerState {
            internal Statecamera01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new[] {1000, 1001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new Statecamera02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statecamera02 : TriggerState {
            internal Statecamera02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {1002, 1003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new Statecamera03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statecamera03 : TriggerState {
            internal Statecamera03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {1004, 1005}, arg2: false);
                context.MoveNpc(arg1: 208, arg2: "MS2PatrolData_Rogues_come");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new Statecamera04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statecamera04 : TriggerState {
            internal Statecamera04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {1006, 1007}, arg2: false);
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcId: 11003338, illustId: "0", msg: "$52000113_QD__52000113__0$", duration: 4000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new Statecamera05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statecamera05 : TriggerState {
            internal Statecamera05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {1008, 1009}, arg2: false);
                context.AddCinematicTalk(npcId: 11003185, illustId: "0", msg: "$52000113_QD__52000113__1$", duration: 4000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new Statecamera06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statecamera06 : TriggerState {
            internal Statecamera06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {1010}, arg2: false);
                context.AddCinematicTalk(npcId: 11003185, illustId: "0", msg: "$52000113_QD__52000113__2$", duration: 4000, align: "right");
                context.MoveNpc(arg1: 208, arg2: "MS2PatrolData_Rogues_out");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new Statecamera07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statecamera07 : TriggerState {
            internal Statecamera07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {1011, 1012}, arg2: false);
                context.AddCinematicTalk(npcId: 11003185, illustId: "0", msg: "$52000113_QD__52000113__3$", duration: 5000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new Statecamera08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statecamera08 : TriggerState {
            internal Statecamera08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003185, illustId: "0", msg: "$52000113_QD__52000113__4$", duration: 5000, align: "right");
            }

            public override TriggerState Execute() {
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
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
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
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.MoveUser(arg1: 02000062, arg2: 13);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}