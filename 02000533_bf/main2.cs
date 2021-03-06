namespace Maple2.Trigger._02000533_bf {
    public static class _main2 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {703}, arg2: 0)) {
                    return new State서브Monster1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State서브Monster1 : TriggerState {
            internal State서브Monster1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {601, 602, 607, 608, 609, 610}, arg2: false);
                context.MoveNpc(arg1: 601, arg2: "MS2PatrolData_5000");
                context.MoveNpc(arg1: 602, arg2: "MS2PatrolData_5001");
                context.SetNpcEmotionLoop(arg1: 607, arg2: "Sit_Down_A", arg3: 10000000f);
                context.SetNpcEmotionLoop(arg1: 608, arg2: "Sit_Down_A", arg3: 10000000f);
                context.SetNpcEmotionLoop(arg1: 610, arg2: "Bore_A", arg3: 10000000f);
                context.AddBalloonTalk(spawnPointId: 601, msg: "$02000533_BF__MAIN2__0$", duration: 3500, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 602, msg: "$02000533_BF__MAIN2__1$", duration: 3500, delayTick: 500);
                context.AddBalloonTalk(spawnPointId: 601, msg: "$02000533_BF__MAIN2__2$", duration: 3500, delayTick: 1500);
                context.AddBalloonTalk(spawnPointId: 607, msg: "$02000533_BF__MAIN2__3$", duration: 3500, delayTick: 500);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State서브Monster2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State서브Monster2 : TriggerState {
            internal State서브Monster2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {601, 602, 607, 608, 609, 610});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State서브Monster3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State서브Monster3 : TriggerState {
            internal State서브Monster3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {6601, 6602, 6607, 6608, 6609, 6610}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {6601, 6602, 6607, 6608, 6609, 6610})) {
                    // return new State(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}