namespace Maple2.Trigger._02000523_bf {
    public static class _buffdelete {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateDefaultSetting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDefaultSetting : TriggerState {
            internal StateDefaultSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "MonsterMany", value: 0);
                context.SetUserValue(key: "BuffDeleteOk", value: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateTrigger작동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger작동01 : TriggerState {
            internal StateTrigger작동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BuffDeleteOk") == 1) {
                    return new StateTrigger작동02Waiting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger작동02Waiting : TriggerState {
            internal StateTrigger작동02Waiting(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1200)) {
                    return new StateTrigger작동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger작동02 : TriggerState {
            internal StateTrigger작동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "MonsterMany") == 0) {
                    return new StateBuffRemove(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuffRemove : TriggerState {
            internal StateBuffRemove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {900}, arg2: 50001098, arg3: 1, arg4: true);
                context.SetUserValue(key: "BuffDeleteOk", value: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3700)) {
                    return new StateTrigger작동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}