namespace Maple2.Trigger._52010064_qd {
    public static class _main {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(isVisible: false);
                context.CreateMonster(arg1: new[] {101}, arg2: false);
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
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {91000073}, arg3: new byte[] {3})) {
                    return new State돌아가(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {91000073}, arg3: new byte[] {2})) {
                    return new StateCameraEffect01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {91000073}, arg3: new byte[] {1})) {
                    return new StateCameraEffect01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {91000072}, arg3: new byte[] {3})) {
                    return new State돌아가(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {91000073}, arg3: new byte[] {1})) {
                    return new State돌아가(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect01 : TriggerState {
            internal StateCameraEffect01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip(state: new StateQuit01(context), arg2: "nextState");
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetAchievement(arg1: 9000, arg2: "trigger", arg3: "flyingtristan");
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
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new[] {8000}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State트리스탄Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리스탄Script01 : TriggerState {
            internal State트리스탄Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8010}, arg2: false);
                context.AddCinematicTalk(npcId: 11003842, illustId: "Tristan_normal", msg: "$52010064_QD__main__0$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State트리스탄Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리스탄Script02 : TriggerState {
            internal State트리스탄Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003842, illustId: "Tristan_normal", msg: "$52010064_QD__main__1$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State트리스탄Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리스탄Script03 : TriggerState {
            internal State트리스탄Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
                context.AddCinematicTalk(npcId: 11003842, illustId: "Tristan_normal", msg: "$52010064_QD__main__2$", duration: 3000, align: "right");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_Tristan_walking");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State트리스탄Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리스탄Script04 : TriggerState {
            internal State트리스탄Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003842, illustId: "Tristan_normal", msg: "$52010064_QD__main__3$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State트리스탄Script05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리스탄Script05 : TriggerState {
            internal State트리스탄Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
                context.AddCinematicTalk(npcId: 11003842, illustId: "Tristan_normal", msg: "$52010064_QD__main__4$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State트리스탄Script06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리스탄Script06 : TriggerState {
            internal State트리스탄Script06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003842, illustId: "Tristan_normal", msg: "$52010064_QD__main__5$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State마무리줌아웃(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마무리줌아웃 : TriggerState {
            internal State마무리줌아웃(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8003}, arg2: false);
                context.SetCinematicUI(arg1: 0);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateQuit01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit01 : TriggerState {
            internal StateQuit01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateQuit03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit03 : TriggerState {
            internal StateQuit03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
                context.MoveUser(arg1: 52010052, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit03(context);
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