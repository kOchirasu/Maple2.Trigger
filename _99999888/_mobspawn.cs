namespace Maple2.Trigger._99999888 {
    public static class _mobspawn {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 911) == 1) {
                    context.CreateMonster(arg1: new[] {101}, arg2: true);
                    return new StateMobCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobCreation : TriggerState {
            internal StateMobCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.CheckNpcAdditionalEffect(spawnPointId: 101, additionalEffectId: 50000900, level: 1)) {
                    context.DebugString(message: "버프가감지되었습니다. 20초 후 삭제합니다");
                    return new StateBuff삭제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff삭제 : TriggerState {
            internal StateBuff삭제(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.DebugString(message: "버프가 삭제되었습니다.");
                    context.NpcRemoveAdditionalEffect(spawnPointId: 101, additionalEffectId: 50000900);
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