namespace Maple2.Trigger._02020062_bf {
    public static class _battle_2 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990001, key: "ObjectClear", value: 0);
                context.SetUserValue(triggerId: 99990004, key: "ObjectStart", value: 0);
                context.SetUserValue(triggerId: 99990005, key: "ObjectStart", value: 0);
                context.SetUserValue(triggerId: 99990006, key: "ObjectStart", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "ObjectPhase") == 1) {
                    context.CreateMonster(arg1: new[] {811, 812, 821, 822, 831, 832}, arg2: false);
                    return new StateSummonObject(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSummonObject : TriggerState {
            internal StateSummonObject(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {711, 712, 713}, arg2: false);
                context.SetUserValue(triggerId: 99990004, key: "ObjectStart", value: 1);
                context.SetUserValue(triggerId: 99990005, key: "ObjectStart", value: 1);
                context.SetUserValue(triggerId: 99990006, key: "ObjectStart", value: 1);
                context.SetUserValue(triggerId: 99990024, key: "MovePanel01", value: 1);
                context.SetUserValue(triggerId: 99990025, key: "MovePanel02", value: 1);
                context.SetUserValue(triggerId: 99990026, key: "MovePanel03", value: 1);
                context.SetUserValue(triggerId: 99990027, key: "MovePanel04", value: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "ObjectPhase") == 2) {
                    return new StateWait(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new State추가Script_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State추가Script_1 : TriggerState {
            internal State추가Script_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcId: 11001813, illust: "Turka_normal", duration: 5000, script: "$02020062_BF__BATTLE_2__0$");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "ObjectPhase") == 2) {
                    return new StateWait(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new State추가Script_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State추가Script_2 : TriggerState {
            internal State추가Script_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcId: 11003536, illust: "Neirin_surprise", duration: 5000, script: "$02020062_BF__BATTLE_2__1$");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "ObjectPhase") == 2) {
                    return new StateWait(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new State추가Script_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State추가Script_3 : TriggerState {
            internal State추가Script_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcId: 11003533, illust: "Bliche_normal", duration: 5000, script: "$02020062_BF__BATTLE_2__2$");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "ObjectPhase") == 2) {
                    return new StateWait(context);
                }

                if (context.MonsterDead(arg1: new[] {701})) {
                    return new StateSummonObject_Clear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSummonObject_Clear : TriggerState {
            internal StateSummonObject_Clear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990001, key: "ObjectClear", value: 1);
                context.SetUserValue(triggerId: 99990004, key: "ObjectStart", value: 2);
                context.SetUserValue(triggerId: 99990005, key: "ObjectStart", value: 2);
                context.SetUserValue(triggerId: 99990006, key: "ObjectStart", value: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}