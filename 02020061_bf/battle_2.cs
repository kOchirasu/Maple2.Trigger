using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02020061_bf {
    public static class _battle_2 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990001, key: "ObjectClear", value: 0);
                context.SetUserValue(triggerId: 99990004, key: "ObjectStart", value: 0);
                context.SetUserValue(triggerId: 99990005, key: "ObjectStart", value: 0);
                context.SetUserValue(triggerId: 99990006, key: "ObjectStart", value: 0);
                context.SetUserValue(triggerId: 99990007, key: "ObjectStart", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "ObjectPhase") == 1) {
                    return new StateSummonObject(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSummonObject : TriggerState {
            internal StateSummonObject(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {711, 712, 713, 714}, arg2: false);
                context.SetUserValue(triggerId: 99990004, key: "ObjectStart", value: 1);
                context.SetUserValue(triggerId: 99990005, key: "ObjectStart", value: 1);
                context.SetUserValue(triggerId: 99990006, key: "ObjectStart", value: 1);
                context.SetUserValue(triggerId: 99990007, key: "ObjectStart", value: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "ObjectPhase") == 2) {
                    return new StateWait(context);
                }

                if (context.MonsterDead(arg1: new[] {701})) {
                    return new StateSummonObject_Clear(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new State대사용_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대사용_1 : TriggerState {
            internal State대사용_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11001813, illust: "Turka_normal", duration: 5000, script: "$02020061_BF__BATTLE_2__0$");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "ObjectPhase") == 2) {
                    return new StateWait(context);
                }

                if (context.MonsterDead(arg1: new[] {701})) {
                    return new StateSummonObject_Clear(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new State대사용_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대사용_2 : TriggerState {
            internal State대사용_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11003536, illust: "Neirin_surprise", duration: 5000, script: "$02020061_BF__BATTLE_2__1$");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "ObjectPhase") == 2) {
                    return new StateWait(context);
                }

                if (context.MonsterDead(arg1: new[] {701})) {
                    return new StateSummonObject_Clear(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new State대사용_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대사용_3 : TriggerState {
            internal State대사용_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11003533, illust: "Bliche_normal", duration: 5000, script: "$02020061_BF__BATTLE_2__2$");
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
                context.SetUserValue(triggerId: 99990004, key: "ObjectStart", value: 0);
                context.SetUserValue(triggerId: 99990005, key: "ObjectStart", value: 0);
                context.SetUserValue(triggerId: 99990006, key: "ObjectStart", value: 0);
                context.SetUserValue(triggerId: 99990007, key: "ObjectStart", value: 0);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}