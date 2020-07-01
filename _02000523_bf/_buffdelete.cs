namespace Maple2.Trigger._02000523_bf {
    public static class _buffdelete {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new State기본셋팅(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State기본셋팅 : TriggerState {
            internal State기본셋팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "MonsterMany", value: 0);
                context.SetUserValue(key: "BuffDeleteOk", value: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State트리거작동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리거작동01 : TriggerState {
            internal State트리거작동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BuffDeleteOk") == 1) {
                    return new State트리거작동02대기중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리거작동02대기중 : TriggerState {
            internal State트리거작동02대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1200)) {
                    return new State트리거작동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리거작동02 : TriggerState {
            internal State트리거작동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "MonsterMany") == 0) {
                    return new State버프제거(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버프제거 : TriggerState {
            internal State버프제거(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {900}, arg2: 50001098, arg3: 1, arg4: true);
                context.SetUserValue(key: "BuffDeleteOk", value: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3700)) {
                    return new State트리거작동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}