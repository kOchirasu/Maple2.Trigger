using System;

namespace Maple2.Trigger._02000336_bf {
    public static class _boss {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90, 92, 93});
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetEffect(arg1: new int[] {7001}, arg2: false);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 701, arg2: 1)) {
                    context.State = new State시작_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작_01 : TriggerState {
            internal State시작_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7015}, arg2: true);
                context.CreateMonster(arg1: new int[] {101});
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State조직원등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State조직원등장 : TriggerState {
            internal State조직원등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7001}, arg2: true);
                context.SetMesh(arg1: new int[] {8041, 8042, 8043, 8044}, arg2: false, arg4: 0, arg5: 10f);
                context.SetSkill(arg1: new int[] {5801}, arg2: true);
                context.CreateMonster(arg1: new int[] {181, 182, 183});
                context.SetTimer(arg1: "2", arg2: 2, arg4: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State웨이홍_대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State웨이홍_대사01 : TriggerState {
            internal State웨이홍_대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {91});
                context.DestroyMonster(arg1: new int[] {90});
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 8001, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11003124, arg3: "$02000336_BF__BOSS__0$", arg4: 3);
                context.SetSkip(arg1: "웨이홍_대사02");
                context.SetTimer(arg1: "3", arg2: 3, arg4: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State웨이홍_대사02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class State웨이홍_대사02 : TriggerState {
            internal State웨이홍_대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003124, arg3: "$02000336_BF__BOSS__1$", arg4: 3);
                context.SetSkip(arg1: "종료");
                context.SetTimer(arg1: "3", arg2: 3, arg4: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 7);
            }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 112, textID: 40009);
                context.CameraSelect(arg1: 8001, arg2: false);
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}