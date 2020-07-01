using System;

namespace Maple2.Trigger._02100000_bf {
    public static class _spawnpoint {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State리스폰변경_1(context);

        private class State리스폰변경_1 : TriggerState {
            internal State리스폰변경_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnPointID: 1, isEnable: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {103})) { }
            }

            public override void OnExit() { }
        }
    }
}