namespace Maple2.Trigger._02000331_bf {
    public static class _spring02 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
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
                context.SetSkill(arg1: new[] {7021}, arg2: false);
                context.SetSkill(arg1: new[] {7022}, arg2: false);
                context.SetSkill(arg1: new[] {7023}, arg2: false);
                context.SetSkill(arg1: new[] {7024}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {99991})) {
                    context.State = new State스킬발동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬발동 : TriggerState {
            internal State스킬발동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
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
                context.SetSkill(arg1: new[] {7021}, arg2: true);
                context.SetSkill(arg1: new[] {7022}, arg2: true);
                context.SetSkill(arg1: new[] {7023}, arg2: true);
                context.SetSkill(arg1: new[] {7024}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}