namespace Maple2.Trigger._02000420_bf {
    public static class _barricade {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {301}, arg2: false, arg3: 0, arg4: 0);
            }

            public override void Execute() {
                if (context.MonsterInCombat(arg1: new[] {99})) {
                    // context.State = new State카운트(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}