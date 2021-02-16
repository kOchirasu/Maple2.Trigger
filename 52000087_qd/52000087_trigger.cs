using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000087_qd {
    public static class _52000087_trigger {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 10, visible: false, enabled: false, minimapVisible: false);
                context.SetEffect(arg1: new[] {600}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {22651}, arg2: new[] {20002266}, arg3: new byte[] {3})) {
                    return new State용무없는유저는아웃(context);
                }

                if (context.QuestUserDetected(arg1: new[] {22651}, arg2: new[] {10002781}, arg3: new byte[] {1})) {
                    return new State카르카르시작(context);
                }

                if (context.QuestUserDetected(arg1: new[] {22651}, arg2: new[] {20002265}, arg3: new byte[] {3})) {
                    return new State20002265_완료Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카르카르시작 : TriggerState {
            internal State카르카르시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State진행(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행 : TriggerState {
            internal State진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State에레브_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에레브_1 : TriggerState {
            internal State에레브_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000075, script: "$52000087_QD__52000087_TRIGGER__0$", arg4: 3);
                context.SetSkip(state: new State에레브_1skip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State에레브_1skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에레브_1skip : TriggerState {
            internal State에레브_1skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State에레브_2(context);
            }

            public override void OnExit() { }
        }

        private class State에레브_2 : TriggerState {
            internal State에레브_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000075, script: "$52000087_QD__52000087_TRIGGER__1$", arg4: 5);
                context.SetSkip(state: new State에레브_2skip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State에레브_2skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에레브_2skip : TriggerState {
            internal State에레브_2skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State에레브_3(context);
            }

            public override void OnExit() { }
        }

        private class State에레브_3 : TriggerState {
            internal State에레브_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000075, script: "$52000087_QD__52000087_TRIGGER__2$", arg4: 5);
                context.SetSkip(state: new State에레브_3skip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State에레브_3skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에레브_3skip : TriggerState {
            internal State에레브_3skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State블랙아이_1(context);
            }

            public override void OnExit() { }
        }

        private class State블랙아이_1 : TriggerState {
            internal State블랙아이_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000006, script: "$52000087_QD__52000087_TRIGGER__3$", arg4: 3);
                context.SetSkip(state: new State블랙아이_1skip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State블랙아이_1skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State블랙아이_1skip : TriggerState {
            internal State블랙아이_1skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State블랙아이_1a(context);
            }

            public override void OnExit() { }
        }

        private class State블랙아이_1a : TriggerState {
            internal State블랙아이_1a(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000006, script: "$52000087_QD__52000087_TRIGGER__4$", arg4: 5);
                context.SetSkip(state: new State블랙아이_1askip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State블랙아이_1askip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State블랙아이_1askip : TriggerState {
            internal State블랙아이_1askip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State프레이_1(context);
            }

            public override void OnExit() { }
        }

        private class State프레이_1 : TriggerState {
            internal State프레이_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000119, script: "$52000087_QD__52000087_TRIGGER__5$", arg4: 5);
                context.SetSkip(state: new State프레이_1skip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State프레이_1skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프레이_1skip : TriggerState {
            internal State프레이_1skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State구르는천둥_1(context);
            }

            public override void OnExit() { }
        }

        private class State구르는천둥_1 : TriggerState {
            internal State구르는천둥_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001581, script: "$52000087_QD__52000087_TRIGGER__6$", arg4: 3);
                context.SetSkip(state: new State구르는천둥_1skip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State구르는천둥_1skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State구르는천둥_1skip : TriggerState {
            internal State구르는천둥_1skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State알론_1(context);
            }

            public override void OnExit() { }
        }

        private class State알론_1 : TriggerState {
            internal State알론_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000076, script: "$52000087_QD__52000087_TRIGGER__7$", arg4: 3);
                context.SetSkip(state: new State알론_1skip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State알론_1skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State알론_1skip : TriggerState {
            internal State알론_1skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State오스칼_1(context);
            }

            public override void OnExit() { }
        }

        private class State오스칼_1 : TriggerState {
            internal State오스칼_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000015, script: "$52000087_QD__52000087_TRIGGER__8$", arg4: 5);
                context.SetSkip(state: new State오스칼_1skip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State오스칼_1skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼_1skip : TriggerState {
            internal State오스칼_1skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State블랙아이_2(context);
            }

            public override void OnExit() { }
        }

        private class State블랙아이_2 : TriggerState {
            internal State블랙아이_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000006, script: "$52000087_QD__52000087_TRIGGER__9$", arg4: 5);
                context.SetSkip(state: new State블랙아이_2skip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State블랙아이_2skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State블랙아이_2skip : TriggerState {
            internal State블랙아이_2skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State블랙아이_2a(context);
            }

            public override void OnExit() { }
        }

        private class State블랙아이_2a : TriggerState {
            internal State블랙아이_2a(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000006, script: "$52000087_QD__52000087_TRIGGER__10$", arg4: 5);
                context.SetSkip(state: new State블랙아이_2askip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State블랙아이_2askip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State블랙아이_2askip : TriggerState {
            internal State블랙아이_2askip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State블랙아이_3(context);
            }

            public override void OnExit() { }
        }

        private class State블랙아이_3 : TriggerState {
            internal State블랙아이_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000006, script: "$52000087_QD__52000087_TRIGGER__11$", arg4: 5);
                context.SetSkip(state: new State블랙아이_3skip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State블랙아이_3skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State블랙아이_3skip : TriggerState {
            internal State블랙아이_3skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State알론_2(context);
            }

            public override void OnExit() { }
        }

        private class State알론_2 : TriggerState {
            internal State알론_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000076, script: "$52000087_QD__52000087_TRIGGER__12$", arg4: 3);
                context.SetSkip(state: new State알론_2skip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State알론_2skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State알론_2skip : TriggerState {
            internal State알론_2skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State에레브_4(context);
            }

            public override void OnExit() { }
        }

        private class State에레브_4 : TriggerState {
            internal State에레브_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000075, script: "$52000087_QD__52000087_TRIGGER__13$", arg4: 5);
                context.SetSkip(state: new State에레브_4skip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State에레브_4skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에레브_4skip : TriggerState {
            internal State에레브_4skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State영상Prepare(context);
            }

            public override void OnExit() { }
        }

        private class State영상Prepare : TriggerState {
            internal State영상Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetTimer(id: "21", arg2: 2);
                context.CameraSelectPath(pathIds: new[] {601, 602}, arg2: false);
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
                context.CreateWidget(type: WidgetType.SceneMovie);
                context.WidgetAction(type: WidgetType.SceneMovie, name: "Clear");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.PlaySceneMovie(fileName: "lumieragonhistory.swf", movieId: 1);
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {102}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, arg2: "IsStop", arg3: "1")) {
                    return new State알론_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State알론_3 : TriggerState {
            internal State알론_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(arg1: 2, arg2: 11000076, script: "$52000087_QD__52000087_TRIGGER__14$", arg4: 5);
                context.SetSkip(state: new State알론_3skip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State알론_3skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State알론_3skip : TriggerState {
            internal State알론_3skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State알론_4(context);
            }

            public override void OnExit() { }
        }

        private class State알론_4 : TriggerState {
            internal State알론_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(arg1: 2, arg2: 11000076, script: "$52000087_QD__52000087_TRIGGER__15$", arg4: 5);
                context.SetSkip(state: new State알론_4skip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State알론_4skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State알론_4skip : TriggerState {
            internal State알론_4skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State알론_4a(context);
            }

            public override void OnExit() { }
        }

        private class State알론_4a : TriggerState {
            internal State알론_4a(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(arg1: 2, arg2: 11000076, script: "$52000087_QD__52000087_TRIGGER__16$", arg4: 5);
                context.SetSkip(state: new State알론_4askip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State알론_4askip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State알론_4askip : TriggerState {
            internal State알론_4askip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State알론_5(context);
            }

            public override void OnExit() { }
        }

        private class State알론_5 : TriggerState {
            internal State알론_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(arg1: 2, arg2: 11000076, script: "$52000087_QD__52000087_TRIGGER__17$", arg4: 5);
                context.SetSkip(state: new State알론_5skip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State알론_5skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State알론_5skip : TriggerState {
            internal State알론_5skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State에레브_5(context);
            }

            public override void OnExit() { }
        }

        private class State에레브_5 : TriggerState {
            internal State에레브_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000075, script: "$52000087_QD__52000087_TRIGGER__18$", arg4: 5);
                context.SetSkip(state: new State에레브_5skip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State에레브_5skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에레브_5skip : TriggerState {
            internal State에레브_5skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State에레브_6(context);
            }

            public override void OnExit() { }
        }

        private class State에레브_6 : TriggerState {
            internal State에레브_6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000075, script: "$52000087_QD__52000087_TRIGGER__19$", arg4: 5);
                context.SetSkip(state: new State에레브_6skip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State에레브_6skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에레브_6skip : TriggerState {
            internal State에레브_6skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State칼_1(context);
            }

            public override void OnExit() { }
        }

        private class State칼_1 : TriggerState {
            internal State칼_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000074, script: "$52000087_QD__52000087_TRIGGER__20$", arg4: 5);
                context.SetSkip(state: new State칼_1skip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State칼_1skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칼_1skip : TriggerState {
            internal State칼_1skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State에레브_7(context);
            }

            public override void OnExit() { }
        }

        private class State에레브_7 : TriggerState {
            internal State에레브_7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000075, script: "$52000087_QD__52000087_TRIGGER__21$", arg4: 5);
                context.SetSkip(state: new State에레브_7skip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State에레브_7skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에레브_7skip : TriggerState {
            internal State에레브_7skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State에레브_8(context);
            }

            public override void OnExit() { }
        }

        private class State에레브_8 : TriggerState {
            internal State에레브_8(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000075, script: "$52000087_QD__52000087_TRIGGER__22$", arg4: 5);
                context.SetSkip(state: new State에레브_8skip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State에레브_8skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에레브_8skip : TriggerState {
            internal State에레브_8skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 22651, arg2: "trigger", arg3: "Lumieragon_History");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State20002265_완료Cinematic01 : TriggerState {
            internal State20002265_완료Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.MoveUser(arg1: 52000087, arg2: 10);
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State20002265_완료Cinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20002265_완료Cinematic02 : TriggerState {
            internal State20002265_완료Cinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new[] {2002, 2003, 2004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State20002265_완료Cinematic03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20002265_완료Cinematic03 : TriggerState {
            internal State20002265_완료Cinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {600}, arg2: true);
                context.CreateMonster(arg1: new[] {1003}, arg2: false);
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_Start");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State20002265_완료Cinematic04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20002265_완료Cinematic04 : TriggerState {
            internal State20002265_완료Cinematic04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 3);
                context.SetNpcEmotionSequence(arg1: 1003, arg2: "Bore_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State20002265_완료Cinematic04_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20002265_완료Cinematic04_b : TriggerState {
            internal State20002265_완료Cinematic04_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003087, script: "$52000087_QD__52000087_TRIGGER__23$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State20002265_완료Cinematic04_c(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20002265_완료Cinematic04_c : TriggerState {
            internal State20002265_완료Cinematic04_c(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 1003, arg2: "ChatUp_A");
                context.SetConversation(arg1: 2, arg2: 11003087, script: "$52000087_QD__52000087_TRIGGER__24$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State20002265_완료Cinematic05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20002265_완료Cinematic05 : TriggerState {
            internal State20002265_완료Cinematic05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {600}, arg2: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 2.0f);
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_Orde");
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {22651}, arg2: new[] {20002266}, arg3: new byte[] {3})) {
                    return new State20002266_완료Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20002266_완료Cinematic01_난입 : TriggerState {
            internal State20002266_완료Cinematic01_난입(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State20002266_완료Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20002266_완료Cinematic01 : TriggerState {
            internal State20002266_완료Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUser(arg1: 52000087, arg2: 10);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State20002266_완료Cinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20002266_완료Cinematic02 : TriggerState {
            internal State20002266_완료Cinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new[] {2005, 2006}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State20002266_완료Cinematic03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20002266_완료Cinematic03 : TriggerState {
            internal State20002266_완료Cinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003087, script: "$52000087_QD__52000087_TRIGGER__25$", arg4: 3);
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_OrdeOut");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State20002266_완료Cinematic04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20002266_완료Cinematic04 : TriggerState {
            internal State20002266_완료Cinematic04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 500, visible: true, enabled: true, minimapVisible: true);
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.DestroyMonster(arg1: new[] {1003});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State20002266_완료Cinematic05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20002266_완료Cinematic05 : TriggerState {
            internal State20002266_완료Cinematic05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 1.0f);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State용무없는유저는아웃 : TriggerState {
            internal State용무없는유저는아웃(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {22651}, arg2: new[] {20002285}, arg3: new byte[] {3})) {
                    return new State챕터10에필로그Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그Cinematic01 : TriggerState {
            internal State챕터10에필로그Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.MoveUser(arg1: 52000087, arg2: 10);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State챕터10에필로그Cinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그Cinematic02 : TriggerState {
            internal State챕터10에필로그Cinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52000087_QD__52000087_TRIGGER__26$");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State챕터10에필로그Cinematic03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그Cinematic03 : TriggerState {
            internal State챕터10에필로그Cinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52000087_QD__52000087_TRIGGER__27$");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State챕터10에필로그Cinematic05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그Cinematic05 : TriggerState {
            internal State챕터10에필로그Cinematic05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52000087_QD__52000087_TRIGGER__28$");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State챕터10에필로그Cinematic05b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그Cinematic05b : TriggerState {
            internal State챕터10에필로그Cinematic05b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State챕터10에필로그Cinematic06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그Cinematic06 : TriggerState {
            internal State챕터10에필로그Cinematic06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 90000, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001820, script: "$52000087_QD__52000087_TRIGGER__29$", arg4: 6);
                context.SetOnetimeEffect(id: 2007, enable: true, path: @"BG/Common/Sound/Eff_Madria_Chapter10_End_01_00002007.xml");
                context.SetSkip(state: new State챕터10에필로그Cinematic06스킵(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State챕터10에필로그Cinematic06스킵(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그Cinematic06스킵 : TriggerState {
            internal State챕터10에필로그Cinematic06스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State챕터10에필로그Cinematic07(context);
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그Cinematic07 : TriggerState {
            internal State챕터10에필로그Cinematic07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001820, script: "$52000087_QD__52000087_TRIGGER__30$", arg4: 6);
                context.SetOnetimeEffect(id: 2008, enable: true, path: @"BG/Common/Sound/Eff_Madria_Chapter10_End_02_00002008.xml");
                context.SetSkip(state: new State챕터10에필로그Cinematic07스킵(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State챕터10에필로그Cinematic07스킵(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그Cinematic07스킵 : TriggerState {
            internal State챕터10에필로그Cinematic07스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State챕터10에필로그Cinematic08(context);
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그Cinematic08 : TriggerState {
            internal State챕터10에필로그Cinematic08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001820, script: "$52000087_QD__52000087_TRIGGER__31$", arg4: 9);
                context.SetOnetimeEffect(id: 2009, enable: true, path: @"BG/Common/Sound/Eff_Madria_Chapter10_End_03_00002009.xml");
                context.SetSkip(state: new State챕터10에필로그Cinematic08스킵(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new State챕터10에필로그Cinematic08스킵(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그Cinematic08스킵 : TriggerState {
            internal State챕터10에필로그Cinematic08스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State챕터10에필로그Cinematic09(context);
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그Cinematic09 : TriggerState {
            internal State챕터10에필로그Cinematic09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52000087_QD__52000087_TRIGGER__32$");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State챕터10에필로그Cinematic10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그Cinematic10 : TriggerState {
            internal State챕터10에필로그Cinematic10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(arg1: 2, arg2: 11001820, script: "$52000087_QD__52000087_TRIGGER__33$", arg4: 5);
                context.SetOnetimeEffect(id: 2010, enable: true, path: @"BG/Common/Sound/Eff_Madria_Chapter10_End_04_00002010.xml");
                context.SetSkip(state: new State챕터10에필로그Cinematic10스킵(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State챕터10에필로그Cinematic10스킵(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그Cinematic10스킵 : TriggerState {
            internal State챕터10에필로그Cinematic10스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State챕터10에필로그Cinematic11(context);
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그Cinematic11 : TriggerState {
            internal State챕터10에필로그Cinematic11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001820, script: "$52000087_QD__52000087_TRIGGER__34$", arg4: 5);
                context.SetOnetimeEffect(id: 2011, enable: true, path: @"BG/Common/Sound/Eff_Madria_Chapter10_End_05_00002011.xml");
                context.SetSkip(state: new State챕터10에필로그Cinematic11스킵(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State챕터10에필로그Cinematic11스킵(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그Cinematic11스킵 : TriggerState {
            internal State챕터10에필로그Cinematic11스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State챕터10에필로그Cinematic12(context);
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그Cinematic12 : TriggerState {
            internal State챕터10에필로그Cinematic12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52000087_QD__52000087_TRIGGER__35$");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State챕터10에필로그Cinematic13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그Cinematic13 : TriggerState {
            internal State챕터10에필로그Cinematic13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52000087_QD__52000087_TRIGGER__36$");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State챕터10에필로그Cinematic13_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그Cinematic13_b : TriggerState {
            internal State챕터10에필로그Cinematic13_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(arg1: 2, arg2: 11001820, script: "$52000087_QD__52000087_TRIGGER__37$", arg4: 5);
                context.SetOnetimeEffect(id: 2012, enable: true, path: @"BG/Common/Sound/Eff_Madria_Chapter10_End_06_00002012.xml");
                context.SetSkip(state: new State챕터10에필로그Cinematic13b스킵(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State챕터10에필로그Cinematic13b스킵(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그Cinematic13b스킵 : TriggerState {
            internal State챕터10에필로그Cinematic13b스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State챕터10에필로그Cinematic14(context);
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그Cinematic14 : TriggerState {
            internal State챕터10에필로그Cinematic14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001820, script: "$52000087_QD__52000087_TRIGGER__38$", arg4: 5);
                context.SetOnetimeEffect(id: 2013, enable: true, path: @"BG/Common/Sound/Eff_Madria_Chapter10_End_07_00002013.xml");
                context.SetSkip(state: new State챕터10에필로그Cinematic14스킵(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State챕터10에필로그Cinematic14스킵(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그Cinematic14스킵 : TriggerState {
            internal State챕터10에필로그Cinematic14스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State챕터10에필로그Cinematic15(context);
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그Cinematic15 : TriggerState {
            internal State챕터10에필로그Cinematic15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001820, script: "$52000087_QD__52000087_TRIGGER__39$", arg4: 6);
                context.SetOnetimeEffect(id: 2014, enable: true, path: @"BG/Common/Sound/Eff_Madria_Chapter10_End_08_00002014.xml");
                context.SetSkip(state: new State챕터10에필로그Cinematic15스킵(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State챕터10에필로그Cinematic15스킵(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그Cinematic15스킵 : TriggerState {
            internal State챕터10에필로그Cinematic15스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State챕터10에필로그Cinematic16(context);
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그Cinematic16 : TriggerState {
            internal State챕터10에필로그Cinematic16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001820, script: "$52000087_QD__52000087_TRIGGER__40$", arg4: 5);
                context.SetOnetimeEffect(id: 2015, enable: true, path: @"BG/Common/Sound/Eff_Madria_Chapter10_End_09_00002015.xml");
                context.SetSkip(state: new State챕터10에필로그Cinematic16스킵(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State챕터10에필로그Cinematic16스킵(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그Cinematic16스킵 : TriggerState {
            internal State챕터10에필로그Cinematic16스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State챕터10에필로그Cinematic17(context);
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그Cinematic17 : TriggerState {
            internal State챕터10에필로그Cinematic17(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State챕터10에필로그Cinematic18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그Cinematic18 : TriggerState {
            internal State챕터10에필로그Cinematic18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52000087_QD__52000087_TRIGGER__41$");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State챕터10에필로그Cinematic18b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그Cinematic18b : TriggerState {
            internal State챕터10에필로그Cinematic18b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52000087_QD__52000087_TRIGGER__42$");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State챕터10에필로그Cinematic19(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그Cinematic19 : TriggerState {
            internal State챕터10에필로그Cinematic19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52000087_QD__52000087_TRIGGER__43$");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State챕터10에필로그Cinematic20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그Cinematic20 : TriggerState {
            internal State챕터10에필로그Cinematic20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52000087_QD__52000087_TRIGGER__44$");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State챕터10에필로그Cinematic21(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그Cinematic21 : TriggerState {
            internal State챕터10에필로그Cinematic21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52000087_QD__52000087_TRIGGER__45$");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State챕터10에필로그Cinematic22(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그Cinematic22 : TriggerState {
            internal State챕터10에필로그Cinematic22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.MoveUser(arg1: 02000025, arg2: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}