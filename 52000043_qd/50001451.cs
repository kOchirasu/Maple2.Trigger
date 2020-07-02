namespace Maple2.Trigger._52000043_qd {
    public static class _50001451 {
        public class StateStart조건 : TriggerState {
            internal StateStart조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601, 602}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001451}, arg3: new byte[] {1})) {
                    return new StateStartCinematic(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001451}, arg3: new byte[] {2})) {
                    return new StateNPC만배치(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC만배치 : TriggerState {
            internal StateNPC만배치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1001, 2001}, arg2: false);
                context.SetMesh(arg1: new[] {3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelect(arg1: 301, arg2: true);
                context.CreateMonster(arg1: new[] {1001, 2001}, arg2: false);
                context.SetMesh(arg1: new[] {3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraDelay : TriggerState {
            internal StateCameraDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State준타대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타대사01 : TriggerState {
            internal State준타대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$52000043_QD__50001451__0$", arg4: 3);
                context.SetSkip(arg1: "준타대사01스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State틴차이대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타대사01스킵 : TriggerState {
            internal State준타대사01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State틴차이대사01(context);
            }

            public override void OnExit() { }
        }

        private class State틴차이대사01 : TriggerState {
            internal State틴차이대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$52000043_QD__50001451__1$", arg4: 4);
                context.SetSkip(arg1: "틴차이대사01스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State준타대사02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State틴차이대사01스킵 : TriggerState {
            internal State틴차이대사01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State준타대사02(context);
            }

            public override void OnExit() { }
        }

        private class State준타대사02 : TriggerState {
            internal State준타대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$52000043_QD__50001451__2$", arg4: 3);
                context.SetSkip(arg1: "준타대사02스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State준타대사03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타대사02스킵 : TriggerState {
            internal State준타대사02스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State준타대사03(context);
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

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State틴차이대사02(context);
                }

                return null;
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

            public override TriggerState Execute() {
                return new State틴차이대사02(context);
            }

            public override void OnExit() { }
        }

        private class State틴차이대사02 : TriggerState {
            internal State틴차이대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$52000043_QD__50001451__4$", arg4: 5);
                context.SetSkip(arg1: "틴차이대사02스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State준타대사04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State틴차이대사02스킵 : TriggerState {
            internal State틴차이대사02스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State준타대사04(context);
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

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStopCinematic(context);
                }

                return null;
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

            public override TriggerState Execute() {
                return new StateStopCinematic(context);
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraSelect(arg1: 302, arg2: false);
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "gdworry");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}