namespace Maple2.Trigger._02000242_bf {
    public static class _trigger_04_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{707, 708}, visible: true);
                context.DestroyMonster(spawnIds: new []{607, 608});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State1차웨이브 : TriggerState {
            internal State1차웨이브(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{607, 608}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{607, 608})) {
                    return new State1차Delay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차Delay : TriggerState {
            internal State1차Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 10);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State2차웨이브(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차웨이브 : TriggerState {
            internal State2차웨이브(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{607, 608}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{607, 608})) {
                    return new State2차Delay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차Delay : TriggerState {
            internal State2차Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 10);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State3차웨이브(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차웨이브 : TriggerState {
            internal State3차웨이브(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{607, 608}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{607, 608})) {
                    return new State3차Delay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차Delay : TriggerState {
            internal State3차Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 180);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
