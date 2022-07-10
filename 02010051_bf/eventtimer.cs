namespace Maple2.Trigger._02010051_bf {
    public static class _eventtimer {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9003})) {
                    return new State시간체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시간체크 : TriggerState {
            internal State시간체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "timercheck") == 1) {
                    return new StateAchievement(context);
                }

                if (context.WaitTick(waitTick: 240000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAchievement : TriggerState {
            internal StateAchievement(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 9003, type: "trigger", code: "CaboTimeEvent");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateAchievement(context);
                }

                if (context.MonsterDead(spawnIds: new []{99})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
