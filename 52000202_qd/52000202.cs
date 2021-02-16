using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000202_qd {
    public static class _52000202 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {10003431}, arg3: new byte[] {1})) {
                    return new StateCameraEffect01(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {10003431}, arg3: new byte[] {1})) {
                    return new State고마해_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect01 : TriggerState {
            internal StateCameraEffect01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraEffect02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect02 : TriggerState {
            internal StateCameraEffect02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4001}, arg2: false);
                context.SetCinematicUI(type: 1);
                context.MoveUser(arg1: 52000202, arg2: 5001);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraEffect03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03 : TriggerState {
            internal StateCameraEffect03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(pathIds: new[] {4002}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_3001");
                context.ShowCaption(type: CaptionType.Vertical, title: "$52000202_QD__52000202__0$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 5000, scale: 2.5f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State시공의균열(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시공의균열 : TriggerState {
            internal State시공의균열(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4003, 4004}, arg2: false);
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 0, script: "$52000202_QD__52000202__1$", duration: 4000);
                context.AddCinematicTalk(npcId: 0, script: "$52000202_QD__52000202__2$", duration: 5000);
                context.AddCinematicTalk(npcId: 0, script: "$52000202_QD__52000202__3$", duration: 4500);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 14000)) {
                    return new State시공의균열_02_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시공의균열_02_01 : TriggerState {
            internal State시공의균열_02_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 101, enable: true, path: @"BG/Common/Eff_Com_Vibrate_long.xml");
                context.SetPcEmotionLoop(arg1: "Attack_Idle_A", arg2: 11000f);
                context.AddCinematicTalk(npcId: 0, script: "$52000202_QD__52000202__4$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State시공의균열_02_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시공의균열_02_02 : TriggerState {
            internal State시공의균열_02_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.AddCinematicTalk(npcId: 0, script: "$52000202_QD__52000202__5$", duration: 4000);
                context.AddCinematicTalk(npcId: 0, script: "$52000202_QD__52000202__6$", duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State시공의균열_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시공의균열_03 : TriggerState {
            internal State시공의균열_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 101, enable: false, path: @"BG/Common/Eff_Com_Vibrate_long.xml");
                context.CameraSelectPath(pathIds: new[] {4005}, arg2: false);
                context.CreateMonster(arg1: new[] {201});
                context.CreateMonster(arg1: new[] {202});
                context.SetPortal(portalId: 8001, visible: false, enabled: false);
                context.SetPortal(portalId: 8002, visible: false, enabled: false);
                context.MoveUser(arg1: 52000202, arg2: 5002);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State시공의균열_03_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시공의균열_03_02 : TriggerState {
            internal State시공의균열_03_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4006}, arg2: false);
                context.CreateMonster(arg1: new[] {203});
                context.CreateMonster(arg1: new[] {204});
                context.SetPortal(portalId: 8003, visible: false, enabled: false);
                context.SetPortal(portalId: 8004, visible: false, enabled: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State시공의균열_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시공의균열_04 : TriggerState {
            internal State시공의균열_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4007, 4008}, arg2: false);
                context.AddCinematicTalk(npcId: 0, script: "$52000202_QD__52000202__7$", duration: 4000);
                context.AddCinematicTalk(npcId: 0, script: "$52000202_QD__52000202__8$", duration: 4500);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new State전투Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투Prepare : TriggerState {
            internal State전투Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Attack_Idle_A", arg2: 4500f);
                context.CameraSelectPath(pathIds: new[] {4009}, arg2: false);
                context.AddCinematicTalk(npcId: 0, script: "$52000202_QD__52000202__9$", duration: 4500);
                context.DestroyMonster(arg1: new[] {201, 202, 203, 204});
                context.CreateMonster(arg1: new[] {205});
                context.CreateMonster(arg1: new[] {206});
                context.CreateMonster(arg1: new[] {207});
                context.CreateMonster(arg1: new[] {208});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new StateUI테스트(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateUI테스트 : TriggerState {
            internal StateUI테스트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State몰려온다(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몰려온다 : TriggerState {
            internal State몰려온다(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4010}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_3006");
                context.MoveNpc(arg1: 205, arg2: "MS2PatrolData_3002");
                context.MoveNpc(arg1: 206, arg2: "MS2PatrolData_3003");
                context.MoveNpc(arg1: 207, arg2: "MS2PatrolData_3004");
                context.MoveNpc(arg1: 208, arg2: "MS2PatrolData_3005");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State몰려온다_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몰려온다_02 : TriggerState {
            internal State몰려온다_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimeScale(enable: true, startScale: 0.1f, endScale: 0.5f, duration: 5.0f, interpolator: 1);
                context.SetOnetimeEffect(id: 30, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOutFast.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State몰려온다_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몰려온다_03 : TriggerState {
            internal State몰려온다_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {205, 206, 207, 208});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State고마해(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State고마해 : TriggerState {
            internal State고마해(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 30, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOutFast.xml");
                context.SetCinematicUI(type: 1);
                context.CameraSelectPath(pathIds: new[] {4011}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State고마해_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State고마해_02 : TriggerState {
            internal State고마해_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 0, script: "$52000202_QD__52000202__10$", duration: 2500);
                context.AddCinematicTalk(npcId: 0, script: "$52000202_QD__52000202__11$", duration: 4000);
                context.AddCinematicTalk(npcId: 0, script: "$52000202_QD__52000202__12$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9500)) {
                    return new State고마해_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State고마해_03 : TriggerState {
            internal State고마해_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Attack_Idle_A", arg2: 9000f);
                context.SetOnetimeEffect(id: 102, enable: true, path: @"BG/Common/Eff_Com_Vibrate_long.xml");
                context.AddCinematicTalk(npcId: 0, script: "$52000202_QD__52000202__13$", duration: 4500);
                context.AddCinematicTalk(npcId: 0, script: "$52000202_QD__52000202__14$", duration: 4000);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8500)) {
                    return new State고마해_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State고마해_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State고마해_04 : TriggerState {
            internal State고마해_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetAchievement(arg1: 2001, arg3: "illusionaryAttack");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State이동시키기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동시키기 : TriggerState {
            internal State이동시키기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000201, arg2: 5001);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}