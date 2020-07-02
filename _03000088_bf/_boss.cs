namespace Maple2.Trigger._03000088_bf {
    public static class _boss {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {11000009}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    context.CreateMonster(arg1: new[] {2001}, arg2: false);
                    return new StateBossSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawn : TriggerState {
            internal StateBossSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 23000001, textId: 23000001, duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateBossSpawn(context);
                }

                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.HideGuideSummary(entityId: 23000001);
                    context.SetInteractObject(arg1: new[] {11000009}, arg2: 1);
                    context.SetEventUI(arg1: 7, arg3: 2000, arg4: "0");
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