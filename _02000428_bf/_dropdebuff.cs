namespace Maple2.Trigger._02000428_bf {
    public static class _dropdebuff {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 750) == 1) {
                    return new State드랍어뷰징디버프_작동시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State드랍어뷰징디버프_작동시작 : TriggerState {
            internal State드랍어뷰징디버프_작동시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 780) == 1) {
                    return new State전투판에떨어지면디버프걸기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투판에떨어지면디버프걸기 : TriggerState {
            internal State전투판에떨어지면디버프걸기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {780}, arg2: 50000512, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new State드랍어뷰징디버프_작동시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}