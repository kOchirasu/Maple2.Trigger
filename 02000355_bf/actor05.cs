namespace Maple2.Trigger._02000355_bf {
    public static class _actor05 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{605}, visible: false);
                context.SetActor(triggerId: 205, visible: true, initialSequence: "Damg_B");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{1501})) {
                    return new StateMonster소환Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster소환Wait : TriggerState {
            internal StateMonster소환Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{605}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateMonster소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster소환 : TriggerState {
            internal StateMonster소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2005}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State더미해제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State더미해제 : TriggerState {
            internal State더미해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 205, visible: false, initialSequence: "Damg_B");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2005})) {
                    return new State소멸(context);
                }

                if (context.MonsterDead(spawnIds: new []{2099})) {
                    return new State소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitTime : TriggerState {
            internal StateWaitTime(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new State리젠Prepare(context);
                }

                if (context.MonsterDead(spawnIds: new []{2099})) {
                    return new State소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리젠Prepare : TriggerState {
            internal State리젠Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 205, visible: true, initialSequence: "Regen_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소멸 : TriggerState {
            internal State소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{2005});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
