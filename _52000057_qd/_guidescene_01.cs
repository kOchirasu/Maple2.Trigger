namespace Maple2.Trigger._52000057_qd {
    public static class _guidescene_01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1003}, arg2: false);
                context.SetEffect(arg1: new[] {601}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {90000611},
                    arg3: new byte[] {2})) {
                    context.State = new State오필리아리젠(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {90000611},
                    arg3: new byte[] {1})) {
                    context.State = new State오필리아리젠(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {90000610},
                    arg3: new byte[] {3})) {
                    context.State = new State오필리아리젠상시(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {90000610},
                    arg3: new byte[] {2})) {
                    context.State = new State오필리아리젠상시(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {90000610},
                    arg3: new byte[] {1})) {
                    context.State = new State연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작 : TriggerState {
            internal State연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 301, arg2: true);
                context.CreateMonster(arg1: new[] {1001}, arg2: false);
                context.SetEffect(arg1: new[] {601}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State말풍선대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State말풍선대사01 : TriggerState {
            internal State말풍선대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 198, arg2: new[] {1001})) {
                    context.State = new State시네마틱대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시네마틱대사01 : TriggerState {
            internal State시네마틱대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001871, arg3: "$52000057_QD__GUIdESCENE_01__0$", arg4: 2,
                    arg5: 0);
                context.SetConversation(arg1: 2, arg2: 11001871, arg3: "$52000057_QD__GUIdESCENE_01__1$", arg4: 3,
                    arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
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
                context.CameraSelect(arg1: 301, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State연퀘감지(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연퀘감지 : TriggerState {
            internal State연퀘감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {90000611},
                    arg3: new byte[] {1})) {
                    context.State = new State오필리아대사연출01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오필리아리젠 : TriggerState {
            internal State오필리아리젠(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State오필리아대사연출01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오필리아대사연출01 : TriggerState {
            internal State오필리아대사연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 11001871, arg3: "$52000057_QD__GUIdESCENE_01__2$", arg4: 2,
                    arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateSendSignalToGuide01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSendSignalToGuide01 : TriggerState {
            internal StateSendSignalToGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.GuideEvent(eventId: 60660);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오필리아리젠상시 : TriggerState {
            internal State오필리아리젠상시(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1002}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {90000611},
                    arg3: new byte[] {1})) {
                    context.State = new State오필리아대사연출01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}