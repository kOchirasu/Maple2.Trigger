namespace Maple2.Trigger._52000157_qd {
    public static class _52000157 {
        public class Statewait_01 : TriggerState {
            internal Statewait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5001, 5002}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {2002}, arg2: new[] {40002731}, arg3: new byte[] {2})) {
                    context.State = new State이별준비(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {2002}, arg2: new[] {40002731}, arg3: new byte[] {3})) {
                    context.State = new State프론티아재단으로_01(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {2002})) {
                    context.State = new State전직컷씬01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전직컷씬01 : TriggerState {
            internal State전직컷씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.PlaySceneMovie(fileName: "jobChange_thief.swf", movieId: 1);
                context.CreateMonster(arg1: new[] {107}, arg2: false);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    context.State = new State정산끝(context);
                    return;
                }

                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State정산끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정산끝 : TriggerState {
            internal State정산끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {2002}, arg2: new[] {40002728}, arg3: new byte[] {3})) {
                    context.State = new State전직이펙트_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전직이펙트_01 : TriggerState {
            internal State전직이펙트_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 30, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOutFast.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State전직이펙트_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전직이펙트_02 : TriggerState {
            internal State전직이펙트_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 30, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOutFast.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State떠나기전준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State떠나기전준비 : TriggerState {
            internal State떠나기전준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {2002}, arg2: new[] {40002731}, arg3: new byte[] {2})) {
                    context.State = new State이별준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이별준비 : TriggerState {
            internal State이별준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State이별준비_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이별준비_01 : TriggerState {
            internal State이별준비_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.DestroyMonster(arg1: new[] {107, 105, 106});
                context.CreateMonster(arg1: new[] {110, 109, 108}, arg2: false);
                context.MoveUser(arg1: 52000157, arg2: 6002);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State이별준비_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이별준비_02 : TriggerState {
            internal State이별준비_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State이별준비_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이별준비_03 : TriggerState {
            internal State이별준비_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {2002}, arg2: new[] {40002731}, arg3: new byte[] {3})) {
                    context.State = new State프론티아재단으로_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State프론티아재단으로_01 : TriggerState {
            internal State프론티아재단으로_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 7, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State프론티아재단으로_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State프론티아재단으로_02 : TriggerState {
            internal State프론티아재단으로_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000186, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}