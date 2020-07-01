namespace Maple2.Trigger._52010064_qd {
    public static class _main {
        public class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(isVisible: false);
                context.CreateMonster(arg1: new[] {101}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserCount() > 0) {
                    context.State = new State퀘스트조건체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트조건체크 : TriggerState {
            internal State퀘스트조건체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {91000073}, arg3: new byte[] {3})) {
                    context.State = new State돌아가(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {91000073}, arg3: new byte[] {2})) {
                    context.State = new StateCameraEffect01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {91000073}, arg3: new byte[] {1})) {
                    context.State = new StateCameraEffect01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {91000072}, arg3: new byte[] {3})) {
                    context.State = new State돌아가(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {91000073}, arg3: new byte[] {1})) {
                    context.State = new State돌아가(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect01 : TriggerState {
            internal StateCameraEffect01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip(arg1: "quit01", arg2: "nextState");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetAchievement(arg1: 9000, arg2: "trigger", arg3: "flyingtristan");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCameraEffect02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect02 : TriggerState {
            internal StateCameraEffect02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new[] {8000}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State트리스탄대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리스탄대사01 : TriggerState {
            internal State트리스탄대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8010}, arg2: false);
                context.AddCinematicTalk(npcId: 11003842, illustId: "Tristan_normal", msg: "$52010064_QD__main__0$", duration: 3000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State트리스탄대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리스탄대사02 : TriggerState {
            internal State트리스탄대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003842, illustId: "Tristan_normal", msg: "$52010064_QD__main__1$", duration: 3000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State트리스탄대사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리스탄대사03 : TriggerState {
            internal State트리스탄대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
                context.AddCinematicTalk(npcId: 11003842, illustId: "Tristan_normal", msg: "$52010064_QD__main__2$", duration: 3000, align: "right");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_Tristan_walking");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State트리스탄대사04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리스탄대사04 : TriggerState {
            internal State트리스탄대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003842, illustId: "Tristan_normal", msg: "$52010064_QD__main__3$", duration: 3000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State트리스탄대사05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리스탄대사05 : TriggerState {
            internal State트리스탄대사05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
                context.AddCinematicTalk(npcId: 11003842, illustId: "Tristan_normal", msg: "$52010064_QD__main__4$", duration: 3000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State트리스탄대사06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리스탄대사06 : TriggerState {
            internal State트리스탄대사06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003842, illustId: "Tristan_normal", msg: "$52010064_QD__main__5$", duration: 3000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State마무리줌아웃(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마무리줌아웃 : TriggerState {
            internal State마무리줌아웃(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8003}, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statequit01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statequit01 : TriggerState {
            internal Statequit01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statequit03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statequit03 : TriggerState {
            internal Statequit03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
                context.MoveUser(arg1: 52010052, arg2: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statequit03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State돌아가 : TriggerState {
            internal State돌아가(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52010052, arg2: 1);
                context.VisibleMyPc(isVisible: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State돌아가(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}