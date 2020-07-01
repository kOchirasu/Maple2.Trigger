namespace Maple2.Trigger._02000006_ad {
    public static class _01_followallice {
        public class State대기00 : TriggerState {
            internal State대기00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {51, 52, 53, 54});
                context.SetMesh(
                    arg1: new[]
                        {101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118},
                    arg2: false);
                context.SetEffect(
                    arg1: new[]
                        {201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218},
                    arg2: false);
                context.SetLadder(arg1: 151, arg2: false, arg3: false);
                context.SetLadder(arg1: 152, arg2: false, arg3: false);
                context.SetLadder(arg1: 153, arg2: false, arg3: false);
                context.SetLadder(arg1: 154, arg2: false, arg3: false);
                context.SetLadder(arg1: 155, arg2: false, arg3: false);
                context.SetLadder(arg1: 156, arg2: false, arg3: false);
                context.SetEffect(arg1: new[] {219, 220, 221, 222, 223, 224}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000449}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000449}, arg2: 0)) {
                    context.State = new State대기01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기01 : TriggerState {
            internal State대기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {51}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {51})) {
                    context.State = new State발판생성01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터수명설정 : TriggerState {
            internal State몬스터수명설정(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 30);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State대기01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판생성01 : TriggerState {
            internal State발판생성01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {101}, arg2: true);
                context.SetEffect(arg1: new[] {201}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State발판생성02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판생성02 : TriggerState {
            internal State발판생성02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {102}, arg2: true);
                context.SetEffect(arg1: new[] {202}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State발판생성03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판생성03 : TriggerState {
            internal State발판생성03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {103}, arg2: true);
                context.SetEffect(arg1: new[] {203}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State발판생성04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판생성04 : TriggerState {
            internal State발판생성04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {104}, arg2: true);
                context.SetEffect(arg1: new[] {204}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State발판생성05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판생성05 : TriggerState {
            internal State발판생성05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {105}, arg2: true);
                context.SetEffect(arg1: new[] {205}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State대기02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기02 : TriggerState {
            internal State대기02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {52}, arg2: true);
                context.SetMesh(
                    arg1: new[]
                        {101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118},
                    arg2: false);
                context.SetEffect(
                    arg1: new[]
                        {201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218},
                    arg2: false);
                context.SetTimer(arg1: "2", arg2: 15);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {52})) {
                    context.State = new State발판생성06(context);
                    return;
                }

                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State대기00(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판생성06 : TriggerState {
            internal State발판생성06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {106}, arg2: true);
                context.SetEffect(arg1: new[] {206}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State발판생성07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판생성07 : TriggerState {
            internal State발판생성07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {107}, arg2: true);
                context.SetEffect(arg1: new[] {207}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State발판생성08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판생성08 : TriggerState {
            internal State발판생성08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {108}, arg2: true);
                context.SetEffect(arg1: new[] {208}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State발판생성09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판생성09 : TriggerState {
            internal State발판생성09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {109}, arg2: true);
                context.SetEffect(arg1: new[] {209}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State발판생성10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판생성10 : TriggerState {
            internal State발판생성10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {110}, arg2: true);
                context.SetEffect(arg1: new[] {210}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State발판생성11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판생성11 : TriggerState {
            internal State발판생성11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {111}, arg2: true);
                context.SetEffect(arg1: new[] {211}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State발판생성12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판생성12 : TriggerState {
            internal State발판생성12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {112}, arg2: true);
                context.SetEffect(arg1: new[] {212}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State발판생성13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판생성13 : TriggerState {
            internal State발판생성13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {113}, arg2: true);
                context.SetEffect(arg1: new[] {213}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State대기03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기03 : TriggerState {
            internal State대기03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {53}, arg2: true);
                context.SetMesh(
                    arg1: new[]
                        {101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118},
                    arg2: false);
                context.SetEffect(
                    arg1: new[]
                        {201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218},
                    arg2: false);
                context.SetTimer(arg1: "2", arg2: 15);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {53})) {
                    context.State = new State발판생성14(context);
                    return;
                }

                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State대기00(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판생성14 : TriggerState {
            internal State발판생성14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {114}, arg2: true);
                context.SetEffect(arg1: new[] {214}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State발판생성15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판생성15 : TriggerState {
            internal State발판생성15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {115}, arg2: true);
                context.SetEffect(arg1: new[] {215}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State발판생성16(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판생성16 : TriggerState {
            internal State발판생성16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {116}, arg2: true);
                context.SetEffect(arg1: new[] {216}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State발판생성17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판생성17 : TriggerState {
            internal State발판생성17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {117}, arg2: true);
                context.SetEffect(arg1: new[] {217}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State발판생성18(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판생성18 : TriggerState {
            internal State발판생성18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {118}, arg2: true);
                context.SetEffect(arg1: new[] {218}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State대기04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기04 : TriggerState {
            internal State대기04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {54}, arg2: true);
                context.SetMesh(
                    arg1: new[]
                        {101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118},
                    arg2: false);
                context.SetEffect(
                    arg1: new[]
                        {201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218},
                    arg2: false);
                context.SetTimer(arg1: "2", arg2: 15);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {54})) {
                    context.State = new State사다리등장(context);
                    return;
                }

                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State대기00(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State사다리등장 : TriggerState {
            internal State사다리등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 151, arg2: true, arg3: true);
                context.SetLadder(arg1: 152, arg2: true, arg3: true);
                context.SetLadder(arg1: 153, arg2: true, arg3: true);
                context.SetLadder(arg1: 154, arg2: true, arg3: true);
                context.SetLadder(arg1: 155, arg2: true, arg3: true);
                context.SetLadder(arg1: 156, arg2: true, arg3: true);
                context.SetEffect(arg1: new[] {219, 220, 221, 222, 223, 224}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 10);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State대기00(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}