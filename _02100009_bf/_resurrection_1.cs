namespace Maple2.Trigger._02100009_bf {
    public static class _resurrection_1 {
        public class State유저감지 : TriggerState {
            internal State유저감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    return new State전투시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투시작 : TriggerState {
            internal State전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {100000001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterInCombat(arg1: new[] {100000001})) {
                    return new State버프(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버프 : TriggerState {
            internal State버프(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {100000001}, arg2: 50000196, arg3: 1, arg4: true, arg5: false);
                context.AddBuff(arg1: new[] {100000001}, arg2: 50000200, arg3: 1, arg4: true, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State체력조건달성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State체력조건달성 : TriggerState {
            internal State체력조건달성(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetNpcHpRate(spawnPointId: 100000001) <= 0.5f) {
                    return new State몬스터기절_2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.AddBuff(arg1: new[] {100000001}, arg2: 50000229, arg3: 1, arg4: true, arg5: false);
                context.AddBuff(arg1: new[] {100000001}, arg2: 50000207, arg3: 1, arg4: true, arg5: false);
                context.AddBuff(arg1: new[] {100000001}, arg2: 50000216, arg3: 1, arg4: true, arg5: false);
            }
        }

        private class State몬스터기절_2 : TriggerState {
            internal State몬스터기절_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 9900, arg2: "trigger", arg3: "02100009_1");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6800)) {
                    return new State몬스터부활(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몬스터부활 : TriggerState {
            internal State몬스터부활(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {100000001}, arg2: 50000204, arg3: 1, arg4: true, arg5: false);
                context.AddBuff(arg1: new[] {100000001}, arg2: 50000196, arg3: 1, arg4: true, arg5: false);
                context.AddBuff(arg1: new[] {100000001}, arg2: 50000200, arg3: 1, arg4: true, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State체력조건미달(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State체력조건미달 : TriggerState {
            internal State체력조건미달(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetNpcHpRate(spawnPointId: 100000001) > 0.5f) {
                    return new State몬스터부활_2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.AddBuff(arg1: new[] {100000001}, arg2: 50000228, arg3: 1, arg4: true, arg5: false);
            }
        }

        private class State몬스터부활_2 : TriggerState {
            internal State몬스터부활_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "MonsterDown", value: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State체력조건달성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}