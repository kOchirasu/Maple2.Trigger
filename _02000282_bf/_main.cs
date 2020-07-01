namespace Maple2.Trigger._02000282_bf {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000424, 10000425, 10000426}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000433, 10000434, 10000435}, arg2: 2);
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

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    return new State준비(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1001, 1002, 1003, 1004, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1014, 1015, 1016, 1017, 1018, 1019, 1020, 1021}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 33f)) {
                    return new State4번생성(context);
                }

                if (context.RandomCondition(arg1: 33f)) {
                    return new State5번생성(context);
                }

                if (context.RandomCondition(arg1: 34f)) {
                    return new State6번생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4번생성 : TriggerState {
            internal State4번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000424}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000424}, arg2: 0)) {
                    return new State4번몬스터(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2004})) {
                    context.ShowGuideSummary(entityId: 20002812, textId: 20002812, duration: 5000);
                    context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                    context.SetLadder(arg1: 341, arg2: true, arg3: true);
                    context.SetLadder(arg1: 342, arg2: true, arg3: true);
                    context.SetLadder(arg1: 343, arg2: true, arg3: true);
                    context.SetPortal(arg1: 4, arg2: false, arg3: true, arg4: true);
                    return new State소멸대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5번생성 : TriggerState {
            internal State5번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000425}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000425}, arg2: 0)) {
                    return new State5번몬스터(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2005})) {
                    context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                    context.ShowGuideSummary(entityId: 20002812, textId: 20002812, duration: 5000);
                    context.SetLadder(arg1: 351, arg2: true, arg3: true);
                    context.SetLadder(arg1: 352, arg2: true, arg3: true);
                    context.SetLadder(arg1: 353, arg2: true, arg3: true);
                    context.SetPortal(arg1: 5, arg2: false, arg3: true, arg4: true);
                    return new State소멸대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State6번생성 : TriggerState {
            internal State6번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000426}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000426}, arg2: 0)) {
                    return new State6번몬스터(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2006})) {
                    context.ShowGuideSummary(entityId: 20002812, textId: 20002812, duration: 5000);
                    context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                    context.SetLadder(arg1: 361, arg2: true, arg3: true);
                    context.SetLadder(arg1: 362, arg2: true, arg3: true);
                    context.SetLadder(arg1: 363, arg2: true, arg3: true);
                    context.SetPortal(arg1: 6, arg2: false, arg3: true, arg4: true);
                    return new State소멸대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소멸대기 : TriggerState {
            internal State소멸대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소멸 : TriggerState {
            internal State소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}