namespace Maple2.Trigger._02000244_bf {
    public static class _trigger_04_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{707, 708}, visible: true);
                context.DestroyMonster(spawnIds: new []{613, 614, 615, 616, 617, 618, 619, 620, 621});
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{204})) {
                    return new StateMobCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobCreation : TriggerState {
            internal StateMobCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{613, 614, 615, 616, 617, 618, 619, 620, 621}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{613, 614, 615, 616, 617, 618, 619, 620, 621})) {
                    return new State통과(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000301}, arg2: 0)) {
                    return new State통과(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State통과 : TriggerState {
            internal State통과(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{707, 708}, visible: false);
                context.SetTimer(timerId: "1", seconds: 180);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
