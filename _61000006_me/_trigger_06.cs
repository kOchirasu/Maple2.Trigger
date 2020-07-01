namespace Maple2.Trigger._61000006_me {
    public static class _trigger_06 {
        public class State시간표등록 : TriggerState {
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
                context.SetInteractObject(arg1: new[] {10000226, 10000227, 10000228, 10000229, 10000230, 10000231}, arg2: 1);
                context.SetEffect(arg1: new[] {711, 712, 713, 714, 715, 716, 717, 718, 719, 720, 721, 722}, arg2: false);
                context.SetSkill(arg1: new[] {811, 812, 813, 814, 815, 816, 817, 818, 819, 820, 821, 822, 823, 824, 825, 826, 827, 828, 911, 912, 913, 914, 915, 916, 917, 918, 919, 920, 921, 922, 923, 924, 925, 926, 927, 928}, arg2: false);
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
                context.SetMesh(arg1: new[] {527, 528, 529}, arg2: true);
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
                context.SetMesh(arg1: new[] {527}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State미로패턴02 : TriggerState {
            internal State미로패턴02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {528}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State미로패턴03 : TriggerState {
            internal State미로패턴03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {529}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State점프패턴01 : TriggerState {
            internal State점프패턴01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {711}, arg2: true);
                context.SetEffect(arg1: new[] {712, 713}, arg2: false);
                context.SetEffect(arg1: new[] {714}, arg2: true);
                context.SetEffect(arg1: new[] {715}, arg2: false);
                context.SetEffect(arg1: new[] {716, 717}, arg2: true);
                context.SetEffect(arg1: new[] {718}, arg2: false);
                context.SetEffect(arg1: new[] {719}, arg2: true);
                context.SetEffect(arg1: new[] {720, 721}, arg2: false);
                context.SetEffect(arg1: new[] {722}, arg2: true);
                context.SetSkill(arg1: new[] {811, 812, 813}, arg2: true);
                context.SetSkill(arg1: new[] {814, 815, 816, 817, 818, 819}, arg2: false);
                context.SetSkill(arg1: new[] {820, 821, 822, 823, 824, 825}, arg2: true);
                context.SetSkill(arg1: new[] {826, 827, 828, 911, 912, 913}, arg2: false);
                context.SetSkill(arg1: new[] {914, 915, 916, 917, 918, 919}, arg2: true);
                context.SetSkill(arg1: new[] {920, 921, 922, 923, 924, 925}, arg2: false);
                context.SetSkill(arg1: new[] {926, 927, 928}, arg2: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State점프패턴02 : TriggerState {
            internal State점프패턴02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {711}, arg2: false);
                context.SetEffect(arg1: new[] {712, 713}, arg2: true);
                context.SetEffect(arg1: new[] {714, 715}, arg2: false);
                context.SetEffect(arg1: new[] {716, 717}, arg2: true);
                context.SetEffect(arg1: new[] {718}, arg2: false);
                context.SetEffect(arg1: new[] {719}, arg2: true);
                context.SetEffect(arg1: new[] {720, 721}, arg2: false);
                context.SetEffect(arg1: new[] {722}, arg2: true);
                context.SetSkill(arg1: new[] {811, 812, 813}, arg2: false);
                context.SetSkill(arg1: new[] {814, 815, 816}, arg2: true);
                context.SetSkill(arg1: new[] {817, 818, 819}, arg2: false);
                context.SetSkill(arg1: new[] {820, 821, 822, 823, 824, 825}, arg2: true);
                context.SetSkill(arg1: new[] {826, 827, 828}, arg2: false);
                context.SetSkill(arg1: new[] {911, 912, 913}, arg2: true);
                context.SetSkill(arg1: new[] {914, 915, 916}, arg2: false);
                context.SetSkill(arg1: new[] {917, 918, 919}, arg2: true);
                context.SetSkill(arg1: new[] {920, 921, 922, 923, 924, 925}, arg2: false);
                context.SetSkill(arg1: new[] {926, 927, 928}, arg2: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}