namespace Maple2.Trigger._02000420_bf {
    public static class _barricade {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {301}, arg2: false, arg3: 0, arg4: 0);
            }

            public override TriggerState Execute() {
                if (context.MonsterInCombat(arg1: new[] {99})) {
                    // return new StateCount(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}