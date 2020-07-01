namespace Maple2.Trigger._52020027_qd {
    public static class _52020027_boss {
        public class State감지 : TriggerState {
            internal State감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "Boss") == 1) {
                    context.State = new State1페이즈(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1페이즈 : TriggerState {
            internal State1페이즈(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "SerihaAI") == 1) {
                    context.State = new State도약(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도약 : TriggerState {
            internal State도약(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 903, arg2: new[] {111})) {
                    context.State = new State2페이즈(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2페이즈 : TriggerState {
            internal State2페이즈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 111, arg3: "조심하는 게 좋을걸?", arg4: 4);
                context.CreateMonster(arg1: new[] {112, 113, 114, 115}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateNPC애니세팅(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC애니세팅 : TriggerState {
            internal StateNPC애니세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 114, arg2: "Attack_01_A", arg3: 2000f);
                context.SetNpcEmotionLoop(arg1: 115, arg2: "Attack_01_A", arg3: 2000f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}