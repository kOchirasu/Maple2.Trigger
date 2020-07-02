namespace Maple2.Trigger._02000499_bf {
    public static class _musicplay {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5101, 5103, 5102, 5104, 5105}, arg2: false);
                context.SetInteractObject(arg1: new[] {11000093}, arg2: 1, arg3: false);
                context.DestroyMonster(arg1: new[] {210});
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {11000093}, arg2: 0)) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WriteLog(arg1: "Survival", arg3: "MushkingLand_musicPlay");
                context.SetNpcEmotionLoop(arg1: 201, arg2: "Play_A", arg3: 30500f);
                context.SetNpcEmotionLoop(arg1: 202, arg2: "Play_A", arg3: 30500f);
                context.SetNpcEmotionLoop(arg1: 203, arg2: "Play_A", arg3: 30500f);
            }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {5101, 5103, 5102, 5104, 5105}, arg2: true);
                context.CreateMonster(arg1: new[] {210}, arg2: false, arg3: 0);
                context.SetNpcEmotionLoop(arg1: 201, arg2: "Play_A", arg3: 30500f);
                context.SetNpcEmotionLoop(arg1: 202, arg2: "Play_A", arg3: 30500f);
                context.SetNpcEmotionLoop(arg1: 203, arg2: "Play_A", arg3: 30500f);
            }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {5101, 5103, 5102, 5104, 5105}, arg2: false);
                context.DestroyMonster(arg1: new[] {210});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}