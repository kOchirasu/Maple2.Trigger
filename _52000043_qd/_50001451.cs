namespace Maple2.Trigger._52000043_qd {
    public static class _50001451 {
        public class State시작조건 : TriggerState {
            internal State시작조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: false);
                context.SetEffect(arg1: new[] {602}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001451},
                    arg3: new byte[] {1})) {
                    context.State = new State연출시작(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001451},
                    arg3: new byte[] {2})) {
                    context.State = new StateNPC만배치(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC만배치 : TriggerState {
            internal StateNPC만배치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1001, 2001}, arg2: false);
                context.SetMesh(
                    arg1: new[] {
                        3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015,
                        3016, 3017
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State종료(context);
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
                context.CreateMonster(arg1: new[] {1001, 2001}, arg2: false);
                context.SetMesh(
                    arg1: new[] {
                        3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015,
                        3016, 3017
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State카메라딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라딜레이 : TriggerState {
            internal State카메라딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State준타대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준타대사01 : TriggerState {
            internal State준타대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$52000043_QD__50001451__0$", arg4: 3);
                context.SetSkip(arg1: "준타대사01스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State틴차이대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준타대사01스킵 : TriggerState {
            internal State준타대사01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State틴차이대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State틴차이대사01 : TriggerState {
            internal State틴차이대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$52000043_QD__50001451__1$", arg4: 4);
                context.SetSkip(arg1: "틴차이대사01스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State준타대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State틴차이대사01스킵 : TriggerState {
            internal State틴차이대사01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State준타대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준타대사02 : TriggerState {
            internal State준타대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$52000043_QD__50001451__2$", arg4: 3);
                context.SetSkip(arg1: "준타대사02스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State준타대사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준타대사02스킵 : TriggerState {
            internal State준타대사02스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State준타대사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준타대사03 : TriggerState {
            internal State준타대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$52000043_QD__50001451__3$", arg4: 4);
                context.SetSkip(arg1: "준타대사03스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State틴차이대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준타대사03스킵 : TriggerState {
            internal State준타대사03스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State틴차이대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State틴차이대사02 : TriggerState {
            internal State틴차이대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$52000043_QD__50001451__4$", arg4: 5);
                context.SetSkip(arg1: "틴차이대사02스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State준타대사04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State틴차이대사02스킵 : TriggerState {
            internal State틴차이대사02스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State준타대사04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준타대사04 : TriggerState {
            internal State준타대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {602}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$52000043_QD__50001451__5$", arg4: 2);
                context.SetSkip(arg1: "준타대사04스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준타대사04스킵 : TriggerState {
            internal State준타대사04스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {602}, arg2: false);
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
                context.CameraSelect(arg1: 302, arg2: false);
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "gdworry");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State종료(context);
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