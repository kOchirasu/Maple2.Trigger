namespace Maple2.Trigger._52020027_qd {
    public static class _52020027_boss {
        public class State감지 : TriggerState {
            internal State감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Boss") == 1) {
                    return new State1Phase(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1Phase : TriggerState {
            internal State1Phase(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "SerihaAI") == 1) {
                    return new State도약(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도약 : TriggerState {
            internal State도약(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 903, spawnIds: new []{111})) {
                    return new State2Phase(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Phase : TriggerState {
            internal State2Phase(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 111, script: "조심하는 게 좋을걸?", arg4: 4);
                context.CreateMonster(spawnIds: new []{112, 113, 114, 115}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateNPC애니세팅(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC애니세팅 : TriggerState {
            internal StateNPC애니세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 114, sequenceName: "Attack_01_A", duration: 2000f);
                context.SetNpcEmotionLoop(spawnId: 115, sequenceName: "Attack_01_A", duration: 2000f);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
