namespace Maple2.Trigger._02000331_bf {
    public static class _change13 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9024, spawnIds: new []{604})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9030, spawnIds: new []{990})) {
                    return new State분기점(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State분기점 : TriggerState {
            internal State분기점(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9030, spawnIds: new []{999})) {
                    return new StateBossCombat(context);
                }

                if (context.MonsterDead(spawnIds: new []{604})) {
                    return new State교체Delay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossCombat : TriggerState {
            internal StateBossCombat(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{999})) {
                    return new State전투종료(context);
                }

                if (context.MonsterDead(spawnIds: new []{604})) {
                    return new State교체Delay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투종료 : TriggerState {
            internal State전투종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9024, spawnIds: new []{604})) {
                    return new State디펜스Success(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State디펜스Success : TriggerState {
            internal State디펜스Success(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State교체Delay : TriggerState {
            internal State교체Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State교체쓰러짐(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State교체쓰러짐 : TriggerState {
            internal State교체쓰러짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{614});
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9020, spawnIds: new []{600})) {
                    return new State교체일어남(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State교체일어남 : TriggerState {
            internal State교체일어남(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(removeSpawnId: 614, addSpawnId: 410);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
