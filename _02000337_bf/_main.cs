using System;

namespace Maple2.Trigger._02000337_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
                context.SetEffect(arg1: new int[] {7301}, arg2: false);
                context.SetEffect(arg1: new int[] {7302}, arg2: false);
                context.SetEffect(arg1: new int[] {7303}, arg2: false);
                context.SetEffect(arg1: new int[] {7304}, arg2: false);
                context.SetEffect(arg1: new int[] {7305}, arg2: false);
                context.SetEffect(arg1: new int[] {7310}, arg2: true);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 701, arg2: 1)) {
                    context.State = new State폭발01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State폭발01 : TriggerState {
            internal State폭발01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7301}, arg2: true);
                context.SetSkill(arg1: new int[] {8301}, arg2: true);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 702, arg2: 1)) {
                    context.State = new State폭발02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State폭발02 : TriggerState {
            internal State폭발02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7302}, arg2: true);
                context.SetSkill(arg1: new int[] {8302}, arg2: true);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 703, arg2: 1)) {
                    context.State = new State폭발03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State폭발03 : TriggerState {
            internal State폭발03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7303}, arg2: true);
                context.SetEffect(arg1: new int[] {7304}, arg2: true);
                context.SetSkill(arg1: new int[] {8303}, arg2: true);
                context.SetSkill(arg1: new int[] {8304}, arg2: true);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 704, arg2: 1)) {
                    context.State = new State폭발04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State폭발04 : TriggerState {
            internal State폭발04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7305}, arg2: true);
                context.SetSkill(arg1: new int[] {8305}, arg2: true);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 705, arg2: 1)) {
                    context.State = new State폭발04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}