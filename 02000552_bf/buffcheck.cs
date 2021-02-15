namespace Maple2.Trigger._02000552_bf {
    public static class _buffcheck {
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
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateTrigger작동시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger작동시작 : TriggerState {
            internal StateTrigger작동시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "MonsterMany") >= 1) {
                    return new State블랙빈에게Buff부여(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State블랙빈에게Buff부여 : TriggerState {
            internal State블랙빈에게Buff부여(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {101}, arg2: 50003307, arg3: 2, arg4: true);
                context.AddBuff(arg1: new[] {102}, arg2: 50003307, arg3: 2, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State블랙빈에게Buff삭제체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State블랙빈에게Buff삭제체크 : TriggerState {
            internal State블랙빈에게Buff삭제체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "MonsterMany") == 0) {
                    return new State블랙빈에게Buff삭제Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State블랙빈에게Buff삭제Wait : TriggerState {
            internal State블랙빈에게Buff삭제Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 900)) {
                    return new State블랙빈에게Buff삭제실시(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State블랙빈에게Buff삭제실시 : TriggerState {
            internal State블랙빈에게Buff삭제실시(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {101}, arg2: 50003309, arg3: 1, arg4: true);
                context.AddBuff(arg1: new[] {102}, arg2: 50003309, arg3: 1, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateTrigger작동시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}