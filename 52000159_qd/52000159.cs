using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000159_qd {
    public static class _52000159 {
        public class StateWait_01 : TriggerState {
            internal StateWait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{40002735}, questStates: new byte[]{2})) {
                    return new State정리_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{40002736}, questStates: new byte[]{2})) {
                    return new State정리_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{40002737}, questStates: new byte[]{2})) {
                    return new State정리_01(context);
                }

                if (context.UserDetected(boxIds: new []{2001}, jobCode: 0)) {
                    return new StateWait_01_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_01_1 : TriggerState {
            internal StateWait_01_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.MoveUser(mapId: 52000159, portalId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State어쌔신과거_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어쌔신과거_01 : TriggerState {
            internal State어쌔신과거_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State어쌔신과거_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어쌔신과거_02 : TriggerState {
            internal State어쌔신과거_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4001, 4002, 4003, 4004}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State어쌔신과거_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어쌔신과거_03 : TriggerState {
            internal State어쌔신과거_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.ShowCaption(type: CaptionType.Vertical, title: "$52000159_QD__52000159__0$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 5000, scale: 2.5f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State어쌔신과거_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어쌔신과거_04 : TriggerState {
            internal State어쌔신과거_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 0, script: "$52000159_QD__52000159__1$", duration: 4000);
                context.MoveUserPath(patrolName: "MS2PatrolData_3001");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State어쌔신과거_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어쌔신과거_05 : TriggerState {
            internal State어쌔신과거_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000159_QD__52000159__2$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "$52000159_QD__52000159__3$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "$52000159_QD__52000159__4$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "$52000159_QD__52000159__5$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new State어쌔신과거_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어쌔신과거_06 : TriggerState {
            internal State어쌔신과거_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4005}, returnView: false);
                context.AddCinematicTalk(npcId: 0, script: "$52000159_QD__52000159__6$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "$52000159_QD__52000159__7$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new State어쌔신과거_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어쌔신과거_07 : TriggerState {
            internal State어쌔신과거_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.AddCinematicTalk(npcId: 0, script: "$52000159_QD__52000159__8$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "$52000159_QD__52000159__9$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State암전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State암전 : TriggerState {
            internal State암전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State쉐도클로_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State쉐도클로_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도클로_01 : TriggerState {
            internal State쉐도클로_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(pathIds: new []{4006}, returnView: false);
                context.CreateMonster(spawnIds: new []{103}, arg2: false);
                context.SetEffect(triggerIds: new []{5001}, visible: true);
                context.CreateMonster(spawnIds: new []{105}, arg2: false);
                context.SetEffect(triggerIds: new []{5002}, visible: true);
                context.CreateMonster(spawnIds: new []{106}, arg2: false);
                context.SetEffect(triggerIds: new []{5003}, visible: true);
                context.CreateMonster(spawnIds: new []{107}, arg2: false);
                context.SetEffect(triggerIds: new []{5004}, visible: true);
                context.CreateMonster(spawnIds: new []{108}, arg2: false);
                context.SetEffect(triggerIds: new []{5005}, visible: true);
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.SetEffect(triggerIds: new []{5006}, visible: true);
                context.MoveUser(mapId: 52000159, portalId: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State쉐도클로_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도클로_02 : TriggerState {
            internal State쉐도클로_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_3002");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State정리_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정리_01 : TriggerState {
            internal State정리_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State정리_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정리_02 : TriggerState {
            internal State정리_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.CreateMonster(spawnIds: new []{102, 104, 109, 110, 111, 112, 113}, arg2: false);
                context.DestroyMonster(spawnIds: new []{101}, arg2: false);
                context.DestroyMonster(spawnIds: new []{103}, arg2: false);
                context.DestroyMonster(spawnIds: new []{105}, arg2: false);
                context.DestroyMonster(spawnIds: new []{106}, arg2: false);
                context.DestroyMonster(spawnIds: new []{107}, arg2: false);
                context.DestroyMonster(spawnIds: new []{108}, arg2: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State밝아짐(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State밝아짐 : TriggerState {
            internal State밝아짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{40002735}, questStates: new byte[]{2})) {
                    return new State남자의죽음_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{40002736}, questStates: new byte[]{2})) {
                    return new State남자의죽음_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{40002737}, questStates: new byte[]{2})) {
                    return new State남자의죽음_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State남자의죽음_01 : TriggerState {
            internal State남자의죽음_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State남자의죽음_01_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State남자의죽음_01_02 : TriggerState {
            internal State남자의죽음_01_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelectPath(pathIds: new []{4007}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State남자의죽음_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State남자의죽음_02 : TriggerState {
            internal State남자의죽음_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(state: new StateSkip_2(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State남자의죽음_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State남자의죽음_03 : TriggerState {
            internal State남자의죽음_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 104, sequenceName: "Attack_01_B");
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Dead_B", duration: 9000000000000f);
                context.SetEffect(triggerIds: new []{5007}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State남자의죽음_03_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State남자의죽음_03_01 : TriggerState {
            internal State남자의죽음_03_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State남자의죽음_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_2 : TriggerState {
            internal StateSkip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 5, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State남자의죽음_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State남자의죽음_04 : TriggerState {
            internal State남자의죽음_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{102}, arg2: false);
                context.CreateMonster(spawnIds: new []{114}, arg2: false);
                context.SetNpcEmotionLoop(spawnId: 114, sequenceName: "Dead_B", duration: 9000000000000f);
                context.CreateMonster(spawnIds: new []{115}, arg2: false);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State남자의죽음_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State남자의죽음_05 : TriggerState {
            internal State남자의죽음_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{40002737}, questStates: new byte[]{2})) {
                    return new State쉐도클로표창_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도클로표창_01 : TriggerState {
            internal State쉐도클로표창_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 6, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State쉐도클로표창_01_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도클로표창_01_01 : TriggerState {
            internal State쉐도클로표창_01_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4009}, returnView: false);
                context.VisibleMyPc(visible: false);
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State쉐도클로표창_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도클로표창_02 : TriggerState {
            internal State쉐도클로표창_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 6, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetNpcEmotionLoop(spawnId: 104, sequenceName: "Attack_Idle_A", duration: 4000f);
                context.SetSceneSkip(state: new StateSkip_3(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State쉐도클로표창_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도클로표창_03 : TriggerState {
            internal State쉐도클로표창_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4008}, returnView: false);
                context.SetNpcEmotionLoop(spawnId: 104, sequenceName: "Attack_01_B", duration: 80000f);
                context.SetTimeScale(enable: true, startScale: 0.1f, endScale: 0.1f, duration: 10.0f, interpolator: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State쉐도클로표창_03_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도클로표창_03_01 : TriggerState {
            internal State쉐도클로표창_03_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 115, sequenceName: "Dead_A", duration: 80000f);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State쉐도클로표창_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_3 : TriggerState {
            internal StateSkip_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State쉐도클로표창_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도클로표창_04 : TriggerState {
            internal State쉐도클로표창_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 7, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State쉐도클로표창_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도클로표창_05 : TriggerState {
            internal State쉐도클로표창_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(visible: true);
                context.MoveUser(mapId: 52000158, portalId: 6001);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
