namespace Maple2.Trigger._02000533_bf {
    public static class _main2 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{703}, jobCode: 0)) {
                    return new State서브Monster1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State서브Monster1 : TriggerState {
            internal State서브Monster1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{601, 602, 607, 608, 609, 610}, arg2: false);
                context.MoveNpc(spawnId: 601, patrolName: "MS2PatrolData_5000");
                context.MoveNpc(spawnId: 602, patrolName: "MS2PatrolData_5001");
                context.SetNpcEmotionLoop(spawnId: 607, sequenceName: "Sit_Down_A", duration: 10000000f);
                context.SetNpcEmotionLoop(spawnId: 608, sequenceName: "Sit_Down_A", duration: 10000000f);
                context.SetNpcEmotionLoop(spawnId: 610, sequenceName: "Bore_A", duration: 10000000f);
                context.AddBalloonTalk(spawnId: 601, msg: "$02000533_BF__MAIN2__0$", duration: 3500, delayTick: 0);
                context.AddBalloonTalk(spawnId: 602, msg: "$02000533_BF__MAIN2__1$", duration: 3500, delayTick: 500);
                context.AddBalloonTalk(spawnId: 601, msg: "$02000533_BF__MAIN2__2$", duration: 3500, delayTick: 1500);
                context.AddBalloonTalk(spawnId: 607, msg: "$02000533_BF__MAIN2__3$", duration: 3500, delayTick: 500);
            }

            public override TriggerState? Execute() {
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
                context.DestroyMonster(spawnIds: new []{601, 602, 607, 608, 609, 610});
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{6601, 6602, 6607, 6608, 6609, 6610}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{6601, 6602, 6607, 6608, 6609, 6610})) {
                    // return new State(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
