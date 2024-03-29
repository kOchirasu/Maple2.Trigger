namespace Maple2.Trigger._02100009_bf {
    public static class _resurrection_1 {
        public class StateUserDetection : TriggerState {
            internal StateUserDetection(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    return new StateBattleStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart : TriggerState {
            internal StateBattleStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{100000001}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterInCombat(spawnIds: new []{100000001})) {
                    return new StateBuff(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff : TriggerState {
            internal StateBuff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{100000001}, skillId: 50000196, level: 1, arg4: true, arg5: false);
                context.AddBuff(boxIds: new []{100000001}, skillId: 50000200, level: 1, arg4: true, arg5: false);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.GetNpcHpRate(spawnId: 100000001) <= 0.5f) {
                    return new StateMonster기절_2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.AddBuff(boxIds: new []{100000001}, skillId: 50000229, level: 1, arg4: true, arg5: false);
                context.AddBuff(boxIds: new []{100000001}, skillId: 50000207, level: 1, arg4: true, arg5: false);
                context.AddBuff(boxIds: new []{100000001}, skillId: 50000216, level: 1, arg4: true, arg5: false);
            }
        }

        private class StateMonster기절_2 : TriggerState {
            internal StateMonster기절_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 9900, type: "trigger", code: "02100009_1");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6800)) {
                    return new StateMonster부활(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster부활 : TriggerState {
            internal StateMonster부활(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{100000001}, skillId: 50000204, level: 1, arg4: true, arg5: false);
                context.AddBuff(boxIds: new []{100000001}, skillId: 50000196, level: 1, arg4: true, arg5: false);
                context.AddBuff(boxIds: new []{100000001}, skillId: 50000200, level: 1, arg4: true, arg5: false);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.GetNpcHpRate(spawnId: 100000001) > 0.5f) {
                    return new StateMonster부활_2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.AddBuff(boxIds: new []{100000001}, skillId: 50000228, level: 1, arg4: true, arg5: false);
            }
        }

        private class StateMonster부활_2 : TriggerState {
            internal StateMonster부활_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "MonsterDown", value: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State체력조건달성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
