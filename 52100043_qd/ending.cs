using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52100043_qd {
    public static class _ending {
        public class StateEnding_Ready : TriggerState {
            internal StateEnding_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {720})) {
                    return new StateEnding_Camera_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_Camera_1 : TriggerState {
            internal StateEnding_Camera_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 500, arg2: false);
                context.CameraSelectPath(pathIds: new[] {500, 501}, arg2: false);
                context.SetEffect(arg1: new[] {5000, 5001, 5002, 5003, 5004, 5005}, arg2: false);
                context.SetMesh(arg1: new[] {4993, 4994, 4995, 4996, 4997, 4998, 4999}, arg2: false);
                context.VisibleMyPc(isVisible: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CreateMonster(arg1: new[] {600, 601, 602}, arg2: false);
                context.SetMesh(arg1: new[] {4993, 4994, 4995, 4996, 4997, 4998, 4999}, arg2: true);
                context.VisibleMyPc(isVisible: true);
                context.MoveNpc(arg1: 600, arg2: "MS2PatrolData0");
                context.MoveNpc(arg1: 601, arg2: "MS2PatrolData1");
                context.MoveNpc(arg1: 602, arg2: "MS2PatrolData2");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEnding_Talk_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_Talk_1 : TriggerState {
            internal StateEnding_Talk_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(state: new StateNarration01(context));
                context.CameraSelect(arg1: 1000, arg2: true);
                context.SetNpcEmotionSequence(arg1: 602, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11001566, illustId: "11001566", script: "$52100043_QD__ENDING__0$", duration: 3000, align: Align.Left);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEnding_Talk_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_Talk_2 : TriggerState {
            internal StateEnding_Talk_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 1001, arg2: true);
                context.SetNpcEmotionSequence(arg1: 601, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11001567, illustId: "11001567", script: "$52100043_QD__ENDING__1$", duration: 3000, align: Align.Left);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEnding_Talk_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_Talk_3 : TriggerState {
            internal StateEnding_Talk_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 1002, arg2: true);
                context.SetNpcEmotionSequence(arg1: 600, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 11001568, illustId: "11001568", script: "$52100043_QD__ENDING__2$", duration: 5000, align: Align.Left);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateShake_Camera(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShake_Camera : TriggerState {
            internal StateShake_Camera(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.CameraSelectPath(pathIds: new[] {4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4006, 4007, 4008, 4006, 4007, 4005, 4006, 4007, 4008, 4006, 4007, 4008, 4006, 4007, 4008, 4006, 4007, 4008, 4008, 4006, 4007, 4008, 4006, 4007, 4008, 4006, 4007, 4008}, arg2: true);
                context.AddCinematicTalk(npcId: 11001567, illustId: "11001567", script: "$52100043_QD__ENDING__3$", duration: 2000, align: Align.Left);
                context.DestroyMonster(arg1: new[] {601, 602}, arg2: false);
                context.CreateMonster(arg1: new[] {701, 702}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnding_Talk_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_Talk_4 : TriggerState {
            internal StateEnding_Talk_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {701, 702}, arg2: false);
                context.DestroyMonster(arg1: new[] {601, 602});
                context.SetEffect(arg1: new[] {5000, 5003, 5004, 5005}, arg2: true);
                context.AddCinematicTalk(npcId: 11001566, illustId: "11001566", script: "$52100043_QD__ENDING__4$", duration: 2000, align: Align.Left);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnding_Talk_5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_Talk_5 : TriggerState {
            internal StateEnding_Talk_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {7000, 7001}, arg2: false);
                context.SetEffect(arg1: new[] {5001}, arg2: true);
                context.AddCinematicTalk(npcId: 11001568, illustId: "11001568", script: "$52100043_QD__ENDING__5$", duration: 2000, align: Align.Left);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State6000_del(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State6000_del : TriggerState {
            internal State6000_del(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_blackfast.xml");
                context.DestroyMonster(arg1: new[] {600});
                context.CreateMonster(arg1: new[] {700}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnding_Talk_6(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_Talk_6 : TriggerState {
            internal StateEnding_Talk_6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_blackfast.xml");
                context.CameraSelect(arg1: 6000, arg2: true);
                context.MoveNpc(arg1: 700, arg2: "MS2PatrolData4");
                context.AddCinematicTalk(npcId: 11001568, illustId: "11001568", script: "$52100043_QD__ENDING__6$", duration: 3000, align: Align.Left);
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
                context.SetTimeScale(enable: true, startScale: 0.8f, endScale: 0.03f, duration: 3.0f, interpolator: 1);
                context.SetEffect(arg1: new[] {5002, 5006}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEnding_Talk_7(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_Talk_7 : TriggerState {
            internal StateEnding_Talk_7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5001}, arg2: true);
                context.CameraSelectPath(pathIds: new[] {3000, 3001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateNarration01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNarration01 : TriggerState {
            internal StateNarration01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.DestroyMonster(arg1: new[] {-1});
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
                context.SetCinematicUI(type: 9, script: "$52100043_QD__ENDING__7$");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateNarration02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNarration02 : TriggerState {
            internal StateNarration02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(state: new StateMap_Warf(context));
                context.SetCinematicUI(type: 9, script: "$52100043_QD__ENDING__8$");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateNarration03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNarration03 : TriggerState {
            internal StateNarration03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52100043_QD__ENDING__9$");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateNarration04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNarration04 : TriggerState {
            internal StateNarration04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52100043_QD__ENDING__10$");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateNarration05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNarration05 : TriggerState {
            internal StateNarration05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52100043_QD__ENDING__11$");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateNarration06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNarration06 : TriggerState {
            internal StateNarration06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52100043_QD__ENDING__12$");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateMap_Warf(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMap_Warf : TriggerState {
            internal StateMap_Warf(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.DestroyMonster(arg1: new[] {-1});
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0f);
                context.MoveUser(arg1: 52010068, arg2: 1);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}