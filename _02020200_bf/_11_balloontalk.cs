using System;

namespace Maple2.Trigger._02020200_bf {
    public static class _11_balloontalk {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "905")) {
                    context.State = new State대사1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대사1 : TriggerState {
            internal State대사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcID: 11001813, illust: "Turka_normal", duration: 5000,
                    script: "$02020200_BF__11_BALLOONTALK__0$");
                context.AddBalloonTalk(spawnPointID: 0, msg: "$02020200_BF__11_BALLOONTALK__1$", duration: 5000,
                    delayTick: 1000);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "921") && !context.MonsterDead(arg1: new int[] {205})) {
                    context.State = new State대사2(context);
                    return;
                }

                if (context.UserDetected(arg1: "922") && !context.MonsterDead(arg1: new int[] {205})) {
                    context.State = new State대사2(context);
                    return;
                }

                if (context.UserDetected(arg1: "923") && !context.MonsterDead(arg1: new int[] {205})) {
                    context.State = new State대사2(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {205})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대사2 : TriggerState {
            internal State대사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 0, msg: "$02020200_BF__11_BALLOONTALK__2$", duration: 5000,
                    delayTick: 0);
            }

            public override void Execute() {
                if (context.CheckNpcAdditionalEffect(spawnPointID: 205, additionalEffectID: 42030261, level: 1)) {
                    context.State = new State대사3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대사3 : TriggerState {
            internal State대사3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcID: 11001813, illust: "Turka_normal", duration: 5000,
                    script: "$02020200_BF__11_BALLOONTALK__3$");
                context.AddBalloonTalk(spawnPointID: 0, msg: "$02020200_BF__11_BALLOONTALK__4$", duration: 5000,
                    delayTick: 0);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}