namespace Maple2.Trigger._52000087_qd {
    public static class _52000087_trigger {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 10, arg2: false, arg3: false, arg4: false);
                context.SetEffect(arg1: new[] {600}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {22651}, arg2: new[] {20002266}, arg3: new byte[] {3})) {
                    context.State = new State용무없는유저는아웃(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {22651}, arg2: new[] {10002781}, arg3: new byte[] {1})) {
                    context.State = new State카르카르시작(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {22651}, arg2: new[] {20002265}, arg3: new byte[] {3})) {
                    context.State = new State20002265_완료연출01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카르카르시작 : TriggerState {
            internal State카르카르시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State진행(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진행 : TriggerState {
            internal State진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State에레브_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에레브_1 : TriggerState {
            internal State에레브_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000075, arg3: "$52000087_QD__52000087_TRIGGER__0$", arg4: 3);
                context.SetSkip(arg1: "에레브_1skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State에레브_1skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에레브_1skip : TriggerState {
            internal State에레브_1skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State에레브_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에레브_2 : TriggerState {
            internal State에레브_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000075, arg3: "$52000087_QD__52000087_TRIGGER__1$", arg4: 5);
                context.SetSkip(arg1: "에레브_2skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State에레브_2skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에레브_2skip : TriggerState {
            internal State에레브_2skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State에레브_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에레브_3 : TriggerState {
            internal State에레브_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000075, arg3: "$52000087_QD__52000087_TRIGGER__2$", arg4: 5);
                context.SetSkip(arg1: "에레브_3skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State에레브_3skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에레브_3skip : TriggerState {
            internal State에레브_3skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State블랙아이_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State블랙아이_1 : TriggerState {
            internal State블랙아이_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000006, arg3: "$52000087_QD__52000087_TRIGGER__3$", arg4: 3);
                context.SetSkip(arg1: "블랙아이_1skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State블랙아이_1skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State블랙아이_1skip : TriggerState {
            internal State블랙아이_1skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State블랙아이_1a(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State블랙아이_1a : TriggerState {
            internal State블랙아이_1a(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000006, arg3: "$52000087_QD__52000087_TRIGGER__4$", arg4: 5);
                context.SetSkip(arg1: "블랙아이_1askip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State블랙아이_1askip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State블랙아이_1askip : TriggerState {
            internal State블랙아이_1askip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State프레이_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State프레이_1 : TriggerState {
            internal State프레이_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000119, arg3: "$52000087_QD__52000087_TRIGGER__5$", arg4: 5);
                context.SetSkip(arg1: "프레이_1skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State프레이_1skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State프레이_1skip : TriggerState {
            internal State프레이_1skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State구르는천둥_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State구르는천둥_1 : TriggerState {
            internal State구르는천둥_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001581, arg3: "$52000087_QD__52000087_TRIGGER__6$", arg4: 3);
                context.SetSkip(arg1: "구르는천둥_1skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State구르는천둥_1skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State구르는천둥_1skip : TriggerState {
            internal State구르는천둥_1skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State알론_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State알론_1 : TriggerState {
            internal State알론_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000076, arg3: "$52000087_QD__52000087_TRIGGER__7$", arg4: 3);
                context.SetSkip(arg1: "알론_1skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State알론_1skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State알론_1skip : TriggerState {
            internal State알론_1skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State오스칼_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오스칼_1 : TriggerState {
            internal State오스칼_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000015, arg3: "$52000087_QD__52000087_TRIGGER__8$", arg4: 5);
                context.SetSkip(arg1: "오스칼_1skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State오스칼_1skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오스칼_1skip : TriggerState {
            internal State오스칼_1skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State블랙아이_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State블랙아이_2 : TriggerState {
            internal State블랙아이_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000006, arg3: "$52000087_QD__52000087_TRIGGER__9$", arg4: 5);
                context.SetSkip(arg1: "블랙아이_2skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State블랙아이_2skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State블랙아이_2skip : TriggerState {
            internal State블랙아이_2skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State블랙아이_2a(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State블랙아이_2a : TriggerState {
            internal State블랙아이_2a(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000006, arg3: "$52000087_QD__52000087_TRIGGER__10$", arg4: 5);
                context.SetSkip(arg1: "블랙아이_2askip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State블랙아이_2askip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State블랙아이_2askip : TriggerState {
            internal State블랙아이_2askip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State블랙아이_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State블랙아이_3 : TriggerState {
            internal State블랙아이_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000006, arg3: "$52000087_QD__52000087_TRIGGER__11$", arg4: 5);
                context.SetSkip(arg1: "블랙아이_3skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State블랙아이_3skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State블랙아이_3skip : TriggerState {
            internal State블랙아이_3skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State알론_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State알론_2 : TriggerState {
            internal State알론_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000076, arg3: "$52000087_QD__52000087_TRIGGER__12$", arg4: 3);
                context.SetSkip(arg1: "알론_2skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State알론_2skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State알론_2skip : TriggerState {
            internal State알론_2skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State에레브_4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에레브_4 : TriggerState {
            internal State에레브_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000075, arg3: "$52000087_QD__52000087_TRIGGER__13$", arg4: 5);
                context.SetSkip(arg1: "에레브_4skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State에레브_4skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에레브_4skip : TriggerState {
            internal State에레브_4skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State영상준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State영상준비 : TriggerState {
            internal State영상준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetTimer(arg1: "21", arg2: 2);
                context.CameraSelectPath(arg1: new[] {601, 602}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "21")) {
                    context.State = new State영상재생(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    context.State = new State알론_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State알론_3 : TriggerState {
            internal State알론_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 11000076, arg3: "$52000087_QD__52000087_TRIGGER__14$", arg4: 5);
                context.SetSkip(arg1: "알론_3skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State알론_3skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State알론_3skip : TriggerState {
            internal State알론_3skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State알론_4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State알론_4 : TriggerState {
            internal State알론_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 11000076, arg3: "$52000087_QD__52000087_TRIGGER__15$", arg4: 5);
                context.SetSkip(arg1: "알론_4skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State알론_4skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State알론_4skip : TriggerState {
            internal State알론_4skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State알론_4a(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State알론_4a : TriggerState {
            internal State알론_4a(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 11000076, arg3: "$52000087_QD__52000087_TRIGGER__16$", arg4: 5);
                context.SetSkip(arg1: "알론_4askip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State알론_4askip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State알론_4askip : TriggerState {
            internal State알론_4askip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State알론_5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State알론_5 : TriggerState {
            internal State알론_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 11000076, arg3: "$52000087_QD__52000087_TRIGGER__17$", arg4: 5);
                context.SetSkip(arg1: "알론_5skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State알론_5skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State알론_5skip : TriggerState {
            internal State알론_5skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State에레브_5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에레브_5 : TriggerState {
            internal State에레브_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000075, arg3: "$52000087_QD__52000087_TRIGGER__18$", arg4: 5);
                context.SetSkip(arg1: "에레브_5skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State에레브_5skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에레브_5skip : TriggerState {
            internal State에레브_5skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State에레브_6(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에레브_6 : TriggerState {
            internal State에레브_6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000075, arg3: "$52000087_QD__52000087_TRIGGER__19$", arg4: 5);
                context.SetSkip(arg1: "에레브_6skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State에레브_6skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에레브_6skip : TriggerState {
            internal State에레브_6skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State칼_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State칼_1 : TriggerState {
            internal State칼_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000074, arg3: "$52000087_QD__52000087_TRIGGER__20$", arg4: 5);
                context.SetSkip(arg1: "칼_1skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State칼_1skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State칼_1skip : TriggerState {
            internal State칼_1skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State에레브_7(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에레브_7 : TriggerState {
            internal State에레브_7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000075, arg3: "$52000087_QD__52000087_TRIGGER__21$", arg4: 5);
                context.SetSkip(arg1: "에레브_7skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State에레브_7skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에레브_7skip : TriggerState {
            internal State에레브_7skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State에레브_8(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에레브_8 : TriggerState {
            internal State에레브_8(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000075, arg3: "$52000087_QD__52000087_TRIGGER__22$", arg4: 5);
                context.SetSkip(arg1: "에레브_8skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State에레브_8skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에레브_8skip : TriggerState {
            internal State에레브_8skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 22651, arg2: "trigger", arg3: "Lumieragon_History");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State20002265_완료연출01 : TriggerState {
            internal State20002265_완료연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.MoveUser(arg1: 52000087, arg2: 10);
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State20002265_완료연출02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State20002265_완료연출02 : TriggerState {
            internal State20002265_완료연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new[] {2002, 2003, 2004}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State20002265_완료연출03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State20002265_완료연출03 : TriggerState {
            internal State20002265_완료연출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {600}, arg2: true);
                context.CreateMonster(arg1: new[] {1003}, arg2: false);
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_Start");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State20002265_완료연출04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State20002265_완료연출04 : TriggerState {
            internal State20002265_완료연출04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 3);
                context.SetNpcEmotionSequence(arg1: 1003, arg2: "Bore_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State20002265_완료연출04_b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State20002265_완료연출04_b : TriggerState {
            internal State20002265_완료연출04_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003087, arg3: "$52000087_QD__52000087_TRIGGER__23$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State20002265_완료연출04_c(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State20002265_완료연출04_c : TriggerState {
            internal State20002265_완료연출04_c(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 1003, arg2: "ChatUp_A");
                context.SetConversation(arg1: 2, arg2: 11003087, arg3: "$52000087_QD__52000087_TRIGGER__24$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State20002265_완료연출05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State20002265_완료연출05 : TriggerState {
            internal State20002265_완료연출05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {600}, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 2.0f);
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_Orde");
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {22651}, arg2: new[] {20002266}, arg3: new byte[] {3})) {
                    context.State = new State20002266_완료연출01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State20002266_완료연출01_난입 : TriggerState {
            internal State20002266_완료연출01_난입(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1003}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State20002266_완료연출01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State20002266_완료연출01 : TriggerState {
            internal State20002266_완료연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveUser(arg1: 52000087, arg2: 10);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State20002266_완료연출02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State20002266_완료연출02 : TriggerState {
            internal State20002266_완료연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new[] {2005, 2006}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State20002266_완료연출03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State20002266_완료연출03 : TriggerState {
            internal State20002266_완료연출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003087, arg3: "$52000087_QD__52000087_TRIGGER__25$", arg4: 3);
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_OrdeOut");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State20002266_완료연출04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State20002266_완료연출04 : TriggerState {
            internal State20002266_완료연출04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 500, arg2: true, arg3: true, arg4: true);
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.DestroyMonster(arg1: new[] {1003});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State20002266_완료연출05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State20002266_완료연출05 : TriggerState {
            internal State20002266_완료연출05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 1.0f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State용무없는유저는아웃 : TriggerState {
            internal State용무없는유저는아웃(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {22651}, arg2: new[] {20002285}, arg3: new byte[] {3})) {
                    context.State = new State챕터10에필로그연출01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출01 : TriggerState {
            internal State챕터10에필로그연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.MoveUser(arg1: 52000087, arg2: 10);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State챕터10에필로그연출02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출02 : TriggerState {
            internal State챕터10에필로그연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52000087_QD__52000087_TRIGGER__26$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State챕터10에필로그연출03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출03 : TriggerState {
            internal State챕터10에필로그연출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52000087_QD__52000087_TRIGGER__27$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State챕터10에필로그연출05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출05 : TriggerState {
            internal State챕터10에필로그연출05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52000087_QD__52000087_TRIGGER__28$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State챕터10에필로그연출05b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출05b : TriggerState {
            internal State챕터10에필로그연출05b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State챕터10에필로그연출06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출06 : TriggerState {
            internal State챕터10에필로그연출06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 90000, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001820, arg3: "$52000087_QD__52000087_TRIGGER__29$", arg4: 6);
                context.SetOnetimeEffect(id: 2007, enable: true, path: @"BG/Common/Sound/Eff_Madria_Chapter10_End_01_00002007.xml");
                context.SetSkip(arg1: "챕터10에필로그연출06스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State챕터10에필로그연출06스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출06스킵 : TriggerState {
            internal State챕터10에필로그연출06스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State챕터10에필로그연출07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출07 : TriggerState {
            internal State챕터10에필로그연출07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001820, arg3: "$52000087_QD__52000087_TRIGGER__30$", arg4: 6);
                context.SetOnetimeEffect(id: 2008, enable: true, path: @"BG/Common/Sound/Eff_Madria_Chapter10_End_02_00002008.xml");
                context.SetSkip(arg1: "챕터10에필로그연출07스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State챕터10에필로그연출07스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출07스킵 : TriggerState {
            internal State챕터10에필로그연출07스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State챕터10에필로그연출08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출08 : TriggerState {
            internal State챕터10에필로그연출08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001820, arg3: "$52000087_QD__52000087_TRIGGER__31$", arg4: 9);
                context.SetOnetimeEffect(id: 2009, enable: true, path: @"BG/Common/Sound/Eff_Madria_Chapter10_End_03_00002009.xml");
                context.SetSkip(arg1: "챕터10에필로그연출08스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new State챕터10에필로그연출08스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출08스킵 : TriggerState {
            internal State챕터10에필로그연출08스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State챕터10에필로그연출09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출09 : TriggerState {
            internal State챕터10에필로그연출09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52000087_QD__52000087_TRIGGER__32$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State챕터10에필로그연출10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출10 : TriggerState {
            internal State챕터10에필로그연출10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 11001820, arg3: "$52000087_QD__52000087_TRIGGER__33$", arg4: 5);
                context.SetOnetimeEffect(id: 2010, enable: true, path: @"BG/Common/Sound/Eff_Madria_Chapter10_End_04_00002010.xml");
                context.SetSkip(arg1: "챕터10에필로그연출10스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State챕터10에필로그연출10스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출10스킵 : TriggerState {
            internal State챕터10에필로그연출10스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State챕터10에필로그연출11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출11 : TriggerState {
            internal State챕터10에필로그연출11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001820, arg3: "$52000087_QD__52000087_TRIGGER__34$", arg4: 5);
                context.SetOnetimeEffect(id: 2011, enable: true, path: @"BG/Common/Sound/Eff_Madria_Chapter10_End_05_00002011.xml");
                context.SetSkip(arg1: "챕터10에필로그연출11스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State챕터10에필로그연출11스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출11스킵 : TriggerState {
            internal State챕터10에필로그연출11스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State챕터10에필로그연출12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출12 : TriggerState {
            internal State챕터10에필로그연출12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52000087_QD__52000087_TRIGGER__35$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State챕터10에필로그연출13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출13 : TriggerState {
            internal State챕터10에필로그연출13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52000087_QD__52000087_TRIGGER__36$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State챕터10에필로그연출13_b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출13_b : TriggerState {
            internal State챕터10에필로그연출13_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 11001820, arg3: "$52000087_QD__52000087_TRIGGER__37$", arg4: 5);
                context.SetOnetimeEffect(id: 2012, enable: true, path: @"BG/Common/Sound/Eff_Madria_Chapter10_End_06_00002012.xml");
                context.SetSkip(arg1: "챕터10에필로그연출13b스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State챕터10에필로그연출13b스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출13b스킵 : TriggerState {
            internal State챕터10에필로그연출13b스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State챕터10에필로그연출14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출14 : TriggerState {
            internal State챕터10에필로그연출14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001820, arg3: "$52000087_QD__52000087_TRIGGER__38$", arg4: 5);
                context.SetOnetimeEffect(id: 2013, enable: true, path: @"BG/Common/Sound/Eff_Madria_Chapter10_End_07_00002013.xml");
                context.SetSkip(arg1: "챕터10에필로그연출14스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State챕터10에필로그연출14스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출14스킵 : TriggerState {
            internal State챕터10에필로그연출14스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State챕터10에필로그연출15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출15 : TriggerState {
            internal State챕터10에필로그연출15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001820, arg3: "$52000087_QD__52000087_TRIGGER__39$", arg4: 6);
                context.SetOnetimeEffect(id: 2014, enable: true, path: @"BG/Common/Sound/Eff_Madria_Chapter10_End_08_00002014.xml");
                context.SetSkip(arg1: "챕터10에필로그연출15스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State챕터10에필로그연출15스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출15스킵 : TriggerState {
            internal State챕터10에필로그연출15스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State챕터10에필로그연출16(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출16 : TriggerState {
            internal State챕터10에필로그연출16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001820, arg3: "$52000087_QD__52000087_TRIGGER__40$", arg4: 5);
                context.SetOnetimeEffect(id: 2015, enable: true, path: @"BG/Common/Sound/Eff_Madria_Chapter10_End_09_00002015.xml");
                context.SetSkip(arg1: "챕터10에필로그연출16스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State챕터10에필로그연출16스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출16스킵 : TriggerState {
            internal State챕터10에필로그연출16스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State챕터10에필로그연출17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출17 : TriggerState {
            internal State챕터10에필로그연출17(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State챕터10에필로그연출18(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출18 : TriggerState {
            internal State챕터10에필로그연출18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52000087_QD__52000087_TRIGGER__41$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State챕터10에필로그연출18b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출18b : TriggerState {
            internal State챕터10에필로그연출18b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52000087_QD__52000087_TRIGGER__42$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State챕터10에필로그연출19(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출19 : TriggerState {
            internal State챕터10에필로그연출19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52000087_QD__52000087_TRIGGER__43$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State챕터10에필로그연출20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출20 : TriggerState {
            internal State챕터10에필로그연출20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52000087_QD__52000087_TRIGGER__44$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State챕터10에필로그연출21(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출21 : TriggerState {
            internal State챕터10에필로그연출21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52000087_QD__52000087_TRIGGER__45$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State챕터10에필로그연출22(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출22 : TriggerState {
            internal State챕터10에필로그연출22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.MoveUser(arg1: 02000025, arg2: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}