namespace Maple2.Trigger._02000368_bf {
    public static class _mob_05 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3005}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkill(triggerIds: new []{7501}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{1001})) {
                    return new State전투01(context);
                }

                if (context.UserDetected(boxIds: new []{1002})) {
                    return new State전투01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투01 : TriggerState {
            internal State전투01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{501, 511}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{501, 511})) {
                    return new State전투02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투02 : TriggerState {
            internal State전투02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3005}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkill(triggerIds: new []{7501}, arg2: true);
                context.CreateMonster(spawnIds: new []{502}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{502})) {
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
