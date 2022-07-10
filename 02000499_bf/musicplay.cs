namespace Maple2.Trigger._02000499_bf {
    public static class _musicplay {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5101, 5103, 5102, 5104, 5105}, visible: false);
                context.SetInteractObject(interactIds: new []{11000093}, state: 1, arg3: false);
                context.DestroyMonster(spawnIds: new []{210});
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{11000093}, arg2: 0)) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WriteLog(logName: "Survival", @event: "MushkingLand_musicPlay");
                context.SetNpcEmotionLoop(spawnId: 201, sequenceName: "Play_A", duration: 30500f);
                context.SetNpcEmotionLoop(spawnId: 202, sequenceName: "Play_A", duration: 30500f);
                context.SetNpcEmotionLoop(spawnId: 203, sequenceName: "Play_A", duration: 30500f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePCPlayMusic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCPlayMusic02 : TriggerState {
            internal StatePCPlayMusic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5101, 5103, 5102, 5104, 5105}, visible: true);
                context.CreateMonster(spawnIds: new []{210}, arg2: false, arg3: 0);
                context.SetNpcEmotionLoop(spawnId: 201, sequenceName: "Play_A", duration: 30500f);
                context.SetNpcEmotionLoop(spawnId: 202, sequenceName: "Play_A", duration: 30500f);
                context.SetNpcEmotionLoop(spawnId: 203, sequenceName: "Play_A", duration: 30500f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 30500)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5101, 5103, 5102, 5104, 5105}, visible: false);
                context.DestroyMonster(spawnIds: new []{210});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
