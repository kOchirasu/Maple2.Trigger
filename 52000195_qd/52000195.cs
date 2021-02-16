using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000195_qd {
    public static class _52000195 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {10003407}, arg3: new byte[] {1})) {
                    return new StateCameraEffect01(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {10003407}, arg3: new byte[] {1})) {
                    return new State이동(context);
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
                context.CreateMonster(arg1: new[] {204});
                context.VisibleMyPc(isVisible: false);
                context.SetCinematicUI(type: 1);
                context.MoveUser(arg1: 52000195, arg2: 5001);
                context.CameraSelectPath(pathIds: new[] {4003}, arg2: false);
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
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 1);
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
                context.CameraSelectPath(pathIds: new[] {4004}, arg2: false);
                context.ShowCaption(type: CaptionType.Vertical, title: "$52000195_QD__52000195__0$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 5000, scale: 2.5f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCameraEffect03_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03_4 : TriggerState {
            internal StateCameraEffect03_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraEffect03_5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03_5 : TriggerState {
            internal StateCameraEffect03_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.DestroyMonster(arg1: new[] {204});
                context.VisibleMyPc(isVisible: true);
                context.SetVisibleUI(uiName: "MessengerBrowser,GroupMessengerBrowser,HighlightGameMenu", visible: false);
                context.AddBuff(arg1: new[] {2001}, arg2: 99910402, arg3: 1, arg4: false, arg5: true);
                context.AddBuff(arg1: new[] {2001}, arg2: 99910402, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraEffect03_6(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03_6 : TriggerState {
            internal StateCameraEffect03_6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraEffect03_7(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03_7 : TriggerState {
            internal StateCameraEffect03_7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 11001302, script: "$52000195_QD__52000195__1$", align: Align.Left, illustId: "Ereb_surprise", duration: 3000);
                context.AddCinematicTalk(npcId: 11001302, script: "$52000195_QD__52000195__2$", align: Align.Left, illustId: "Ereb_serious", duration: 3000);
                context.AddCinematicTalk(npcId: 11001302, script: "$52000195_QD__52000195__3$", align: Align.Left, illustId: "Ereb_serious", duration: 3000);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new StateCameraEffect03_8(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 0.0f);
                context.DestroyMonster(arg1: new[] {204});
                context.VisibleMyPc(isVisible: true);
                context.SetVisibleUI(uiName: "MessengerBrowser,GroupMessengerBrowser,HighlightGameMenu", visible: false);
                context.AddBuff(arg1: new[] {2001}, arg2: 99910402, arg3: 1, arg4: false, arg5: true);
                context.AddBuff(arg1: new[] {2001}, arg2: 99910402, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraEffect03_8(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03_8 : TriggerState {
            internal StateCameraEffect03_8(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {2002})) {
                    return new State과거장면_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State과거장면_01 : TriggerState {
            internal State과거장면_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State과거장면_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State과거장면_02 : TriggerState {
            internal State과거장면_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4005}, arg2: false);
                context.CreateMonster(arg1: new[] {201});
                context.CreateMonster(arg1: new[] {202});
                context.CreateMonster(arg1: new[] {203});
                context.RemoveBuff(arg1: 2002, arg2: 99910402);
                context.VisibleMyPc(isVisible: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State과거장면_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State과거장면_03 : TriggerState {
            internal State과거장면_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip(state: new StateSkip_2(context), arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State과거장면_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State과거장면_05 : TriggerState {
            internal State과거장면_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4006}, arg2: false);
                context.SetCinematicUI(type: 3);
                context.SetNpcEmotionLoop(arg1: 202, arg2: "Talk_A", arg3: 4000f);
                context.AddCinematicTalk(npcId: 11004787, script: "$52000195_QD__52000195__4$", duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State과거장면_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State과거장면_06 : TriggerState {
            internal State과거장면_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4007}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 201, arg2: "Talk_A", arg3: 8000f);
                context.AddCinematicTalk(npcId: 11004778, script: "$52000195_QD__52000195__5$", align: Align.Right, illustId: "Karl_normal", duration: 4000);
                context.AddCinematicTalk(npcId: 11004778, script: "$52000195_QD__52000195__6$", align: Align.Right, illustId: "Karl_normal", duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State과거장면_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State과거장면_07 : TriggerState {
            internal State과거장면_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4008}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 202, arg2: "Talk_A", arg3: 4000f);
                context.AddCinematicTalk(npcId: 11004787, script: "$52000195_QD__52000195__7$", align: Align.Right, illustId: "Baron_normal", duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State과거장면_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State과거장면_08 : TriggerState {
            internal State과거장면_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4006}, arg2: false);
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_3001");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State과거장면_08_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State과거장면_08_1 : TriggerState {
            internal State과거장면_08_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 201, arg2: "Talk_A", arg3: 4000f);
                context.AddCinematicTalk(npcId: 11004778, script: "$52000195_QD__52000195__8$", align: Align.Right, illustId: "Karl_normal", duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State과거장면_08_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State과거장면_08_2 : TriggerState {
            internal State과거장면_08_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {202});
                context.CameraSelectPath(pathIds: new[] {4009}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State과거장면_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State과거장면_09 : TriggerState {
            internal State과거장면_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 203, arg2: "Bore_B");
                context.AddCinematicTalk(npcId: 11004785, script: "$52000195_QD__52000195__9$", duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State과거장면_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State과거장면_10 : TriggerState {
            internal State과거장면_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcId: 11004785, script: "$52000195_QD__52000195__10$", illustId: "Ereb_surprise", duration: 4000);
                context.AddCinematicTalk(npcId: 11004785, script: "$52000195_QD__52000195__11$", illustId: "Ereb_surprise", duration: 4000);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateAchievement(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_2 : TriggerState {
            internal StateSkip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateAchievement(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAchievement : TriggerState {
            internal StateAchievement(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 2002, arg3: "DreamofEreb");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동 : TriggerState {
            internal State이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000193, arg2: 5001);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}