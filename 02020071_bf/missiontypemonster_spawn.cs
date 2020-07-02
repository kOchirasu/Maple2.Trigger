namespace Maple2.Trigger._02020071_bf {
    public static class _missiontypemonster_spawn {
        public class State루프1 : TriggerState {
            internal State루프1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.StartCombineSpawn(groupId: new[] {520}, isStart: true);
                    return new State루프2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State루프2 : TriggerState {
            internal State루프2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 150000)) {
                    return new State루프3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State루프3 : TriggerState {
            internal State루프3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 150000)) {
                    return new State루프2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}