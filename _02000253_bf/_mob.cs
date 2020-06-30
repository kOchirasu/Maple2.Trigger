using System;

namespace Maple2.Trigger._02000253_bf {
    public static class _mob {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 20002527);
                context.HideGuideSummary(entityID: 20002528);
                context.HideGuideSummary(entityID: 20002529);
                context.HideGuideSummary(entityID: 20002530);
                context.HideGuideSummary(entityID: 20002531);
                context.HideGuideSummary(entityID: 20002532);
                context.SetLadder(arg1: 1701, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1702, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1703, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1704, arg2: false, arg3: false, arg4: 0);
                context.SetInteractObject(arg1: new int[] {13000005}, arg2: 2);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 906, arg2: 1)) {
                    context.State = new State딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State딜레이 : TriggerState {
            internal State딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 8);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State몹1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몹1 : TriggerState {
            internal State몹1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20002527, textID: 20002527);
                context.SetTimer(arg1: "1", arg2: 15);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State몹2(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10001050}, arg2: 0)) {
                    context.State = new State몹2(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10001051}, arg2: 0)) {
                    context.State = new State몹2(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10001052}, arg2: 0)) {
                    context.State = new State몹2(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10001053}, arg2: 0)) {
                    context.State = new State몹2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몹2 : TriggerState {
            internal State몹2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20002528, textID: 20002528);
                context.SetTimer(arg1: "1", arg2: 20);
                context.CreateMonster(arg1: new int[] {4002}, arg2: true);
                context.CreateMonster(arg1: new int[] {4004}, arg2: true);
                context.CreateMonster(arg1: new int[] {4008}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {4002, 4004, 4006, 4008})) {
                    context.State = new State몹3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몹3 : TriggerState {
            internal State몹3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20002529, textID: 20002529);
                context.SetTimer(arg1: "1", arg2: 20);
                context.CreateMonster(arg1: new int[] {4001}, arg2: true);
                context.CreateMonster(arg1: new int[] {4003}, arg2: true);
                context.CreateMonster(arg1: new int[] {4007}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {4001, 4003, 4005, 4007})) {
                    context.State = new State몹4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몹4 : TriggerState {
            internal State몹4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20002530, textID: 20002530);
                context.SetTimer(arg1: "1", arg2: 20);
                context.CreateMonster(arg1: new int[] {4001}, arg2: true);
                context.CreateMonster(arg1: new int[] {4002}, arg2: true);
                context.CreateMonster(arg1: new int[] {4003}, arg2: true);
                context.CreateMonster(arg1: new int[] {4004}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {4001, 4002, 4003, 4005, 4006})) {
                    context.State = new State몹5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몹5 : TriggerState {
            internal State몹5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20002531, textID: 20002531);
                context.SetTimer(arg1: "1", arg2: 20);
                context.CreateMonster(arg1: new int[] {4005}, arg2: true);
                context.CreateMonster(arg1: new int[] {4006}, arg2: true);
                context.CreateMonster(arg1: new int[] {4007}, arg2: true);
                context.CreateMonster(arg1: new int[] {4008}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {4003, 4004, 4005, 4006, 4007, 4008})) {
                    context.State = new State몹6(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몹6 : TriggerState {
            internal State몹6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20002532, textID: 20002532);
                context.SetTimer(arg1: "1", arg2: 20);
                context.CreateMonster(arg1: new int[] {4001}, arg2: true);
                context.CreateMonster(arg1: new int[] {4002}, arg2: true);
                context.CreateMonster(arg1: new int[] {4003}, arg2: true);
                context.CreateMonster(arg1: new int[] {4004}, arg2: true);
                context.CreateMonster(arg1: new int[] {4005}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {4001, 4002, 4003, 4004, 4005, 4006})) {
                    context.State = new State몹10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몹7 : TriggerState {
            internal State몹7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20002533, textID: 20002533);
                context.SetTimer(arg1: "1", arg2: 20);
                context.CreateMonster(arg1: new int[] {4001}, arg2: true);
                context.CreateMonster(arg1: new int[] {4002}, arg2: true);
                context.CreateMonster(arg1: new int[] {4003}, arg2: true);
                context.CreateMonster(arg1: new int[] {4004}, arg2: true);
                context.CreateMonster(arg1: new int[] {4005}, arg2: true);
                context.CreateMonster(arg1: new int[] {4006}, arg2: true);
                context.CreateMonster(arg1: new int[] {4007}, arg2: true);
                context.CreateMonster(arg1: new int[] {4008}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State몹8(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몹8 : TriggerState {
            internal State몹8(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 20);
                context.CreateMonster(arg1: new int[] {4001}, arg2: true);
                context.CreateMonster(arg1: new int[] {4002}, arg2: true);
                context.CreateMonster(arg1: new int[] {4003}, arg2: true);
                context.CreateMonster(arg1: new int[] {4004}, arg2: true);
                context.CreateMonster(arg1: new int[] {4005}, arg2: true);
                context.CreateMonster(arg1: new int[] {4006}, arg2: true);
                context.CreateMonster(arg1: new int[] {4007}, arg2: true);
                context.CreateMonster(arg1: new int[] {4008}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State몹9(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몹9 : TriggerState {
            internal State몹9(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 20);
                context.CreateMonster(arg1: new int[] {4001}, arg2: true);
                context.CreateMonster(arg1: new int[] {4002}, arg2: true);
                context.CreateMonster(arg1: new int[] {4003}, arg2: true);
                context.CreateMonster(arg1: new int[] {4004}, arg2: true);
                context.CreateMonster(arg1: new int[] {4005}, arg2: true);
                context.CreateMonster(arg1: new int[] {4006}, arg2: true);
                context.CreateMonster(arg1: new int[] {4007}, arg2: true);
                context.CreateMonster(arg1: new int[] {4008}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State몹10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몹10 : TriggerState {
            internal State몹10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20002533, textID: 20002533);
                context.SetTimer(arg1: "1", arg2: 20);
                context.CreateMonster(arg1: new int[] {4009}, arg2: true);
                context.CreateMonster(arg1: new int[] {4010}, arg2: true);
                context.CreateMonster(arg1: new int[] {4011}, arg2: true);
                context.CreateMonster(arg1: new int[] {4012}, arg2: true);
                context.CreateMonster(arg1: new int[] {4013}, arg2: true);
                context.CreateMonster(arg1: new int[] {4014}, arg2: true);
                context.CreateMonster(arg1: new int[] {4015}, arg2: true);
                context.CreateMonster(arg1: new int[] {4016}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {4009, 4010, 4011, 4012, 4013, 4014, 4015, 4016})) {
                    context.State = new State열려(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State열려 : TriggerState {
            internal State열려(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20002524, textID: 20002524);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetLadder(arg1: 1701, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1702, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1703, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1704, arg2: true, arg3: true, arg4: 2);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 20002524);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}