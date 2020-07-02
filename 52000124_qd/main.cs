namespace Maple2.Trigger._52000124_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60100105, 60100106, 60100107, 60100108, 60100109, 60100110}, arg3: new byte[] {2})) {
                    return new StateReady(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60100110}, arg3: new byte[] {3})) {
                    return new StateDelnpc(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetCinematicUI(arg1: 4);
                context.DestroyMonster(arg1: new[] {201});
                context.CreateMonster(arg1: new[] {202}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCamera(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera : TriggerState {
            internal StateCamera(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 4001, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateScene_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_01 : TriggerState {
            internal StateScene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4001, 4002}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 202, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003195, msg: "$52000124_QD__MAIN__0$", duration: 2000, align: "right");
                context.SetSceneSkip(arg1: "scene_07", arg2: "exit");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_02 : TriggerState {
            internal StateScene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 202, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003195, msg: "$52000124_QD__MAIN__1$", duration: 2000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_03 : TriggerState {
            internal StateScene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4003}, arg2: false);
                context.AddCinematicTalk(npcId: 11000069, msg: "$52000124_QD__MAIN__2$", duration: 2000, align: "left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_04 : TriggerState {
            internal StateScene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4004}, arg2: false);
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_3001");
                context.AddCinematicTalk(npcId: 11003195, msg: "$52000124_QD__MAIN__3$", duration: 3000, align: "left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_05 : TriggerState {
            internal StateScene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4005}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Sit_down_A", arg3: 999999999999f);
                context.AddCinematicTalk(npcId: 11000069, msg: "$52000124_QD__MAIN__4$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {4003}, arg2: false);
                context.AddCinematicTalk(npcId: 11003195, msg: "$52000124_QD__MAIN__5$", duration: 3000, align: "left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_07 : TriggerState {
            internal StateScene_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201}, arg2: true);
                context.DestroyMonster(arg1: new[] {202});
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 1.0f);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60100110}, arg3: new byte[] {2})) {
                    return new StateWarptalk(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWarptalk : TriggerState {
            internal StateWarptalk(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 201, msg: "$52000124_QD__MAIN__6$", duration: 2000, delayTick: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateWarp(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWarp : TriggerState {
            internal StateWarp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000073, arg2: 4);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelnpc : TriggerState {
            internal StateDelnpc(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {201, 202});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}