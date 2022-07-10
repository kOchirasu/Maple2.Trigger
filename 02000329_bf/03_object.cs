namespace Maple2.Trigger._02000329_bf {
    public static class _03_object {
        public class State오브젝트_03 : TriggerState {
            internal State오브젝트_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1103, 1104})) {
                    return new State오브젝트_03_작동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오브젝트_03_작동 : TriggerState {
            internal State오브젝트_03_작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{10001}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{103})) {
                    return new State오브젝트_03_작동_메세지(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오브젝트_03_작동_메세지 : TriggerState {
            internal State오브젝트_03_작동_메세지(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
