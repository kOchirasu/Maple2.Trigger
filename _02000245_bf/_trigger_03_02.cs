using System;

namespace Maple2.Trigger._02000245_bf {
    public static class _trigger_03_02 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {801}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkill(arg1: new int[] {7001}, arg2: true);
                context.SetSkill(arg1: new int[] {7002}, arg2: true);
                context.SetSkill(arg1: new int[] {7003}, arg2: true);
                context.SetSkill(arg1: new int[] {7004}, arg2: true);
                context.SetSkill(arg1: new int[] {7005}, arg2: true);
                context.SetSkill(arg1: new int[] {7006}, arg2: true);
                context.SetSkill(arg1: new int[] {7007}, arg2: true);
                context.SetSkill(arg1: new int[] {7008}, arg2: true);
                context.SetSkill(arg1: new int[] {7009}, arg2: true);
                context.SetSkill(arg1: new int[] {7010}, arg2: true);
                context.SetSkill(arg1: new int[] {7011}, arg2: true);
                context.SetSkill(arg1: new int[] {7012}, arg2: true);
                context.SetSkill(arg1: new int[] {7013}, arg2: true);
                context.SetSkill(arg1: new int[] {7014}, arg2: true);
                context.SetSkill(arg1: new int[] {7015}, arg2: true);
                context.SetSkill(arg1: new int[] {7016}, arg2: true);
                context.SetSkill(arg1: new int[] {7017}, arg2: true);
                context.SetSkill(arg1: new int[] {7018}, arg2: true);
                context.SetSkill(arg1: new int[] {7019}, arg2: true);
                context.SetSkill(arg1: new int[] {7020}, arg2: true);
                context.SetEffect(arg1: new int[] {901}, arg2: true);
                context.SetEffect(arg1: new int[] {902}, arg2: true);
                context.SetEffect(arg1: new int[] {903}, arg2: true);
                context.SetEffect(arg1: new int[] {904}, arg2: true);
                context.SetEffect(arg1: new int[] {905}, arg2: true);
                context.SetEffect(arg1: new int[] {906}, arg2: true);
                context.SetEffect(arg1: new int[] {907}, arg2: true);
                context.SetEffect(arg1: new int[] {908}, arg2: true);
                context.SetEffect(arg1: new int[] {909}, arg2: true);
                context.SetEffect(arg1: new int[] {910}, arg2: true);
                context.SetEffect(arg1: new int[] {911}, arg2: true);
                context.SetEffect(arg1: new int[] {912}, arg2: true);
                context.SetEffect(arg1: new int[] {913}, arg2: true);
                context.SetEffect(arg1: new int[] {914}, arg2: true);
                context.SetEffect(arg1: new int[] {915}, arg2: true);
                context.SetEffect(arg1: new int[] {916}, arg2: true);
                context.SetEffect(arg1: new int[] {917}, arg2: true);
                context.SetEffect(arg1: new int[] {918}, arg2: true);
                context.SetEffect(arg1: new int[] {919}, arg2: true);
                context.SetEffect(arg1: new int[] {920}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "207")) {
                    context.State = new State1단계(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1단계 : TriggerState {
            internal State1단계(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {801}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkill(arg1: new int[] {7001}, arg2: false);
                context.SetSkill(arg1: new int[] {7002}, arg2: false);
                context.SetSkill(arg1: new int[] {7003}, arg2: false);
                context.SetSkill(arg1: new int[] {7004}, arg2: false);
                context.SetSkill(arg1: new int[] {7005}, arg2: false);
                context.SetSkill(arg1: new int[] {7006}, arg2: false);
                context.SetSkill(arg1: new int[] {7007}, arg2: false);
                context.SetSkill(arg1: new int[] {7008}, arg2: false);
                context.SetSkill(arg1: new int[] {7009}, arg2: false);
                context.SetSkill(arg1: new int[] {7010}, arg2: false);
                context.SetSkill(arg1: new int[] {7011}, arg2: false);
                context.SetSkill(arg1: new int[] {7012}, arg2: false);
                context.SetSkill(arg1: new int[] {7013}, arg2: false);
                context.SetSkill(arg1: new int[] {7014}, arg2: false);
                context.SetSkill(arg1: new int[] {7015}, arg2: false);
                context.SetSkill(arg1: new int[] {7016}, arg2: false);
                context.SetSkill(arg1: new int[] {7017}, arg2: false);
                context.SetSkill(arg1: new int[] {7018}, arg2: false);
                context.SetSkill(arg1: new int[] {7019}, arg2: false);
                context.SetSkill(arg1: new int[] {7020}, arg2: false);
                context.SetEffect(arg1: new int[] {901}, arg2: false);
                context.SetEffect(arg1: new int[] {902}, arg2: false);
                context.SetEffect(arg1: new int[] {903}, arg2: false);
                context.SetEffect(arg1: new int[] {904}, arg2: false);
                context.SetEffect(arg1: new int[] {905}, arg2: false);
                context.SetEffect(arg1: new int[] {906}, arg2: false);
                context.SetEffect(arg1: new int[] {907}, arg2: false);
                context.SetEffect(arg1: new int[] {908}, arg2: false);
                context.SetEffect(arg1: new int[] {909}, arg2: false);
                context.SetEffect(arg1: new int[] {910}, arg2: false);
                context.SetEffect(arg1: new int[] {911}, arg2: false);
                context.SetEffect(arg1: new int[] {912}, arg2: false);
                context.SetEffect(arg1: new int[] {913}, arg2: false);
                context.SetEffect(arg1: new int[] {914}, arg2: false);
                context.SetEffect(arg1: new int[] {915}, arg2: false);
                context.SetEffect(arg1: new int[] {916}, arg2: false);
                context.SetEffect(arg1: new int[] {917}, arg2: false);
                context.SetEffect(arg1: new int[] {918}, arg2: false);
                context.SetEffect(arg1: new int[] {919}, arg2: false);
                context.SetEffect(arg1: new int[] {920}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}