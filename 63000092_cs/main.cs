namespace Maple2.Trigger._63000092_cs {
    public static class _main {
        public class State날짜체크 : TriggerState {
            internal State날짜체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DayOfWeek(dayOfWeeks: new byte[]{3}, description: "1(일)-7(토)")) {
                    return new State만남(context);
                }

                if (context.DayOfWeek(dayOfWeeks: new byte[]{1, 2, 4, 5, 6, 7}, description: "1(일)-7(토)")) {
                    return new State헤어짐(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State만남 : TriggerState {
            internal State만남(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{111, 112});
                context.CreateMonster(spawnIds: new []{121, 122}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.DayOfWeek(dayOfWeeks: new byte[]{1, 2, 4, 5, 6, 7}, description: "1(일)-7(토)")) {
                    return new State헤어짐(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State헤어짐 : TriggerState {
            internal State헤어짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{121, 122});
                context.CreateMonster(spawnIds: new []{111, 112}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.DayOfWeek(dayOfWeeks: new byte[]{3}, description: "1(일)-7(토)")) {
                    return new State만남(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
