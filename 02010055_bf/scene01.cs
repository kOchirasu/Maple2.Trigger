namespace Maple2.Trigger._02010055_bf {
    public static class _scene01 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {699}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {105})) {
                    return new State바르칸트대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바르칸트대사 : TriggerState {
            internal State바르칸트대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(arg1: 301, arg2: true);
                context.SetEffect(arg1: new[] {699}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 23000068, script: "$02010055_BF__SCENE01__0$", arg4: 4);
                context.SetSkip(state: new State바르칸트Script2스킵(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State바르칸트Script2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바르칸트Script2스킵 : TriggerState {
            internal State바르칸트Script2스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State바르칸트Script2(context);
            }

            public override void OnExit() { }
        }

        private class State바르칸트Script2 : TriggerState {
            internal State바르칸트Script2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 301, arg2: true);
                context.SetEffect(arg1: new[] {699}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 23000068, script: "$02010055_BF__SCENE01__1$", arg4: 4);
                context.SetSkip(state: new StateEndPrepare(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndPrepare : TriggerState {
            internal StateEndPrepare(ITriggerContext context) : base(context) { }

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
                context.CameraSelect(arg1: 301, arg2: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}