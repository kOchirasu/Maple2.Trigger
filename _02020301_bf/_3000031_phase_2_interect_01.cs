using System;

namespace Maple2.Trigger._02020301_bf {
    public static class _3000031_phase_2_interect_01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10003131}, arg2: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "Phase_2_Interect_01", value: 1)) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcID: 11004205, illust: "ArcaneBlader_unfair",
                    script: "$02020301_BF__3000031_PHASE_2_INTERECT_01__0$", duration: 3176);
                context.SideNpcTalk(type: "talk", npcID: 11004205, illust: "ArcaneBlader_unfair",
                    script: "$02020301_BF__3000031_PHASE_2_INTERECT_01__1$", duration: 3176);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State인터렉트_설정(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인터렉트_설정 : TriggerState {
            internal State인터렉트_설정(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02020301_BF__3000031_PHASE_2_INTERECT_01__2$",
                    arg3: new int[] {4000});
                context.CreateMonster(arg1: new int[] {999}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State탈것_등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State탈것_등장 : TriggerState {
            internal State탈것_등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10003131}, arg2: 1);
                context.DestroyMonster(arg1: new int[] {999});
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10003131}, arg2: 0)) {
                    context.State = new State인터렉트_동작(context);
                    return;
                }

                if (context.UserValue(key: "Phase_2_Interect_01", value: 0)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인터렉트_동작 : TriggerState {
            internal State인터렉트_동작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State인터렉트_리셋(context);
                    return;
                }

                if (context.UserValue(key: "Phase_2_Interect_01", value: 0)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인터렉트_리셋 : TriggerState {
            internal State인터렉트_리셋(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckNpcAdditionalEffect(spawnPointID: 101, additionalEffectID: 62100152, level: 1)) {
                    context.State = new State리셋_대기(context);
                    return;
                }

                if (context.UserValue(key: "Phase_2_Interect_01", value: 0)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State리셋_대기 : TriggerState {
            internal State리셋_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new State인터렉트_설정(context);
                    return;
                }

                if (context.UserValue(key: "Phase_2_Interect_01", value: 0)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}