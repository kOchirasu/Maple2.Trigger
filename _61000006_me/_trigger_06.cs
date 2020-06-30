using System;

namespace Maple2.Trigger._61000006_me {
    public static class _trigger_06 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시간표등록(context);

        private class State시간표등록 : TriggerState {
            internal State시간표등록(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (true) {
                    context.State = new State시간표확인(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시간표확인 : TriggerState {
            internal State시간표확인(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000226}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {10000227}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {10000228}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {10000229}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {10000230}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {10000231}, arg2: 1);
                context.SetEffect(arg1: new int[] {711}, arg2: false);
                context.SetEffect(arg1: new int[] {712}, arg2: false);
                context.SetEffect(arg1: new int[] {713}, arg2: false);
                context.SetEffect(arg1: new int[] {714}, arg2: false);
                context.SetEffect(arg1: new int[] {715}, arg2: false);
                context.SetEffect(arg1: new int[] {716}, arg2: false);
                context.SetEffect(arg1: new int[] {717}, arg2: false);
                context.SetEffect(arg1: new int[] {718}, arg2: false);
                context.SetEffect(arg1: new int[] {719}, arg2: false);
                context.SetEffect(arg1: new int[] {720}, arg2: false);
                context.SetEffect(arg1: new int[] {721}, arg2: false);
                context.SetEffect(arg1: new int[] {722}, arg2: false);
                context.SetSkill(arg1: new int[] {811}, arg2: false);
                context.SetSkill(arg1: new int[] {812}, arg2: false);
                context.SetSkill(arg1: new int[] {813}, arg2: false);
                context.SetSkill(arg1: new int[] {814}, arg2: false);
                context.SetSkill(arg1: new int[] {815}, arg2: false);
                context.SetSkill(arg1: new int[] {816}, arg2: false);
                context.SetSkill(arg1: new int[] {817}, arg2: false);
                context.SetSkill(arg1: new int[] {818}, arg2: false);
                context.SetSkill(arg1: new int[] {819}, arg2: false);
                context.SetSkill(arg1: new int[] {820}, arg2: false);
                context.SetSkill(arg1: new int[] {821}, arg2: false);
                context.SetSkill(arg1: new int[] {822}, arg2: false);
                context.SetSkill(arg1: new int[] {823}, arg2: false);
                context.SetSkill(arg1: new int[] {824}, arg2: false);
                context.SetSkill(arg1: new int[] {825}, arg2: false);
                context.SetSkill(arg1: new int[] {826}, arg2: false);
                context.SetSkill(arg1: new int[] {827}, arg2: false);
                context.SetSkill(arg1: new int[] {828}, arg2: false);
                context.SetSkill(arg1: new int[] {911}, arg2: false);
                context.SetSkill(arg1: new int[] {912}, arg2: false);
                context.SetSkill(arg1: new int[] {913}, arg2: false);
                context.SetSkill(arg1: new int[] {914}, arg2: false);
                context.SetSkill(arg1: new int[] {915}, arg2: false);
                context.SetSkill(arg1: new int[] {916}, arg2: false);
                context.SetSkill(arg1: new int[] {917}, arg2: false);
                context.SetSkill(arg1: new int[] {918}, arg2: false);
                context.SetSkill(arg1: new int[] {919}, arg2: false);
                context.SetSkill(arg1: new int[] {920}, arg2: false);
                context.SetSkill(arg1: new int[] {921}, arg2: false);
                context.SetSkill(arg1: new int[] {922}, arg2: false);
                context.SetSkill(arg1: new int[] {923}, arg2: false);
                context.SetSkill(arg1: new int[] {924}, arg2: false);
                context.SetSkill(arg1: new int[] {925}, arg2: false);
                context.SetSkill(arg1: new int[] {926}, arg2: false);
                context.SetSkill(arg1: new int[] {927}, arg2: false);
                context.SetSkill(arg1: new int[] {928}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State어나운스0(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어나운스0 : TriggerState {
            internal State어나운스0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetState(arg1: 1, arg2: "미로패턴01,미로패턴02,미로패턴03", arg3: false);
                context.SetState(arg1: 2, arg2: "점프패턴01,점프패턴02", arg3: false);
                context.SetTimer(arg1: "89", arg2: 5);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "89")) {
                    context.State = new State레버(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레버 : TriggerState {
            internal State레버(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetState(arg1: 1, arg2: "미로패턴01,미로패턴02,미로패턴03", arg3: false);
                context.SetState(arg1: 2, arg2: "점프패턴01,점프패턴02", arg3: false);
                context.SetMesh(arg1: new int[] {527, 528, 529}, arg2: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State패턴결정(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴결정 : TriggerState {
            internal State패턴결정(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.UseState(arg1: 1, arg2: true);
                context.UseState(arg1: 2, arg2: true);
                context.SetTimer(arg1: "12", arg2: 240);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "12")) {
                    context.State = new State시간표확인(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State미로패턴01 : TriggerState {
            internal State미로패턴01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {527}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State미로패턴02 : TriggerState {
            internal State미로패턴02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {528}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State미로패턴03 : TriggerState {
            internal State미로패턴03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {529}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State점프패턴01 : TriggerState {
            internal State점프패턴01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {711}, arg2: true);
                context.SetEffect(arg1: new int[] {712}, arg2: false);
                context.SetEffect(arg1: new int[] {713}, arg2: false);
                context.SetEffect(arg1: new int[] {714}, arg2: true);
                context.SetEffect(arg1: new int[] {715}, arg2: false);
                context.SetEffect(arg1: new int[] {716}, arg2: true);
                context.SetEffect(arg1: new int[] {717}, arg2: true);
                context.SetEffect(arg1: new int[] {718}, arg2: false);
                context.SetEffect(arg1: new int[] {719}, arg2: true);
                context.SetEffect(arg1: new int[] {720}, arg2: false);
                context.SetEffect(arg1: new int[] {721}, arg2: false);
                context.SetEffect(arg1: new int[] {722}, arg2: true);
                context.SetSkill(arg1: new int[] {811}, arg2: true);
                context.SetSkill(arg1: new int[] {812}, arg2: true);
                context.SetSkill(arg1: new int[] {813}, arg2: true);
                context.SetSkill(arg1: new int[] {814}, arg2: false);
                context.SetSkill(arg1: new int[] {815}, arg2: false);
                context.SetSkill(arg1: new int[] {816}, arg2: false);
                context.SetSkill(arg1: new int[] {817}, arg2: false);
                context.SetSkill(arg1: new int[] {818}, arg2: false);
                context.SetSkill(arg1: new int[] {819}, arg2: false);
                context.SetSkill(arg1: new int[] {820}, arg2: true);
                context.SetSkill(arg1: new int[] {821}, arg2: true);
                context.SetSkill(arg1: new int[] {822}, arg2: true);
                context.SetSkill(arg1: new int[] {823}, arg2: true);
                context.SetSkill(arg1: new int[] {824}, arg2: true);
                context.SetSkill(arg1: new int[] {825}, arg2: true);
                context.SetSkill(arg1: new int[] {826}, arg2: false);
                context.SetSkill(arg1: new int[] {827}, arg2: false);
                context.SetSkill(arg1: new int[] {828}, arg2: false);
                context.SetSkill(arg1: new int[] {911}, arg2: false);
                context.SetSkill(arg1: new int[] {912}, arg2: false);
                context.SetSkill(arg1: new int[] {913}, arg2: false);
                context.SetSkill(arg1: new int[] {914}, arg2: true);
                context.SetSkill(arg1: new int[] {915}, arg2: true);
                context.SetSkill(arg1: new int[] {916}, arg2: true);
                context.SetSkill(arg1: new int[] {917}, arg2: true);
                context.SetSkill(arg1: new int[] {918}, arg2: true);
                context.SetSkill(arg1: new int[] {919}, arg2: true);
                context.SetSkill(arg1: new int[] {920}, arg2: false);
                context.SetSkill(arg1: new int[] {921}, arg2: false);
                context.SetSkill(arg1: new int[] {922}, arg2: false);
                context.SetSkill(arg1: new int[] {923}, arg2: false);
                context.SetSkill(arg1: new int[] {924}, arg2: false);
                context.SetSkill(arg1: new int[] {925}, arg2: false);
                context.SetSkill(arg1: new int[] {926}, arg2: true);
                context.SetSkill(arg1: new int[] {927}, arg2: true);
                context.SetSkill(arg1: new int[] {928}, arg2: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State점프패턴02 : TriggerState {
            internal State점프패턴02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {711}, arg2: false);
                context.SetEffect(arg1: new int[] {712}, arg2: true);
                context.SetEffect(arg1: new int[] {713}, arg2: true);
                context.SetEffect(arg1: new int[] {714}, arg2: false);
                context.SetEffect(arg1: new int[] {715}, arg2: false);
                context.SetEffect(arg1: new int[] {716}, arg2: true);
                context.SetEffect(arg1: new int[] {717}, arg2: true);
                context.SetEffect(arg1: new int[] {718}, arg2: false);
                context.SetEffect(arg1: new int[] {719}, arg2: true);
                context.SetEffect(arg1: new int[] {720}, arg2: false);
                context.SetEffect(arg1: new int[] {721}, arg2: false);
                context.SetEffect(arg1: new int[] {722}, arg2: true);
                context.SetSkill(arg1: new int[] {811}, arg2: false);
                context.SetSkill(arg1: new int[] {812}, arg2: false);
                context.SetSkill(arg1: new int[] {813}, arg2: false);
                context.SetSkill(arg1: new int[] {814}, arg2: true);
                context.SetSkill(arg1: new int[] {815}, arg2: true);
                context.SetSkill(arg1: new int[] {816}, arg2: true);
                context.SetSkill(arg1: new int[] {817}, arg2: false);
                context.SetSkill(arg1: new int[] {818}, arg2: false);
                context.SetSkill(arg1: new int[] {819}, arg2: false);
                context.SetSkill(arg1: new int[] {820}, arg2: true);
                context.SetSkill(arg1: new int[] {821}, arg2: true);
                context.SetSkill(arg1: new int[] {822}, arg2: true);
                context.SetSkill(arg1: new int[] {823}, arg2: true);
                context.SetSkill(arg1: new int[] {824}, arg2: true);
                context.SetSkill(arg1: new int[] {825}, arg2: true);
                context.SetSkill(arg1: new int[] {826}, arg2: false);
                context.SetSkill(arg1: new int[] {827}, arg2: false);
                context.SetSkill(arg1: new int[] {828}, arg2: false);
                context.SetSkill(arg1: new int[] {911}, arg2: true);
                context.SetSkill(arg1: new int[] {912}, arg2: true);
                context.SetSkill(arg1: new int[] {913}, arg2: true);
                context.SetSkill(arg1: new int[] {914}, arg2: false);
                context.SetSkill(arg1: new int[] {915}, arg2: false);
                context.SetSkill(arg1: new int[] {916}, arg2: false);
                context.SetSkill(arg1: new int[] {917}, arg2: true);
                context.SetSkill(arg1: new int[] {918}, arg2: true);
                context.SetSkill(arg1: new int[] {919}, arg2: true);
                context.SetSkill(arg1: new int[] {920}, arg2: false);
                context.SetSkill(arg1: new int[] {921}, arg2: false);
                context.SetSkill(arg1: new int[] {922}, arg2: false);
                context.SetSkill(arg1: new int[] {923}, arg2: false);
                context.SetSkill(arg1: new int[] {924}, arg2: false);
                context.SetSkill(arg1: new int[] {925}, arg2: false);
                context.SetSkill(arg1: new int[] {926}, arg2: true);
                context.SetSkill(arg1: new int[] {927}, arg2: true);
                context.SetSkill(arg1: new int[] {928}, arg2: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}