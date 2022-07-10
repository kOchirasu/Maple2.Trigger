namespace Maple2.Trigger._63000076_cs {
    public static class _63000076_interact_1395 {
        public class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{116, 117}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001395}, arg2: 0)) {
                    return new State1395화난요정_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1395화난요정_01 : TriggerState {
            internal State1395화난요정_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{116, 117});
                context.CreateMonster(spawnIds: new []{216, 217}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{216, 217})) {
                    return new State1395화난요정_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1395화난요정_02 : TriggerState {
            internal State1395화난요정_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State1395화난요정_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1395화난요정_03 : TriggerState {
            internal State1395화난요정_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{116, 117}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateEnd(context);
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
