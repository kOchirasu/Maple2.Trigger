namespace Maple2.Trigger._02020051_bf {
    public static class _102_timmer {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(arg1: "990");
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Timmer") == 1) {
                    context.State = new State타이머(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State타이머 : TriggerState {
            internal State타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "990", arg2: 600, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 600000)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetUserValue(key: "Timmer") == 3) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcId: 11003536, illust: "Neirin_shy",
                    script: "$02020051_BF__102_TIMMER__0$", duration: 5684, voice: @"ko/Npc/00002201");
                context.SetUserValue(triggerId: 104, key: "End", value: 3);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Timmer") == 2) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}