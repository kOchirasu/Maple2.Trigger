namespace Maple2.Trigger._52100300_qd {
    public static class _monsterspawn {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990001, key: "SpawnRoomEnd", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Spawn") == 1) {
                    context.State = new State스폰1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스폰1 : TriggerState {
            internal State스폰1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {111, 121, 131, 141}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new State스폰2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스폰2 : TriggerState {
            internal State스폰2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {112, 122, 132, 142}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new State스폰5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스폰3 : TriggerState {
            internal State스폰3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {113, 123, 133, 143}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new State스폰4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스폰4 : TriggerState {
            internal State스폰4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {114, 124, 134, 144}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 13000)) {
                    context.State = new State스폰5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스폰5 : TriggerState {
            internal State스폰5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {115, 125, 135, 145}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {
                    111, 112, 113, 114, 115, 121, 122, 123, 124, 125, 131, 132, 133, 134, 135, 141, 142, 143, 144, 145
                })) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990001, key: "SpawnRoomEnd", value: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}