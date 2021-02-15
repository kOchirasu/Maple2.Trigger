namespace Maple2.Trigger._52000157_qd {
    public static class _52000157 {
        public class StateWait_01 : TriggerState {
            internal StateWait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5001, 5002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2002}, arg2: new[] {40002731}, arg3: new byte[] {2})) {
                    return new State이별Prepare(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2002}, arg2: new[] {40002731}, arg3: new byte[] {3})) {
                    return new State프론티아재단으로_01(context);
                }

                if (context.UserDetected(arg1: new[] {2002})) {
                    return new State전직컷씬01(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    return new State정산끝(context);
                }

                if (context.WaitTick(waitTick: 8000)) {
                    return new State정산끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정산끝 : TriggerState {
            internal State정산끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2002}, arg2: new[] {40002728}, arg3: new byte[] {3})) {
                    return new State전직이펙트_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전직이펙트_01 : TriggerState {
            internal State전직이펙트_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 30, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOutFast.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State전직이펙트_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전직이펙트_02 : TriggerState {
            internal State전직이펙트_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 30, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOutFast.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State떠나기전Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State떠나기전Prepare : TriggerState {
            internal State떠나기전Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2002}, arg2: new[] {40002731}, arg3: new byte[] {2})) {
                    return new State이별Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이별Prepare : TriggerState {
            internal State이별Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State이별Prepare_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이별Prepare_01 : TriggerState {
            internal State이별Prepare_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.DestroyMonster(arg1: new[] {107, 105, 106});
                context.CreateMonster(arg1: new[] {110, 109, 108}, arg2: false);
                context.MoveUser(arg1: 52000157, arg2: 6002);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State이별Prepare_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이별Prepare_02 : TriggerState {
            internal State이별Prepare_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State이별Prepare_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이별Prepare_03 : TriggerState {
            internal State이별Prepare_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2002}, arg2: new[] {40002731}, arg3: new byte[] {3})) {
                    return new State프론티아재단으로_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프론티아재단으로_01 : TriggerState {
            internal State프론티아재단으로_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 7, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(arg1: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State프론티아재단으로_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프론티아재단으로_02 : TriggerState {
            internal State프론티아재단으로_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000186, arg2: 1);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}