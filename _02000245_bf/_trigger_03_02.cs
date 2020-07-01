namespace Maple2.Trigger._02000245_bf {
    public static class _trigger_03_02 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {801}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkill(arg1: new[] {7001}, arg2: true);
                context.SetSkill(arg1: new[] {7002}, arg2: true);
                context.SetSkill(arg1: new[] {7003}, arg2: true);
                context.SetSkill(arg1: new[] {7004}, arg2: true);
                context.SetSkill(arg1: new[] {7005}, arg2: true);
                context.SetSkill(arg1: new[] {7006}, arg2: true);
                context.SetSkill(arg1: new[] {7007}, arg2: true);
                context.SetSkill(arg1: new[] {7008}, arg2: true);
                context.SetSkill(arg1: new[] {7009}, arg2: true);
                context.SetSkill(arg1: new[] {7010}, arg2: true);
                context.SetSkill(arg1: new[] {7011}, arg2: true);
                context.SetSkill(arg1: new[] {7012}, arg2: true);
                context.SetSkill(arg1: new[] {7013}, arg2: true);
                context.SetSkill(arg1: new[] {7014}, arg2: true);
                context.SetSkill(arg1: new[] {7015}, arg2: true);
                context.SetSkill(arg1: new[] {7016}, arg2: true);
                context.SetSkill(arg1: new[] {7017}, arg2: true);
                context.SetSkill(arg1: new[] {7018}, arg2: true);
                context.SetSkill(arg1: new[] {7019}, arg2: true);
                context.SetSkill(arg1: new[] {7020}, arg2: true);
                context.SetEffect(arg1: new[] {901}, arg2: true);
                context.SetEffect(arg1: new[] {902}, arg2: true);
                context.SetEffect(arg1: new[] {903}, arg2: true);
                context.SetEffect(arg1: new[] {904}, arg2: true);
                context.SetEffect(arg1: new[] {905}, arg2: true);
                context.SetEffect(arg1: new[] {906}, arg2: true);
                context.SetEffect(arg1: new[] {907}, arg2: true);
                context.SetEffect(arg1: new[] {908}, arg2: true);
                context.SetEffect(arg1: new[] {909}, arg2: true);
                context.SetEffect(arg1: new[] {910}, arg2: true);
                context.SetEffect(arg1: new[] {911}, arg2: true);
                context.SetEffect(arg1: new[] {912}, arg2: true);
                context.SetEffect(arg1: new[] {913}, arg2: true);
                context.SetEffect(arg1: new[] {914}, arg2: true);
                context.SetEffect(arg1: new[] {915}, arg2: true);
                context.SetEffect(arg1: new[] {916}, arg2: true);
                context.SetEffect(arg1: new[] {917}, arg2: true);
                context.SetEffect(arg1: new[] {918}, arg2: true);
                context.SetEffect(arg1: new[] {919}, arg2: true);
                context.SetEffect(arg1: new[] {920}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {207})) {
                    context.State = new State1단계(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1단계 : TriggerState {
            internal State1단계(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {801}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkill(arg1: new[] {7001}, arg2: false);
                context.SetSkill(arg1: new[] {7002}, arg2: false);
                context.SetSkill(arg1: new[] {7003}, arg2: false);
                context.SetSkill(arg1: new[] {7004}, arg2: false);
                context.SetSkill(arg1: new[] {7005}, arg2: false);
                context.SetSkill(arg1: new[] {7006}, arg2: false);
                context.SetSkill(arg1: new[] {7007}, arg2: false);
                context.SetSkill(arg1: new[] {7008}, arg2: false);
                context.SetSkill(arg1: new[] {7009}, arg2: false);
                context.SetSkill(arg1: new[] {7010}, arg2: false);
                context.SetSkill(arg1: new[] {7011}, arg2: false);
                context.SetSkill(arg1: new[] {7012}, arg2: false);
                context.SetSkill(arg1: new[] {7013}, arg2: false);
                context.SetSkill(arg1: new[] {7014}, arg2: false);
                context.SetSkill(arg1: new[] {7015}, arg2: false);
                context.SetSkill(arg1: new[] {7016}, arg2: false);
                context.SetSkill(arg1: new[] {7017}, arg2: false);
                context.SetSkill(arg1: new[] {7018}, arg2: false);
                context.SetSkill(arg1: new[] {7019}, arg2: false);
                context.SetSkill(arg1: new[] {7020}, arg2: false);
                context.SetEffect(arg1: new[] {901}, arg2: false);
                context.SetEffect(arg1: new[] {902}, arg2: false);
                context.SetEffect(arg1: new[] {903}, arg2: false);
                context.SetEffect(arg1: new[] {904}, arg2: false);
                context.SetEffect(arg1: new[] {905}, arg2: false);
                context.SetEffect(arg1: new[] {906}, arg2: false);
                context.SetEffect(arg1: new[] {907}, arg2: false);
                context.SetEffect(arg1: new[] {908}, arg2: false);
                context.SetEffect(arg1: new[] {909}, arg2: false);
                context.SetEffect(arg1: new[] {910}, arg2: false);
                context.SetEffect(arg1: new[] {911}, arg2: false);
                context.SetEffect(arg1: new[] {912}, arg2: false);
                context.SetEffect(arg1: new[] {913}, arg2: false);
                context.SetEffect(arg1: new[] {914}, arg2: false);
                context.SetEffect(arg1: new[] {915}, arg2: false);
                context.SetEffect(arg1: new[] {916}, arg2: false);
                context.SetEffect(arg1: new[] {917}, arg2: false);
                context.SetEffect(arg1: new[] {918}, arg2: false);
                context.SetEffect(arg1: new[] {919}, arg2: false);
                context.SetEffect(arg1: new[] {920}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}