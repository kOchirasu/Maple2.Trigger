namespace Maple2.Trigger._02000006_ad {
    public static class _01_followallice {
        public class StateWait00 : TriggerState {
            internal StateWait00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {51, 52, 53, 54});
                context.SetMesh(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118}, arg2: false);
                context.SetEffect(arg1: new[] {201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218}, arg2: false);
                context.SetLadder(arg1: 151, arg2: false, arg3: false);
                context.SetLadder(arg1: 152, arg2: false, arg3: false);
                context.SetLadder(arg1: 153, arg2: false, arg3: false);
                context.SetLadder(arg1: 154, arg2: false, arg3: false);
                context.SetLadder(arg1: 155, arg2: false, arg3: false);
                context.SetLadder(arg1: 156, arg2: false, arg3: false);
                context.SetEffect(arg1: new[] {219, 220, 221, 222, 223, 224}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000449}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000449}, arg2: 0)) {
                    return new StateWait01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait01 : TriggerState {
            internal StateWait01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {51}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {51})) {
                    return new StateSetup01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster수명설정 : TriggerState {
            internal StateMonster수명설정(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 30);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateWait01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup01 : TriggerState {
            internal StateSetup01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {101}, arg2: true);
                context.SetEffect(arg1: new[] {201}, arg2: true);
                context.SetTimer(id: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSetup02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup02 : TriggerState {
            internal StateSetup02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {102}, arg2: true);
                context.SetEffect(arg1: new[] {202}, arg2: true);
                context.SetTimer(id: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSetup03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup03 : TriggerState {
            internal StateSetup03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {103}, arg2: true);
                context.SetEffect(arg1: new[] {203}, arg2: true);
                context.SetTimer(id: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSetup04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup04 : TriggerState {
            internal StateSetup04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {104}, arg2: true);
                context.SetEffect(arg1: new[] {204}, arg2: true);
                context.SetTimer(id: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSetup05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup05 : TriggerState {
            internal StateSetup05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {105}, arg2: true);
                context.SetEffect(arg1: new[] {205}, arg2: true);
                context.SetTimer(id: "1", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateWait02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait02 : TriggerState {
            internal StateWait02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {52}, arg2: true);
                context.SetMesh(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118}, arg2: false);
                context.SetEffect(arg1: new[] {201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218}, arg2: false);
                context.SetTimer(id: "2", arg2: 15);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {52})) {
                    return new StateSetup06(context);
                }

                if (context.TimeExpired(arg1: "2")) {
                    return new StateWait00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup06 : TriggerState {
            internal StateSetup06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {106}, arg2: true);
                context.SetEffect(arg1: new[] {206}, arg2: true);
                context.SetTimer(id: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSetup07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup07 : TriggerState {
            internal StateSetup07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {107}, arg2: true);
                context.SetEffect(arg1: new[] {207}, arg2: true);
                context.SetTimer(id: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSetup08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup08 : TriggerState {
            internal StateSetup08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {108}, arg2: true);
                context.SetEffect(arg1: new[] {208}, arg2: true);
                context.SetTimer(id: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSetup09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup09 : TriggerState {
            internal StateSetup09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {109}, arg2: true);
                context.SetEffect(arg1: new[] {209}, arg2: true);
                context.SetTimer(id: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSetup10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup10 : TriggerState {
            internal StateSetup10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {110}, arg2: true);
                context.SetEffect(arg1: new[] {210}, arg2: true);
                context.SetTimer(id: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSetup11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup11 : TriggerState {
            internal StateSetup11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {111}, arg2: true);
                context.SetEffect(arg1: new[] {211}, arg2: true);
                context.SetTimer(id: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSetup12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup12 : TriggerState {
            internal StateSetup12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {112}, arg2: true);
                context.SetEffect(arg1: new[] {212}, arg2: true);
                context.SetTimer(id: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSetup13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup13 : TriggerState {
            internal StateSetup13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {113}, arg2: true);
                context.SetEffect(arg1: new[] {213}, arg2: true);
                context.SetTimer(id: "1", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateWait03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait03 : TriggerState {
            internal StateWait03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {53}, arg2: true);
                context.SetMesh(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118}, arg2: false);
                context.SetEffect(arg1: new[] {201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218}, arg2: false);
                context.SetTimer(id: "2", arg2: 15);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {53})) {
                    return new StateSetup14(context);
                }

                if (context.TimeExpired(arg1: "2")) {
                    return new StateWait00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup14 : TriggerState {
            internal StateSetup14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {114}, arg2: true);
                context.SetEffect(arg1: new[] {214}, arg2: true);
                context.SetTimer(id: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSetup15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup15 : TriggerState {
            internal StateSetup15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {115}, arg2: true);
                context.SetEffect(arg1: new[] {215}, arg2: true);
                context.SetTimer(id: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSetup16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup16 : TriggerState {
            internal StateSetup16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {116}, arg2: true);
                context.SetEffect(arg1: new[] {216}, arg2: true);
                context.SetTimer(id: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSetup17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup17 : TriggerState {
            internal StateSetup17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {117}, arg2: true);
                context.SetEffect(arg1: new[] {217}, arg2: true);
                context.SetTimer(id: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSetup18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup18 : TriggerState {
            internal StateSetup18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {118}, arg2: true);
                context.SetEffect(arg1: new[] {218}, arg2: true);
                context.SetTimer(id: "1", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateWait04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait04 : TriggerState {
            internal StateWait04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {54}, arg2: true);
                context.SetMesh(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118}, arg2: false);
                context.SetEffect(arg1: new[] {201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218}, arg2: false);
                context.SetTimer(id: "2", arg2: 15);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {54})) {
                    return new StateLadder(context);
                }

                if (context.TimeExpired(arg1: "2")) {
                    return new StateWait00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadder : TriggerState {
            internal StateLadder(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 151, arg2: true, arg3: true);
                context.SetLadder(arg1: 152, arg2: true, arg3: true);
                context.SetLadder(arg1: 153, arg2: true, arg3: true);
                context.SetLadder(arg1: 154, arg2: true, arg3: true);
                context.SetLadder(arg1: 155, arg2: true, arg3: true);
                context.SetLadder(arg1: 156, arg2: true, arg3: true);
                context.SetEffect(arg1: new[] {219, 220, 221, 222, 223, 224}, arg2: true);
                context.SetTimer(id: "1", arg2: 10);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateWait00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}