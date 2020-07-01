namespace Maple2.Trigger._02000410_bf {
    public static class _resurrectionprohibition {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 750) == 1) {
                    return new State전투시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투시작 : TriggerState {
            internal State전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetDungeonPlayTime() == 420) {
                    return new State지금부터부활불가처리(context);
                }

                if (context.GetUserValue(key: "ThirdPhase") == 1) {
                    return new State지금부터부활불가처리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지금부터부활불가처리 : TriggerState {
            internal State지금부터부활불가처리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {750}, arg2: 70000073, arg3: 1, arg4: false);
                context.ShowGuideSummary(entityId: 20041001, textId: 20041001);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20041001);
            }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}