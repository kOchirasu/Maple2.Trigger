namespace Maple2.Trigger._52000005_qd {
    public static class _act01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {103, 202}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {10002781}, arg3: new byte[] {1})) {
                    return new State딜레이01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State딜레이01 : TriggerState {
            internal State딜레이01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.DestroyMonster(arg1: new[] {103, 202});
                context.SetTimer(arg1: "1", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State영감대화준비(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영감대화준비 : TriggerState {
            internal State영감대화준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override TriggerState Execute() {
                return new State영감대화01(context);
            }

            public override void OnExit() { }
        }

        private class State영감대화01 : TriggerState {
            internal State영감대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 3);
                context.SetConversation(arg1: 2, arg2: 11000031, arg3: "$52000005_QD__ACT01__0$", arg4: 3);
                context.SetSkip(arg1: "영감대화02대기");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State영감대화02대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영감대화02대기 : TriggerState {
            internal State영감대화02대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new State영감대화02(context);
            }

            public override void OnExit() { }
        }

        private class State영감대화02 : TriggerState {
            internal State영감대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetConversation(arg1: 2, arg2: 11000001, arg3: "$52000005_QD__ACT01__1$", arg4: 3);
                context.CreateMonster(arg1: new[] {101, 201}, arg2: true);
                context.SetSkip(arg1: "여제입장01");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State여제입장01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State여제입장01 : TriggerState {
            internal State여제입장01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetTimer(arg1: "10", arg2: 1);
                context.CameraSelect(arg1: 601, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    return new State딜레이03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State딜레이03 : TriggerState {
            internal State딜레이03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "12", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "12")) {
                    return new State여제대화01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State여제대화01 : TriggerState {
            internal State여제대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "20", arg2: 3);
                context.SetConversation(arg1: 2, arg2: 11000075, arg3: "$52000005_QD__ACT01__2$", arg4: 3);
                context.SetSkip(arg1: "영상준비");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "20")) {
                    return new State영상준비(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상준비 : TriggerState {
            internal State영상준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetTimer(arg1: "21", arg2: 3);
                context.CameraSelectPath(arg1: new[] {601, 602}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "21")) {
                    return new State영상재생(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상재생 : TriggerState {
            internal State영상재생(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.WidgetAction(arg1: "SceneMovie", arg2: "Clear");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.PlaySceneMovie(fileName: "lumieragonhistory.swf", movieId: 1);
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {102}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    return new State영상종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상종료 : TriggerState {
            internal State영상종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "31", arg2: 4);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 11000075, arg3: "$52000005_QD__ACT01__3$", arg4: 4);
                context.SetSkip(arg1: "연출종료");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "31")) {
                    return new State연출종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new State업적발생(context);
            }

            public override void OnExit() { }
        }

        private class State업적발생 : TriggerState {
            internal State업적발생(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 9001, arg2: "trigger", arg3: "Lumieragon_History");
                context.CameraSelect(arg1: 601, arg2: false);
                context.CameraSelect(arg1: 602, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}