using System;

namespace Maple2.Trigger._02010086_bf {
    public static class _boss {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CountUsers(arg1: 799, arg2: 1)) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {995, 999, 998});
                context.CreateMonster(arg1: new int[] {199}, arg2: true);
                context.SetTimer(arg1: "10", arg2: 10);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {199})) {
                    context.State = new State포탈_개방(context);
                    return;
                }

                if (context.TimeExpired(arg1: "10")) {
                    context.State = new State소환_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소환_01 : TriggerState {
            internal State소환_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {181, 188}, arg2: true);
                context.SetTimer(arg1: "10", arg2: 10);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {199})) {
                    context.State = new State포탈_개방(context);
                    return;
                }

                if (context.TimeExpired(arg1: "10")) {
                    context.State = new State소환_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소환_02 : TriggerState {
            internal State소환_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {182, 187}, arg2: true);
                context.SetTimer(arg1: "10", arg2: 10);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {199})) {
                    context.State = new State포탈_개방(context);
                    return;
                }

                if (context.TimeExpired(arg1: "10")) {
                    context.State = new State소환_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소환_03 : TriggerState {
            internal State소환_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {183, 186}, arg2: true);
                context.SetTimer(arg1: "10", arg2: 10);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {199})) {
                    context.State = new State포탈_개방(context);
                    return;
                }

                if (context.TimeExpired(arg1: "10")) {
                    context.State = new State소환_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소환_04 : TriggerState {
            internal State소환_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {184, 185}, arg2: true);
                context.SetTimer(arg1: "20", arg2: 20);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {199})) {
                    context.State = new State포탈_개방(context);
                    return;
                }

                if (context.TimeExpired(arg1: "20")) {
                    context.State = new State소환_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소환_05 : TriggerState {
            internal State소환_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {996}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {199})) {
                    context.State = new State포탈_개방(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포탈_개방 : TriggerState {
            internal State포탈_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {181, 182, 183, 184, 185, 186, 187, 188, 997, 996, 995});
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityID: 112, textID: 40009);
                context.SetMesh(arg1: new int[] {1098}, arg2: false, arg4: 0, arg5: 10f);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 112);
            }
        }
    }
}