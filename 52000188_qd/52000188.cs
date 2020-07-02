namespace Maple2.Trigger._52000188_qd {
    public static class _52000188 {
        public class StateWait_01 : TriggerState {
            internal StateWait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {40002794}, arg3: new byte[] {2})) {
                    return new State바베니로_01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {40002793}, arg3: new byte[] {2})) {
                    return new State컷씬준비(context);
                }

                if (context.UserDetected(arg1: new[] {2001}, arg2: 0)) {
                    return new StateWait_01_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_01_02 : TriggerState {
            internal StateWait_01_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.MoveUser(arg1: 52000188, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State동굴도착_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State동굴도착_01 : TriggerState {
            internal State동굴도착_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State동굴도착_01_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State동굴도착_01_2 : TriggerState {
            internal State동굴도착_01_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4001, 4002}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_3001");
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State동굴도착_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State동굴도착_02 : TriggerState {
            internal State동굴도착_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcId: 0, msg: "$52000188_QD__52000188__0$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State정리_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정리_01 : TriggerState {
            internal State정리_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State정리_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
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
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override TriggerState Execute() {
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
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {40002793}, arg3: new byte[] {2})) {
                    return new State컷씬준비(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State컷씬준비 : TriggerState {
            internal State컷씬준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 30, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOutFast.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State컷씬준비_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State컷씬준비_02 : TriggerState {
            internal State컷씬준비_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {40002793}, arg3: new byte[] {2}, arg4: 10)) {
                    return new State나이트컷씬(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {40002793}, arg3: new byte[] {2}, arg4: 20)) {
                    return new State버서커컷씬(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {40002793}, arg3: new byte[] {2}, arg4: 30)) {
                    return new State위자드컷씬(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {40002793}, arg3: new byte[] {2}, arg4: 40)) {
                    return new State프리스트컷씬(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {40002793}, arg3: new byte[] {2}, arg4: 50)) {
                    return new State레인저컷씬(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {40002793}, arg3: new byte[] {2}, arg4: 60)) {
                    return new State헤비거너컷씬(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {40002793}, arg3: new byte[] {2}, arg4: 70)) {
                    return new State시프컷씬(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {40002793}, arg3: new byte[] {2}, arg4: 80)) {
                    return new State어쌔신컷씬(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {40002793}, arg3: new byte[] {2}, arg4: 90)) {
                    return new State룬블컷씬(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {40002793}, arg3: new byte[] {2}, arg4: 100)) {
                    return new State스커컷씬(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {40002793}, arg3: new byte[] {2}, arg4: 110)) {
                    return new State소바컷씬(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State나이트컷씬 : TriggerState {
            internal State나이트컷씬(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.PlaySceneMovie(fileName: "MasterSkill_knight.swf", movieId: 1);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    return new State영상재생_end(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new State영상재생_end(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버서커컷씬 : TriggerState {
            internal State버서커컷씬(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.PlaySceneMovie(fileName: "MasterSkill_berserker.swf", movieId: 2);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    return new State영상재생_end(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new State영상재생_end(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State위자드컷씬 : TriggerState {
            internal State위자드컷씬(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.PlaySceneMovie(fileName: "MasterSkill_wizard.swf", movieId: 3);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    return new State영상재생_end(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new State영상재생_end(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프리스트컷씬 : TriggerState {
            internal State프리스트컷씬(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.PlaySceneMovie(fileName: "MasterSkill_priest.swf", movieId: 4);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    return new State영상재생_end(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new State영상재생_end(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레인저컷씬 : TriggerState {
            internal State레인저컷씬(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.PlaySceneMovie(fileName: "MasterSkill_ranger.swf", movieId: 5);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    return new State영상재생_end(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new State영상재생_end(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State헤비거너컷씬 : TriggerState {
            internal State헤비거너컷씬(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.PlaySceneMovie(fileName: "MasterSkill_heavy.swf", movieId: 6);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    return new State영상재생_end(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new State영상재생_end(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시프컷씬 : TriggerState {
            internal State시프컷씬(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.PlaySceneMovie(fileName: "MasterSkill_thief.swf", movieId: 7);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    return new State영상재생_end(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new State영상재생_end(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어쌔신컷씬 : TriggerState {
            internal State어쌔신컷씬(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.PlaySceneMovie(fileName: "MasterSkill_Assassin.swf", movieId: 8);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    return new State영상재생_end(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new State영상재생_end(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State룬블컷씬 : TriggerState {
            internal State룬블컷씬(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.PlaySceneMovie(fileName: "MasterSkill_RBlader.swf", movieId: 9);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    return new State영상재생_end(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new State영상재생_end(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스커컷씬 : TriggerState {
            internal State스커컷씬(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.PlaySceneMovie(fileName: "MasterSkill_striker.swf", movieId: 10);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    return new State영상재생_end(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new State영상재생_end(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소바컷씬 : TriggerState {
            internal State소바컷씬(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.PlaySceneMovie(fileName: "MasterSkill_soul.swf", movieId: 11);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    return new State영상재생_end(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new State영상재생_end(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상재생_end : TriggerState {
            internal State영상재생_end(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 30, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOutFast.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State영상재생_end02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상재생_end02 : TriggerState {
            internal State영상재생_end02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {40002794}, arg3: new byte[] {2})) {
                    return new State바베니로_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바베니로_01 : TriggerState {
            internal State바베니로_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State바베니로_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바베니로_02 : TriggerState {
            internal State바베니로_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02020041, arg2: 1);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}