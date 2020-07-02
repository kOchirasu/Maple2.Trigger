namespace Maple2.Trigger._02000294_bf {
    public static class _main2 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {10001, 10002, 10003, 10004});
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Battle_01") == 1) {
                    return new StateTrigger01진행(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger01진행 : TriggerState {
            internal StateTrigger01진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {10001, 10002, 10003, 10004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateTrigger02시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger02시작 : TriggerState {
            internal StateTrigger02시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 10001, arg2: "MS2PatrolData0");
                context.MoveNpc(arg1: 10002, arg2: "MS2PatrolData1");
                context.MoveNpc(arg1: 10003, arg2: "MS2PatrolData2");
                context.MoveNpc(arg1: 10004, arg2: "MS2PatrolData3");
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}