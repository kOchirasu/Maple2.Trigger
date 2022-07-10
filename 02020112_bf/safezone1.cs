namespace Maple2.Trigger._02020112_bf {
    public static class _safezone1 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990002, key: "Safe", value: 0);
                context.SetInteractObject(interactIds: new []{10002117}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{902})) {
                    return new State감지(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State감지 : TriggerState {
            internal State감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 102, 103}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101, 102, 103})) {
                    return new State안전장치Enabled(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State안전장치Enabled : TriggerState {
            internal State안전장치Enabled(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002117}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10002117}, arg2: 0)) {
                    return new State안전장치_작동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State안전장치_작동 : TriggerState {
            internal State안전장치_작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02020112_BF__SAFEZONE1__0$", duration: 5000);
                context.SetUserValue(triggerId: 99990002, key: "Safe", value: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
