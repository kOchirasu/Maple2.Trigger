namespace Maple2.Trigger._02020098_bf {
    public static class _barricade {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {10})) {
                    return new State칸막이Wait시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칸막이Wait시작 : TriggerState {
            internal State칸막이Wait시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State칸막이Wait알림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칸막이Wait알림 : TriggerState {
            internal State칸막이Wait알림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02020098_BF__BARRICADE__0$", arg3: 3000);
                context.DungeonEnableGiveUp(isEnable: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 22000)) {
                    return new State칸막이막기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칸막이막기 : TriggerState {
            internal State칸막이막기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311}, arg2: true, arg3: 1, arg4: 120, arg5: 0.5f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTrigger종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger종료 : TriggerState {
            internal StateTrigger종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}