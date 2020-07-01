namespace Maple2.Trigger._52000017_qd {
    public static class _quest01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000, 5001}, arg2: false);
                context.CreateMonster(arg1: new[] {1001}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {50001444}, arg3: new byte[] {2})) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CreateWidget(arg1: "SceneMovie");
                context.WidgetAction(arg1: "SceneMovie", arg2: "Clear");
                context.PlaySceneMovie(fileName: "Cut_Remember_Vision.swf", movieId: 1);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    context.State = new State말풍선딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State말풍선딜레이 : TriggerState {
            internal State말풍선딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StatePC말풍선01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선01 : TriggerState {
            internal StatePC말풍선01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000017_QD__QUEST01__0$", arg4: 3, arg5: 0);
                context.SetSceneSkip(arg1: "종료", arg2: "exit");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateNPC대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC대사01 : TriggerState {
            internal StateNPC대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001560, arg3: "$52000017_QD__QUEST01__1$", arg4: 4);
                context.SetSkip(arg1: "NPC대사01스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNPC대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC대사01스킵 : TriggerState {
            internal StateNPC대사01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNPC대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC대사02 : TriggerState {
            internal StateNPC대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5001}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001560, arg3: "$52000017_QD__QUEST01__2$", arg4: 3);
                context.SetSkip(arg1: "NPC대사02스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC대사02스킵 : TriggerState {
            internal StateNPC대사02스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5001}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000040, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}