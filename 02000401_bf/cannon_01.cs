namespace Maple2.Trigger._02000401_bf {
    public static class _cannon_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{691}, visible: false);
                context.SetMesh(triggerIds: new []{3901}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "cannon01") == 1) {
                    return new StateCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation : TriggerState {
            internal StateCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2901}, arg2: true);
                context.AddBuff(boxIds: new []{2901}, skillId: 40444001, level: 1, arg4: true, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2901})) {
                    context.SetEffect(triggerIds: new []{691}, visible: true);
                    context.SetMesh(triggerIds: new []{3901}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
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
