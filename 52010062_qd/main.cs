using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52010062_qd {
    public static class _main {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(isVisible: false);
                context.CreateMonster(arg1: new[] {2000, 2001, 2002, 2003}, arg2: false);
                context.SetEffect(arg1: new[] {6000, 6001, 6002, 6003, 6010, 6011, 6031, 6032, 6033, 6041, 6042, 6043, 6051, 6052, 6053}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateQuestConditionCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestConditionCheck : TriggerState {
            internal StateQuestConditionCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {91000051}, arg3: new byte[] {3})) {
                    return new State돌아가(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {91000051}, arg3: new byte[] {2})) {
                    return new State돌아가(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {91000051}, arg3: new byte[] {1})) {
                    return new State스케치01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {91000050}, arg3: new byte[] {3})) {
                    return new State돌아가(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {91000051}, arg3: new byte[] {1})) {
                    return new State돌아가(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스케치01 : TriggerState {
            internal State스케치01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new State스킵완료(context), arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State스케치02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스케치02 : TriggerState {
            internal State스케치02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new[] {4000, 4001}, arg2: false);
                context.SetEffect(arg1: new[] {6001, 6002, 6003, 6010}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new State스케치03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스케치03 : TriggerState {
            internal State스케치03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State크림슨발록Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록Script01 : TriggerState {
            internal State크림슨발록Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetEffect(arg1: new[] {6003}, arg2: true);
                context.AddCinematicTalk(npcId: 11003835, script: "$52010062_QD__main__0$", duration: 7000, align: Align.Right);
                context.CameraSelectPath(pathIds: new[] {4002, 4003}, arg2: false);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State크림슨발록Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록Script02 : TriggerState {
            internal State크림슨발록Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6001}, arg2: true);
                context.AddCinematicTalk(npcId: 11003833, script: "$52010062_QD__main__1$", duration: 5000, align: Align.Right);
                context.CameraSelectPath(pathIds: new[] {4004, 4005}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 2001, arg2: "Attack_01_C,Attack_Idle_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State크림슨발록Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록Script03 : TriggerState {
            internal State크림슨발록Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6002}, arg2: true);
                context.AddCinematicTalk(npcId: 11003834, script: "$52010062_QD__main__2$", duration: 5000, align: Align.Right);
                context.CameraSelectPath(pathIds: new[] {4006, 4007}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 2002, arg2: "Attack_01_B,Attack_Idle_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State크림슨발록Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록Script04 : TriggerState {
            internal State크림슨발록Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6001, 6002, 6003}, arg2: true);
                context.AddCinematicTalk(npcId: 11003793, script: "$52010062_QD__main__3$", duration: 4000, align: Align.Right);
                context.CameraSelectPath(pathIds: new[] {4008, 4009, 4013, 4014}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State인페르녹부활00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹부활00 : TriggerState {
            internal State인페르녹부활00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6031, 6032, 6033}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State인페르녹부활01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹부활01 : TriggerState {
            internal State인페르녹부활01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 0)) {
                    return new State인페르녹부활02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹부활02 : TriggerState {
            internal State인페르녹부활02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetCinematicUI(type: 1);
                context.SetEffect(arg1: new[] {6000, 6041, 6042, 6043}, arg2: true);
                context.SetTimeScale(enable: true, startScale: 1.0f, endScale: 0.1f, duration: 10.0f, interpolator: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State인페르녹부활03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹부활03 : TriggerState {
            internal State인페르녹부활03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetEffect(arg1: new[] {6051, 6052, 6053}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State인페르녹부활04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹부활04 : TriggerState {
            internal State인페르녹부활04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6000}, arg2: true);
                context.SetEffect(arg1: new[] {6010}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State인페르녹부활05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹부활05 : TriggerState {
            internal State인페르녹부활05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6031, 6032, 6033, 6041, 6042, 6043, 6051, 6052, 6053}, arg2: false);
                context.SetEffect(arg1: new[] {6011}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State인페르녹부활06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹부활06 : TriggerState {
            internal State인페르녹부활06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetOnetimeEffect(id: 5, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetEffect(arg1: new[] {6031, 6032, 6033, 6041, 6042, 6043, 6051, 6052, 6053, 6000}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State인페르녹Script00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹Script00 : TriggerState {
            internal State인페르녹Script00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4010, 4011, 4012}, arg2: false);
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetOnetimeEffect(id: 5, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State인페르녹Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹Script01 : TriggerState {
            internal State인페르녹Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4021}, arg2: false);
                context.AddCinematicTalk(npcId: 11003831, illustId: "infernog_nomal", script: "$52010062_QD__main__4$", duration: 4000, align: Align.Right);
                context.SetEffect(arg1: new[] {6011}, arg2: false);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State인페르녹Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹Script02 : TriggerState {
            internal State인페르녹Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003831, illustId: "infernog_nomal", script: "$52010062_QD__main__5$", duration: 4000, align: Align.Right);
                context.SetNpcEmotionSequence(arg1: 2000, arg2: "Attack_01_B");
                context.SetEffect(arg1: new[] {6000, 6011}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State부하Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부하Script01 : TriggerState {
            internal State부하Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003834, script: "$52010062_QD__main__6$", duration: 4000, align: Align.Right);
                context.SetEffect(arg1: new[] {6000, 6011}, arg2: false);
                context.CameraSelectPath(pathIds: new[] {4006, 4007}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 2002, arg2: "Attack_01_B,Attack_Idle_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State부하Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부하Script02 : TriggerState {
            internal State부하Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003835, script: "$52010062_QD__main__7$", duration: 4000, align: Align.Right);
                context.CameraSelectPath(pathIds: new[] {4002, 4003}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 2003, arg2: "Attack_01_B,Attack_Idle_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State부하Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부하Script03 : TriggerState {
            internal State부하Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003833, script: "$52010062_QD__main__8$", duration: 4000, align: Align.Right);
                context.CameraSelectPath(pathIds: new[] {4004, 4005}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 2001, arg2: "Attack_01_C,Attack_Idle_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State인페르녹Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹Script03 : TriggerState {
            internal State인페르녹Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4013, 4012}, arg2: false);
                context.AddCinematicTalk(npcId: 11003831, illustId: "infernog_nomal", script: "$52010062_QD__main__9$", duration: 4000, align: Align.Right);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State인페르녹Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹Script04 : TriggerState {
            internal State인페르녹Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4021}, arg2: false);
                context.AddCinematicTalk(npcId: 11003831, illustId: "infernog_nomal", script: "$52010062_QD__main__10$", duration: 4000, align: Align.Right);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State인페르녹Script05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹Script05 : TriggerState {
            internal State인페르녹Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4021, 4022}, arg2: false);
                context.AddCinematicTalk(npcId: 11003831, illustId: "infernog_nomal", script: "$52010062_QD__main__11$", duration: 4000, align: Align.Right);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State인페르녹Script06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹Script06 : TriggerState {
            internal State인페르녹Script06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4022, 4023}, arg2: false);
                context.SetOnetimeEffect(id: 6, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.AddCinematicTalk(npcId: 11003831, illustId: "infernog_nomal", script: "$52010062_QD__main__12$", duration: 4000, align: Align.Right);
                context.SetSceneSkip();
                context.SetEffect(arg1: new[] {6000}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스킵완료 : TriggerState {
            internal State스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetEffect(arg1: new[] {6000, 6001, 6002, 6003, 6010, 6011, 6031, 6032, 6033, 6041, 6042, 6043, 6051, 6052, 6053}, arg2: false);
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
                context.CameraReset(interpolationTime: 2.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetAchievement(arg1: 9001, arg2: "trigger", arg3: "infernogrevive");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateFinal맵이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFinal맵이동 : TriggerState {
            internal StateFinal맵이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52010052, arg2: 1);
                context.VisibleMyPc(isVisible: true);
                context.SetOnetimeEffect(id: 6, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetOnetimeEffect(id: 5, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateFinal맵이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State돌아가 : TriggerState {
            internal State돌아가(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52010052, arg2: 1);
                context.VisibleMyPc(isVisible: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State돌아가(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}