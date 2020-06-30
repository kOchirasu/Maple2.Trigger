using System;

namespace Maple2.Trigger._02000499_bf {
    public static class _musicplay {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Statewait(context);

        private class Statewait : TriggerState {
            internal Statewait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5101}, arg2: false);
                context.SetEffect(arg1: new int[] {5103}, arg2: false);
                context.SetEffect(arg1: new int[] {5102}, arg2: false);
                context.SetEffect(arg1: new int[] {5104}, arg2: false);
                context.SetEffect(arg1: new int[] {5105}, arg2: false);
                context.SetInteractObject(arg1: new int[] {11000093}, arg2: 1, arg3: false);
                context.DestroyMonster(arg1: new int[] {210});
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {11000093}, arg2: 0)) {
                    context.State = new Stateready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WriteLog(arg1: "Survival", arg3: "MushkingLand_musicPlay");
                context.SetNpcEmotionLoop(arg1: 201, arg2: "Play_A", arg3: 30500f);
                context.SetNpcEmotionLoop(arg1: 202, arg2: "Play_A", arg3: 30500f);
                context.SetNpcEmotionLoop(arg1: 203, arg2: "Play_A", arg3: 30500f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePCPlayMusic02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCPlayMusic02 : TriggerState {
            internal StatePCPlayMusic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5101}, arg2: true);
                context.SetEffect(arg1: new int[] {5103}, arg2: true);
                context.SetEffect(arg1: new int[] {5102}, arg2: true);
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetEffect(arg1: new int[] {5105}, arg2: true);
                context.CreateMonster(arg1: new int[] {210}, arg2: false, arg3: 0);
                context.SetNpcEmotionLoop(arg1: 201, arg2: "Play_A", arg3: 30500f);
                context.SetNpcEmotionLoop(arg1: 202, arg2: "Play_A", arg3: 30500f);
                context.SetNpcEmotionLoop(arg1: 203, arg2: "Play_A", arg3: 30500f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 30500)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5101}, arg2: false);
                context.SetEffect(arg1: new int[] {5103}, arg2: false);
                context.SetEffect(arg1: new int[] {5102}, arg2: false);
                context.SetEffect(arg1: new int[] {5104}, arg2: false);
                context.SetEffect(arg1: new int[] {5105}, arg2: false);
                context.DestroyMonster(arg1: new int[] {210});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statewait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}