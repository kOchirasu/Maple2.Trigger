namespace Maple2.Trigger._52010018_qd {
    public static class _main_3 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1001, 1005}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new State분기점(context);
            }

            public override void OnExit() { }
        }

        private class State분기점 : TriggerState {
            internal State분기점(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{100}, questIds: new []{10002851}, questStates: new byte[]{2})) {
                    context.DestroyMonster(spawnIds: new []{1005});
                    return new StateEnd(context);
                }

                if (context.QuestUserDetected(boxIds: new []{100}, questIds: new []{10002852}, questStates: new byte[]{1})) {
                    context.DestroyMonster(spawnIds: new []{1005});
                    return new StateEnd(context);
                }

                if (context.QuestUserDetected(boxIds: new []{100}, questIds: new []{10002853}, questStates: new byte[]{1})) {
                    context.DestroyMonster(spawnIds: new []{1005});
                    return new StateEnd(context);
                }

                if (context.QuestUserDetected(boxIds: new []{100}, questIds: new []{10002853}, questStates: new byte[]{2})) {
                    context.DestroyMonster(spawnIds: new []{1005});
                    return new StateEnd(context);
                }

                if (context.QuestUserDetected(boxIds: new []{100}, questIds: new []{10002851}, questStates: new byte[]{3})) {
                    return new State분기점2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State분기점2 : TriggerState {
            internal State분기점2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{100}, questIds: new []{10002852}, questStates: new byte[]{2})) {
                    return new StateEnd(context);
                }

                if (context.QuestUserDetected(boxIds: new []{100}, questIds: new []{10002852}, questStates: new byte[]{3})) {
                    return new StateEnd(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{100}, questIds: new []{10002852}, questStates: new byte[]{2})) {
                    context.DestroyMonster(spawnIds: new []{1005});
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
