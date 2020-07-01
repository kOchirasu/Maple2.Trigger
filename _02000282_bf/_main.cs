namespace Maple2.Trigger._02000282_bf {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000424}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000425}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000426}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000433}, arg2: 2);
                context.SetInteractObject(arg1: new[] {10000434}, arg2: 2);
                context.SetInteractObject(arg1: new[] {10000435}, arg2: 2);
                context.SetLadder(arg1: 341, arg2: false, arg3: false);
                context.SetLadder(arg1: 342, arg2: false, arg3: false);
                context.SetLadder(arg1: 343, arg2: false, arg3: false);
                context.SetLadder(arg1: 351, arg2: false, arg3: false);
                context.SetLadder(arg1: 352, arg2: false, arg3: false);
                context.SetLadder(arg1: 353, arg2: false, arg3: false);
                context.SetLadder(arg1: 361, arg2: false, arg3: false);
                context.SetLadder(arg1: 362, arg2: false, arg3: false);
                context.SetLadder(arg1: 363, arg2: false, arg3: false);
                context.SetPortal(arg1: 4, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 5, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 6, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    context.State = new State준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1001}, arg2: false);
                context.CreateMonster(arg1: new[] {1002}, arg2: false);
                context.CreateMonster(arg1: new[] {1003}, arg2: false);
                context.CreateMonster(arg1: new[] {1004}, arg2: false);
                context.CreateMonster(arg1: new[] {1006}, arg2: false);
                context.CreateMonster(arg1: new[] {1007}, arg2: false);
                context.CreateMonster(arg1: new[] {1008}, arg2: false);
                context.CreateMonster(arg1: new[] {1009}, arg2: false);
                context.CreateMonster(arg1: new[] {1010}, arg2: false);
                context.CreateMonster(arg1: new[] {1011}, arg2: false);
                context.CreateMonster(arg1: new[] {1012}, arg2: false);
                context.CreateMonster(arg1: new[] {1014}, arg2: false);
                context.CreateMonster(arg1: new[] {1015}, arg2: false);
                context.CreateMonster(arg1: new[] {1016}, arg2: false);
                context.CreateMonster(arg1: new[] {1017}, arg2: false);
                context.CreateMonster(arg1: new[] {1018}, arg2: false);
                context.CreateMonster(arg1: new[] {1019}, arg2: false);
                context.CreateMonster(arg1: new[] {1020}, arg2: false);
                context.CreateMonster(arg1: new[] {1021}, arg2: false);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new State4번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new State5번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 34f)) {
                    context.State = new State6번생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4번생성 : TriggerState {
            internal State4번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000424}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000424}, arg2: 0)) {
                    context.State = new State4번몬스터(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4번몬스터 : TriggerState {
            internal State4번몬스터(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2004}, arg2: false);
                context.ShowGuideSummary(entityId: 20002817, textId: 20002817, duration: 5000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2004})) {
                    context.ShowGuideSummary(entityId: 20002812, textId: 20002812, duration: 5000);
                    context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                    context.SetLadder(arg1: 341, arg2: true, arg3: true);
                    context.SetLadder(arg1: 342, arg2: true, arg3: true);
                    context.SetLadder(arg1: 343, arg2: true, arg3: true);
                    context.SetPortal(arg1: 4, arg2: false, arg3: true, arg4: true);
                    context.State = new State소멸대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State5번생성 : TriggerState {
            internal State5번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000425}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000425}, arg2: 0)) {
                    context.State = new State5번몬스터(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State5번몬스터 : TriggerState {
            internal State5번몬스터(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2005}, arg2: false);
                context.ShowGuideSummary(entityId: 20002817, textId: 20002817, duration: 5000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2005})) {
                    context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                    context.ShowGuideSummary(entityId: 20002812, textId: 20002812, duration: 5000);
                    context.SetLadder(arg1: 351, arg2: true, arg3: true);
                    context.SetLadder(arg1: 352, arg2: true, arg3: true);
                    context.SetLadder(arg1: 353, arg2: true, arg3: true);
                    context.SetPortal(arg1: 5, arg2: false, arg3: true, arg4: true);
                    context.State = new State소멸대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State6번생성 : TriggerState {
            internal State6번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000426}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000426}, arg2: 0)) {
                    context.State = new State6번몬스터(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State6번몬스터 : TriggerState {
            internal State6번몬스터(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2006}, arg2: false);
                context.ShowGuideSummary(entityId: 20002817, textId: 20002817, duration: 5000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2006})) {
                    context.ShowGuideSummary(entityId: 20002812, textId: 20002812, duration: 5000);
                    context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                    context.SetLadder(arg1: 361, arg2: true, arg3: true);
                    context.SetLadder(arg1: 362, arg2: true, arg3: true);
                    context.SetLadder(arg1: 363, arg2: true, arg3: true);
                    context.SetPortal(arg1: 6, arg2: false, arg3: true, arg4: true);
                    context.State = new State소멸대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소멸대기 : TriggerState {
            internal State소멸대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소멸 : TriggerState {
            internal State소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}